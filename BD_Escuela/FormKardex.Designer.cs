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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dgvKardex = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvKardex).BeginInit();
            SuspendLayout();
            // 
            // dgvKardex
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(245, 249, 254);
            dgvKardex.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvKardex.BackgroundColor = Color.White;
            dgvKardex.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(24, 95, 165);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvKardex.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvKardex.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(12, 68, 124);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(181, 212, 244);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(12, 68, 124);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvKardex.DefaultCellStyle = dataGridViewCellStyle3;
            dgvKardex.Dock = DockStyle.Fill;
            dgvKardex.EnableHeadersVisualStyles = false;
            dgvKardex.GridColor = Color.FromArgb(181, 212, 244);
            dgvKardex.Location = new Point(0, 0);
            dgvKardex.Name = "dgvKardex";
            dgvKardex.RowHeadersVisible = false;
            dgvKardex.RowHeadersWidth = 51;
            dgvKardex.Size = new Size(800, 450);
            dgvKardex.TabIndex = 5;
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