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
            lblDia.Font = new Font("Monospac821 BT", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDia.Location = new Point(53, 0);
            lblDia.Name = "lblDia";
            lblDia.Size = new Size(26, 18);
            lblDia.TabIndex = 1;
            lblDia.Text = "00";
            // 
            // lblInformacao
            // 
            lblInformacao.Location = new Point(13, 45);
            lblInformacao.Name = "lblInformacao";
            lblInformacao.Size = new Size(109, 37);
            lblInformacao.TabIndex = 2;
            lblInformacao.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
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
        private Label lblInformacao;
        private System.Windows.Forms.Timer timer1;
    }
}
