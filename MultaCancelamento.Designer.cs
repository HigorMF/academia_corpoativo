namespace academia_corpoativo
{
    partial class MultaCancelamento
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
            lblPercentual = new Label();
            lblDescricao = new Label();
            lblDataInicio = new Label();
            lblDataFim = new Label();
            comboBox1 = new ComboBox();
            maskedTextBox1 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            btnOK = new Button();
            comboBox2 = new ComboBox();
            SuspendLayout();
            // 
            // lblPercentual
            // 
            lblPercentual.AutoSize = true;
            lblPercentual.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPercentual.Location = new Point(84, 107);
            lblPercentual.Name = "lblPercentual";
            lblPercentual.Size = new Size(145, 21);
            lblPercentual.TabIndex = 0;
            lblPercentual.Text = "Percentual Multa:";
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescricao.Location = new Point(84, 169);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(132, 21);
            lblDescricao.TabIndex = 1;
            lblDescricao.Text = "Descrição regra:";
            // 
            // lblDataInicio
            // 
            lblDataInicio.AutoSize = true;
            lblDataInicio.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDataInicio.Location = new Point(84, 235);
            lblDataInicio.Name = "lblDataInicio";
            lblDataInicio.Size = new Size(97, 21);
            lblDataInicio.TabIndex = 2;
            lblDataInicio.Text = "Data início:";
            // 
            // lblDataFim
            // 
            lblDataFim.AutoSize = true;
            lblDataFim.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDataFim.Location = new Point(84, 298);
            lblDataFim.Name = "lblDataFim";
            lblDataFim.Size = new Size(80, 21);
            lblDataFim.TabIndex = 3;
            lblDataFim.Text = "Data fim:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(235, 167);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(239, 23);
            comboBox1.TabIndex = 4;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(235, 235);
            maskedTextBox1.Mask = "00/00/0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(129, 23);
            maskedTextBox1.TabIndex = 5;
            maskedTextBox1.TextAlign = HorizontalAlignment.Center;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(235, 300);
            maskedTextBox2.Mask = "00/00/0000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(129, 23);
            maskedTextBox2.TabIndex = 6;
            maskedTextBox2.TextAlign = HorizontalAlignment.Center;
            maskedTextBox2.ValidatingType = typeof(DateTime);
            // 
            // btnOK
            // 
            btnOK.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOK.Location = new Point(257, 352);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(87, 43);
            btnOK.TabIndex = 8;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(235, 107);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(239, 23);
            comboBox2.TabIndex = 9;
            // 
            // MultaCancelamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox2);
            Controls.Add(btnOK);
            Controls.Add(maskedTextBox2);
            Controls.Add(maskedTextBox1);
            Controls.Add(comboBox1);
            Controls.Add(lblDataFim);
            Controls.Add(lblDataInicio);
            Controls.Add(lblDescricao);
            Controls.Add(lblPercentual);
            Name = "MultaCancelamento";
            Text = "x";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPercentual;
        private Label lblDescricao;
        private Label lblDataInicio;
        private Label lblDataFim;
        private ComboBox comboBox1;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox2;
        private Button btnOK;
        private ComboBox comboBox2;
    }
}