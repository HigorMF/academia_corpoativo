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
            lblHorario = new Label();
            lblDataInicio = new Label();
            lblDataFim = new Label();
            textHorario = new TextBox();
            mtbDataInicio = new MaskedTextBox();
            mtbDataFim = new MaskedTextBox();
            btnOK = new Button();
            SuspendLayout();
            // 
            // lblHorario
            // 
            lblHorario.AutoSize = true;
            lblHorario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHorario.Location = new Point(68, 101);
            lblHorario.Name = "lblHorario";
            lblHorario.Size = new Size(72, 21);
            lblHorario.TabIndex = 0;
            lblHorario.Text = "Horário:";
            // 
            // lblDataInicio
            // 
            lblDataInicio.AutoSize = true;
            lblDataInicio.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDataInicio.Location = new Point(68, 174);
            lblDataInicio.Name = "lblDataInicio";
            lblDataInicio.Size = new Size(97, 21);
            lblDataInicio.TabIndex = 1;
            lblDataInicio.Text = "Data Início:";
            // 
            // lblDataFim
            // 
            lblDataFim.AutoSize = true;
            lblDataFim.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDataFim.Location = new Point(68, 266);
            lblDataFim.Name = "lblDataFim";
            lblDataFim.Size = new Size(82, 21);
            lblDataFim.TabIndex = 2;
            lblDataFim.Text = "Data Fim:";
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
            mtbDataInicio.Location = new Point(182, 174);
            mtbDataInicio.Mask = "00/00/0000";
            mtbDataInicio.Name = "mtbDataInicio";
            mtbDataInicio.Size = new Size(119, 23);
            mtbDataInicio.TabIndex = 4;
            mtbDataInicio.TextAlign = HorizontalAlignment.Center;
            mtbDataInicio.ValidatingType = typeof(DateTime);
            // 
            // mtbDataFim
            // 
            mtbDataFim.Location = new Point(182, 264);
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
            btnOK.Location = new Point(197, 325);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(91, 50);
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
            Controls.Add(lblDataFim);
            Controls.Add(lblDataInicio);
            Controls.Add(lblHorario);
            Name = "Cadastro_Turmacs";
            Text = "Cadastro_Turmacs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHorario;
        private Label lblDataInicio;
        private Label lblDataFim;
        private TextBox textHorario;
        private MaskedTextBox mtbDataInicio;
        private MaskedTextBox mtbDataFim;
        private Button btnOK;
    }
}