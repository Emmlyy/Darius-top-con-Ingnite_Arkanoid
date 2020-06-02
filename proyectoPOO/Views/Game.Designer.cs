using System.ComponentModel;

namespace proyectoPOO
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.pictureBoxBall = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxBall)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxBall
            // 
            this.pictureBoxBall.Image = ((System.Drawing.Image) (resources.GetObject("pictureBoxBall.Image")));
            this.pictureBoxBall.Location = new System.Drawing.Point(419, 275);
            this.pictureBoxBall.Name = "pictureBoxBall";
            this.pictureBoxBall.Size = new System.Drawing.Size(43, 44);
            this.pictureBoxBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBall.TabIndex = 0;
            this.pictureBoxBall.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.pictureBoxBall);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "Game";
            this.Text = "Game";
            this.Shown += new System.EventHandler(this.Game_Shown);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxBall)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBall;
        private System.Windows.Forms.Timer timer1;
    }
}