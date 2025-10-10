namespace academia_corpoativo
{
    partial class DadosCadastroAluno
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
            btn_BuscarCadastroAluno = new Button();
            txtBuscaAluno = new TextBox();
            lb_CPF = new Label();
            lb_ID = new Label();
            txtBuscarIDAluno = new TextBox();
            dataGridView1 = new DataGridView();
            lbEmail = new Label();
            txtBuscarEmailAluno = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btn_BuscarCadastroAluno
            // 
            btn_BuscarCadastroAluno.Location = new Point(867, 156);
            btn_BuscarCadastroAluno.Name = "btn_BuscarCadastroAluno";
            btn_BuscarCadastroAluno.Size = new Size(75, 23);
            btn_BuscarCadastroAluno.TabIndex = 1;
            btn_BuscarCadastroAluno.Text = "Buscar";
            btn_BuscarCadastroAluno.UseVisualStyleBackColor = true;
            // 
            // txtBuscaAluno
            // 
            txtBuscaAluno.Location = new Point(47, 60);
            txtBuscaAluno.Name = "txtBuscaAluno";
            txtBuscaAluno.Size = new Size(306, 23);
            txtBuscaAluno.TabIndex = 2;
            // 
            // lb_CPF
            // 
            lb_CPF.AutoSize = true;
            lb_CPF.Location = new Point(47, 42);
            lb_CPF.Name = "lb_CPF";
            lb_CPF.Size = new Size(63, 15);
            lb_CPF.TabIndex = 3;
            lb_CPF.Text = "CPF Aluno";
            // 
            // lb_ID
            // 
            lb_ID.AutoSize = true;
            lb_ID.Location = new Point(475, 42);
            lb_ID.Name = "lb_ID";
            lb_ID.Size = new Size(53, 15);
            lb_ID.TabIndex = 5;
            lb_ID.Text = "ID Aluno";
            // 
            // txtBuscarIDAluno
            // 
            txtBuscarIDAluno.Location = new Point(475, 60);
            txtBuscarIDAluno.Name = "txtBuscarIDAluno";
            txtBuscarIDAluno.Size = new Size(356, 23);
            txtBuscarIDAluno.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 199);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(984, 446);
            dataGridView1.TabIndex = 6;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(47, 109);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(71, 15);
            lbEmail.TabIndex = 8;
            lbEmail.Text = "Email Aluno";
            // 
            // txtBuscarEmailAluno
            // 
            txtBuscarEmailAluno.Location = new Point(47, 127);
            txtBuscarEmailAluno.Name = "txtBuscarEmailAluno";
            txtBuscarEmailAluno.Size = new Size(306, 23);
            txtBuscarEmailAluno.TabIndex = 7;
            // 
            // DadosCadastroAluno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 682);
            Controls.Add(lbEmail);
            Controls.Add(txtBuscarEmailAluno);
            Controls.Add(dataGridView1);
            Controls.Add(lb_ID);
            Controls.Add(txtBuscarIDAluno);
            Controls.Add(lb_CPF);
            Controls.Add(txtBuscaAluno);
            Controls.Add(btn_BuscarCadastroAluno);
            Name = "DadosCadastroAluno";
            Text = "DadosCadastroAluno";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button btn_BuscarCadastroAluno;
        private TextBox txtBuscaAluno;
        private Label lb_CPF;
        private Label lb_ID;
        private TextBox txtBuscarIDAluno;
        private DataGridView dataGridView1;
        private Label lbEmail;
        private TextBox txtBuscarEmailAluno;
    }
}