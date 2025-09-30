namespace academia_corpoativo
{
    partial class EscolhaCadastro
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
            btoAluno = new Button();
            btoProfesor = new Button();
            btoRecepcionista = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(80, 64);
            label1.Name = "label1";
            label1.Size = new Size(383, 30);
            label1.TabIndex = 0;
            label1.Text = "QUAL SERA O TIPO DE CADASTRO ?";
            // 
            // btoAluno
            // 
            btoAluno.Location = new Point(64, 141);
            btoAluno.Name = "btoAluno";
            btoAluno.Size = new Size(108, 35);
            btoAluno.TabIndex = 1;
            btoAluno.Text = "Aluno";
            btoAluno.UseVisualStyleBackColor = true;
            btoAluno.Click += btoAluno_Click;
            // 
            // btoProfesor
            // 
            btoProfesor.Location = new Point(218, 141);
            btoProfesor.Name = "btoProfesor";
            btoProfesor.Size = new Size(108, 35);
            btoProfesor.TabIndex = 2;
            btoProfesor.Text = "Professor";
            btoProfesor.UseVisualStyleBackColor = true;
            btoProfesor.Click += btoProfesor_Click;
            // 
            // btoRecepcionista
            // 
            btoRecepcionista.Location = new Point(355, 141);
            btoRecepcionista.Name = "btoRecepcionista";
            btoRecepcionista.Size = new Size(108, 35);
            btoRecepcionista.TabIndex = 3;
            btoRecepcionista.Text = "Recepcionista";
            btoRecepcionista.UseVisualStyleBackColor = true;
            btoRecepcionista.Click += btoRecepcionista_Click;
            // 
            // EscolhaCAdastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 221);
            Controls.Add(btoRecepcionista);
            Controls.Add(btoProfesor);
            Controls.Add(btoAluno);
            Controls.Add(label1);
            Name = "EscolhaCAdastro";
            Text = "EscolhaCAdastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btoAluno;
        private Button btoProfesor;
        private Button btoRecepcionista;
    }
}