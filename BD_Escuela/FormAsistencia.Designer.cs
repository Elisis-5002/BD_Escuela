namespace BD_Escuela
{
    partial class FormAsistencia
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
            txtFecha = new TextBox();
            label4 = new Label();
            dgvAsistencia = new DataGridView();
            txtIdAsistencia = new TextBox();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnGuardar = new Button();
            cmbInscripcion = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            cmbEstado = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvAsistencia).BeginInit();
            SuspendLayout();
            // 
            // txtFecha
            // 
            txtFecha.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFecha.Location = new Point(311, 218);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(125, 35);
            txtFecha.TabIndex = 61;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(115, 221);
            label4.Name = "label4";
            label4.Size = new Size(89, 28);
            label4.TabIndex = 60;
            label4.Text = "Fecha:";
            // 
            // dgvAsistencia
            // 
            dgvAsistencia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAsistencia.Location = new Point(69, 387);
            dgvAsistencia.Name = "dgvAsistencia";
            dgvAsistencia.RowHeadersWidth = 51;
            dgvAsistencia.Size = new Size(776, 215);
            dgvAsistencia.TabIndex = 59;
            // 
            // txtIdAsistencia
            // 
            txtIdAsistencia.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdAsistencia.Location = new Point(311, 117);
            txtIdAsistencia.Name = "txtIdAsistencia";
            txtIdAsistencia.Size = new Size(125, 35);
            txtIdAsistencia.TabIndex = 58;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(660, 331);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(124, 39);
            btnEliminar.TabIndex = 57;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnModificar.Location = new Point(393, 331);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(124, 39);
            btnModificar.TabIndex = 56;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(109, 331);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(124, 39);
            btnGuardar.TabIndex = 55;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // cmbInscripcion
            // 
            cmbInscripcion.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbInscripcion.FormattingEnabled = true;
            cmbInscripcion.Location = new Point(311, 168);
            cmbInscripcion.Name = "cmbInscripcion";
            cmbInscripcion.Size = new Size(151, 33);
            cmbInscripcion.TabIndex = 54;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(115, 169);
            label3.Name = "label3";
            label3.Size = new Size(138, 28);
            label3.TabIndex = 53;
            label3.Text = "Inscripcion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 23);
            label2.Name = "label2";
            label2.Size = new Size(223, 48);
            label2.TabIndex = 52;
            label2.Text = "Asistencia";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(115, 120);
            label1.Name = "label1";
            label1.Size = new Size(170, 28);
            label1.TabIndex = 51;
            label1.Text = "Id Asistencia:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(115, 272);
            label5.Name = "label5";
            label5.Size = new Size(100, 28);
            label5.TabIndex = 62;
            label5.Text = "Estado:";
            // 
            // cmbEstado
            // 
            cmbEstado.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(311, 271);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(151, 33);
            cmbEstado.TabIndex = 63;
            // 
            // FormAsistencia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 614);
            Controls.Add(cmbEstado);
            Controls.Add(label5);
            Controls.Add(txtFecha);
            Controls.Add(label4);
            Controls.Add(dgvAsistencia);
            Controls.Add(txtIdAsistencia);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnGuardar);
            Controls.Add(cmbInscripcion);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormAsistencia";
            Text = "FormAsistencia";
            ((System.ComponentModel.ISupportInitialize)dgvAsistencia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFecha;
        private Label label4;
        private DataGridView dgvAsistencia;
        private TextBox txtIdAsistencia;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnGuardar;
        private ComboBox cmbInscripcion;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private ComboBox cmbEstado;
    }
}