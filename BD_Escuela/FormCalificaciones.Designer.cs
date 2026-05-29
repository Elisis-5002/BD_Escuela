namespace BD_Escuela
{
    partial class FormCalificaciones
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
            dgvCalificaciones = new DataGridView();
            txtIdCalificacion = new TextBox();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnGuardar = new Button();
            cmbInscripcion = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            txtNota = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvCalificaciones).BeginInit();
            SuspendLayout();
            // 
            // dgvCalificaciones
            // 
            dgvCalificaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCalificaciones.Location = new Point(50, 362);
            dgvCalificaciones.Name = "dgvCalificaciones";
            dgvCalificaciones.RowHeadersWidth = 51;
            dgvCalificaciones.Size = new Size(776, 215);
            dgvCalificaciones.TabIndex = 48;
            // 
            // txtIdCalificacion
            // 
            txtIdCalificacion.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdCalificacion.Location = new Point(293, 103);
            txtIdCalificacion.Name = "txtIdCalificacion";
            txtIdCalificacion.Size = new Size(125, 35);
            txtIdCalificacion.TabIndex = 47;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(642, 317);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(124, 39);
            btnEliminar.TabIndex = 46;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnModificar.Location = new Point(375, 317);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(124, 39);
            btnModificar.TabIndex = 45;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(91, 317);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(124, 39);
            btnGuardar.TabIndex = 44;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // cmbInscripcion
            // 
            cmbInscripcion.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbInscripcion.FormattingEnabled = true;
            cmbInscripcion.Location = new Point(293, 170);
            cmbInscripcion.Name = "cmbInscripcion";
            cmbInscripcion.Size = new Size(151, 33);
            cmbInscripcion.TabIndex = 42;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(97, 171);
            label3.Name = "label3";
            label3.Size = new Size(138, 28);
            label3.TabIndex = 40;
            label3.Text = "Inscripcion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(294, 48);
            label2.TabIndex = 39;
            label2.Text = "Calificaciones";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(97, 106);
            label1.Name = "label1";
            label1.Size = new Size(183, 28);
            label1.TabIndex = 38;
            label1.Text = "Id Calificacion:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(97, 233);
            label4.Name = "label4";
            label4.Size = new Size(76, 28);
            label4.TabIndex = 49;
            label4.Text = "Nota:";
            // 
            // txtNota
            // 
            txtNota.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNota.Location = new Point(293, 230);
            txtNota.Name = "txtNota";
            txtNota.Size = new Size(125, 35);
            txtNota.TabIndex = 50;
            // 
            // FormCalificaciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 599);
            Controls.Add(txtNota);
            Controls.Add(label4);
            Controls.Add(dgvCalificaciones);
            Controls.Add(txtIdCalificacion);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnGuardar);
            Controls.Add(cmbInscripcion);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormCalificaciones";
            Text = "FormCalificaciones";
            ((System.ComponentModel.ISupportInitialize)dgvCalificaciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCalificaciones;
        private TextBox txtIdCalificacion;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnGuardar;
        private ComboBox cmbInscripcion;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private TextBox txtNota;
    }
}