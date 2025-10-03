namespace academia_corpoativo
{
    partial class RecuperarSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecuperarSenha));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            txtNovaSenha = new TextBox();
            txtConfirmacaoNovaSenha = new TextBox();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtRepetirNovoEmail = new TextBox();
            txtNovoEmail = new TextBox();
            label6 = new Label();
            txtEmailAtual = new TextBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Location = new Point(-3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(381, 655);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SuperFrench", 20F);
            label1.Location = new Point(492, 64);
            label1.Name = "label1";
            label1.Size = new Size(198, 28);
            label1.TabIndex = 1;
            label1.Text = "Redefinir a senha";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Black;
            pictureBox2.Location = new Point(517, 95);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(152, 10);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // txtNovaSenha
            // 
            txtNovaSenha.Location = new Point(451, 409);
            txtNovaSenha.Name = "txtNovaSenha";
            txtNovaSenha.Size = new Size(311, 23);
            txtNovaSenha.TabIndex = 3;
            // 
            // txtConfirmacaoNovaSenha
            // 
            txtConfirmacaoNovaSenha.Location = new Point(451, 478);
            txtConfirmacaoNovaSenha.Name = "txtConfirmacaoNovaSenha";
            txtConfirmacaoNovaSenha.Size = new Size(311, 23);
            txtConfirmacaoNovaSenha.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(574, 548);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Redefinir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(451, 373);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 6;
            label2.Text = "Nova Senha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(451, 450);
            label3.Name = "label3";
            label3.Size = new Size(116, 15);
            label3.TabIndex = 7;
            label3.Text = "Repitir a Nova Senha";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(451, 303);
            label4.Name = "label4";
            label4.Size = new Size(118, 15);
            label4.TabIndex = 11;
            label4.Text = "Repetir o Novo Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(451, 226);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 10;
            label5.Text = "Novo Email";
            // 
            // txtRepetirNovoEmail
            // 
            txtRepetirNovoEmail.Location = new Point(451, 331);
            txtRepetirNovoEmail.Name = "txtRepetirNovoEmail";
            txtRepetirNovoEmail.Size = new Size(311, 23);
            txtRepetirNovoEmail.TabIndex = 9;
            // 
            // txtNovoEmail
            // 
            txtNovoEmail.Location = new Point(451, 262);
            txtNovoEmail.Name = "txtNovoEmail";
            txtNovoEmail.Size = new Size(311, 23);
            txtNovoEmail.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(451, 137);
            label6.Name = "label6";
            label6.Size = new Size(127, 15);
            label6.TabIndex = 13;
            label6.Text = "Informe Email Anterior";
            // 
            // txtEmailAtual
            // 
            txtEmailAtual.Location = new Point(451, 179);
            txtEmailAtual.Name = "txtEmailAtual";
            txtEmailAtual.Size = new Size(311, 23);
            txtEmailAtual.TabIndex = 12;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Black;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(58, 184);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(253, 248);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // RecuperarSenha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 663);
            Controls.Add(pictureBox3);
            Controls.Add(label6);
            Controls.Add(txtEmailAtual);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(txtRepetirNovoEmail);
            Controls.Add(txtNovoEmail);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(txtConfirmacaoNovaSenha);
            Controls.Add(txtNovaSenha);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "RecuperarSenha";
            Text = "RecuperarSenha";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private TextBox txtNovaSenha;
        private TextBox txtConfirmacaoNovaSenha;
        private Button button1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtRepetirNovoEmail;
        private TextBox txtNovoEmail;
        private Label label6;
        private TextBox txtEmailAtual;
        private PictureBox pictureBox3;
    }
}