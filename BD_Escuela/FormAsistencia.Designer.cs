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
            btnGuardar = new Button();
            label2 = new Label();
            dtpFecha = new DateTimePicker();
            checkFaltas = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgvAsistencia).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(90, 131);
            label4.Name = "label4";
            label4.Size = new Size(74, 23);
            label4.TabIndex = 60;
            label4.Text = "Fecha:";
            // 
            // dgvAsistencia
            // 
            dgvAsistencia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAsistencia.Location = new Point(10, 256);
            dgvAsistencia.Margin = new Padding(3, 2, 3, 2);
            dgvAsistencia.Name = "dgvAsistencia";
            dgvAsistencia.ReadOnly = true;
            dgvAsistencia.RowHeadersWidth = 51;
            dgvAsistencia.Size = new Size(745, 196);
            dgvAsistencia.TabIndex = 59;
            dgvAsistencia.CellClick += dgvAsistencia_CellClick;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(525, 214);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(166, 29);
            btnEliminar.TabIndex = 57;
            btnEliminar.Text = "Eliminar dia";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(283, 214);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(174, 29);
            btnGuardar.TabIndex = 55;
            btnGuardar.Text = "Dia Escolar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 17);
            label2.Name = "label2";
            label2.Size = new Size(179, 38);
            label2.TabIndex = 52;
            label2.Text = "Asistencia";
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(262, 133);
            dtpFecha.Margin = new Padding(2);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(237, 23);
            dtpFecha.TabIndex = 64;
            dtpFecha.ValueChanged += dtpFecha_ValueChanged;
            // 
            // checkFaltas
            // 
            checkFaltas.AutoSize = true;
            checkFaltas.Location = new Point(54, 226);
            checkFaltas.Name = "checkFaltas";
            checkFaltas.Size = new Size(73, 19);
            checkFaltas.TabIndex = 65;
            checkFaltas.Text = "Sin faltas";
            checkFaltas.UseVisualStyleBackColor = true;
            checkFaltas.CheckedChanged += checkFaltas_CheckedChanged;
            // 
            // FormAsistencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(766, 461);
            Controls.Add(checkFaltas);
            Controls.Add(dtpFecha);
            Controls.Add(label4);
            Controls.Add(dgvAsistencia);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(label2);
            Margin = new Padding(3, 2, 3, 2);
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
        private DateTimePicker dtpFecha;
        private CheckBox checkFaltas;
    }
}