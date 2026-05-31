namespace BD_Escuela.Forms
{
    partial class frmAlumnos
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
            splitContainer1 = new SplitContainer();
            numAño = new NumericUpDown();
            txtEmail = new TextBox();
            txtApellido = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnModificar = new Button();
            btnBaja = new Button();
            btnAlta = new Button();
            txtNombre = new TextBox();
            dgvAlumnos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numAño).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(2, 2, 2, 2);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(numAño);
            splitContainer1.Panel1.Controls.Add(txtEmail);
            splitContainer1.Panel1.Controls.Add(txtApellido);
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(btnModificar);
            splitContainer1.Panel1.Controls.Add(btnBaja);
            splitContainer1.Panel1.Controls.Add(btnAlta);
            splitContainer1.Panel1.Controls.Add(txtNombre);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvAlumnos);
            splitContainer1.Size = new Size(655, 501);
            splitContainer1.SplitterDistance = 208;
            splitContainer1.SplitterWidth = 2;
            splitContainer1.TabIndex = 0;
            // 
            // numAño
            // 
            numAño.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numAño.Location = new Point(166, 132);
            numAño.Margin = new Padding(2, 2, 2, 2);
            numAño.Maximum = new decimal(new int[] { 2026, 0, 0, 0 });
            numAño.Minimum = new decimal(new int[] { 2000, 0, 0, 0 });
            numAño.Name = "numAño";
            numAño.Size = new Size(167, 39);
            numAño.TabIndex = 0;
            numAño.TextAlign = HorizontalAlignment.Center;
            numAño.Value = new decimal(new int[] { 2000, 0, 0, 0 });
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(131, 98);
            txtEmail.Margin = new Padding(2, 2, 2, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(203, 27);
            txtEmail.TabIndex = 9;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(131, 62);
            txtApellido.Margin = new Padding(2, 2, 2, 2);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(203, 27);
            txtApellido.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(29, 97);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(63, 28);
            label4.TabIndex = 7;
            label4.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(29, 138);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(149, 28);
            label3.TabIndex = 6;
            label3.Text = "Año de Ingreso:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(29, 62);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(90, 28);
            label2.TabIndex = 5;
            label2.Text = "Apellido:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 26);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(89, 28);
            label1.TabIndex = 4;
            label1.Text = "Nombre:";
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificar.Location = new Point(370, 118);
            btnModificar.Margin = new Padding(2, 2, 2, 2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(142, 37);
            btnModificar.TabIndex = 3;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnBaja
            // 
            btnBaja.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBaja.Location = new Point(370, 70);
            btnBaja.Margin = new Padding(2, 2, 2, 2);
            btnBaja.Name = "btnBaja";
            btnBaja.Size = new Size(142, 34);
            btnBaja.TabIndex = 2;
            btnBaja.Text = "Dar de Baja";
            btnBaja.UseVisualStyleBackColor = true;
            btnBaja.Click += btnBaja_Click;
            // 
            // btnAlta
            // 
            btnAlta.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAlta.Location = new Point(370, 18);
            btnAlta.Margin = new Padding(2, 2, 2, 2);
            btnAlta.Name = "btnAlta";
            btnAlta.Size = new Size(142, 37);
            btnAlta.TabIndex = 1;
            btnAlta.Text = "Dar de Alta";
            btnAlta.UseVisualStyleBackColor = true;
            btnAlta.Click += button1_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(131, 29);
            txtNombre.Margin = new Padding(2, 2, 2, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(203, 27);
            txtNombre.TabIndex = 0;
            // 
            // dgvAlumnos
            // 
            dgvAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlumnos.Dock = DockStyle.Fill;
            dgvAlumnos.Location = new Point(0, 0);
            dgvAlumnos.Margin = new Padding(2, 2, 2, 2);
            dgvAlumnos.Name = "dgvAlumnos";
            dgvAlumnos.RowHeadersWidth = 62;
            dgvAlumnos.Size = new Size(655, 291);
            dgvAlumnos.TabIndex = 0;
            dgvAlumnos.CellClick += dgvAlumnos_CellClick;
            dgvAlumnos.CellContentClick += dgvAlumnos_CellContentClick;
            // 
            // frmAlumnos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(655, 501);
            Controls.Add(splitContainer1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "frmAlumnos";
            Text = "frmAlumnos";
            Load += frmAlumnos_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numAño).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button btnModificar;
        private Button btnBaja;
        private Button btnAlta;
        private TextBox txtNombre;
        private Label label1;
        private TextBox txtEmail;
        private TextBox txtApellido;
        private Label label4;
        private Label label3;
        private Label label2;
        private NumericUpDown numAño;
        private DataGridView dataGridView1;
        private DataGridView dgvAlumnos;
    }
}