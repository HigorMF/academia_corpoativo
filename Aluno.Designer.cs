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
            lbNome = new Label();
            lbNumeroMatricula = new Label();
            SuspendLayout();
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Location = new Point(36, 144);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(40, 15);
            lbNome.TabIndex = 2;
            lbNome.Text = "Nome";
            // 
            // lbNumeroMatricula
            // 
            lbNumeroMatricula.AutoSize = true;
            lbNumeroMatricula.Location = new Point(36, 159);
            lbNumeroMatricula.Name = "lbNumeroMatricula";
            lbNumeroMatricula.Size = new Size(57, 15);
            lbNumeroMatricula.TabIndex = 3;
            lbNumeroMatricula.Text = "Matrícula";
            // 
            // Aluno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 641);
            Controls.Add(lbNumeroMatricula);
            Controls.Add(lbNome);
            Name = "Aluno";
            Text = "Aluno";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbNome;
        private Label lbNumeroMatricula;
    }
}