namespace academia_corpoativo
{
    partial class TelaInicial
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
            components = new System.ComponentModel.Container();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            btHome = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            btnLogin = new Button();
            panel4 = new Panel();
            btnConheca = new Button();
            panel5 = new Panel();
            button3 = new Button();
            lbMenu = new Label();
            pictureBox1 = new PictureBox();
            sidebartimer = new System.Windows.Forms.Timer(components);
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Black;
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel4);
            flowLayoutPanel1.Controls.Add(panel5);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(193, 666);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(lbMenu);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(190, 100);
            panel1.TabIndex = 0;
            // 
            // btHome
            // 
            btHome.Font = new Font("Bodoni Bk BT", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btHome.Image = Properties.Resources.imagem;
            btHome.Location = new Point(-114, -11);
            btHome.Name = "btHome";
            btHome.Size = new Size(316, 78);
            btHome.TabIndex = 1;
            btHome.Text = "                              Inicio";
            btHome.UseVisualStyleBackColor = true;
            btHome.Click += btHome_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btHome);
            panel2.Location = new Point(3, 109);
            panel2.Name = "panel2";
            panel2.Size = new Size(177, 52);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnLogin);
            panel3.Location = new Point(3, 283);
            panel3.Name = "panel3";
            panel3.Size = new Size(177, 52);
            panel3.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Bodoni Bk BT", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.Image = Properties.Resources.imagem;
            btnLogin.Location = new Point(-114, -11);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(316, 78);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "                              Login";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnConheca);
            panel4.Location = new Point(3, 167);
            panel4.Name = "panel4";
            panel4.Size = new Size(177, 52);
            panel4.TabIndex = 4;
            // 
            // btnConheca
            // 
            btnConheca.Font = new Font("Bodoni Bk BT", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConheca.Image = Properties.Resources.imagem;
            btnConheca.Location = new Point(-114, -11);
            btnConheca.Name = "btnConheca";
            btnConheca.Size = new Size(316, 78);
            btnConheca.TabIndex = 1;
            btnConheca.Text = "                                      Funcionário";
            btnConheca.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.Controls.Add(button3);
            panel5.Location = new Point(3, 225);
            panel5.Name = "panel5";
            panel5.Size = new Size(177, 52);
            panel5.TabIndex = 4;
            // 
            // button3
            // 
            button3.Font = new Font("Bodoni Bk BT", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Image = Properties.Resources.imagem;
            button3.Location = new Point(-114, -11);
            button3.Name = "button3";
            button3.Size = new Size(316, 78);
            button3.TabIndex = 1;
            button3.Text = "                              Sobre";
            button3.UseVisualStyleBackColor = true;
            // 
            // lbMenu
            // 
            lbMenu.AutoSize = true;
            lbMenu.BackColor = Color.Transparent;
            lbMenu.ForeColor = Color.White;
            lbMenu.Location = new Point(83, 44);
            lbMenu.Name = "lbMenu";
            lbMenu.Size = new Size(38, 15);
            lbMenu.TabIndex = 1;
            lbMenu.Text = "Menu";
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.imagem;
            pictureBox1.Location = new Point(9, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(47, 45);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // sidebartimer
            // 
            sidebartimer.Interval = 10;
            // 
            // TelaInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 666);
            Controls.Add(flowLayoutPanel1);
            Name = "TelaInicial";
            Text = "TelaInicial";
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Button btHome;
        private Panel panel2;
        private Label lbMenu;
        private PictureBox pictureBox1;
        private Panel panel4;
        private Button btnConheca;
        private Panel panel5;
        private Button button3;
        private Panel panel3;
        private Button btnLogin;
        private System.Windows.Forms.Timer sidebartimer;
    }
}