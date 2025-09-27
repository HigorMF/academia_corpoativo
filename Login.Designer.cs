namespace academia_corpoativo
{
    partial class Login
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
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            label2 = new Label();
            btn_login = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 9F);
            label1.Location = new Point(193, 282);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Usuário";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(193, 313);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(361, 23);
            txtUsuario.TabIndex = 1;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(728, 313);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(282, 23);
            txtSenha.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(728, 282);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 2;
            label2.Text = "Senha";
            // 
            // btn_login
            // 
            btn_login.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_login.Location = new Point(488, 547);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(75, 23);
            btn_login.TabIndex = 4;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(488, 130);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(129, 100);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.ImageLocation = "";
            pictureBox2.Location = new Point(678, 304);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(44, 32);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(127, 304);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(44, 32);
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(1118, 663);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btn_login);
            Controls.Add(txtSenha);
            Controls.Add(label2);
            Controls.Add(txtUsuario);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUsuario;
        private TextBox txtSenha;
        private Label label2;
        private Button btn_login;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}