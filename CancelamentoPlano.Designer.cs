namespace academia_corpoativo
{
    partial class CancelamentoPlano
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CancelamentoPlano));
            pictureBox2 = new PictureBox();
            btnCancelamento = new Button();
            txtEmail = new TextBox();
            txtConfirmaçãoEmail = new TextBox();
            txtSenha = new TextBox();
            txtConfirmarSenha = new TextBox();
            lv = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Black;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(416, 37);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(183, 152);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // btnCancelamento
            // 
            btnCancelamento.BackColor = Color.Black;
            btnCancelamento.Font = new Font("Microsoft Himalaya", 15F);
            btnCancelamento.ForeColor = Color.White;
            btnCancelamento.Location = new Point(466, 559);
            btnCancelamento.Margin = new Padding(3, 2, 3, 2);
            btnCancelamento.Name = "btnCancelamento";
            btnCancelamento.Size = new Size(76, 31);
            btnCancelamento.TabIndex = 2;
            btnCancelamento.Text = "Confirmar";
            btnCancelamento.UseVisualStyleBackColor = false;
            btnCancelamento.Click += btnCancelamento_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(312, 262);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(396, 23);
            txtEmail.TabIndex = 3;
            // 
            // txtConfirmaçãoEmail
            // 
            txtConfirmaçãoEmail.Location = new Point(312, 346);
            txtConfirmaçãoEmail.Margin = new Padding(3, 2, 3, 2);
            txtConfirmaçãoEmail.Name = "txtConfirmaçãoEmail";
            txtConfirmaçãoEmail.Size = new Size(396, 23);
            txtConfirmaçãoEmail.TabIndex = 4;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(312, 429);
            txtSenha.Margin = new Padding(3, 2, 3, 2);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(396, 23);
            txtSenha.TabIndex = 5;
            // 
            // txtConfirmarSenha
            // 
            txtConfirmarSenha.Location = new Point(312, 512);
            txtConfirmarSenha.Margin = new Padding(3, 2, 3, 2);
            txtConfirmarSenha.Name = "txtConfirmarSenha";
            txtConfirmarSenha.Size = new Size(396, 23);
            txtConfirmarSenha.TabIndex = 6;
            // 
            // lv
            // 
            lv.AutoSize = true;
            lv.BackColor = Color.Transparent;
            lv.Font = new Font("Microsoft Himalaya", 18F);
            lv.ForeColor = Color.White;
            lv.Location = new Point(312, 236);
            lv.Name = "lv";
            lv.Size = new Size(172, 24);
            lv.TabIndex = 7;
            lv.Text = "Insira o e-mail cadastrado";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Himalaya", 18F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(311, 320);
            label1.Name = "label1";
            label1.Size = new Size(198, 24);
            label1.TabIndex = 8;
            label1.Text = "Confirma o e-mail cadastrado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Himalaya", 18F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(312, 403);
            label2.Name = "label2";
            label2.Size = new Size(171, 24);
            label2.TabIndex = 9;
            label2.Text = "Insira a senha de cadastro";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Himalaya", 18F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(312, 486);
            label3.Name = "label3";
            label3.Size = new Size(197, 24);
            label3.TabIndex = 10;
            label3.Text = "Confirma a senha de cadastro";
            // 
            // CancelamentoPlano
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1057, 628);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lv);
            Controls.Add(txtConfirmarSenha);
            Controls.Add(txtSenha);
            Controls.Add(txtConfirmaçãoEmail);
            Controls.Add(txtEmail);
            Controls.Add(btnCancelamento);
            Controls.Add(pictureBox2);
            ForeColor = Color.BlanchedAlmond;
            Margin = new Padding(3, 2, 3, 2);
            Name = "CancelamentoPlano";
            Text = "CancelamentoPlano1";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox2;
        private Button btnCancelamento;
        private TextBox txtEmail;
        private TextBox txtConfirmaçãoEmail;
        private TextBox txtSenha;
        private TextBox txtConfirmarSenha;
        private Label lv;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}