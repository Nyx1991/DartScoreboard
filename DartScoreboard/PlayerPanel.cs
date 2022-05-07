using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DartScoreboard
{
    public class PlayerPanel : Panel
    {
        internal Panel panelFirstDartFinish;
        internal Label labelFirstDartFinish;
        internal Panel panelSecondDartFinish;
        internal Label labelSecondDartFinish;
        internal Panel panelThirdDartFinish;
        internal Label labelThirdDartFinish;
        internal Panel panelScore;
        internal Label labelScore;
        internal Panel panelLeg;
        internal Label labelLeg;
        internal Panel panelSet;
        internal Label labelSet;
        internal Panel panelPlayerBackground;
        internal Label labelPlayer;
        internal Panel panelPlayerIndicator;
        internal PictureBox flag;

        public PlayerPanel()
        {
            InitializeComponent();
        }

        internal void InitializeComponent()
        {
            this.panelFirstDartFinish = new Panel();
            this.labelFirstDartFinish = new Label();
            this.panelSecondDartFinish = new Panel();
            this.labelSecondDartFinish = new Label();
            this.panelThirdDartFinish = new Panel();
            this.labelThirdDartFinish = new Label();
            this.panelScore = new Panel();
            this.labelScore = new Label();
            this.panelLeg = new Panel();
            this.labelLeg = new Label();
            this.panelSet = new Panel();
            this.labelSet = new Label();
            this.panelPlayerBackground = new Panel();
            this.labelPlayer = new Label();
            this.panelPlayerIndicator = new Panel();
            this.flag = new PictureBox();

            ((System.ComponentModel.ISupportInitialize)(this.flag)).BeginInit();
            this.SuspendLayout();

            // 
            // panelFirstDartFinish
            // 
            this.panelFirstDartFinish.BackColor = System.Drawing.Color.Maroon;
            this.panelFirstDartFinish.Controls.Add(this.labelFirstDartFinish);
            this.panelFirstDartFinish.Location = new System.Drawing.Point(0, 3);
            this.panelFirstDartFinish.Name = "panelFirstDartFinish";
            this.panelFirstDartFinish.Size = new System.Drawing.Size(90, 42);
            this.panelFirstDartFinish.TabIndex = 23;
            // 
            // labelFirstDartFinish
            // 
            this.labelFirstDartFinish.Font = new System.Drawing.Font("Franklin Gothic Book", 18F, System.Drawing.FontStyle.Bold);
            this.labelFirstDartFinish.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelFirstDartFinish.Location = new System.Drawing.Point(3, 6);
            this.labelFirstDartFinish.Name = "labelFirstDartFinish";
            this.labelFirstDartFinish.Size = new System.Drawing.Size(84, 27);
            this.labelFirstDartFinish.TabIndex = 0;
            this.labelFirstDartFinish.Text = "T19";
            this.labelFirstDartFinish.TextChanged += this.finish_TextChanged;
            this.labelFirstDartFinish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelSecondDartFinish
            // 
            this.panelSecondDartFinish.BackColor = System.Drawing.Color.Maroon;
            this.panelSecondDartFinish.Controls.Add(this.labelSecondDartFinish);
            this.panelSecondDartFinish.Location = new System.Drawing.Point(93, 3);
            this.panelSecondDartFinish.Name = "panelSecondDartFinish";
            this.panelSecondDartFinish.Size = new System.Drawing.Size(90, 42);
            this.panelSecondDartFinish.TabIndex = 22;
            // 
            // labelSecondDartFinish
            // 
            this.labelSecondDartFinish.Font = new System.Drawing.Font("Franklin Gothic Book", 18F, System.Drawing.FontStyle.Bold);
            this.labelSecondDartFinish.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelSecondDartFinish.Location = new System.Drawing.Point(3, 6);
            this.labelSecondDartFinish.Name = "labelSecondDartFinish";
            this.labelSecondDartFinish.Size = new System.Drawing.Size(84, 27);
            this.labelSecondDartFinish.TabIndex = 0;
            this.labelSecondDartFinish.Text = "10";
            this.labelSecondDartFinish.TextChanged += this.finish_TextChanged;
            this.labelSecondDartFinish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelThirdDartFinish
            // 
            this.panelThirdDartFinish.BackColor = System.Drawing.Color.Maroon;
            this.panelThirdDartFinish.Controls.Add(this.labelThirdDartFinish);
            this.panelThirdDartFinish.Location = new System.Drawing.Point(186, 3);
            this.panelThirdDartFinish.Name = "panelThirdDartFinish";
            this.panelThirdDartFinish.Size = new System.Drawing.Size(90, 42);
            this.panelThirdDartFinish.TabIndex = 21;
            // 
            // labelThirdDartFinish
            // 
            this.labelThirdDartFinish.Font = new System.Drawing.Font("Franklin Gothic Book", 18F, System.Drawing.FontStyle.Bold);
            this.labelThirdDartFinish.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelThirdDartFinish.Location = new System.Drawing.Point(3, 6);
            this.labelThirdDartFinish.Name = "labelThirdDartFinish";
            this.labelThirdDartFinish.Size = new System.Drawing.Size(84, 27);
            this.labelThirdDartFinish.TabIndex = 0;
            this.labelThirdDartFinish.Text = "D16";
            this.labelThirdDartFinish.TextChanged += this.finish_TextChanged;
            this.labelThirdDartFinish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelScore
            // 
            this.panelScore.BackColor = System.Drawing.Color.Green;
            this.panelScore.Controls.Add(this.labelScore);
            this.panelScore.Location = new System.Drawing.Point(784, 0);
            this.panelScore.Name = "panelScore";
            this.panelScore.Size = new System.Drawing.Size(87, 50);
            this.panelScore.BackgroundImage = Properties.Resources.panelScoreBackground;
            this.panelScore.BackgroundImageLayout = ImageLayout.Stretch;
            this.panelScore.TabIndex = 20;
            // 
            // labelScore
            // 
            this.labelScore.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.ForeColor = System.Drawing.Color.White;
            this.labelScore.BackColor = System.Drawing.Color.Transparent;
            this.labelScore.Location = new System.Drawing.Point(6, 6);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(78, 39);
            this.labelScore.TabIndex = 5;
            this.labelScore.Text = "99";
            this.labelScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelLeg
            // 
            this.panelLeg.BackColor = System.Drawing.Color.Green;
            this.panelLeg.Controls.Add(this.labelLeg);
            this.panelLeg.Location = new System.Drawing.Point(697, 0);
            this.panelLeg.Name = "panelLeg";
            this.panelLeg.Size = new System.Drawing.Size(87, 50);
            this.panelLeg.BackgroundImage = Properties.Resources.panelLegBackground;
            this.panelLeg.BackgroundImageLayout = ImageLayout.Stretch;
            this.panelLeg.TabIndex = 19;
            // 
            // labelLeg
            // 
            this.labelLeg.AutoSize = true;
            this.labelLeg.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLeg.ForeColor = System.Drawing.Color.White;
            this.labelLeg.Location = new System.Drawing.Point(26, 6);
            this.labelLeg.Name = "labelLeg";
            this.labelLeg.Size = new System.Drawing.Size(36, 39);
            this.labelLeg.BackColor = System.Drawing.Color.Transparent;
            this.labelLeg.TabIndex = 5;
            this.labelLeg.Text = "5";
            // 
            // panelSet
            // 
            this.panelSet.BackColor = System.Drawing.Color.Green;
            this.panelSet.Controls.Add(this.labelSet);
            this.panelSet.Location = new System.Drawing.Point(610, 0);
            this.panelSet.Name = "panelSet";
            this.panelSet.Size = new System.Drawing.Size(87, 50);
            this.panelSet.BackgroundImage = Properties.Resources.panelSetBackground;
            this.panelSet.BackgroundImageLayout = ImageLayout.Stretch;
            this.panelSet.TabIndex = 18;
            // 
            // labelSet
            // 
            this.labelSet.AutoSize = true;
            this.labelSet.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSet.ForeColor = System.Drawing.Color.White;
            this.labelSet.Location = new System.Drawing.Point(26, 6);
            this.labelSet.Name = "labelSet";
            this.labelSet.BackColor = System.Drawing.Color.Transparent;
            this.labelSet.Size = new System.Drawing.Size(36, 39);
            this.labelSet.TabIndex = 5;
            this.labelSet.Text = "5";
            // 
            // panelPlayerBackground
            // 
            this.panelPlayerBackground.BackColor = System.Drawing.Color.Silver;
            this.panelPlayerBackground.Controls.Add(this.labelPlayer);
            this.panelPlayerBackground.Location = new System.Drawing.Point(276, 0);
            this.panelPlayerBackground.Name = "panelPlayerBackground";
            this.panelPlayerBackground.Size = new System.Drawing.Size(334, 50);
            this.panelPlayerBackground.BackgroundImage = Properties.Resources.playerBackground;
            this.panelPlayerBackground.BackgroundImageLayout = ImageLayout.Stretch;
            this.panelPlayerBackground.TabIndex = 17;
            // 
            // flag
            //
            this.flag.BackColor = System.Drawing.Color.Silver;
            this.flag.Location = new System.Drawing.Point(550, 15);
            this.flag.Name = "flag";
            this.flag.Size = new System.Drawing.Size(30, 20);
            this.flag.SizeMode = PictureBoxSizeMode.StretchImage;
            this.flag.TabIndex = 18;
            this.flag.BackColor = System.Drawing.Color.Transparent;
            this.flag.Visible = false;
            this.flag.TabStop = false;
            // 
            // labelPlayer
            // 
            this.labelPlayer.AutoSize = true;
            this.labelPlayer.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayer.ForeColor = System.Drawing.Color.Black;
            this.labelPlayer.Location = new System.Drawing.Point(16, 7);
            this.labelPlayer.Name = "labelPlayer";
            this.labelPlayer.Size = new System.Drawing.Size(130, 35);
            this.labelPlayer.TabIndex = 1;
            this.labelPlayer.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayer.Text = "Player 1";
            // 
            // panelPlayerIndicator
            // 
            this.panelPlayerIndicator.BackColor = System.Drawing.Color.Maroon;
            this.panelPlayerIndicator.Location = new System.Drawing.Point(871, 7);
            this.panelPlayerIndicator.Name = "panelPlayerIndicator";
            this.panelPlayerIndicator.Size = new System.Drawing.Size(36, 36);
            this.panelPlayerIndicator.BackgroundImage = Properties.Resources.indicator;
            this.panelPlayerIndicator.TabIndex = 18;
            // 
            // PlayerPanel
            // 
            this.Controls.Add(this.panelFirstDartFinish);
            this.Controls.Add(this.panelSecondDartFinish);
            this.Controls.Add(this.panelThirdDartFinish);
            this.Controls.Add(this.panelScore);
            this.Controls.Add(this.panelLeg);
            this.Controls.Add(this.panelSet);
            this.Controls.Add(this.panelPlayerBackground);
            this.Controls.Add(this.panelPlayerIndicator);
            this.Controls.Add(this.flag);
            this.Location = new System.Drawing.Point(16, 247);
            this.Margin = new Padding(0);
            this.Size = new System.Drawing.Size(1000, 50);
            this.TabIndex = 17;

            this.flag.BringToFront();

            ((System.ComponentModel.ISupportInitialize)(this.flag)).EndInit();
            this.ResumeLayout(false);
        }

        private void finish_TextChanged(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            Panel panel = (Panel)lbl.Parent;

            lbl.Visible = lbl.Text != "";
            panel.Visible = lbl.Text != "";
        }
    }
}
