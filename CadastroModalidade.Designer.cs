namespace academia_corpoativo
{
    partial class CadastroModalidade
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
            textModalidade = new TextBox();
            textValor = new TextBox();
            btnOK = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(76, 80);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 0;
            label1.Text = "Modalidade:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(108, 151);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 1;
            label2.Text = "Valor:";
            // 
            // textModalidade
            // 
            textModalidade.Location = new Point(156, 77);
            textModalidade.Name = "textModalidade";
            textModalidade.Size = new Size(273, 23);
            textModalidade.TabIndex = 2;
            // 
            // textValor
            // 
            textValor.Location = new Point(179, 148);
            textValor.Name = "textValor";
            textValor.Size = new Size(206, 23);
            textValor.TabIndex = 3;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(231, 227);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(101, 28);
            btnOK.TabIndex = 4;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // CadastroModalidade
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnOK);
            Controls.Add(textValor);
            Controls.Add(textModalidade);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CadastroModalidade";
            Text = "CadastroModalidade";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textModalidade;
        private TextBox textValor;
        private Button btnOK;
    }
}