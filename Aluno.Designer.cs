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
            calendarRegistroFrequencia = new MonthCalendar();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            dgPagamento = new DataGridView();
            lbPagamento = new Label();
            label1 = new Label();
            btnBuscar = new Button();
            btnFrequencia = new Button();
            lbLogout = new LinkLabel();
            dgvMarcarFrequencia = new DataGridView();
            label3 = new Label();
            btnCancelamentoPlano = new Button();
            label4 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            dateTimePicker1 = new DateTimePicker();
            dgvHistoricoRenovacao = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgPagamento).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMarcarFrequencia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvHistoricoRenovacao).BeginInit();
            SuspendLayout();
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.BackColor = SystemColors.ActiveCaptionText;
            lbNome.Font = new Font("Microsoft Uighur", 20.25F);
            lbNome.ForeColor = SystemColors.ButtonHighlight;
            lbNome.Location = new Point(34, 192);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(61, 36);
            lbNome.TabIndex = 2;
            lbNome.Text = "Nome";
            lbNome.Click += lbNome_Click;
            // 
            // lbNumeroMatricula
            // 
            lbNumeroMatricula.AutoSize = true;
            lbNumeroMatricula.BackColor = SystemColors.ActiveCaptionText;
            lbNumeroMatricula.Font = new Font("Microsoft Uighur", 20.25F);
            lbNumeroMatricula.ForeColor = SystemColors.ButtonHighlight;
            lbNumeroMatricula.Location = new Point(34, 234);
            lbNumeroMatricula.Name = "lbNumeroMatricula";
            lbNumeroMatricula.Size = new Size(89, 36);
            lbNumeroMatricula.TabIndex = 3;
            lbNumeroMatricula.Text = "Matrícula";
            lbNumeroMatricula.Click += lbNumeroMatricula_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaptionText;
            pictureBox1.Location = new Point(-1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(288, 1069);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // calendarRegistroFrequencia
            // 
            calendarRegistroFrequencia.Location = new Point(34, 382);
            calendarRegistroFrequencia.Name = "calendarRegistroFrequencia";
            calendarRegistroFrequencia.TabIndex = 7;
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
            label2.Font = new Font("Microsoft Uighur", 20.25F);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(34, 275);
            label2.Name = "label2";
            label2.Size = new Size(117, 36);
            label2.TabIndex = 10;
            label2.Text = "Plano Cliente";
            // 
            // dgPagamento
            // 
            dgPagamento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPagamento.Location = new Point(352, 431);
            dgPagamento.Name = "dgPagamento";
            dgPagamento.Size = new Size(746, 108);
            dgPagamento.TabIndex = 11;
            // 
            // lbPagamento
            // 
            lbPagamento.AutoSize = true;
            lbPagamento.Font = new Font("Microsoft Uighur", 20.25F);
            lbPagamento.Location = new Point(352, 343);
            lbPagamento.Name = "lbPagamento";
            lbPagamento.Size = new Size(99, 36);
            lbPagamento.TabIndex = 12;
            lbPagamento.Text = "Pagamento";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Uighur", 20.25F);
            label1.Location = new Point(352, 119);
            label1.Name = "label1";
            label1.Size = new Size(158, 36);
            label1.TabIndex = 13;
            label1.Text = "Marcar Frequência";
            label1.Click += label1_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(1014, 545);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 14;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnFrequencia
            // 
            btnFrequencia.Location = new Point(934, 119);
            btnFrequencia.Name = "btnFrequencia";
            btnFrequencia.Size = new Size(164, 29);
            btnFrequencia.TabIndex = 15;
            btnFrequencia.Text = "Marcar Frequência";
            btnFrequencia.UseVisualStyleBackColor = true;
            btnFrequencia.Click += btnFrequencia_Click;
            // 
            // lbLogout
            // 
            lbLogout.ActiveLinkColor = Color.Transparent;
            lbLogout.AutoSize = true;
            lbLogout.BackColor = Color.Black;
            lbLogout.Font = new Font("Microsoft Uighur", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbLogout.ForeColor = Color.White;
            lbLogout.LinkColor = Color.White;
            lbLogout.Location = new Point(27, 949);
            lbLogout.Name = "lbLogout";
            lbLogout.Size = new Size(68, 36);
            lbLogout.TabIndex = 16;
            lbLogout.TabStop = true;
            lbLogout.Text = "Logout";
            lbLogout.LinkClicked += lbLogout_LinkClicked;
            // 
            // dgvMarcarFrequencia
            // 
            dgvMarcarFrequencia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMarcarFrequencia.Location = new Point(352, 169);
            dgvMarcarFrequencia.Name = "dgvMarcarFrequencia";
            dgvMarcarFrequencia.Size = new Size(746, 81);
            dgvMarcarFrequencia.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Uighur", 20.25F);
            label3.Location = new Point(352, 898);
            label3.Name = "label3";
            label3.Size = new Size(170, 36);
            label3.TabIndex = 19;
            label3.Text = "Cancelamento Plano";
            // 
            // btnCancelamentoPlano
            // 
            btnCancelamentoPlano.Font = new Font("Microsoft Himalaya", 17F);
            btnCancelamentoPlano.Location = new Point(352, 949);
            btnCancelamentoPlano.Name = "btnCancelamentoPlano";
            btnCancelamentoPlano.Size = new Size(746, 39);
            btnCancelamentoPlano.TabIndex = 20;
            btnCancelamentoPlano.Text = "Cancelar Plano";
            btnCancelamentoPlano.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Uighur", 20.25F);
            label4.Location = new Point(352, 590);
            label4.Name = "label4";
            label4.Size = new Size(170, 36);
            label4.TabIndex = 21;
            label4.Text = "Historico Renovação";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(352, 382);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 24;
            // 
            // dgvHistoricoRenovacao
            // 
            dgvHistoricoRenovacao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistoricoRenovacao.Location = new Point(352, 629);
            dgvHistoricoRenovacao.Name = "dgvHistoricoRenovacao";
            dgvHistoricoRenovacao.Size = new Size(746, 249);
            dgvHistoricoRenovacao.TabIndex = 25;
            // 
            // Aluno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1110, 1001);
            Controls.Add(dgvHistoricoRenovacao);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(btnCancelamentoPlano);
            Controls.Add(label3);
            Controls.Add(dgvMarcarFrequencia);
            Controls.Add(lbLogout);
            Controls.Add(btnFrequencia);
            Controls.Add(btnBuscar);
            Controls.Add(label1);
            Controls.Add(lbPagamento);
            Controls.Add(dgPagamento);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(calendarRegistroFrequencia);
            Controls.Add(lbNumeroMatricula);
            Controls.Add(lbNome);
            Controls.Add(pictureBox1);
            Name = "Aluno";
            Text = "Aluno";
            Load += Aluno_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgPagamento).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMarcarFrequencia).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvHistoricoRenovacao).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbNome;
        private Label lbNumeroMatricula;
        private PictureBox pictureBox1;
        private MonthCalendar calendarRegistroFrequencia;
        private PictureBox pictureBox2;
        private Label label2;
        private DataGridView dgPagamento;
        private Label lbPagamento;
        private Label label1;
        private Button btnBuscar;
        private Button btnFrequencia;
        private LinkLabel lbLogout;
        private DataGridView dgvMarcarFrequencia;
        private Label label3;
        private Button btnCancelamentoPlano;
        private Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DateTimePicker dateTimePicker1;
        private DataGridView dgvHistoricoRenovacao;
    }
}