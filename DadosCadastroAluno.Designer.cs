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
            dataCalendarioPesquisa = new DataGridView();
            label1 = new Label();
            txtIdPlano = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataCalendarioPesquisa).BeginInit();
            SuspendLayout();
            // 
            // btn_BuscarCadastroAluno
            // 
            btn_BuscarCadastroAluno.Location = new Point(871, 47);
            btn_BuscarCadastroAluno.Name = "btn_BuscarCadastroAluno";
            btn_BuscarCadastroAluno.Size = new Size(75, 23);
            btn_BuscarCadastroAluno.TabIndex = 1;
            btn_BuscarCadastroAluno.Text = "Buscar";
            btn_BuscarCadastroAluno.UseVisualStyleBackColor = true;
            btn_BuscarCadastroAluno.Click += btn_BuscarCadastroAluno_Click;
            // 
            // dataCalendarioPesquisa
            // 
            dataCalendarioPesquisa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataCalendarioPesquisa.Location = new Point(12, 96);
            dataCalendarioPesquisa.Name = "dataCalendarioPesquisa";
            dataCalendarioPesquisa.Size = new Size(984, 535);
            dataCalendarioPesquisa.TabIndex = 6;
            dataCalendarioPesquisa.CellContentClick += dataCalendarioPesquisa_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 30);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 7;
            label1.Text = "ID Plano";
            // 
            // txtIdPlano
            // 
            txtIdPlano.Location = new Point(30, 47);
            txtIdPlano.Name = "txtIdPlano";
            txtIdPlano.Size = new Size(501, 23);
            txtIdPlano.TabIndex = 8;
            // 
            // DadosCadastroAluno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 682);
            Controls.Add(txtIdPlano);
            Controls.Add(label1);
            Controls.Add(dataCalendarioPesquisa);
            Controls.Add(btn_BuscarCadastroAluno);
            Name = "DadosCadastroAluno";
            Text = "DadosCadastroAluno";
            Load += DadosCadastroAluno_Load;
            ((System.ComponentModel.ISupportInitialize)dataCalendarioPesquisa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button btn_BuscarCadastroAluno;
        private DataGridView dataCalendarioPesquisa;
        private Label label1;
        private TextBox txtIdPlano;
    }
}