namespace academia_corpoativo
{
    partial class CadastroProfessor
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
            btoCadastrar = new Button();
            txtSenha = new TextBox();
            txtTelefone = new MaskedTextBox();
            txtCPF = new MaskedTextBox();
            txtEmail = new TextBox();
            txtNomeCompleto = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btoCadastrar
            // 
            btoCadastrar.Location = new Point(410, 351);
            btoCadastrar.Name = "btoCadastrar";
            btoCadastrar.Size = new Size(92, 35);
            btoCadastrar.TabIndex = 23;
            btoCadastrar.Text = "Cadastrar";
            btoCadastrar.UseVisualStyleBackColor = true;
            btoCadastrar.Click += btoCadastrar_Click;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(598, 122);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(100, 23);
            txtSenha.TabIndex = 22;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(242, 252);
            txtTelefone.Mask = "(99) 00000-0000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(100, 23);
            txtTelefone.TabIndex = 21;
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(242, 129);
            txtCPF.Mask = "000,000,000-00";
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(100, 23);
            txtCPF.TabIndex = 20;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(242, 182);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 19;
            // 
            // txtNomeCompleto
            // 
            txtNomeCompleto.Location = new Point(242, 65);
            txtNomeCompleto.Name = "txtNomeCompleto";
            txtNomeCompleto.Size = new Size(139, 23);
            txtNomeCompleto.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(504, 122);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 17;
            label5.Text = "Senha:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(142, 255);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 16;
            label4.Text = "Telefone:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(142, 188);
            label3.Name = "label3";
            label3.Size = new Size(49, 19);
            label3.TabIndex = 15;
            label3.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(142, 132);
            label2.Name = "label2";
            label2.Size = new Size(38, 19);
            label2.TabIndex = 14;
            label2.Text = "CPF:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(102, 68);
            label1.Name = "label1";
            label1.Size = new Size(124, 19);
            label1.TabIndex = 13;
            label1.Text = "Nome Completo:";
            // 
            // CadastroProfessor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btoCadastrar);
            Controls.Add(txtSenha);
            Controls.Add(txtTelefone);
            Controls.Add(txtCPF);
            Controls.Add(txtEmail);
            Controls.Add(txtNomeCompleto);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CadastroProfessor";
            Text = "CadastroProfessor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btoCadastrar;
        private TextBox txtSenha;
        private MaskedTextBox txtTelefone;
        private MaskedTextBox txtCPF;
        private TextBox txtEmail;
        private TextBox txtNomeCompleto;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}