namespace academia_corpoativo
{
    partial class frmRecepcionista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecepcionista));
            btnCalendario = new Button();
            btnCadastro = new Button();
            btnCliente = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnCalendario
            // 
            btnCalendario.BackColor = SystemColors.InactiveCaption;
            btnCalendario.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalendario.Location = new Point(304, 210);
            btnCalendario.Name = "btnCalendario";
            btnCalendario.Size = new Size(196, 146);
            btnCalendario.TabIndex = 0;
            btnCalendario.Text = "Calendário";
            btnCalendario.UseVisualStyleBackColor = false;
            // 
            // btnCadastro
            // 
            btnCadastro.BackColor = SystemColors.InactiveCaption;
            btnCadastro.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastro.Location = new Point(39, 209);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.Size = new Size(196, 148);
            btnCadastro.TabIndex = 1;
            btnCadastro.Text = "Cadastro";
            btnCadastro.UseVisualStyleBackColor = false;
            btnCadastro.Click += btnCadastro_Click;
            // 
            // btnCliente
            // 
            btnCliente.BackColor = SystemColors.InactiveCaption;
            btnCliente.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCliente.Location = new Point(559, 209);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(197, 147);
            btnCliente.TabIndex = 2;
            btnCliente.Text = "Cliente";
            btnCliente.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.BackgroundImage = Properties.Resources.CorpoAtivo;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 148);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(192, 142);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(291, 50);
            label1.Name = "label1";
            label1.Size = new Size(369, 45);
            label1.TabIndex = 2;
            label1.Text = "Painel da Recepcionista";
            // 
            // frmRecepcionista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 439);
            Controls.Add(btnCliente);
            Controls.Add(panel2);
            Controls.Add(btnCadastro);
            Controls.Add(btnCalendario);
            Name = "frmRecepcionista";
            Text = "frmRecepcionista";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnCalendario;
        private Button btnCadastro;
        private Button btnCliente;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}