namespace BD_Escuela
{
    partial class FormKardex
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
            dgvKardex = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvKardex).BeginInit();
            SuspendLayout();
            // 
            // dgvKardex
            // 
            dgvKardex.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKardex.Dock = DockStyle.Fill;
            dgvKardex.Location = new Point(0, 0);
            dgvKardex.Name = "dgvKardex";
            dgvKardex.RowHeadersWidth = 62;
            dgvKardex.Size = new Size(800, 450);
            dgvKardex.TabIndex = 0;
            dgvKardex.CellContentClick += dgvKardex_CellContentClick;
            // 
            // FormKardex
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvKardex);
            Name = "FormKardex";
            Text = "FormKardex";
            Load += FormKardex_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKardex).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvKardex;
    }
}