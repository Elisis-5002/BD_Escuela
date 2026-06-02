namespace BD_Escuela
{
    partial class FormPersonas
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pblTitulo = new Guna.UI2.WinForms.Guna2Panel();
            btnMaximizar = new Guna.UI2.WinForms.Guna2Button();
            btnMinimizar = new Guna.UI2.WinForms.Guna2Button();
            btnCerrar = new Guna.UI2.WinForms.Guna2Button();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            dgvPersonas = new DataGridView();
            pblTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPersonas).BeginInit();
            SuspendLayout();
            // 
            // pblTitulo
            // 
            pblTitulo.Controls.Add(btnMaximizar);
            pblTitulo.Controls.Add(btnMinimizar);
            pblTitulo.Controls.Add(btnCerrar);
            pblTitulo.Controls.Add(guna2HtmlLabel1);
            pblTitulo.CustomizableEdges = customizableEdges7;
            pblTitulo.FillColor = Color.FromArgb(24, 95, 165);
            pblTitulo.Location = new Point(0, 0);
            pblTitulo.Name = "pblTitulo";
            pblTitulo.ShadowDecoration.CustomizableEdges = customizableEdges8;
            pblTitulo.Size = new Size(950, 55);
            pblTitulo.TabIndex = 9;
            // 
            // btnMaximizar
            // 
            btnMaximizar.BackColor = Color.FromArgb(24, 95, 165);
            btnMaximizar.BorderRadius = 17;
            btnMaximizar.CustomizableEdges = customizableEdges1;
            btnMaximizar.DisabledState.BorderColor = Color.DarkGray;
            btnMaximizar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnMaximizar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnMaximizar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnMaximizar.FillColor = Color.FromArgb(55, 138, 221);
            btnMaximizar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMaximizar.ForeColor = Color.White;
            btnMaximizar.Location = new Point(870, 10);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnMaximizar.Size = new Size(34, 34);
            btnMaximizar.TabIndex = 7;
            btnMaximizar.Text = "□";
            btnMaximizar.Click += btnMaximizar_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.BackColor = Color.FromArgb(24, 95, 165);
            btnMinimizar.BorderRadius = 17;
            btnMinimizar.CustomizableEdges = customizableEdges3;
            btnMinimizar.DisabledState.BorderColor = Color.DarkGray;
            btnMinimizar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnMinimizar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnMinimizar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnMinimizar.FillColor = Color.FromArgb(55, 138, 221);
            btnMinimizar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMinimizar.ForeColor = Color.White;
            btnMinimizar.Location = new Point(835, 10);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnMinimizar.Size = new Size(34, 34);
            btnMinimizar.TabIndex = 6;
            btnMinimizar.Text = "─";
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.FromArgb(24, 95, 165);
            btnCerrar.BorderRadius = 17;
            btnCerrar.CustomizableEdges = customizableEdges5;
            btnCerrar.DisabledState.BorderColor = Color.DarkGray;
            btnCerrar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCerrar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCerrar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCerrar.FillColor = Color.FromArgb(226, 75, 74);
            btnCerrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrar.ForeColor = Color.White;
            btnCerrar.Location = new Point(905, 10);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnCerrar.Size = new Size(34, 34);
            btnCerrar.TabIndex = 1;
            btnCerrar.Text = "✕";
            btnCerrar.Click += btnCerrar_Click;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.ForeColor = Color.White;
            guna2HtmlLabel1.Location = new Point(16, 12);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(221, 33);
            guna2HtmlLabel1.TabIndex = 0;
            guna2HtmlLabel1.Text = "Alumnos y Maestros";
            // 
            // dgvPersonas
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(245, 249, 254);
            dgvPersonas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvPersonas.BackgroundColor = Color.White;
            dgvPersonas.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(24, 95, 165);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvPersonas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvPersonas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(12, 68, 124);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(181, 212, 244);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(12, 68, 124);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvPersonas.DefaultCellStyle = dataGridViewCellStyle3;
            dgvPersonas.EnableHeadersVisualStyles = false;
            dgvPersonas.GridColor = Color.FromArgb(181, 212, 244);
            dgvPersonas.Location = new Point(50, 120);
            dgvPersonas.Name = "dgvPersonas";
            dgvPersonas.RowHeadersVisible = false;
            dgvPersonas.RowHeadersWidth = 51;
            dgvPersonas.Size = new Size(850, 400);
            dgvPersonas.TabIndex = 11;
            // 
            // FormPersonas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 600);
            Controls.Add(dgvPersonas);
            Controls.Add(pblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormPersonas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPersonas";
            pblTitulo.ResumeLayout(false);
            pblTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPersonas).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel pblTitulo;
        private Guna.UI2.WinForms.Guna2Button btnMaximizar;
        private Guna.UI2.WinForms.Guna2Button btnMinimizar;
        private Guna.UI2.WinForms.Guna2Button btnCerrar;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private DataGridView dgvPersonas;
    }
}