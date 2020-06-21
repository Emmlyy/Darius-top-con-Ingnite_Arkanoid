using System.ComponentModel;

namespace proyectoPOO.Views
{
    partial class FrmGame
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
                new System.ComponentModel.ComponentResourceManager(typeof(FrmGame));
            this.Ball = new System.Windows.Forms.PictureBox();
            this.Player = new System.Windows.Forms.PictureBox();
            this.timerForMovements = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize) (this.Ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // Ball
            // 
            this.Ball.BackColor = System.Drawing.Color.Transparent;
            this.Ball.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("Ball.BackgroundImage")));
            this.Ball.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Ball.Location = new System.Drawing.Point(509, 289);
            this.Ball.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(32, 30);
            this.Ball.TabIndex = 0;
            this.Ball.TabStop = false;
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.Location = new System.Drawing.Point(75, 393);
            this.Player.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(180, 30);
            this.Player.TabIndex = 1;
            this.Player.TabStop = false;
            // 
            // timerForMovements
            // 
            this.timerForMovements.Enabled = true;
            this.timerForMovements.Interval = 10;
            this.timerForMovements.Tick += new System.EventHandler(this.TimerForMovements_Tick);
            // 
            // FrmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(708, 465);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.Ball);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmGame";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Game_MouseMove);
            ((System.ComponentModel.ISupportInitialize) (this.Ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.Player)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Timer timerForMovements;

        #endregion

        private System.Windows.Forms.PictureBox Ball;
    }
}