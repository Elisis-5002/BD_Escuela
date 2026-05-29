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
            label1 = new Label();
            txtIdInscripcion = new TextBox();
            dgvInscripciones = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvInscripciones).BeginInit();
            SuspendLayout();
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(615, 315);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(124, 39);
            btnEliminar.TabIndex = 35;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnModificar.Location = new Point(348, 315);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(124, 39);
            btnModificar.TabIndex = 34;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(64, 315);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(124, 39);
            btnGuardar.TabIndex = 33;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // cmbCurso
            // 
            cmbCurso.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCurso.FormattingEnabled = true;
            cmbCurso.Location = new Point(216, 230);
            cmbCurso.Name = "cmbCurso";
            cmbCurso.Size = new Size(151, 33);
            cmbCurso.TabIndex = 32;
            // 
            // cmbAlumno
            // 
            cmbAlumno.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbAlumno.FormattingEnabled = true;
            cmbAlumno.Location = new Point(216, 168);
            cmbAlumno.Name = "cmbAlumno";
            cmbAlumno.Size = new Size(151, 33);
            cmbAlumno.TabIndex = 31;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(70, 231);
            label4.Name = "label4";
            label4.Size = new Size(89, 28);
            label4.TabIndex = 30;
            label4.Text = "Curso:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(70, 169);
            label3.Name = "label3";
            label3.Size = new Size(110, 28);
            label3.TabIndex = 29;
            label3.Text = "Alumno:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(284, 48);
            label2.TabIndex = 28;
            label2.Text = "Inscripciones";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(70, 104);
            label1.Name = "label1";
            label1.Size = new Size(180, 28);
            label1.TabIndex = 26;
            label1.Text = "Id Inscripcion:";
            // 
            // txtIdInscripcion
            // 
            txtIdInscripcion.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdInscripcion.Location = new Point(266, 101);
            txtIdInscripcion.Name = "txtIdInscripcion";
            txtIdInscripcion.Size = new Size(125, 35);
            txtIdInscripcion.TabIndex = 36;
            // 
            // dgvInscripciones
            // 
            dgvInscripciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInscripciones.Location = new Point(12, 370);
            dgvInscripciones.Name = "dgvInscripciones";
            dgvInscripciones.RowHeadersWidth = 51;
            dgvInscripciones.Size = new Size(776, 215);
            dgvInscripciones.TabIndex = 37;
            // 
            // FormInscripciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 597);
            Controls.Add(dgvInscripciones);
            Controls.Add(txtIdInscripcion);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnGuardar);
            Controls.Add(cmbCurso);
            Controls.Add(cmbAlumno);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormInscripciones";
            Text = "FormInscripciones";
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
        private Label label1;
        private TextBox txtIdInscripcion;
        private DataGridView dgvInscripciones;
    }
}