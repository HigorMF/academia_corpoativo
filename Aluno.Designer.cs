namespace academia_corpoativo
{
    partial class Aluno
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
            lbNome = new Label();
            lbNumeroMatricula = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(539, 166);
            label1.Name = "label1";
            label1.Size = new Size(162, 15);
            label1.TabIndex = 1;
            label1.Text = "Agendamento com professor";
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Location = new Point(36, 144);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(40, 15);
            lbNome.TabIndex = 2;
            lbNome.Text = "Nome";
            // 
            // lbNumeroMatricula
            // 
            lbNumeroMatricula.AutoSize = true;
            lbNumeroMatricula.Location = new Point(36, 159);
            lbNumeroMatricula.Name = "lbNumeroMatricula";
            lbNumeroMatricula.Size = new Size(57, 15);
            lbNumeroMatricula.TabIndex = 3;
            lbNumeroMatricula.Text = "Matrícula";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 289);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 4;
            label2.Text = "Plano";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 414);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 5;
            label3.Text = "Pagamento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(539, 414);
            label4.Name = "label4";
            label4.Size = new Size(113, 15);
            label4.TabIndex = 6;
            label4.Text = "Sequência de Treino";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(539, 445);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(82, 19);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Aluno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 641);
            Controls.Add(checkBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbNumeroMatricula);
            Controls.Add(lbNome);
            Controls.Add(label1);
            Name = "Aluno";
            Text = "Aluno";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label lbNome;
        private Label lbNumeroMatricula;
        private Label label2;
        private Label label3;
        private Label label4;
        private CheckBox checkBox1;
    }
}