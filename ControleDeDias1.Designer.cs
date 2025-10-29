namespace academia_corpoativo
{
    partial class ControleDeDias1
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblDia = new Label();
            lblInformacao = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lblDia
            // 
            lblDia.AutoSize = true;
            lblDia.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lblDia.Location = new Point(53, 0);
            lblDia.Name = "lblDia";
            lblDia.Size = new Size(29, 20);
            lblDia.TabIndex = 1;
            lblDia.Text = "00";
            // 
            // lblInformacao
            // 
            lblInformacao.AutoSize = true;
            lblInformacao.BackColor = Color.White;
            lblInformacao.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lblInformacao.Location = new Point(16, 31);
            lblInformacao.Name = "lblInformacao";
            lblInformacao.Size = new Size(0, 10);
            lblInformacao.TabIndex = 2;
            lblInformacao.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ControleDeDias1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(lblInformacao);
            Controls.Add(lblDia);
            Name = "ControleDeDias1";
            Size = new Size(134, 90);
            Load += ControleDeDias1_Load;
            Click += ControleDeDias1_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDia;
        private System.Windows.Forms.Timer timer1;
        public Label lblInformacao;
    }
}
