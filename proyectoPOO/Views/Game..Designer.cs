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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(proyectoPOO.Game_));
            this.pictureBoxBall = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxBall)).BeginInit();
            this.SuspendLayout();
            this.pictureBoxBall.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("pictureBoxBall.BackgroundImage")));
            this.pictureBoxBall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxBall.Location = new System.Drawing.Point(278, 166);
            this.pictureBoxBall.Name = "pictureBoxBall";
            this.pictureBoxBall.Size = new System.Drawing.Size(42, 41);
            this.pictureBoxBall.TabIndex = 0;
            this.pictureBoxBall.TabStop = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 376);
            this.Controls.Add(this.pictureBoxBall);
            this.Name = "Game_";
            this.Text = "Game_";
            this.Load += new System.EventHandler(this.Game__Load);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxBall)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox pictureBoxBall;
        private System.Windows.Forms.Timer timer1;

        #endregion
    }
}