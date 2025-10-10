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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aluno));
            lbNome = new Label();
            lbNumeroMatricula = new Label();
            lbPlano = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            montAgendamentoCliente = new MonthCalendar();
            lstPlanoCliente = new ListBox();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.BackColor = SystemColors.ActiveCaptionText;
            lbNome.Font = new Font("Microsoft Himalaya", 21.75F);
            lbNome.ForeColor = SystemColors.ButtonHighlight;
            lbNome.Location = new Point(34, 183);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(61, 29);
            lbNome.TabIndex = 2;
            lbNome.Text = "Nome";
            // 
            // lbNumeroMatricula
            // 
            lbNumeroMatricula.AutoSize = true;
            lbNumeroMatricula.BackColor = SystemColors.ActiveCaptionText;
            lbNumeroMatricula.Font = new Font("Microsoft Himalaya", 21.75F);
            lbNumeroMatricula.ForeColor = SystemColors.ButtonHighlight;
            lbNumeroMatricula.Location = new Point(34, 227);
            lbNumeroMatricula.Name = "lbNumeroMatricula";
            lbNumeroMatricula.Size = new Size(88, 29);
            lbNumeroMatricula.TabIndex = 3;
            lbNumeroMatricula.Text = "Matrícula";
            // 
            // lbPlano
            // 
            lbPlano.AutoSize = true;
            lbPlano.Font = new Font("Microsoft Himalaya", 21.75F);
            lbPlano.Location = new Point(356, 263);
            lbPlano.Name = "lbPlano";
            lbPlano.Size = new Size(121, 29);
            lbPlano.TabIndex = 4;
            lbPlano.Text = "Treinamentos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Microsoft Himalaya", 21.75F);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(53, 359);
            label1.Name = "label1";
            label1.Size = new Size(185, 29);
            label1.TabIndex = 5;
            label1.Text = "Agendamento Cliente";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaptionText;
            pictureBox1.Location = new Point(-3, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(332, 649);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // montAgendamentoCliente
            // 
            montAgendamentoCliente.Location = new Point(34, 409);
            montAgendamentoCliente.Name = "montAgendamentoCliente";
            montAgendamentoCliente.TabIndex = 7;
            // 
            // lstPlanoCliente
            // 
            lstPlanoCliente.FormattingEnabled = true;
            lstPlanoCliente.ItemHeight = 15;
            lstPlanoCliente.Location = new Point(356, 295);
            lstPlanoCliente.Name = "lstPlanoCliente";
            lstPlanoCliente.Size = new Size(525, 289);
            lstPlanoCliente.TabIndex = 8;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Black;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(78, 29);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(127, 115);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Himalaya", 21.75F);
            label2.Location = new Point(356, 115);
            label2.Name = "label2";
            label2.Size = new Size(119, 29);
            label2.TabIndex = 10;
            label2.Text = "Plano Cliente";
            // 
            // Aluno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 641);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(lstPlanoCliente);
            Controls.Add(montAgendamentoCliente);
            Controls.Add(label1);
            Controls.Add(lbPlano);
            Controls.Add(lbNumeroMatricula);
            Controls.Add(lbNome);
            Controls.Add(pictureBox1);
            Name = "Aluno";
            Text = "Aluno";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbNome;
        private Label lbNumeroMatricula;
        private Label lbPlano;
        private Label label1;
        private PictureBox pictureBox1;
        private MonthCalendar montAgendamentoCliente;
        private ListBox lstPlanoCliente;
        private PictureBox pictureBox2;
        private Label label2;
    }
}