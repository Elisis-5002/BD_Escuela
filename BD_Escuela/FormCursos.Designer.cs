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
            txtIdCurso = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            cmbProfesor = new ComboBox();
            cmbMateria = new ComboBox();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnGuardar = new Button();
            dgvCursos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvCursos).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(156, 48);
            label2.TabIndex = 18;
            label2.Text = "Cursos";
            // 
            // txtIdCurso
            // 
            txtIdCurso.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdCurso.Location = new Point(216, 108);
            txtIdCurso.Name = "txtIdCurso";
            txtIdCurso.Size = new Size(125, 35);
            txtIdCurso.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(70, 104);
            label1.Name = "label1";
            label1.Size = new Size(121, 28);
            label1.TabIndex = 16;
            label1.Text = "Id Curso:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(70, 169);
            label3.Name = "label3";
            label3.Size = new Size(118, 28);
            label3.TabIndex = 19;
            label3.Text = "Profesor:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(70, 231);
            label4.Name = "label4";
            label4.Size = new Size(108, 28);
            label4.TabIndex = 20;
            label4.Text = "Materia:";
            // 
            // cmbProfesor
            // 
            cmbProfesor.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbProfesor.FormattingEnabled = true;
            cmbProfesor.Location = new Point(216, 168);
            cmbProfesor.Name = "cmbProfesor";
            cmbProfesor.Size = new Size(151, 33);
            cmbProfesor.TabIndex = 21;
            // 
            // cmbMateria
            // 
            cmbMateria.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbMateria.FormattingEnabled = true;
            cmbMateria.Location = new Point(216, 230);
            cmbMateria.Name = "cmbMateria";
            cmbMateria.Size = new Size(151, 33);
            cmbMateria.TabIndex = 22;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(615, 315);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(124, 39);
            btnEliminar.TabIndex = 25;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnModificar.Location = new Point(348, 315);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(124, 39);
            btnModificar.TabIndex = 24;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(64, 315);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(124, 39);
            btnGuardar.TabIndex = 23;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // dgvCursos
            // 
            dgvCursos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCursos.Location = new Point(12, 369);
            dgvCursos.Name = "dgvCursos";
            dgvCursos.RowHeadersWidth = 51;
            dgvCursos.Size = new Size(776, 215);
            dgvCursos.TabIndex = 26;
            // 
            // FormCursos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 596);
            Controls.Add(dgvCursos);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnGuardar);
            Controls.Add(cmbMateria);
            Controls.Add(cmbProfesor);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtIdCurso);
            Controls.Add(label1);
            Name = "FormCursos";
            Text = "FormCursos";
            ((System.ComponentModel.ISupportInitialize)dgvCursos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox txtIdCurso;
        private Label label1;
        private Label label3;
        private Label label4;
        private ComboBox cmbProfesor;
        private ComboBox cmbMateria;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnGuardar;
        private DataGridView dgvCursos;
    }
}