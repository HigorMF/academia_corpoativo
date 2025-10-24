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
            pictureBox1 = new PictureBox();
            montAgendamentoCliente = new MonthCalendar();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            dgPagamento = new DataGridView();
            lbPagamento = new Label();
            label1 = new Label();
            btnBuscar = new Button();
            btnFrequencia = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgPagamento).BeginInit();
            SuspendLayout();
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.BackColor = SystemColors.ActiveCaptionText;
            lbNome.Font = new Font("Microsoft Himalaya", 21.75F);
            lbNome.ForeColor = SystemColors.ButtonHighlight;
            lbNome.Location = new Point(34, 192);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(61, 29);
            lbNome.TabIndex = 2;
            lbNome.Text = "Nome";
            lbNome.Click += lbNome_Click;
            // 
            // lbNumeroMatricula
            // 
            lbNumeroMatricula.AutoSize = true;
            lbNumeroMatricula.BackColor = SystemColors.ActiveCaptionText;
            lbNumeroMatricula.Font = new Font("Microsoft Himalaya", 21.75F);
            lbNumeroMatricula.ForeColor = SystemColors.ButtonHighlight;
            lbNumeroMatricula.Location = new Point(34, 234);
            lbNumeroMatricula.Name = "lbNumeroMatricula";
            lbNumeroMatricula.Size = new Size(88, 29);
            lbNumeroMatricula.TabIndex = 3;
            lbNumeroMatricula.Text = "Matrícula";
            lbNumeroMatricula.Click += lbNumeroMatricula_Click;
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
            montAgendamentoCliente.Location = new Point(34, 382);
            montAgendamentoCliente.Name = "montAgendamentoCliente";
            montAgendamentoCliente.TabIndex = 7;
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
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Font = new Font("Microsoft Himalaya", 21.75F);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(34, 275);
            label2.Name = "label2";
            label2.Size = new Size(119, 29);
            label2.TabIndex = 10;
            label2.Text = "Plano Cliente";
            // 
            // dgPagamento
            // 
            dgPagamento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPagamento.Location = new Point(352, 275);
            dgPagamento.Name = "dgPagamento";
            dgPagamento.Size = new Size(527, 292);
            dgPagamento.TabIndex = 11;
            // 
            // lbPagamento
            // 
            lbPagamento.AutoSize = true;
            lbPagamento.Font = new Font("Segoe UI", 15F);
            lbPagamento.Location = new Point(352, 244);
            lbPagamento.Name = "lbPagamento";
            lbPagamento.Size = new Size(111, 28);
            lbPagamento.TabIndex = 12;
            lbPagamento.Text = "Pagamento";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(352, 29);
            label1.Name = "label1";
            label1.Size = new Size(173, 28);
            label1.TabIndex = 13;
            label1.Text = "Marcar Frequência";
            label1.Click += label1_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(804, 573);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 14;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnFrequencia
            // 
            btnFrequencia.Location = new Point(352, 74);
            btnFrequencia.Name = "btnFrequencia";
            btnFrequencia.Size = new Size(545, 23);
            btnFrequencia.TabIndex = 15;
            btnFrequencia.Text = "Marcar Frequência";
            btnFrequencia.UseVisualStyleBackColor = true;
            btnFrequencia.Click += btnFrequencia_Click;
            // 
            // Aluno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 641);
            Controls.Add(btnFrequencia);
            Controls.Add(btnBuscar);
            Controls.Add(label1);
            Controls.Add(lbPagamento);
            Controls.Add(dgPagamento);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(montAgendamentoCliente);
            Controls.Add(lbNumeroMatricula);
            Controls.Add(lbNome);
            Controls.Add(pictureBox1);
            Name = "Aluno";
            Text = "Aluno";
            Load += Aluno_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgPagamento).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbNome;
        private Label lbNumeroMatricula;
        private PictureBox pictureBox1;
        private MonthCalendar montAgendamentoCliente;
        private PictureBox pictureBox2;
        private Label label2;
        private DataGridView dgPagamento;
        private Label lbPagamento;
        private Label label1;
        private Button btnBuscar;
        private Button btnFrequencia;
    }
}