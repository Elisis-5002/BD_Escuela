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
            label4 = new Label();
            dgvAsistencia = new DataGridView();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnGuardar = new Button();
            cmbInscripcion = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label5 = new Label();
            cmbEstado = new ComboBox();
            dtpFecha = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvAsistencia).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(142, 219);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(110, 34);
            label4.TabIndex = 60;
            label4.Text = "Fecha:";
            // 
            // dgvAsistencia
            // 
            dgvAsistencia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAsistencia.Location = new Point(16, 426);
            dgvAsistencia.Margin = new Padding(4);
            dgvAsistencia.Name = "dgvAsistencia";
            dgvAsistencia.RowHeadersWidth = 51;
            dgvAsistencia.Size = new Size(1170, 326);
            dgvAsistencia.TabIndex = 59;
            dgvAsistencia.CellClick += dgvAsistencia_CellClick;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(891, 356);
            btnEliminar.Margin = new Padding(4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(170, 49);
            btnEliminar.TabIndex = 57;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnModificar.Location = new Point(524, 356);
            btnModificar.Margin = new Padding(4);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(170, 49);
            btnModificar.TabIndex = 56;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(133, 356);
            btnGuardar.Margin = new Padding(4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(170, 49);
            btnGuardar.TabIndex = 55;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // cmbInscripcion
            // 
            cmbInscripcion.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbInscripcion.FormattingEnabled = true;
            cmbInscripcion.Location = new Point(411, 152);
            cmbInscripcion.Margin = new Padding(4);
            cmbInscripcion.Name = "cmbInscripcion";
            cmbInscripcion.Size = new Size(370, 37);
            cmbInscripcion.TabIndex = 54;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(142, 154);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(173, 34);
            label3.TabIndex = 53;
            label3.Text = "Inscripcion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(41, 29);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(266, 59);
            label2.TabIndex = 52;
            label2.Text = "Asistencia";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(142, 282);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(123, 34);
            label5.TabIndex = 62;
            label5.Text = "Estado:";
            // 
            // cmbEstado
            // 
            cmbEstado.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(411, 281);
            cmbEstado.Margin = new Padding(4);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(370, 37);
            cmbEstado.TabIndex = 63;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(411, 221);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(370, 33);
            dtpFecha.TabIndex = 64;
            // 
            // FormAsistencia
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1203, 768);
            Controls.Add(dtpFecha);
            Controls.Add(cmbEstado);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dgvAsistencia);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnGuardar);
            Controls.Add(cmbInscripcion);
            Controls.Add(label3);
            Controls.Add(label2);
            Margin = new Padding(4);
            Name = "FormAsistencia";
            Text = "FormAsistencia";
            Load += FormAsistencia_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvAsistencia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private DataGridView dgvAsistencia;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnGuardar;
        private ComboBox cmbInscripcion;
        private Label label3;
        private Label label2;
        private Label label5;
        private ComboBox cmbEstado;
        private DateTimePicker dtpFecha;
    }
}