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
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(64, 39);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(565, 48);
            label1.TabIndex = 0;
            label1.Text = "Administracion de usuarios";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 13.8F);
            label2.Location = new Point(143, 163);
            label2.Name = "label2";
            label2.Size = new Size(110, 28);
            label2.TabIndex = 1;
            label2.Text = "Usuario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 13.8F);
            label3.Location = new Point(105, 237);
            label3.Name = "label3";
            label3.Size = new Size(155, 28);
            label3.TabIndex = 2;
            label3.Text = "Contraseña:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 13.8F);
            label4.Location = new Point(188, 311);
            label4.Name = "label4";
            label4.Size = new Size(57, 28);
            label4.TabIndex = 3;
            label4.Text = "Rol:";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Verdana", 13.8F);
            txtUsuario.Location = new Point(291, 160);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(303, 35);
            txtUsuario.TabIndex = 4;
            // 
            // txtContraseña
            // 
            txtContraseña.Font = new Font("Verdana", 13.8F);
            txtContraseña.Location = new Point(291, 234);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(303, 35);
            txtContraseña.TabIndex = 5;
            // 
            // cmbRol
            // 
            cmbRol.Font = new Font("Verdana", 13.8F);
            cmbRol.FormattingEnabled = true;
            cmbRol.Location = new Point(291, 308);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(303, 36);
            cmbRol.TabIndex = 6;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(92, 407);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(121, 40);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(301, 405);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(123, 42);
            btnModificar.TabIndex = 8;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(499, 407);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(130, 42);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(12, 466);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowHeadersWidth = 51;
            dgvUsuarios.Size = new Size(677, 155);
            dgvUsuarios.TabIndex = 10;
            // 
            // FormUsuarios
            // 
            AutoScaleDimensions = new SizeF(13F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(701, 633);
            Controls.Add(dgvUsuarios);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnGuardar);
            Controls.Add(cmbRol);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "FormUsuarios";
            Text = "FormUsuarios";
            Load += FormUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
    }
}