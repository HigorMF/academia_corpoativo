namespace academia_corpoativo
{
    partial class CadastroPlano
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
            label4 = new Label();
            txtTipo = new TextBox();
            txtValor = new TextBox();
            mtbDataInicio = new MaskedTextBox();
            mtbDataFim = new MaskedTextBox();
            btnCadastroPlano = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(241, 78);
            label1.Name = "label1";
            label1.Size = new Size(40, 17);
            label1.TabIndex = 0;
            label1.Text = "Tipo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(236, 139);
            label2.Name = "label2";
            label2.Size = new Size(45, 17);
            label2.TabIndex = 1;
            label2.Text = "Valor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(202, 204);
            label3.Name = "label3";
            label3.Size = new Size(79, 17);
            label3.TabIndex = 2;
            label3.Text = "Data Inicio:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(213, 271);
            label4.Name = "label4";
            label4.Size = new Size(68, 17);
            label4.TabIndex = 3;
            label4.Text = "Data Fim:";
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(309, 72);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(250, 23);
            txtTipo.TabIndex = 4;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(309, 133);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(250, 23);
            txtValor.TabIndex = 5;
            // 
            // mtbDataInicio
            // 
            mtbDataInicio.Location = new Point(309, 204);
            mtbDataInicio.Mask = "00/00/0000";
            mtbDataInicio.Name = "mtbDataInicio";
            mtbDataInicio.Size = new Size(124, 23);
            mtbDataInicio.TabIndex = 7;
            mtbDataInicio.TextAlign = HorizontalAlignment.Center;
            mtbDataInicio.ValidatingType = typeof(DateTime);
            // 
            // mtbDataFim
            // 
            mtbDataFim.Location = new Point(309, 271);
            mtbDataFim.Mask = "00/00/0000";
            mtbDataFim.Name = "mtbDataFim";
            mtbDataFim.Size = new Size(129, 23);
            mtbDataFim.TabIndex = 8;
            mtbDataFim.TextAlign = HorizontalAlignment.Center;
            mtbDataFim.ValidatingType = typeof(DateTime);
            // 
            // btnCadastroPlano
            // 
            btnCadastroPlano.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastroPlano.Location = new Point(309, 334);
            btnCadastroPlano.Name = "btnCadastroPlano";
            btnCadastroPlano.Size = new Size(110, 36);
            btnCadastroPlano.TabIndex = 9;
            btnCadastroPlano.Text = "OK";
            btnCadastroPlano.UseVisualStyleBackColor = true;
            btnCadastroPlano.Click += btnCadastroPlano_Click;
            // 
            // CadastroPlano
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(590, 450);
            Controls.Add(btnCadastroPlano);
            Controls.Add(mtbDataFim);
            Controls.Add(mtbDataInicio);
            Controls.Add(txtValor);
            Controls.Add(txtTipo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CadastroPlano";
            Text = "CadastroPlano";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtTipo;
        private TextBox txtValor;
        private MaskedTextBox mtbDataInicio;
        private MaskedTextBox mtbDataFim;
        private Button btnCadastroPlano;
    }
}