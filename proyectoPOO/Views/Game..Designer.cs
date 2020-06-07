using System.ComponentModel;

namespace proyectoPOO
{
    partial class Game_
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(Game_));
            this.pictureBoxBall = new System.Windows.Forms.PictureBox();
            this.Player = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxBall
            // 
            this.pictureBoxBall.BackgroundImage =
                ((System.Drawing.Image) (resources.GetObject("pictureBoxBall.BackgroundImage")));
            this.pictureBoxBall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxBall.Location = new System.Drawing.Point(324, 192);
            this.pictureBoxBall.Name = "pictureBoxBall";
            this.pictureBoxBall.Size = new System.Drawing.Size(49, 47);
            this.pictureBoxBall.TabIndex = 0;
            this.pictureBoxBall.TabStop = false;
            // 
            // Player
            // 
            this.Player.Location = new System.Drawing.Point(45, 321);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(279, 39);
            this.Player.TabIndex = 1;
            this.Player.TabStop = false;
            // 
            // Game_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(933, 434);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.pictureBoxBall);
            this.Name = "Game_";
            this.Text = "Game_";
            this.Load += new System.EventHandler(this.Game__Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Game__MouseMove);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.Player)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox pictureBoxBall;
        private System.Windows.Forms.Timer timer1;

        #endregion

        private System.Windows.Forms.PictureBox Player;
    }
}