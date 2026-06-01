namespace BD_Escuela
{
    partial class FormCursos
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cmbProfesor = new ComboBox();
            cmbMateria = new ComboBox();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnGuardar = new Button();
            dgvCursos = new DataGridView();
            splitContainer1 = new SplitContainer();
            label5 = new Label();
            dgvMasUn = new DataGridView();
            label1 = new Label();
            txtID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvCursos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMasUn).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(10, 7);
            label2.Name = "label2";
            label2.Size = new Size(126, 38);
            label2.TabIndex = 18;
            label2.Text = "Cursos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(60, 68);
            label3.Name = "label3";
            label3.Size = new Size(98, 23);
            label3.TabIndex = 19;
            label3.Text = "Profesor:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(60, 131);
            label4.Name = "label4";
            label4.Size = new Size(89, 23);
            label4.TabIndex = 20;
            label4.Text = "Materia:";
            // 
            // cmbProfesor
            // 
            cmbProfesor.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbProfesor.FormattingEnabled = true;
            cmbProfesor.Location = new Point(206, 68);
            cmbProfesor.Margin = new Padding(3, 2, 3, 2);
            cmbProfesor.Name = "cmbProfesor";
            cmbProfesor.Size = new Size(248, 26);
            cmbProfesor.TabIndex = 21;
            cmbProfesor.SelectedIndexChanged += cmbProfesor_SelectedIndexChanged;
            // 
            // cmbMateria
            // 
            cmbMateria.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbMateria.FormattingEnabled = true;
            cmbMateria.Location = new Point(206, 131);
            cmbMateria.Margin = new Padding(3, 2, 3, 2);
            cmbMateria.Name = "cmbMateria";
            cmbMateria.Size = new Size(248, 26);
            cmbMateria.TabIndex = 22;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(477, 179);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(108, 29);
            btnEliminar.TabIndex = 25;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnModificar.Location = new Point(280, 179);
            btnModificar.Margin = new Padding(3, 2, 3, 2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(108, 29);
            btnModificar.TabIndex = 24;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(69, 179);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(108, 29);
            btnGuardar.TabIndex = 23;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dgvCursos
            // 
            dgvCursos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgvCursos.BackgroundColor = SystemColors.Control;
            dgvCursos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCursos.Dock = DockStyle.Fill;
            dgvCursos.Location = new Point(0, 0);
            dgvCursos.Margin = new Padding(3, 2, 3, 2);
            dgvCursos.Name = "dgvCursos";
            dgvCursos.ReadOnly = true;
            dgvCursos.RowHeadersWidth = 51;
            dgvCursos.Size = new Size(997, 221);
            dgvCursos.TabIndex = 26;
            dgvCursos.CellClick += dgvCursos_CellClick;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(2);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(label5);
            splitContainer1.Panel1.Controls.Add(dgvMasUn);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(txtID);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(btnEliminar);
            splitContainer1.Panel1.Controls.Add(cmbProfesor);
            splitContainer1.Panel1.Controls.Add(btnModificar);
            splitContainer1.Panel1.Controls.Add(cmbMateria);
            splitContainer1.Panel1.Controls.Add(btnGuardar);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvCursos);
            splitContainer1.Size = new Size(997, 447);
            splitContainer1.SplitterDistance = 224;
            splitContainer1.SplitterWidth = 2;
            splitContainer1.TabIndex = 27;
            splitContainer1.SplitterMoved += splitContainer1_SplitterMoved;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(663, 22);
            label5.Name = "label5";
            label5.Size = new Size(310, 23);
            label5.TabIndex = 29;
            label5.Text = "Cursos con mas de un alumno:";
            // 
            // dgvMasUn
            // 
            dgvMasUn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMasUn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMasUn.Location = new Point(663, 58);
            dgvMasUn.Name = "dgvMasUn";
            dgvMasUn.ReadOnly = true;
            dgvMasUn.Size = new Size(301, 150);
            dgvMasUn.TabIndex = 28;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(507, 67);
            label1.Name = "label1";
            label1.Size = new Size(42, 23);
            label1.TabIndex = 27;
            label1.Text = "ID:";
            // 
            // txtID
            // 
            txtID.Location = new Point(507, 93);
            txtID.Name = "txtID";
            txtID.Size = new Size(131, 23);
            txtID.TabIndex = 26;
            // 
            // FormCursos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(997, 447);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(splitContainer1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormCursos";
            Text = "FormCursos";
            Load += FormCursos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCursos).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMasUn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cmbProfesor;
        private ComboBox cmbMateria;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnGuardar;
        private DataGridView dgvCursos;
        private SplitContainer splitContainer1;
        private Label label1;
        private TextBox txtID;
        private DataGridView dgvMasUn;
        private Label label5;
    }
}