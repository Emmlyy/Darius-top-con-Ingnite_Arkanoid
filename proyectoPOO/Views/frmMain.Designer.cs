namespace proyectoPOO.Views
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
                new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.pnl = new System.Windows.Forms.TableLayoutPanel();
            this.pic = new System.Windows.Forms.PictureBox();
            this.bttnPlayy = new System.Windows.Forms.Button();
            this.bttnPoint = new System.Windows.Forms.Button();
            this.bttnClosed = new System.Windows.Forms.Button();
            this.pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.pnl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnl.BackgroundImage =
                ((System.Drawing.Image) (resources.GetObject("tableLayoutPanel1.BackgroundImage")));
            this.pnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl.ColumnCount = 3;
            this.pnl.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnl.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.pnl.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnl.Controls.Add(this.pic, 1, 0);
            this.pnl.Controls.Add(this.bttnPlayy, 1, 1);
            this.pnl.Controls.Add(this.bttnPoint, 1, 2);
            this.pnl.Controls.Add(this.bttnClosed, 1, 3);
            this.pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.pnl.ForeColor = System.Drawing.Color.Black;
            this.pnl.Location = new System.Drawing.Point(0, 0);
            this.pnl.Margin = new System.Windows.Forms.Padding(6);
            this.pnl.Name = "pnl";
            this.pnl.RowCount = 5;
            this.pnl.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnl.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnl.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnl.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnl.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnl.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnl.Size = new System.Drawing.Size(649, 490);
            this.pnl.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pic.BackgroundImage =
                ((System.Drawing.Image) (resources.GetObject("pictureBox1.BackgroundImage")));
            this.pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic.ImageLocation = "";
            this.pic.InitialImage = null;
            this.pic.Location = new System.Drawing.Point(132, 3);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(383, 92);
            this.pic.TabIndex = 3;
            this.pic.TabStop = false;
            // 
            // btnPlayy
            // 
            this.bttnPlayy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttnPlayy.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (255)))),
                ((int) (((byte) (128)))));
            this.bttnPlayy.Location = new System.Drawing.Point(212, 118);
            this.bttnPlayy.Margin = new System.Windows.Forms.Padding(6);
            this.bttnPlayy.Name = "bttnPlayy";
            this.bttnPlayy.Size = new System.Drawing.Size(223, 57);
            this.bttnPlayy.TabIndex = 0;
            this.bttnPlayy.Text = "Jugar";
            this.bttnPlayy.UseVisualStyleBackColor = false;
            this.bttnPlayy.Click += new System.EventHandler(this.BttnPlayy_Click);
            // 
            // btnPoint
            // 
            this.bttnPoint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttnPoint.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (128)))), ((int) (((byte) (128)))),
                ((int) (((byte) (255)))));
            this.bttnPoint.Location = new System.Drawing.Point(212, 214);
            this.bttnPoint.Margin = new System.Windows.Forms.Padding(6);
            this.bttnPoint.Name = "bttnPoint";
            this.bttnPoint.Size = new System.Drawing.Size(223, 62);
            this.bttnPoint.TabIndex = 1;
            this.bttnPoint.Text = "Puntaje";
            this.bttnPoint.UseVisualStyleBackColor = false;
            this.bttnPoint.Click += new System.EventHandler(this.BttnPoint_Click);
            // 
            // btnClosed
            // 
            this.bttnClosed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttnClosed.BackColor = System.Drawing.Color.Red;
            this.bttnClosed.Location = new System.Drawing.Point(210, 313);
            this.bttnClosed.Margin = new System.Windows.Forms.Padding(6);
            this.bttnClosed.Name = "bttnClosed";
            this.bttnClosed.Size = new System.Drawing.Size(227, 60);
            this.bttnClosed.TabIndex = 2;
            this.bttnClosed.Text = "Salir";
            this.bttnClosed.UseVisualStyleBackColor = false;
            this.bttnClosed.Click += new System.EventHandler(this.BttnClosed_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 490);
            this.Controls.Add(this.pnl);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMain_KeyDown);
            this.pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.pic)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button bttnClosed;
        private System.Windows.Forms.Button bttnPlayy;
        private System.Windows.Forms.Button bttnPoint;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.TableLayoutPanel pnl;

        #endregion
    }
}