namespace BD_Escuela
{
    partial class FormErrores
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
            label3 = new Label();
            dgvErrores = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvErrores).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 23);
            label3.Name = "label3";
            label3.Size = new Size(202, 46);
            label3.TabIndex = 5;
            label3.Text = "ERRORES";
            // 
            // dgvErrores
            // 
            dgvErrores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvErrores.Location = new Point(54, 94);
            dgvErrores.Name = "dgvErrores";
            dgvErrores.Size = new Size(654, 268);
            dgvErrores.TabIndex = 6;
            // 
            // FormErrores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvErrores);
            Controls.Add(label3);
            Name = "FormErrores";
            Text = "FormErrores";
            ((System.ComponentModel.ISupportInitialize)dgvErrores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private DataGridView dgvErrores;
    }
}