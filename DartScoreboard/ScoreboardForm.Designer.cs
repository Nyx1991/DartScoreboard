using System;

namespace DartScoreboard
{
    partial class ScoreboardForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelGameMode = new System.Windows.Forms.Label();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.PlayersFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.panelHeader.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Black;
            this.panelHeader.BackgroundImage = global::DartScoreboard.Properties.Resources.headerBackgroud;
            this.panelHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelHeader.Controls.Add(this.label2);
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Controls.Add(this.labelGameMode);
            this.panelHeader.Location = new System.Drawing.Point(276, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(595, 44);
            this.panelHeader.TabIndex = 1;
            this.panelHeader.Click += new System.EventHandler(this.Panel1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Book", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(434, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Legs";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Book", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(350, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sets";
            // 
            // labelGameMode
            // 
            this.labelGameMode.AutoSize = true;
            this.labelGameMode.BackColor = System.Drawing.Color.Transparent;
            this.labelGameMode.Font = new System.Drawing.Font("Franklin Gothic Book", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGameMode.ForeColor = System.Drawing.Color.White;
            this.labelGameMode.Location = new System.Drawing.Point(16, 7);
            this.labelGameMode.Name = "labelGameMode";
            this.labelGameMode.Size = new System.Drawing.Size(184, 30);
            this.labelGameMode.TabIndex = 0;
            this.labelGameMode.Text = "Scoreboard Beta";
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.Black;
            this.panelFooter.Controls.Add(this.label11);
            this.panelFooter.Location = new System.Drawing.Point(276, 94);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(595, 33);
            this.panelFooter.TabIndex = 10;
            this.panelFooter.Click += new System.EventHandler(this.Panel10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Franklin Gothic Book", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(16, 4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(186, 25);
            this.label11.TabIndex = 0;
            this.label11.Text = "05.05.2022 - 20:03";
            // 
            // PlayersFlowLayout
            // 
            this.PlayersFlowLayout.Location = new System.Drawing.Point(0, 44);
            this.PlayersFlowLayout.Margin = new System.Windows.Forms.Padding(0);
            this.PlayersFlowLayout.Name = "PlayersFlowLayout";
            this.PlayersFlowLayout.Size = new System.Drawing.Size(994, 50);
            this.PlayersFlowLayout.TabIndex = 11;
            // 
            // ScoreboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.ClientSize = new System.Drawing.Size(1003, 262);
            this.Controls.Add(this.PlayersFlowLayout);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ScoreboardForm";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelGameMode;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.FlowLayoutPanel PlayersFlowLayout;
    }
}

