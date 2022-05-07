using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DartScoreboard
{
    public partial class ScoreboardForm : Form
    {
        PlayerPanel player = new PlayerPanel() { Name = "Test" };
        List<PlayerPanel> players = new List<PlayerPanel>();
        private string json;

        public ScoreboardForm()
        {
            InitializeComponent();
        }

        private void Panel1_Click(object sender, EventArgs e)
        {
            if (FormBorderStyle == FormBorderStyle.None)
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.None;
            }
        }

        private void Panel10_Click(object sender, EventArgs e)
        {
            if (this.TransparencyKey == Color.Fuchsia)
            {
                this.TransparencyKey = Color.Empty;
            }
            else
            {
                this.TransparencyKey = Color.Fuchsia;
            }
        }

        public void processJson()
        {
            try
            {
                int i = 0;

                PlayerPanel playerPanel;
                JObject data = JObject.Parse(json);
                JArray playerList = (JArray)data.GetValue("players");

                this.SuspendLayout();

                labelGameMode.Text = ((JValue)data.GetValue("mode")).ToString();

                foreach (JObject playerJson in playerList)
                {
                    if (PlayersFlowLayout.Controls.Count > i)
                    {
                        playerPanel = (PlayerPanel)PlayersFlowLayout.Controls[i];
                    }
                    else
                    {
                        playerPanel = new PlayerPanel();

                        PlayersFlowLayout.Controls.Add(playerPanel);
                        PlayersFlowLayout.Height = (PlayersFlowLayout.Controls.Count) * playerPanel.Height;
                    }

                    Type panelType = typeof(PlayerPanel);
                    playerPanel.Name = playerJson.GetValue("nr").ToString();

                    foreach (JProperty jprop in playerJson.Properties())
                    {
                        if (jprop.Name == "nr")
                            continue;

                        if (jprop.Name == "flag")
                        {
                            playerPanel.flag.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(jprop.Value.ToString());
                            playerPanel.flag.Visible = true;
                            playerPanel.flag.Refresh();
                            continue;
                        }

                        string[] props = jprop.Name.Split('.');

                        FieldInfo fieldInfo = panelType.GetField(props[0], System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                        var fieldVal = fieldInfo.GetValue(playerPanel);
                        PropertyInfo propInfo = fieldVal.GetType().GetProperty(props[1]);
                        propInfo.SetValue(fieldVal, Convert.ChangeType(jprop.Value.ToString(), propInfo.PropertyType));
                    }

                    i++;
                }

                panelFooter.Top = panelHeader.Height + (PlayersFlowLayout.Controls.Count * 50);

                this.ResumeLayout(false);
                this.PerformLayout();
            }
            catch 
            { 
            }
        }

        public void SetJson(string _json)
        {
            json = _json;
        }

    }
}
