namespace BD_Escuela
{
    partial class FormInscripciones
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
            btnEliminar = new Button();
            btnModificar = new Button();
            btnGuardar = new Button();
            cmbCurso = new ComboBox();
            cmbAlumno = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dgvInscripciones = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvInscripciones).BeginInit();
            SuspendLayout();
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(846, 321);
            btnEliminar.Margin = new Padding(4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(170, 49);
            btnEliminar.TabIndex = 35;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnModificar.Location = new Point(478, 321);
            btnModificar.Margin = new Padding(4);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(170, 49);
            btnModificar.TabIndex = 34;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(88, 321);
            btnGuardar.Margin = new Padding(4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(170, 49);
            btnGuardar.TabIndex = 33;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // cmbCurso
            // 
            cmbCurso.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCurso.FormattingEnabled = true;
            cmbCurso.Location = new Point(297, 215);
            cmbCurso.Margin = new Padding(4);
            cmbCurso.Name = "cmbCurso";
            cmbCurso.Size = new Size(393, 37);
            cmbCurso.TabIndex = 32;
            // 
            // cmbAlumno
            // 
            cmbAlumno.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbAlumno.FormattingEnabled = true;
            cmbAlumno.Location = new Point(297, 138);
            cmbAlumno.Margin = new Padding(4);
            cmbAlumno.Name = "cmbAlumno";
            cmbAlumno.Size = new Size(393, 37);
            cmbAlumno.TabIndex = 31;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(96, 216);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(110, 34);
            label4.TabIndex = 30;
            label4.Text = "Curso:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(96, 139);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(136, 34);
            label3.TabIndex = 29;
            label3.Text = "Alumno:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(16, 11);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(340, 59);
            label2.TabIndex = 28;
            label2.Text = "Inscripciones";
            // 
            // dgvInscripciones
            // 
            dgvInscripciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInscripciones.Location = new Point(16, 396);
            dgvInscripciones.Margin = new Padding(4);
            dgvInscripciones.Name = "dgvInscripciones";
            dgvInscripciones.RowHeadersWidth = 51;
            dgvInscripciones.Size = new Size(1067, 322);
            dgvInscripciones.TabIndex = 37;
            dgvInscripciones.CellClick += dgvInscripciones_CellClick;
            // 
            // FormInscripciones
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 746);
            Controls.Add(dgvInscripciones);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnGuardar);
            Controls.Add(cmbCurso);
            Controls.Add(cmbAlumno);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Margin = new Padding(4);
            Name = "FormInscripciones";
            Text = "FormInscripciones";
            Load += FormInscripciones_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvInscripciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEliminar;
        private Button btnModificar;
        private Button btnGuardar;
        private ComboBox cmbCurso;
        private ComboBox cmbAlumno;
        private Label label4;
        private Label label3;
        private Label label2;
        private DataGridView dgvInscripciones;
    }
}