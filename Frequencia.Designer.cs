namespace academia_corpoativo
{
    partial class Frequencia
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
            lblID_Aluno = new Label();
            lblID_Turma = new Label();
            lblData = new Label();
            lblEntrada = new Label();
            lblSaida = new Label();
            txtID_Aluno = new TextBox();
            txtID_Turma = new TextBox();
            mtbData = new MaskedTextBox();
            mtbEntrada = new MaskedTextBox();
            mtbSaida = new MaskedTextBox();
            btnOK = new Button();
            SuspendLayout();
            // 
            // lblID_Aluno
            // 
            lblID_Aluno.AutoSize = true;
            lblID_Aluno.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblID_Aluno.Location = new Point(46, 85);
            lblID_Aluno.Name = "lblID_Aluno";
            lblID_Aluno.Size = new Size(67, 17);
            lblID_Aluno.TabIndex = 0;
            lblID_Aluno.Text = "ID Aluno:";
            // 
            // lblID_Turma
            // 
            lblID_Turma.AutoSize = true;
            lblID_Turma.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblID_Turma.Location = new Point(48, 143);
            lblID_Turma.Name = "lblID_Turma";
            lblID_Turma.Size = new Size(65, 17);
            lblID_Turma.TabIndex = 1;
            lblID_Turma.Text = "ID Turma";
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblData.Location = new Point(47, 191);
            lblData.Name = "lblData";
            lblData.Size = new Size(41, 17);
            lblData.TabIndex = 2;
            lblData.Text = "Data:";
            // 
            // lblEntrada
            // 
            lblEntrada.AutoSize = true;
            lblEntrada.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEntrada.Location = new Point(47, 237);
            lblEntrada.Name = "lblEntrada";
            lblEntrada.Size = new Size(59, 17);
            lblEntrada.TabIndex = 3;
            lblEntrada.Text = "Entrada:";
            // 
            // lblSaida
            // 
            lblSaida.AutoSize = true;
            lblSaida.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSaida.Location = new Point(47, 290);
            lblSaida.Name = "lblSaida";
            lblSaida.Size = new Size(45, 17);
            lblSaida.TabIndex = 4;
            lblSaida.Text = "Saída:";
            // 
            // txtID_Aluno
            // 
            txtID_Aluno.Location = new Point(119, 84);
            txtID_Aluno.Name = "txtID_Aluno";
            txtID_Aluno.Size = new Size(203, 23);
            txtID_Aluno.TabIndex = 5;
            // 
            // txtID_Turma
            // 
            txtID_Turma.Location = new Point(119, 143);
            txtID_Turma.Name = "txtID_Turma";
            txtID_Turma.Size = new Size(195, 23);
            txtID_Turma.TabIndex = 6;
            // 
            // mtbData
            // 
            mtbData.Location = new Point(119, 191);
            mtbData.Mask = "00/00/0000";
            mtbData.Name = "mtbData";
            mtbData.Size = new Size(195, 23);
            mtbData.TabIndex = 7;
            mtbData.TextAlign = HorizontalAlignment.Center;
            mtbData.ValidatingType = typeof(DateTime);
            // 
            // mtbEntrada
            // 
            mtbEntrada.Location = new Point(119, 236);
            mtbEntrada.Mask = "00:00";
            mtbEntrada.Name = "mtbEntrada";
            mtbEntrada.Size = new Size(195, 23);
            mtbEntrada.TabIndex = 8;
            mtbEntrada.TextAlign = HorizontalAlignment.Center;
            mtbEntrada.ValidatingType = typeof(DateTime);
            // 
            // mtbSaida
            // 
            mtbSaida.Location = new Point(119, 284);
            mtbSaida.Mask = "00:00";
            mtbSaida.Name = "mtbSaida";
            mtbSaida.Size = new Size(195, 23);
            mtbSaida.TabIndex = 9;
            mtbSaida.TextAlign = HorizontalAlignment.Center;
            mtbSaida.ValidatingType = typeof(DateTime);
            // 
            // btnOK
            // 
            btnOK.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOK.Location = new Point(184, 348);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 23);
            btnOK.TabIndex = 10;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // Frequencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 477);
            Controls.Add(btnOK);
            Controls.Add(mtbSaida);
            Controls.Add(mtbEntrada);
            Controls.Add(mtbData);
            Controls.Add(txtID_Turma);
            Controls.Add(txtID_Aluno);
            Controls.Add(lblSaida);
            Controls.Add(lblEntrada);
            Controls.Add(lblData);
            Controls.Add(lblID_Turma);
            Controls.Add(lblID_Aluno);
            Name = "Frequencia";
            Text = "Frequencia";
//            Load += Frequencia_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblID_Aluno;
        private Label lblID_Turma;
        private Label lblData;
        private Label lblEntrada;
        private Label lblSaida;
        private TextBox txtID_Aluno;
        private TextBox txtID_Turma;
        private MaskedTextBox mtbData;
        private MaskedTextBox mtbEntrada;
        private MaskedTextBox mtbSaida;
        private Button btnOK;
    }
}