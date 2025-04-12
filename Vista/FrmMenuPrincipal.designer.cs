namespace PlayerUI
{
    partial class FrmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            panelSideMenu = new Panel();
            btnAyuda = new Button();
            btnReportes = new Button();
            btnPagarTicket = new Button();
            btnApuestas = new Button();
            btnInicio = new Button();
            btnExit = new Button();
            panelLogo = new Panel();
            pictureBox1 = new PictureBox();
            panelFormInicio = new Panel();
            PanelInicio = new Panel();
            panelSideMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelFormInicio.SuspendLayout();
            SuspendLayout();
            // 
            // panelSideMenu
            // 
            panelSideMenu.AutoScroll = true;
            panelSideMenu.BackColor = Color.FromArgb(20, 20, 19);
            panelSideMenu.Controls.Add(btnAyuda);
            panelSideMenu.Controls.Add(btnReportes);
            panelSideMenu.Controls.Add(btnPagarTicket);
            panelSideMenu.Controls.Add(btnApuestas);
            panelSideMenu.Controls.Add(btnInicio);
            panelSideMenu.Controls.Add(btnExit);
            panelSideMenu.Controls.Add(panelLogo);
            panelSideMenu.Dock = DockStyle.Left;
            panelSideMenu.Location = new Point(0, 0);
            panelSideMenu.Name = "panelSideMenu";
            panelSideMenu.Size = new Size(401, 843);
            panelSideMenu.TabIndex = 0;
            // 
            // btnAyuda
            // 
            btnAyuda.Dock = DockStyle.Top;
            btnAyuda.FlatAppearance.BorderSize = 0;
            btnAyuda.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 20, 19);
            btnAyuda.FlatAppearance.MouseOverBackColor = Color.FromArgb(25, 25, 19);
            btnAyuda.FlatStyle = FlatStyle.Flat;
            btnAyuda.Font = new Font("Inria Sans", 14F);
            btnAyuda.ForeColor = Color.FromArgb(252, 206, 66);
            btnAyuda.Image = PitchWin.Properties.Resources.BTNAYUDA;
            btnAyuda.ImageAlign = ContentAlignment.MiddleLeft;
            btnAyuda.Location = new Point(0, 536);
            btnAyuda.Name = "btnAyuda";
            btnAyuda.Padding = new Padding(5, 0, 0, 0);
            btnAyuda.Size = new Size(401, 91);
            btnAyuda.TabIndex = 14;
            btnAyuda.Text = "  AYUDA";
            btnAyuda.TextAlign = ContentAlignment.MiddleLeft;
            btnAyuda.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAyuda.UseVisualStyleBackColor = true;
            btnAyuda.Click += btnAyuda_Click;
            // 
            // btnReportes
            // 
            btnReportes.Dock = DockStyle.Top;
            btnReportes.FlatAppearance.BorderSize = 0;
            btnReportes.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 20, 19);
            btnReportes.FlatAppearance.MouseOverBackColor = Color.FromArgb(25, 25, 19);
            btnReportes.FlatStyle = FlatStyle.Flat;
            btnReportes.Font = new Font("Inria Sans", 14F);
            btnReportes.ForeColor = Color.FromArgb(252, 206, 66);
            btnReportes.Image = PitchWin.Properties.Resources.BTNREPORTE;
            btnReportes.ImageAlign = ContentAlignment.MiddleLeft;
            btnReportes.Location = new Point(0, 445);
            btnReportes.Name = "btnReportes";
            btnReportes.Padding = new Padding(5, 0, 0, 0);
            btnReportes.Size = new Size(401, 91);
            btnReportes.TabIndex = 13;
            btnReportes.Text = "  REPORTES";
            btnReportes.TextAlign = ContentAlignment.MiddleLeft;
            btnReportes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReportes.UseVisualStyleBackColor = true;
            btnReportes.Click += btnReportes_Click;
            // 
            // btnPagarTicket
            // 
            btnPagarTicket.Dock = DockStyle.Top;
            btnPagarTicket.FlatAppearance.BorderSize = 0;
            btnPagarTicket.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 20, 19);
            btnPagarTicket.FlatAppearance.MouseOverBackColor = Color.FromArgb(25, 25, 19);
            btnPagarTicket.FlatStyle = FlatStyle.Flat;
            btnPagarTicket.Font = new Font("Inria Sans", 14F);
            btnPagarTicket.ForeColor = Color.FromArgb(252, 206, 66);
            btnPagarTicket.Image = PitchWin.Properties.Resources.BTNTICKET;
            btnPagarTicket.ImageAlign = ContentAlignment.MiddleLeft;
            btnPagarTicket.Location = new Point(0, 354);
            btnPagarTicket.Name = "btnPagarTicket";
            btnPagarTicket.Padding = new Padding(5, 0, 0, 0);
            btnPagarTicket.Size = new Size(401, 91);
            btnPagarTicket.TabIndex = 12;
            btnPagarTicket.Text = "  PAGAR TICKET";
            btnPagarTicket.TextAlign = ContentAlignment.MiddleLeft;
            btnPagarTicket.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPagarTicket.UseVisualStyleBackColor = true;
            btnPagarTicket.Click += btnPagarTicket_Click;
            // 
            // btnApuestas
            // 
            btnApuestas.Dock = DockStyle.Top;
            btnApuestas.FlatAppearance.BorderSize = 0;
            btnApuestas.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 20, 19);
            btnApuestas.FlatAppearance.MouseOverBackColor = Color.FromArgb(25, 25, 19);
            btnApuestas.FlatStyle = FlatStyle.Flat;
            btnApuestas.Font = new Font("Inria Sans", 14F);
            btnApuestas.ForeColor = Color.FromArgb(252, 206, 66);
            btnApuestas.Image = PitchWin.Properties.Resources.ChatGPT_Image_10_abr_2025__02_33_05_a_m_;
            btnApuestas.ImageAlign = ContentAlignment.MiddleLeft;
            btnApuestas.Location = new Point(0, 263);
            btnApuestas.Name = "btnApuestas";
            btnApuestas.Padding = new Padding(5, 0, 0, 0);
            btnApuestas.Size = new Size(401, 91);
            btnApuestas.TabIndex = 11;
            btnApuestas.Text = "  APUESTAS";
            btnApuestas.TextAlign = ContentAlignment.MiddleLeft;
            btnApuestas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnApuestas.UseVisualStyleBackColor = true;
            btnApuestas.Click += btnApuestas_Click;
            // 
            // btnInicio
            // 
            btnInicio.Dock = DockStyle.Top;
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 20, 19);
            btnInicio.FlatAppearance.MouseOverBackColor = Color.FromArgb(25, 25, 19);
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Font = new Font("Inria Sans", 14F);
            btnInicio.ForeColor = Color.FromArgb(252, 206, 66);
            btnInicio.Image = (Image)resources.GetObject("btnInicio.Image");
            btnInicio.ImageAlign = ContentAlignment.MiddleLeft;
            btnInicio.Location = new Point(0, 172);
            btnInicio.Name = "btnInicio";
            btnInicio.Padding = new Padding(5, 0, 0, 0);
            btnInicio.Size = new Size(401, 91);
            btnInicio.TabIndex = 10;
            btnInicio.Text = "  INICIO";
            btnInicio.TextAlign = ContentAlignment.MiddleLeft;
            btnInicio.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click;
            // 
            // btnExit
            // 
            btnExit.Dock = DockStyle.Bottom;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 20, 19);
            btnExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(25, 25, 19);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Inria Sans", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.FromArgb(252, 206, 66);
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
            // panelLogo
            // 
            panelLogo.BorderStyle = BorderStyle.FixedSingle;
            panelLogo.Controls.Add(pictureBox1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(401, 172);
            panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = PitchWin.Properties.Resources.ChatGPT_Image_10_abr_2025__02_55_24_a_m_;
            pictureBox1.Location = new Point(51, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(293, 136);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelFormInicio
            // 
            panelFormInicio.BackColor = Color.FromArgb(225, 238, 255);
            panelFormInicio.Controls.Add(PanelInicio);
            panelFormInicio.Dock = DockStyle.Fill;
            panelFormInicio.Location = new Point(401, 0);
            panelFormInicio.Name = "panelFormInicio";
            panelFormInicio.Size = new Size(1288, 843);
            panelFormInicio.TabIndex = 2;
            // 
            // PanelInicio
            // 
            PanelInicio.BackColor = Color.FromArgb(12, 12, 12);
            PanelInicio.Dock = DockStyle.Fill;
            PanelInicio.Location = new Point(0, 0);
            PanelInicio.Name = "PanelInicio";
            PanelInicio.Size = new Size(1288, 843);
            PanelInicio.TabIndex = 15;
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1689, 843);
            Controls.Add(panelFormInicio);
            Controls.Add(panelSideMenu);
            Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MinimumSize = new Size(950, 600);
            Name = "FrmMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FrmMenuPrincipal_Load;
            panelSideMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelFormInicio.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panelFormInicio;
        private PictureBox pictureBox1;
        private Button btnAyuda;
        private Button btnReportes;
        private Button btnPagarTicket;
        private Button btnApuestas;
        private Button btnInicio;
        public Panel PanelInicio;
    }
}

