namespace academia_corpoativo
{
    partial class EventoForms
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
            txtData = new TextBox();
            label1 = new Label();
            btoSalvar = new Button();
            label2 = new Label();
            txtSobre = new TextBox();
            label3 = new Label();
            cboProfessores = new ComboBox();
            label4 = new Label();
            txtHorario = new MaskedTextBox();
            SuspendLayout();
            // 
            // txtData
            // 
            txtData.Enabled = false;
            txtData.Font = new Font("Monospac821 BT", 12F);
            txtData.Location = new Point(85, 65);
            txtData.Name = "txtData";
            txtData.Size = new Size(297, 27);
            txtData.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 35);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 3;
            label1.Text = "Data:";
            // 
            // btoSalvar
            // 
            btoSalvar.Location = new Point(412, 211);
            btoSalvar.Name = "btoSalvar";
            btoSalvar.Size = new Size(75, 23);
            btoSalvar.TabIndex = 5;
            btoSalvar.Text = "Salvar";
            btoSalvar.UseVisualStyleBackColor = true;
            btoSalvar.Click += btoSalvar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(173, 194);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 9;
            label2.Text = "Sobre:";
            // 
            // txtSobre
            // 
            txtSobre.Font = new Font("Monospac821 BT", 12F);
            txtSobre.Location = new Point(173, 221);
            txtSobre.Name = "txtSobre";
            txtSobre.Size = new Size(139, 27);
            txtSobre.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(117, 105);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 12;
            label3.Text = "Professor:";
            // 
            // cboProfessores
            // 
            cboProfessores.Font = new Font("Monospac821 BT", 12F);
            cboProfessores.FormattingEnabled = true;
            cboProfessores.Location = new Point(142, 147);
            cboProfessores.Name = "cboProfessores";
            cboProfessores.Size = new Size(121, 27);
            cboProfessores.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(371, 118);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 16;
            label4.Text = "Horario:";
            // 
            // txtHorario
            // 
            txtHorario.Font = new Font("Monospac821 BT", 12F);
            txtHorario.Location = new Point(371, 147);
            txtHorario.Mask = "00:00";
            txtHorario.Name = "txtHorario";
            txtHorario.Size = new Size(100, 27);
            txtHorario.TabIndex = 17;
            txtHorario.ValidatingType = typeof(DateTime);
            // 
            // EventoForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(651, 294);
            Controls.Add(txtHorario);
            Controls.Add(label4);
            Controls.Add(cboProfessores);
            Controls.Add(label3);
            Controls.Add(txtSobre);
            Controls.Add(label2);
            Controls.Add(btoSalvar);
            Controls.Add(label1);
            Controls.Add(txtData);
            Name = "EventoForms";
            Text = "EventoForms";
            Load += EventoForms_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtData;
        private Label label1;
        private Button btoSalvar;
        private Label label2;
        private TextBox txtSobre;
        private Label label3;
        private ComboBox cboProfessores;
        private Label label4;
        private MaskedTextBox txtHorario;
    }
}