namespace academia_corpoativo
{
    partial class CadastroPlanoOuro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroPlanoOuro));
            pictureBox1 = new PictureBox();
            lbNome = new Label();
            lbMatricula = new Label();
            lbPlano = new Label();
            pictureBox2 = new PictureBox();
            dataGridView1 = new DataGridView();
            btnBuscar = new Button();
            lbAgendamento = new Label();
            btnAgendamento = new Button();
            lbFrequencia = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaptionText;
            pictureBox1.Location = new Point(12, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 631);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.BackColor = Color.Black;
            lbNome.Font = new Font("Microsoft Himalaya", 20F);
            lbNome.ForeColor = Color.Transparent;
            lbNome.Location = new Point(34, 210);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(56, 27);
            lbNome.TabIndex = 1;
            lbNome.Text = "Nome";
            lbNome.Click += label1_Click;
            // 
            // lbMatricula
            // 
            lbMatricula.AutoSize = true;
            lbMatricula.BackColor = Color.Black;
            lbMatricula.Font = new Font("Microsoft Himalaya", 20F);
            lbMatricula.ForeColor = Color.Transparent;
            lbMatricula.Location = new Point(34, 248);
            lbMatricula.Name = "lbMatricula";
            lbMatricula.Size = new Size(82, 27);
            lbMatricula.TabIndex = 2;
            lbMatricula.Text = "Matrícula";
            //lbMatricula.Click += this.label2_Click;
            // 
            // lbPlano
            // 
            lbPlano.AutoSize = true;
            lbPlano.BackColor = Color.Black;
            lbPlano.Font = new Font("Microsoft Himalaya", 20F);
            lbPlano.ForeColor = Color.White;
            lbPlano.Location = new Point(34, 292);
            lbPlano.Name = "lbPlano";
            lbPlano.Size = new Size(53, 27);
            lbPlano.TabIndex = 3;
            lbPlano.Text = "Plano";
            //lbPlano.Click += this.label3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Black;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(74, 25);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(159, 155);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(336, 306);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(727, 255);
            dataGridView1.TabIndex = 5;
            // 
            // btnBuscar
            // 
            btnBuscar.ForeColor = Color.Black;
            btnBuscar.Location = new Point(988, 567);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 6;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // lbAgendamento
            // 
            lbAgendamento.AutoSize = true;
            lbAgendamento.BackColor = Color.Black;
            lbAgendamento.Font = new Font("Microsoft Himalaya", 20F);
            lbAgendamento.ForeColor = Color.White;
            lbAgendamento.Location = new Point(34, 370);
            lbAgendamento.Name = "lbAgendamento";
            lbAgendamento.Size = new Size(175, 27);
            lbAgendamento.TabIndex = 7;
            lbAgendamento.Text = "Agendamento de Aula";
            // 
            // btnAgendamento
            // 
            btnAgendamento.BackColor = SystemColors.ActiveCaptionText;
            btnAgendamento.Font = new Font("Microsoft Himalaya", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgendamento.ForeColor = Color.White;
            btnAgendamento.Location = new Point(34, 400);
            btnAgendamento.Name = "btnAgendamento";
            btnAgendamento.Size = new Size(247, 190);
            btnAgendamento.TabIndex = 8;
            btnAgendamento.Text = "Agende Aqui";
            btnAgendamento.UseVisualStyleBackColor = false;
            // 
            // lbFrequencia
            // 
            lbFrequencia.AutoSize = true;
            lbFrequencia.BackColor = Color.Transparent;
            lbFrequencia.Font = new Font("Microsoft Himalaya", 20F);
            lbFrequencia.ForeColor = Color.Black;
            lbFrequencia.Location = new Point(336, 51);
            lbFrequencia.Name = "lbFrequencia";
            lbFrequencia.Size = new Size(92, 27);
            lbFrequencia.TabIndex = 9;
            lbFrequencia.Text = "Frequência";
            // 
            // button1
            // 
            button1.Location = new Point(336, 81);
            button1.Name = "button1";
            button1.Size = new Size(727, 38);
            button1.TabIndex = 10;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // CadastroPlanoOuro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1075, 628);
            Controls.Add(button1);
            Controls.Add(lbFrequencia);
            Controls.Add(btnAgendamento);
            Controls.Add(lbAgendamento);
            Controls.Add(btnBuscar);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox2);
            Controls.Add(lbPlano);
            Controls.Add(lbMatricula);
            Controls.Add(lbNome);
            Controls.Add(pictureBox1);
            ForeColor = Color.White;
            Name = "CadastroPlanoOuro";
            Text = "CadastroPlanoOuro";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lbNome;
        private Label lbMatricula;
        private Label lbPlano;
        private PictureBox pictureBox2;
        private DataGridView dataGridView1;
        private Button btnBuscar;
        private Label lbAgendamento;
        private Button btnAgendamento;
        private Label lbFrequencia;
        private Button button1;
    }
}