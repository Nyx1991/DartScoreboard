using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DartScoreboard
{
    static class WebServer
    {
        private static bool             serverRun = false;
        public  static HttpListener     listener;
        private static Thread           serverThread;
        private static ScoreboardForm   scoreboardForm;
        
        public static void SetForm(ScoreboardForm _form)
        {
            scoreboardForm = _form;
            _form.FormClosed += formCloseEventHandler;
        }

        public static void Start()
        {
            if (serverRun)
                return;

            listener = new HttpListener();
            listener.Prefixes.Add(string.Format("http://*:{0}/", 51057));
            try
            {
                listener.Start();
            }
            catch 
            {
                System.Windows.Forms.MessageBox.Show("Run as admin.");
                Environment.Exit(0);
            }

            serverRun = true;
            serverThread = new Thread(new ThreadStart(WebServer.ServerRun));
            serverThread.Start();
        }

        public static void Stop()
        {
            serverRun = false;
            while (serverThread.IsAlive);

            listener.Close();
        }

        private static void formCloseEventHandler(object sender, EventArgs e)
        {
            listener.Close();
            serverRun = false;
            while (serverThread.IsAlive);
        }

        private static void ServerRun()
        {

            while (serverRun)
            {
                HttpListenerContext ctx;
                try
                {
                    ctx = listener.GetContext();
                }
                catch (Exception e)
                {
                    serverRun = false;
                    continue;
                }

                // Peel out the requests and response objects
                HttpListenerRequest req = ctx.Request;
                HttpListenerResponse resp = ctx.Response;

                // If `shutdown` url requested w/ POST, then shutdown the server after serving the page
                if ((req.HttpMethod == "POST"))
                {
                    if (req.HasEntityBody)
                    {
                        StreamReader streamReader = new StreamReader(req.InputStream);
                        string body = streamReader.ReadToEnd();

                        scoreboardForm.SetJson(body);
                        scoreboardForm.Invoke(new Action(() => scoreboardForm.processJson()));
                    }
                }

                // Write the response info
                byte[] data = Encoding.UTF8.GetBytes("success");
                resp.ContentType = "text/html";
                resp.ContentEncoding = Encoding.UTF8;
                resp.ContentLength64 = data.LongLength;
                resp.StatusCode = 200;

                // Write out to the response stream (asynchronously), then close it
                resp.OutputStream.Write(data, 0, data.Length);
                resp.Close();
            }
        }
    }
}
