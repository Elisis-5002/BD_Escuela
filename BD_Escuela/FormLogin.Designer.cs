namespace BD_Escuela
{
    partial class FormLogin
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
            label1 = new Label();
            label2 = new Label();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            label3 = new Label();
            btnIniciarSesion = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 13.8F);
            label1.Location = new Point(173, 198);
            label1.Name = "label1";
            label1.Size = new Size(110, 28);
            label1.TabIndex = 0;
            label1.Text = "Usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 13.8F);
            label2.Location = new Point(128, 287);
            label2.Name = "label2";
            label2.Size = new Size(155, 28);
            label2.TabIndex = 1;
            label2.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(289, 202);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(274, 35);
            txtUsuario.TabIndex = 2;
            // 
            // txtContraseña
            // 
            txtContraseña.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContraseña.Location = new Point(289, 284);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(274, 35);
            txtContraseña.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(190, 51);
            label3.Name = "label3";
            label3.Size = new Size(347, 57);
            label3.TabIndex = 4;
            label3.Text = "Iniciar Sesion";
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIniciarSesion.Location = new Point(243, 420);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(211, 39);
            btnIniciarSesion.TabIndex = 5;
            btnIniciarSesion.Text = "Iniciar Sesion";
            btnIniciarSesion.UseVisualStyleBackColor = true;
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(721, 585);
            Controls.Add(btnIniciarSesion);
            Controls.Add(label3);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormLogin";
            Text = "FormLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private Label label3;
        private Button btnIniciarSesion;
    }
}