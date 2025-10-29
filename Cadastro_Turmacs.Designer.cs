namespace academia_corpoativo
{
    partial class Cadastro_Turmacs
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
            label2 = new Label();
            label3 = new Label();
            textHorario = new TextBox();
            mtbDataInicio = new MaskedTextBox();
            mtbDataFim = new MaskedTextBox();
            btnOK = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(68, 99);
            label1.Name = "label1";
            label1.Size = new Size(72, 21);
            label1.TabIndex = 0;
            label1.Text = "Horário:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(68, 176);
            label2.Name = "label2";
            label2.Size = new Size(97, 21);
            label2.TabIndex = 1;
            label2.Text = "Data Início:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(68, 266);
            label3.Name = "label3";
            label3.Size = new Size(82, 21);
            label3.TabIndex = 2;
            label3.Text = "Data Fim:";
            // 
            // textHorario
            // 
            textHorario.Location = new Point(182, 99);
            textHorario.Name = "textHorario";
            textHorario.Size = new Size(135, 23);
            textHorario.TabIndex = 3;
            // 
            // mtbDataInicio
            // 
            mtbDataInicio.Location = new Point(198, 176);
            mtbDataInicio.Mask = "00/00/0000";
            mtbDataInicio.Name = "mtbDataInicio";
            mtbDataInicio.Size = new Size(119, 23);
            mtbDataInicio.TabIndex = 4;
            mtbDataInicio.TextAlign = HorizontalAlignment.Center;
            mtbDataInicio.ValidatingType = typeof(DateTime);
            // 
            // mtbDataFim
            // 
            mtbDataFim.Location = new Point(189, 264);
            mtbDataFim.Mask = "00/00/0000";
            mtbDataFim.Name = "mtbDataFim";
            mtbDataFim.Size = new Size(128, 23);
            mtbDataFim.TabIndex = 5;
            mtbDataFim.TextAlign = HorizontalAlignment.Center;
            mtbDataFim.ValidatingType = typeof(DateTime);
            // 
            // btnOK
            // 
            btnOK.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOK.Location = new Point(150, 342);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(126, 33);
            btnOK.TabIndex = 6;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // Cadastro_Turmacs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(777, 450);
            Controls.Add(btnOK);
            Controls.Add(mtbDataFim);
            Controls.Add(mtbDataInicio);
            Controls.Add(textHorario);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Cadastro_Turmacs";
            Text = "Cadastro_Turmacs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textHorario;
        private MaskedTextBox mtbDataInicio;
        private MaskedTextBox mtbDataFim;
        private Button btnOK;
    }
}