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
            btnEliminar = new Button();
            btnModificar = new Button();
            btnGuardar = new Button();
            cmbInscripcion = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            txtNota = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvCalificaciones).BeginInit();
            SuspendLayout();
            // 
            // dgvCalificaciones
            // 
            dgvCalificaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCalificaciones.Location = new Point(52, 405);
            dgvCalificaciones.Margin = new Padding(4);
            dgvCalificaciones.Name = "dgvCalificaciones";
            dgvCalificaciones.RowHeadersWidth = 51;
            dgvCalificaciones.Size = new Size(1067, 314);
            dgvCalificaciones.TabIndex = 48;
            dgvCalificaciones.CellClick += dgvCalificaciones_CellClick;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(866, 331);
            btnEliminar.Margin = new Padding(4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(170, 49);
            btnEliminar.TabIndex = 46;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnModificar.Location = new Point(499, 331);
            btnModificar.Margin = new Padding(4);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(170, 49);
            btnModificar.TabIndex = 45;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(109, 331);
            btnGuardar.Margin = new Padding(4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(170, 49);
            btnGuardar.TabIndex = 44;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // cmbInscripcion
            // 
            cmbInscripcion.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbInscripcion.FormattingEnabled = true;
            cmbInscripcion.Location = new Point(386, 148);
            cmbInscripcion.Margin = new Padding(4);
            cmbInscripcion.Name = "cmbInscripcion";
            cmbInscripcion.Size = new Size(327, 37);
            cmbInscripcion.TabIndex = 42;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(117, 149);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(173, 34);
            label3.TabIndex = 40;
            label3.Text = "Inscripcion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(16, 11);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(349, 59);
            label2.TabIndex = 39;
            label2.Text = "Calificaciones";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(117, 226);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(94, 34);
            label4.TabIndex = 49;
            label4.Text = "Nota:";
            // 
            // txtNota
            // 
            txtNota.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNota.Location = new Point(386, 222);
            txtNota.Margin = new Padding(4);
            txtNota.Name = "txtNota";
            txtNota.Size = new Size(327, 41);
            txtNota.TabIndex = 50;
            // 
            // FormCalificaciones
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1174, 749);
            Controls.Add(txtNota);
            Controls.Add(label4);
            Controls.Add(dgvCalificaciones);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnGuardar);
            Controls.Add(cmbInscripcion);
            Controls.Add(label3);
            Controls.Add(label2);
            Margin = new Padding(4);
            Name = "FormCalificaciones";
            Text = "FormCalificaciones";
            Load += FormCalificaciones_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCalificaciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCalificaciones;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnGuardar;
        private ComboBox cmbInscripcion;
        private Label label3;
        private Label label2;
        private Label label4;
        private TextBox txtNota;
    }
}