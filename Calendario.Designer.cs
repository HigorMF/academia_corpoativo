namespace academia_corpoativo
{
    partial class Calendario
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
            CalendarioGeral = new FlowLayoutPanel();
            btProximo = new Button();
            btnAnterior = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            panel96 = new Panel();
            lbData = new Label();
            SuspendLayout();
            // 
            // CalendarioGeral
            // 
            CalendarioGeral.Location = new Point(42, 108);
            CalendarioGeral.Name = "CalendarioGeral";
            CalendarioGeral.Size = new Size(990, 567);
            CalendarioGeral.TabIndex = 0;
            CalendarioGeral.Paint += CalendarioGeral_Paint;
            // 
            // btProximo
            // 
            btProximo.Location = new Point(960, 681);
            btProximo.Name = "btProximo";
            btProximo.Size = new Size(75, 23);
            btProximo.TabIndex = 1;
            btProximo.Text = "Próximo";
            btProximo.UseVisualStyleBackColor = true;
            btProximo.Click += btProximo_Click;
            // 
            // btnAnterior
            // 
            btnAnterior.Location = new Point(883, 681);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(75, 23);
            btnAnterior.TabIndex = 2;
            btnAnterior.Text = "Anterior";
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sylfaen", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(75, 66);
            label1.Name = "label1";
            label1.Size = new Size(79, 25);
            label1.TabIndex = 0;
            label1.Text = "Segunda";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sylfaen", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(225, 66);
            label2.Name = "label2";
            label2.Size = new Size(56, 25);
            label2.TabIndex = 3;
            label2.Text = "Terça";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sylfaen", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(498, 66);
            label3.Name = "label3";
            label3.Size = new Size(68, 25);
            label3.TabIndex = 5;
            label3.Text = "Quinta";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sylfaen", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(367, 66);
            label4.Name = "label4";
            label4.Size = new Size(66, 25);
            label4.TabIndex = 4;
            label4.Text = "Quarta";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sylfaen", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(901, 66);
            label6.Name = "label6";
            label6.Size = new Size(88, 25);
            label6.TabIndex = 8;
            label6.Text = "Domingo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sylfaen", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(780, 66);
            label7.Name = "label7";
            label7.Size = new Size(67, 25);
            label7.TabIndex = 7;
            label7.Text = "Sábado";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Sylfaen", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(654, 66);
            label8.Name = "label8";
            label8.Size = new Size(53, 25);
            label8.TabIndex = 6;
            label8.Text = "Sexta";
            // 
            // panel96
            // 
            panel96.Location = new Point(156, 0);
            panel96.Name = "panel96";
            panel96.Size = new Size(150, 90);
            panel96.TabIndex = 6;
            // 
            // lbData
            // 
            lbData.Font = new Font("Sylfaen", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbData.Location = new Point(308, 19);
            lbData.Name = "lbData";
            lbData.Size = new Size(452, 30);
            lbData.TabIndex = 10;
            lbData.Text = "MES ANO";
            lbData.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Calendario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1099, 716);
            Controls.Add(lbData);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAnterior);
            Controls.Add(btProximo);
            Controls.Add(CalendarioGeral);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Calendario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calendario";
            Load += Calendario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel CalendarioGeral;
        private Button btProximo;
        private Button btnAnterior;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label8;
        private Panel panel96;
        private Label lbData;
    }
}