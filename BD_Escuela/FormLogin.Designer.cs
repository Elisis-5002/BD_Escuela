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
            btnVer = new CheckBox();
            btnSee = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 13.8F);
            label1.Location = new Point(151, 148);
            label1.Name = "label1";
            label1.Size = new Size(92, 23);
            label1.TabIndex = 0;
            label1.Text = "Usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 13.8F);
            label2.Location = new Point(112, 215);
            label2.Name = "label2";
            label2.Size = new Size(126, 23);
            label2.TabIndex = 1;
            label2.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(253, 152);
            txtUsuario.Margin = new Padding(3, 2, 3, 2);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(240, 30);
            txtUsuario.TabIndex = 2;
            // 
            // txtContraseña
            // 
            txtContraseña.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContraseña.Location = new Point(253, 215);
            txtContraseña.Margin = new Padding(3, 2, 3, 2);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '●';
            txtContraseña.Size = new Size(240, 30);
            txtContraseña.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(184, 55);
            label3.Name = "label3";
            label3.Size = new Size(278, 46);
            label3.TabIndex = 4;
            label3.Text = "Iniciar Sesion";
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIniciarSesion.Location = new Point(206, 315);
            btnIniciarSesion.Margin = new Padding(3, 2, 3, 2);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(185, 29);
            btnIniciarSesion.TabIndex = 5;
            btnIniciarSesion.Text = "Iniciar Sesion";
            btnIniciarSesion.UseVisualStyleBackColor = true;
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // btnVer
            // 
            btnVer.AutoSize = true;
            btnVer.Location = new Point(20, 100);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(42, 19);
            btnVer.TabIndex = 6;
            btnVer.Text = "Ver";
            btnVer.UseVisualStyleBackColor = true;
           
            // 
            // btnSee
            // 
            btnSee.AutoSize = true;
            btnSee.Location = new Point(548, 226);
            btnSee.Name = "btnSee";
            btnSee.Size = new Size(42, 19);
            btnSee.TabIndex = 6;
            btnSee.Text = "Ver";
            btnSee.UseVisualStyleBackColor = true;
            btnSee.CheckedChanged += btnSee_CheckedChanged;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(692, 439);
            Controls.Add(btnSee);
            Controls.Add(btnIniciarSesion);
            Controls.Add(label3);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormLogin";
            Text = "FormLogin";
            KeyDown += FormLogin_KeyDown;
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
        private CheckBox btnVer;
        private CheckBox btnSee;
    }
}