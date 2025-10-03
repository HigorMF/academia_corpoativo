namespace academia_corpoativo
{
    partial class CadastroAluno
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtNomeCompleto = new TextBox();
            txtEmail = new TextBox();
            txtCPF = new MaskedTextBox();
            txtTelefone = new MaskedTextBox();
            txtSenha = new TextBox();
            btoCadastrar = new Button();
            cboTipoPlano = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(70, 101);
            label1.Name = "label1";
            label1.Size = new Size(124, 19);
            label1.TabIndex = 0;
            label1.Text = "Nome Completo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(110, 165);
            label2.Name = "label2";
            label2.Size = new Size(38, 19);
            label2.TabIndex = 1;
            label2.Text = "CPF:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(110, 221);
            label3.Name = "label3";
            label3.Size = new Size(49, 19);
            label3.TabIndex = 2;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(110, 288);
            label4.Name = "label4";
            label4.Size = new Size(70, 19);
            label4.TabIndex = 3;
            label4.Text = "Telefone:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(472, 101);
            label5.Name = "label5";
            label5.Size = new Size(53, 19);
            label5.TabIndex = 4;
            label5.Text = "Senha:";
            // 
            // txtNomeCompleto
            // 
            txtNomeCompleto.Location = new Point(210, 98);
            txtNomeCompleto.Name = "txtNomeCompleto";
            txtNomeCompleto.Size = new Size(139, 25);
            txtNomeCompleto.TabIndex = 6;
            txtNomeCompleto.TextChanged += txtNomeCompleto_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(210, 215);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 25);
            txtEmail.TabIndex = 7;
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(210, 162);
            txtCPF.Mask = "000,000,000-00";
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(100, 25);
            txtCPF.TabIndex = 8;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(210, 285);
            txtTelefone.Mask = "(99) 00000-0000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(100, 25);
            txtTelefone.TabIndex = 9;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(566, 101);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(100, 25);
            txtSenha.TabIndex = 10;
            // 
            // btoCadastrar
            // 
            btoCadastrar.Location = new Point(378, 384);
            btoCadastrar.Name = "btoCadastrar";
            btoCadastrar.Size = new Size(92, 35);
            btoCadastrar.TabIndex = 12;
            btoCadastrar.Text = "Cadastrar";
            btoCadastrar.UseVisualStyleBackColor = true;
            btoCadastrar.Click += btoCadastrar_Click;
            // 
            // CadastroAluno
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 510);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(cboTipoPlano);
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
            Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Name = "CadastroAluno";
            Text = "Cadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNomeCompleto;
        private TextBox txtEmail;
        private MaskedTextBox txtCPF;
        private MaskedTextBox txtTelefone;
        private TextBox txtSenha;
        private Button btoCadastrar;
        private ComboBox cboTipoPlano;
        private Label label6;
        private Label label7;
    }
}