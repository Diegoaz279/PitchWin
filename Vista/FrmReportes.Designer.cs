namespace PitchWin.Vista
{
    partial class FrmReportes
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label2 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            label9 = new Label();
            dtpReportesFecha = new Guna.UI2.WinForms.Guna2DateTimePicker();
            btnReportesBuscar = new Guna.UI2.WinForms.Guna2Button();
            tableLayoutPanel6 = new TableLayoutPanel();
            label3 = new Label();
            dgvTicketsDelDia = new DataGridView();
            tableLayoutPanel3 = new TableLayoutPanel();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTicketsDelDia).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(12, 12, 12);
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.77777767F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 94.44444F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.77777767F));
            tableLayoutPanel1.Controls.Add(panel1, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 129);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 1.96078432F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 93.13725F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 4.901961F));
            tableLayoutPanel1.Size = new Size(1470, 776);
            tableLayoutPanel1.TabIndex = 21;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 30, 59);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(43, 18);
            panel1.Name = "panel1";
            panel1.Size = new Size(1382, 716);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.FromArgb(20, 20, 19);
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1.5F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 97F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1.5F));
            tableLayoutPanel2.Controls.Add(label2, 1, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 1, 2);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel6, 1, 3);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 2.38095236F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7.142857F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25.3401356F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 63.24639F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 1.57136106F));
            tableLayoutPanel2.Size = new Size(1380, 714);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Font = new Font("Rubik Mono One", 13.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(252, 206, 66);
            label2.Location = new Point(444, 33);
            label2.Name = "label2";
            label2.Size = new Size(490, 35);
            label2.TabIndex = 19;
            label2.Text = "SELECCIONE LA FECHA";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 4;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.8985252F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.4353218F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.8993034F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.7668476F));
            tableLayoutPanel4.Controls.Add(label9, 0, 1);
            tableLayoutPanel4.Controls.Add(dtpReportesFecha, 1, 1);
            tableLayoutPanel4.Controls.Add(btnReportesBuscar, 2, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(23, 71);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 34.4243774F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 37.9232521F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 27.6523685F));
            tableLayoutPanel4.Size = new Size(1332, 175);
            tableLayoutPanel4.TabIndex = 20;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Inria Sans", 11F, FontStyle.Bold);
            label9.ForeColor = Color.White;
            label9.Location = new Point(461, 79);
            label9.Name = "label9";
            label9.Size = new Size(80, 28);
            label9.TabIndex = 37;
            label9.Text = "FECHA:";
            // 
            // dtpReportesFecha
            // 
            dtpReportesFecha.Anchor = AnchorStyles.Left;
            dtpReportesFecha.BorderColor = SystemColors.ActiveCaption;
            dtpReportesFecha.BorderRadius = 5;
            dtpReportesFecha.Checked = true;
            dtpReportesFecha.CustomizableEdges = customizableEdges1;
            dtpReportesFecha.FillColor = Color.FromArgb(12, 12, 12);
            dtpReportesFecha.Font = new Font("Inria Sans", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpReportesFecha.ForeColor = Color.White;
            dtpReportesFecha.Format = DateTimePickerFormat.Long;
            dtpReportesFecha.Location = new Point(547, 66);
            dtpReportesFecha.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpReportesFecha.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpReportesFecha.Name = "dtpReportesFecha";
            dtpReportesFecha.ShadowDecoration.CustomizableEdges = customizableEdges2;
            dtpReportesFecha.Size = new Size(239, 54);
            dtpReportesFecha.TabIndex = 40;
            dtpReportesFecha.Value = new DateTime(2025, 4, 10, 0, 0, 0, 0);
            // 
            // btnReportesBuscar
            // 
            btnReportesBuscar.Anchor = AnchorStyles.Left;
            btnReportesBuscar.BorderRadius = 10;
            btnReportesBuscar.CustomizableEdges = customizableEdges3;
            btnReportesBuscar.DisabledState.BorderColor = Color.DarkGray;
            btnReportesBuscar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnReportesBuscar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnReportesBuscar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnReportesBuscar.FillColor = Color.FromArgb(252, 206, 66);
            btnReportesBuscar.Font = new Font("Inria Sans", 11F, FontStyle.Bold);
            btnReportesBuscar.ForeColor = SystemColors.WindowText;
            btnReportesBuscar.Location = new Point(792, 69);
            btnReportesBuscar.Name = "btnReportesBuscar";
            btnReportesBuscar.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnReportesBuscar.Size = new Size(148, 47);
            btnReportesBuscar.TabIndex = 39;
            btnReportesBuscar.Text = "BUSCAR";
            btnReportesBuscar.Click += btnReportesBuscar_Click;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Controls.Add(label3, 0, 1);
            tableLayoutPanel6.Controls.Add(dgvTicketsDelDia, 0, 2);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(23, 252);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 4;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 2.46575332F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 9.289618F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 82.1029053F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 6.2639823F));
            tableLayoutPanel6.Size = new Size(1332, 447);
            tableLayoutPanel6.TabIndex = 21;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Font = new Font("Rubik Mono One", 10.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(252, 206, 66);
            label3.Location = new Point(580, 24);
            label3.Name = "label3";
            label3.Size = new Size(172, 28);
            label3.TabIndex = 22;
            label3.Text = "DETALLES";
            // 
            // dgvTicketsDelDia
            // 
            dgvTicketsDelDia.AllowUserToAddRows = false;
            dgvTicketsDelDia.AllowUserToDeleteRows = false;
            dgvTicketsDelDia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTicketsDelDia.BackgroundColor = Color.FromArgb(12, 12, 12);
            dgvTicketsDelDia.BorderStyle = BorderStyle.Fixed3D;
            dgvTicketsDelDia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTicketsDelDia.Dock = DockStyle.Fill;
            dgvTicketsDelDia.Location = new Point(3, 55);
            dgvTicketsDelDia.MultiSelect = false;
            dgvTicketsDelDia.Name = "dgvTicketsDelDia";
            dgvTicketsDelDia.ReadOnly = true;
            dgvTicketsDelDia.RowHeadersVisible = false;
            dgvTicketsDelDia.RowHeadersWidth = 62;
            dgvTicketsDelDia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTicketsDelDia.Size = new Size(1326, 360);
            dgvTicketsDelDia.TabIndex = 25;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = Color.FromArgb(12, 12, 12);
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.5F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 95F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.5F));
            tableLayoutPanel3.Controls.Add(label1, 1, 1);
            tableLayoutPanel3.Dock = DockStyle.Top;
            tableLayoutPanel3.ForeColor = Color.DarkOrange;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 29.1428566F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 59.42857F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 10.8193607F));
            tableLayoutPanel3.Size = new Size(1470, 129);
            tableLayoutPanel3.TabIndex = 20;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Rubik Mono One", 27.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(252, 206, 66);
            label1.Location = new Point(523, 41);
            label1.Name = "label1";
            label1.Size = new Size(422, 69);
            label1.TabIndex = 0;
            label1.Text = "REPORTES";
            // 
            // FrmReportes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1470, 905);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tableLayoutPanel3);
            Name = "FrmReportes";
            Text = "FrmReportes";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTicketsDelDia).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label9;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpReportesFecha;
        private Guna.UI2.WinForms.Guna2Button btnReportesBuscar;
        private TableLayoutPanel tableLayoutPanel6;
        private Label label3;
        private DataGridView dgvTicketsDelDia;
    }
}