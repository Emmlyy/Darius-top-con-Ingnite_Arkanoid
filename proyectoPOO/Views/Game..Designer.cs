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
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(Game_));
            this.pictureBoxBall = new System.Windows.Forms.PictureBox();
            this.Player = new System.Windows.Forms.PictureBox();
            this.timerForMovements = new System.Windows.Forms.Timer(this.components);
            this.life1 = new System.Windows.Forms.PictureBox();
            this.life2 = new System.Windows.Forms.PictureBox();
            this.life3 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbPoints = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.life1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.life2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.life3)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxBall
            // 
            this.pictureBoxBall.BackgroundImage =
                ((System.Drawing.Image) (resources.GetObject("pictureBoxBall.BackgroundImage")));
            this.pictureBoxBall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxBall.Location = new System.Drawing.Point(509, 289);
            this.pictureBoxBall.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pictureBoxBall.Name = "pictureBoxBall";
            this.pictureBoxBall.Size = new System.Drawing.Size(32, 30);
            this.pictureBoxBall.TabIndex = 0;
            this.pictureBoxBall.TabStop = false;
            // 
            // Player
            // 
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
            this.timerForMovements.Tick += new System.EventHandler(this.timerForMovements_Tick);
            // 
            // life1
            // 
            this.life1.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("life1.BackgroundImage")));
            this.life1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.life1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.life1.Location = new System.Drawing.Point(5, 4);
            this.life1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.life1.Name = "life1";
            this.life1.Size = new System.Drawing.Size(25, 43);
            this.life1.TabIndex = 26;
            this.life1.TabStop = false;
            // 
            // life2
            // 
            this.life2.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("life2.BackgroundImage")));
            this.life2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.life2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.life2.Location = new System.Drawing.Point(40, 4);
            this.life2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.life2.Name = "life2";
            this.life2.Size = new System.Drawing.Size(25, 43);
            this.life2.TabIndex = 27;
            this.life2.TabStop = false;
            // 
            // life3
            // 
            this.life3.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("life3.BackgroundImage")));
            this.life3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.life3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.life3.Location = new System.Drawing.Point(75, 4);
            this.life3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.life3.Name = "life3";
            this.life3.Size = new System.Drawing.Size(25, 43);
            this.life3.TabIndex = 28;
            this.life3.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.life1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.life3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.life2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbPoints, 5, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(708, 51);
            this.tableLayoutPanel1.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(570, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 51);
            this.label1.TabIndex = 29;
            this.label1.Text = "Points:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPoints
            // 
            this.lbPoints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbPoints.Location = new System.Drawing.Point(640, 0);
            this.lbPoints.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbPoints.Name = "lbPoints";
            this.lbPoints.Size = new System.Drawing.Size(63, 51);
            this.lbPoints.TabIndex = 30;
            this.lbPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Game_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(708, 465);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.pictureBoxBall);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Game_";
            this.Text = "Game_";
            this.Load += new System.EventHandler(this.Game__Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game__KeyDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Game__MouseMove);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.life1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.life2)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.life3)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox pictureBoxBall;
        private System.Windows.Forms.Timer timer1;

        #endregion

        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Timer timerForMovements;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox life3;
        private System.Windows.Forms.PictureBox life2;
        private System.Windows.Forms.PictureBox life1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbPoints;
    }
}