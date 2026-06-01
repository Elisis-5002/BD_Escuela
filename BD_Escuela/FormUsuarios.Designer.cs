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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            cmbRol = new ComboBox();
            btnGuardar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            dgvUsuarios = new DataGridView();
            splitContainer1 = new SplitContainer();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(55, 9);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(316, 76);
            label1.TabIndex = 0;
            label1.Text = "Administracion de \r\nusuarios";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 13.8F);
            label2.Location = new Point(55, 186);
            label2.Name = "label2";
            label2.Size = new Size(92, 23);
            label2.TabIndex = 1;
            label2.Text = "Usuario:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 13.8F);
            label3.Location = new Point(17, 260);
            label3.Name = "label3";
            label3.Size = new Size(126, 23);
            label3.TabIndex = 2;
            label3.Text = "Contraseña:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 13.8F);
            label4.Location = new Point(100, 334);
            label4.Name = "label4";
            label4.Size = new Size(50, 23);
            label4.TabIndex = 3;
            label4.Text = "Rol:";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Verdana", 13.8F);
            txtUsuario.Location = new Point(203, 183);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(303, 30);
            txtUsuario.TabIndex = 4;
            // 
            // txtContraseña
            // 
            txtContraseña.Font = new Font("Verdana", 13.8F);
            txtContraseña.Location = new Point(203, 257);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(303, 30);
            txtContraseña.TabIndex = 5;
            // 
            // cmbRol
            // 
            cmbRol.Font = new Font("Verdana", 13.8F);
            cmbRol.FormattingEnabled = true;
            cmbRol.Location = new Point(203, 331);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(303, 30);
            cmbRol.TabIndex = 6;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(71, 489);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(121, 40);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(216, 489);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(130, 42);
            btnModificar.TabIndex = 8;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(376, 489);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(130, 42);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgvUsuarios.BackgroundColor = SystemColors.Control;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Dock = DockStyle.Fill;
            dgvUsuarios.Location = new Point(0, 0);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersWidth = 51;
            dgvUsuarios.Size = new Size(694, 637);
            dgvUsuarios.TabIndex = 10;
            dgvUsuarios.CellClick += dgvUsuarios_CellClick;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(label5);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(btnEliminar);
            splitContainer1.Panel1.Controls.Add(btnModificar);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(btnGuardar);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(cmbRol);
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Controls.Add(txtContraseña);
            splitContainer1.Panel1.Controls.Add(txtUsuario);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvUsuarios);
            splitContainer1.Size = new Size(1268, 637);
            splitContainer1.SplitterDistance = 570;
            splitContainer1.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 13.8F);
            label5.Location = new Point(71, 446);
            label5.Name = "label5";
            label5.Size = new Size(403, 23);
            label5.TabIndex = 10;
            label5.Text = "SOLO para administradores y secretarios";
            // 
            // FormUsuarios
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1268, 637);
            Controls.Add(splitContainer1);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "FormUsuarios";
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

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private ComboBox cmbRol;
        private Button btnGuardar;
        private Button btnModificar;
        private Button btnEliminar;
        private DataGridView dgvUsuarios;
        private SplitContainer splitContainer1;
        private Label label5;
    }
}