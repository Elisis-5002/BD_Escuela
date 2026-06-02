using Guna.UI2.WinForms.Suite;

namespace BD_Escuela
{
    partial class FormUsuarios
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            CustomizableEdges customizableEdges1 = new CustomizableEdges();
            CustomizableEdges customizableEdges2 = new CustomizableEdges();
            CustomizableEdges customizableEdges3 = new CustomizableEdges();
            CustomizableEdges customizableEdges4 = new CustomizableEdges();
            CustomizableEdges customizableEdges5 = new CustomizableEdges();
            CustomizableEdges customizableEdges6 = new CustomizableEdges();
            CustomizableEdges customizableEdges7 = new CustomizableEdges();
            CustomizableEdges customizableEdges8 = new CustomizableEdges();
            CustomizableEdges customizableEdges9 = new CustomizableEdges();
            CustomizableEdges customizableEdges10 = new CustomizableEdges();
            CustomizableEdges customizableEdges11 = new CustomizableEdges();
            CustomizableEdges customizableEdges12 = new CustomizableEdges();
            CustomizableEdges customizableEdges13 = new CustomizableEdges();
            dgvUsuarios = new DataGridView();
            splitContainer1 = new SplitContainer();
            cmbRol = new Guna.UI2.WinForms.Guna2ComboBox();
            txtContraseña = new Guna.UI2.WinForms.Guna2TextBox();
            txtUsuario = new Guna.UI2.WinForms.Guna2TextBox();
            btnEliminar = new Guna.UI2.WinForms.Guna2Button();
            btnModificar = new Guna.UI2.WinForms.Guna2Button();
            btnGuardar = new Guna.UI2.WinForms.Guna2Button();
            guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblUsuario2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnMinimizar = new Guna.UI2.WinForms.Guna2Button();
            btnMaximizar = new Guna.UI2.WinForms.Guna2Button();
            btnCerrar = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvUsuarios
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(245, 249, 254);
            dgvUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvUsuarios.BackgroundColor = Color.White;
            dgvUsuarios.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(24, 95, 165);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(12, 68, 124);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(181, 212, 244);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(12, 68, 124);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvUsuarios.DefaultCellStyle = dataGridViewCellStyle3;
            dgvUsuarios.EnableHeadersVisualStyles = false;
            dgvUsuarios.GridColor = Color.FromArgb(181, 212, 244);
            dgvUsuarios.Location = new Point(4, 52);
            dgvUsuarios.Margin = new Padding(4, 3, 4, 3);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowHeadersVisible = false;
            dgvUsuarios.RowHeadersWidth = 51;
            dgvUsuarios.Size = new Size(920, 494);
            dgvUsuarios.TabIndex = 5;
            dgvUsuarios.CellClick += dgvUsuarios_CellClick;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(4, 3, 4, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.FromArgb(181, 212, 244);
            splitContainer1.Panel1.Controls.Add(cmbRol);
            splitContainer1.Panel1.Controls.Add(txtContraseña);
            splitContainer1.Panel1.Controls.Add(txtUsuario);
            splitContainer1.Panel1.Controls.Add(btnEliminar);
            splitContainer1.Panel1.Controls.Add(btnModificar);
            splitContainer1.Panel1.Controls.Add(btnGuardar);
            splitContainer1.Panel1.Controls.Add(guna2HtmlLabel4);
            splitContainer1.Panel1.Controls.Add(guna2HtmlLabel3);
            splitContainer1.Panel1.Controls.Add(guna2HtmlLabel2);
            splitContainer1.Panel1.Controls.Add(guna2HtmlLabel1);
            splitContainer1.Panel1.Controls.Add(lblUsuario2);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(btnMinimizar);
            splitContainer1.Panel2.Controls.Add(btnMaximizar);
            splitContainer1.Panel2.Controls.Add(btnCerrar);
            splitContainer1.Panel2.Controls.Add(dgvUsuarios);
            splitContainer1.Size = new Size(1563, 549);
            splitContainer1.SplitterDistance = 634;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 11;
            splitContainer1.SplitterMoved += splitContainer1_SplitterMoved;
            // 
            // cmbRol
            // 
            cmbRol.BackColor = Color.Transparent;
            cmbRol.BorderColor = Color.FromArgb(133, 183, 235);
            cmbRol.BorderRadius = 10;
            cmbRol.CustomizableEdges = customizableEdges1;
            cmbRol.DrawMode = DrawMode.OwnerDrawFixed;
            cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRol.FillColor = Color.FromArgb(230, 241, 251);
            cmbRol.FocusedColor = Color.FromArgb(94, 148, 255);
            cmbRol.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cmbRol.Font = new Font("Segoe UI", 10F);
            cmbRol.ForeColor = Color.FromArgb(12, 68, 124);
            cmbRol.ItemHeight = 30;
            cmbRol.Location = new Point(227, 292);
            cmbRol.Margin = new Padding(4, 3, 4, 3);
            cmbRol.Name = "cmbRol";
            cmbRol.ShadowDecoration.CustomizableEdges = customizableEdges2;
            cmbRol.Size = new Size(372, 36);
            cmbRol.TabIndex = 6;
            // 
            // txtContraseña
            // 
            txtContraseña.BackColor = Color.White;
            txtContraseña.BorderColor = Color.FromArgb(133, 183, 235);
            txtContraseña.BorderRadius = 10;
            txtContraseña.CustomizableEdges = customizableEdges1;
            txtContraseña.DefaultText = "";
            txtContraseña.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtContraseña.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtContraseña.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtContraseña.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtContraseña.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtContraseña.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContraseña.ForeColor = Color.FromArgb(12, 68, 124);
            txtContraseña.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtContraseña.Location = new Point(227, 226);
            txtContraseña.Margin = new Padding(5);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PlaceholderText = "Escribe tu  contraseña...";
            txtContraseña.SelectedText = "";
            txtContraseña.ShadowDecoration.CustomizableEdges = customizableEdges3;
            txtContraseña.Size = new Size(373, 38);
            txtContraseña.TabIndex = 17;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.White;
            txtUsuario.BorderColor = Color.FromArgb(133, 183, 235);
            txtUsuario.BorderRadius = 10;
            txtUsuario.CustomizableEdges = customizableEdges4;
            txtUsuario.DefaultText = "";
            txtUsuario.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtUsuario.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtUsuario.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtUsuario.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtUsuario.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUsuario.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.ForeColor = Color.FromArgb(12, 68, 124);
            txtUsuario.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUsuario.Location = new Point(227, 162);
            txtUsuario.Margin = new Padding(5);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Escribe tu usuario...";
            txtUsuario.SelectedText = "";
            txtUsuario.ShadowDecoration.CustomizableEdges = customizableEdges5;
            txtUsuario.Size = new Size(373, 38);
            txtUsuario.TabIndex = 5;
            // 
            // btnEliminar
            // 
            btnEliminar.BorderColor = Color.Empty;
            btnEliminar.BorderRadius = 10;
            btnEliminar.CustomizableEdges = customizableEdges6;
            btnEliminar.DisabledState.BorderColor = Color.DarkGray;
            btnEliminar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnEliminar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnEliminar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnEliminar.FillColor = Color.FromArgb(226, 75, 74);
            btnEliminar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(433, 424);
            btnEliminar.Margin = new Padding(4, 2, 4, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.ShadowDecoration.CustomizableEdges = customizableEdges7;
            btnEliminar.Size = new Size(174, 34);
            btnEliminar.TabIndex = 16;
            btnEliminar.Text = "Eliminar";
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BorderColor = Color.Empty;
            btnModificar.BorderRadius = 10;
            btnModificar.CustomizableEdges = customizableEdges5;
            btnModificar.DisabledState.BorderColor = Color.DarkGray;
            btnModificar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnModificar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnModificar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnModificar.FillColor = Color.FromArgb(55, 138, 221);
            btnModificar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(227, 424);
            btnModificar.Margin = new Padding(4, 2, 4, 2);
            btnModificar.Name = "btnModificar";
            btnModificar.ShadowDecoration.CustomizableEdges = customizableEdges5;
            btnModificar.Size = new Size(174, 34);
            btnModificar.TabIndex = 15;
            btnModificar.Text = "Modificar";
            btnModificar.Click += btnModificar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BorderColor = Color.Empty;
            btnGuardar.BorderRadius = 10;
            btnGuardar.CustomizableEdges = customizableEdges8;
            btnGuardar.DisabledState.BorderColor = Color.DarkGray;
            btnGuardar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnGuardar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnGuardar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnGuardar.FillColor = Color.FromArgb(24, 95, 165);
            btnGuardar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(44, 424);
            btnGuardar.Margin = new Padding(4, 2, 4, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.ShadowDecoration.CustomizableEdges = customizableEdges9;
            btnGuardar.Size = new Size(160, 34);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.Click += btnGuardar_Click;
            // 
            // guna2HtmlLabel4
            // 
            guna2HtmlLabel4.BackColor = Color.Transparent;
            guna2HtmlLabel4.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            guna2HtmlLabel4.ForeColor = Color.FromArgb(24, 95, 165);
            guna2HtmlLabel4.Location = new Point(210, 71);
            guna2HtmlLabel4.Margin = new Padding(4, 2, 4, 2);
            guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            guna2HtmlLabel4.Size = new Size(197, 67);
            guna2HtmlLabel4.TabIndex = 14;
            guna2HtmlLabel4.Text = "Usuarios";
            // 
            // guna2HtmlLabel3
            // 
            guna2HtmlLabel3.BackColor = Color.Transparent;
            guna2HtmlLabel3.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            guna2HtmlLabel3.ForeColor = Color.FromArgb(24, 95, 165);
            guna2HtmlLabel3.Location = new Point(88, 9);
            guna2HtmlLabel3.Margin = new Padding(4, 2, 4, 2);
            guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            guna2HtmlLabel3.Size = new Size(417, 67);
            guna2HtmlLabel3.TabIndex = 13;
            guna2HtmlLabel3.Text = "Administración de";
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel2.ForeColor = Color.FromArgb(24, 95, 165);
            guna2HtmlLabel2.Location = new Point(64, 299);
            guna2HtmlLabel2.Margin = new Padding(4, 2, 4, 2);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(41, 34);
            guna2HtmlLabel2.TabIndex = 12;
            guna2HtmlLabel2.Text = "Rol";
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.ForeColor = Color.FromArgb(24, 95, 165);
            guna2HtmlLabel1.Location = new Point(64, 235);
            guna2HtmlLabel1.Margin = new Padding(4, 2, 4, 2);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(122, 34);
            guna2HtmlLabel1.TabIndex = 11;
            guna2HtmlLabel1.Text = "Contaseña";
            // 
            // lblUsuario2
            // 
            lblUsuario2.BackColor = Color.Transparent;
            lblUsuario2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario2.ForeColor = Color.FromArgb(24, 95, 165);
            lblUsuario2.Location = new Point(64, 171);
            lblUsuario2.Margin = new Padding(4, 2, 4, 2);
            lblUsuario2.Name = "lblUsuario2";
            lblUsuario2.Size = new Size(91, 34);
            lblUsuario2.TabIndex = 3;
            lblUsuario2.Text = "Usuario";
            // 
            // btnMinimizar
            // 
            btnMinimizar.BackColor = Color.FromArgb(181, 212, 244);
            btnMinimizar.BorderRadius = 17;
            btnMinimizar.CustomizableEdges = customizableEdges10;
            btnMinimizar.DisabledState.BorderColor = Color.DarkGray;
            btnMinimizar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnMinimizar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnMinimizar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnMinimizar.FillColor = Color.FromArgb(55, 138, 221);
            btnMinimizar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMinimizar.ForeColor = Color.White;
            btnMinimizar.Location = new Point(718, 3);
            btnMinimizar.Margin = new Padding(5, 4, 5, 4);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.ShadowDecoration.CustomizableEdges = customizableEdges11;
            btnMinimizar.Size = new Size(57, 42);
            btnMinimizar.TabIndex = 12;
            btnMinimizar.Text = "─";
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnMaximizar
            // 
            btnMaximizar.BackColor = Color.FromArgb(181, 212, 244);
            btnMaximizar.BorderRadius = 17;
            btnMaximizar.CustomizableEdges = customizableEdges12;
            btnMaximizar.DisabledState.BorderColor = Color.DarkGray;
            btnMaximizar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnMaximizar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnMaximizar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnMaximizar.FillColor = Color.FromArgb(55, 138, 221);
            btnMaximizar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMaximizar.ForeColor = Color.White;
            btnMaximizar.Location = new Point(785, 4);
            btnMaximizar.Margin = new Padding(5, 4, 5, 4);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.ShadowDecoration.CustomizableEdges = customizableEdges13;
            btnMaximizar.Size = new Size(61, 38);
            btnMaximizar.TabIndex = 11;
            btnMaximizar.Text = "□";
            btnMaximizar.Click += btnMaximizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.FromArgb(181, 212, 244);
            btnCerrar.BorderRadius = 17;
            btnCerrar.CustomizableEdges = customizableEdges5;
            btnCerrar.DisabledState.BorderColor = Color.DarkGray;
            btnCerrar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCerrar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCerrar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCerrar.FillColor = Color.FromArgb(226, 75, 74);
            btnCerrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrar.ForeColor = Color.White;
            btnCerrar.Location = new Point(854, 3);
            btnCerrar.Margin = new Padding(4, 3, 4, 3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnCerrar.Size = new Size(57, 39);
            btnCerrar.TabIndex = 1;
            btnCerrar.Text = "✕";
            btnCerrar.Click += btnCerrar_Click;
            // 
            // FormUsuarios
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(181, 212, 244);
            ClientSize = new Size(1563, 549);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 2, 4, 2);
            Name = "FormUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormUsuarios";
            Load += FormUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvUsuarios;
        private SplitContainer splitContainer1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblUsuario2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2Button btnGuardar;
        private Guna.UI2.WinForms.Guna2Button btnModificar;
        private Guna.UI2.WinForms.Guna2Button btnEliminar;
        private Guna.UI2.WinForms.Guna2TextBox txtUsuario;
        private Guna.UI2.WinForms.Guna2ComboBox cmbRol;
        private Guna.UI2.WinForms.Guna2TextBox txtContraseña;
        private Guna.UI2.WinForms.Guna2Button btnCerrar;
        private Guna.UI2.WinForms.Guna2Button btnMaximizar;
        private Guna.UI2.WinForms.Guna2Button btnMinimizar;
    }
}