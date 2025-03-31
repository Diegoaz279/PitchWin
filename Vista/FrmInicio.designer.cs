namespace PlayerUI
{
    partial class FrmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            panelSideMenu = new Panel();
            btnExit = new Button();
            btnAyuda = new Button();
            btnReportes = new Button();
            btnPagarTicket = new Button();
            btnApuestas = new Button();
            btnInicio = new Button();
            panelLogo = new Panel();
            pictureBox1 = new PictureBox();
            panelFormInicio = new Panel();
            panel3 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            label2 = new Label();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            button1 = new Button();
            panel2 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            label1 = new Label();
            panelSideMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelFormInicio.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // panelSideMenu
            // 
            panelSideMenu.AutoScroll = true;
            panelSideMenu.BackColor = Color.FromArgb(17, 52, 91);
            panelSideMenu.Controls.Add(btnExit);
            panelSideMenu.Controls.Add(btnAyuda);
            panelSideMenu.Controls.Add(btnReportes);
            panelSideMenu.Controls.Add(btnPagarTicket);
            panelSideMenu.Controls.Add(btnApuestas);
            panelSideMenu.Controls.Add(btnInicio);
            panelSideMenu.Controls.Add(panelLogo);
            panelSideMenu.Dock = DockStyle.Left;
            panelSideMenu.Location = new Point(0, 0);
            panelSideMenu.Name = "panelSideMenu";
            panelSideMenu.Size = new Size(401, 843);
            panelSideMenu.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.Dock = DockStyle.Bottom;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.MouseDownBackColor = Color.FromArgb(10, 40, 80);
            btnExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(17, 20, 80);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Inria Sans", 14F);
            btnExit.ForeColor = Color.Silver;
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.ImageAlign = ContentAlignment.MiddleLeft;
            btnExit.Location = new Point(0, 752);
            btnExit.Name = "btnExit";
            btnExit.Padding = new Padding(10, 2, 0, 0);
            btnExit.Size = new Size(401, 91);
            btnExit.TabIndex = 9;
            btnExit.Text = "  LOGOUT";
            btnExit.TextAlign = ContentAlignment.MiddleLeft;
            btnExit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnAyuda
            // 
            btnAyuda.Dock = DockStyle.Top;
            btnAyuda.FlatAppearance.BorderSize = 0;
            btnAyuda.FlatAppearance.MouseDownBackColor = Color.FromArgb(10, 40, 80);
            btnAyuda.FlatAppearance.MouseOverBackColor = Color.FromArgb(17, 20, 80);
            btnAyuda.FlatStyle = FlatStyle.Flat;
            btnAyuda.Font = new Font("Inria Sans", 14F);
            btnAyuda.ForeColor = Color.Silver;
            btnAyuda.Image = (Image)resources.GetObject("btnAyuda.Image");
            btnAyuda.ImageAlign = ContentAlignment.MiddleLeft;
            btnAyuda.Location = new Point(0, 509);
            btnAyuda.Name = "btnAyuda";
            btnAyuda.Padding = new Padding(5, 0, 0, 0);
            btnAyuda.Size = new Size(401, 91);
            btnAyuda.TabIndex = 8;
            btnAyuda.Text = "  AYUDA";
            btnAyuda.TextAlign = ContentAlignment.MiddleLeft;
            btnAyuda.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAyuda.UseVisualStyleBackColor = true;
            btnAyuda.Click += btnHelp_Click;
            // 
            // btnReportes
            // 
            btnReportes.Dock = DockStyle.Top;
            btnReportes.FlatAppearance.BorderSize = 0;
            btnReportes.FlatAppearance.MouseDownBackColor = Color.FromArgb(10, 40, 80);
            btnReportes.FlatAppearance.MouseOverBackColor = Color.FromArgb(17, 20, 80);
            btnReportes.FlatStyle = FlatStyle.Flat;
            btnReportes.Font = new Font("Inria Sans", 14F);
            btnReportes.ForeColor = Color.Silver;
            btnReportes.Image = (Image)resources.GetObject("btnReportes.Image");
            btnReportes.ImageAlign = ContentAlignment.MiddleLeft;
            btnReportes.Location = new Point(0, 418);
            btnReportes.Name = "btnReportes";
            btnReportes.Padding = new Padding(5, 0, 0, 0);
            btnReportes.Size = new Size(401, 91);
            btnReportes.TabIndex = 6;
            btnReportes.Text = "  REPORTES";
            btnReportes.TextAlign = ContentAlignment.MiddleLeft;
            btnReportes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReportes.UseVisualStyleBackColor = true;
            btnReportes.Click += btnTools_Click;
            // 
            // btnPagarTicket
            // 
            btnPagarTicket.Dock = DockStyle.Top;
            btnPagarTicket.FlatAppearance.BorderSize = 0;
            btnPagarTicket.FlatAppearance.MouseDownBackColor = Color.FromArgb(10, 40, 80);
            btnPagarTicket.FlatAppearance.MouseOverBackColor = Color.FromArgb(17, 20, 80);
            btnPagarTicket.FlatStyle = FlatStyle.Flat;
            btnPagarTicket.Font = new Font("Inria Sans", 14F);
            btnPagarTicket.ForeColor = Color.Silver;
            btnPagarTicket.Image = (Image)resources.GetObject("btnPagarTicket.Image");
            btnPagarTicket.ImageAlign = ContentAlignment.MiddleLeft;
            btnPagarTicket.Location = new Point(0, 327);
            btnPagarTicket.Name = "btnPagarTicket";
            btnPagarTicket.Padding = new Padding(5, 0, 0, 0);
            btnPagarTicket.Size = new Size(401, 91);
            btnPagarTicket.TabIndex = 5;
            btnPagarTicket.Text = "  PAGAR TICKET";
            btnPagarTicket.TextAlign = ContentAlignment.MiddleLeft;
            btnPagarTicket.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPagarTicket.UseVisualStyleBackColor = true;
            btnPagarTicket.Click += btnEqualizer_Click;
            // 
            // btnApuestas
            // 
            btnApuestas.Dock = DockStyle.Top;
            btnApuestas.FlatAppearance.BorderSize = 0;
            btnApuestas.FlatAppearance.MouseDownBackColor = Color.FromArgb(10, 40, 80);
            btnApuestas.FlatAppearance.MouseOverBackColor = Color.FromArgb(17, 20, 80);
            btnApuestas.FlatStyle = FlatStyle.Flat;
            btnApuestas.Font = new Font("Inria Sans", 14F);
            btnApuestas.ForeColor = Color.Silver;
            btnApuestas.Image = (Image)resources.GetObject("btnApuestas.Image");
            btnApuestas.ImageAlign = ContentAlignment.MiddleLeft;
            btnApuestas.Location = new Point(0, 236);
            btnApuestas.Name = "btnApuestas";
            btnApuestas.Padding = new Padding(5, 0, 0, 0);
            btnApuestas.Size = new Size(401, 91);
            btnApuestas.TabIndex = 3;
            btnApuestas.Text = "  APUESTAS";
            btnApuestas.TextAlign = ContentAlignment.MiddleLeft;
            btnApuestas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnApuestas.UseVisualStyleBackColor = true;
            btnApuestas.Click += btnPlaylist_Click;
            // 
            // btnInicio
            // 
            btnInicio.Dock = DockStyle.Top;
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.FlatAppearance.MouseDownBackColor = Color.FromArgb(10, 40, 80);
            btnInicio.FlatAppearance.MouseOverBackColor = Color.FromArgb(17, 20, 80);
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Font = new Font("Inria Sans", 14F);
            btnInicio.ForeColor = Color.Silver;
            btnInicio.Image = (Image)resources.GetObject("btnInicio.Image");
            btnInicio.ImageAlign = ContentAlignment.MiddleLeft;
            btnInicio.Location = new Point(0, 145);
            btnInicio.Name = "btnInicio";
            btnInicio.Padding = new Padding(5, 0, 0, 0);
            btnInicio.Size = new Size(401, 91);
            btnInicio.TabIndex = 1;
            btnInicio.Text = "  INICIO";
            btnInicio.TextAlign = ContentAlignment.MiddleLeft;
            btnInicio.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnMedia_Click;
            // 
            // panelLogo
            // 
            panelLogo.BorderStyle = BorderStyle.FixedSingle;
            panelLogo.Controls.Add(pictureBox1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(401, 145);
            panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = PitchWin.Properties.Resources.ChatGPT_Image_31_mar_2025__02_14_43_p_m_;
            pictureBox1.Location = new Point(51, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(293, 136);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelFormInicio
            // 
            panelFormInicio.BackColor = Color.FromArgb(225, 238, 255);
            panelFormInicio.Controls.Add(panel3);
            panelFormInicio.Controls.Add(panel1);
            panelFormInicio.Controls.Add(panel2);
            panelFormInicio.Dock = DockStyle.Fill;
            panelFormInicio.Location = new Point(401, 0);
            panelFormInicio.Name = "panelFormInicio";
            panelFormInicio.Size = new Size(987, 843);
            panelFormInicio.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(tableLayoutPanel1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 175);
            panel3.Name = "panel3";
            panel3.Size = new Size(987, 518);
            panel3.TabIndex = 15;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(pictureBox2, 1, 1);
            tableLayoutPanel1.Controls.Add(pictureBox3, 3, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 2, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.Size = new Size(987, 518);
            tableLayoutPanel1.TabIndex = 13;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(200, 106);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(265, 253);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Dock = DockStyle.Fill;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(520, 106);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(265, 253);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 0F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 0F));
            tableLayoutPanel4.Controls.Add(label2, 1, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(471, 106);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanel4.Size = new Size(43, 253);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Rubik Mono One", 6F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(7, 118);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 0;
            label2.Text = "VS";
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 693);
            panel1.Name = "panel1";
            panel1.Size = new Size(987, 150);
            panel1.TabIndex = 14;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.88889F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.2222214F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.88889F));
            tableLayoutPanel2.Controls.Add(button1, 1, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.7320652F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 49.1874771F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 39.08046F));
            tableLayoutPanel2.Size = new Size(987, 150);
            tableLayoutPanel2.TabIndex = 13;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(34, 142, 254);
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Dock = DockStyle.Fill;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 100, 254);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(5, 70, 225);
            button1.Font = new Font("Inria Sans", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(386, 20);
            button1.Name = "button1";
            button1.Padding = new Padding(5, 0, 0, 0);
            button1.Size = new Size(213, 67);
            button1.TabIndex = 10;
            button1.Text = "  APOSTAR";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(987, 175);
            panel2.TabIndex = 11;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.5F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 95F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.5F));
            tableLayoutPanel3.Controls.Add(label1, 1, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.ForeColor = Color.DarkOrange;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 29.1428566F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 59.42857F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 10.8193607F));
            tableLayoutPanel3.Size = new Size(987, 175);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Rubik Mono One", 31.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 63);
            label1.Name = "label1";
            label1.Size = new Size(914, 80);
            label1.TabIndex = 0;
            label1.Text = "PARTIDOS DEL DIA";
            // 
            // FrmInicio
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1388, 843);
            Controls.Add(panelFormInicio);
            Controls.Add(panelSideMenu);
            Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MinimumSize = new Size(950, 600);
            Name = "FrmInicio";
            StartPosition = FormStartPosition.CenterScreen;
            panelSideMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelFormInicio.ResumeLayout(false);
            panel3.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnPagarTicket;
        private System.Windows.Forms.Button btnApuestas;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panelFormInicio;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button button1;
        private Panel panel3;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label2;
    }
}

