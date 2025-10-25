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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicial));
            sidebar = new FlowLayoutPanel();
            panel1 = new Panel();
            lbMenu = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btHome = new Button();
            panel4 = new Panel();
            btnConheca = new Button();
            panel5 = new Panel();
            btnLogin = new Button();
            panel3 = new Panel();
            btnSobre = new Button();
            sidebarTimer = new System.Windows.Forms.Timer(components);
            sidebar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.Black;
            sidebar.Controls.Add(panel1);
            sidebar.Controls.Add(panel2);
            sidebar.Controls.Add(panel4);
            sidebar.Controls.Add(panel5);
            sidebar.Controls.Add(panel3);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.MaximumSize = new Size(193, 666);
            sidebar.MinimumSize = new Size(68, 666);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(190, 666);
            sidebar.TabIndex = 0;
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
            // lbMenu
            // 
            lbMenu.AutoSize = true;
            lbMenu.BackColor = Color.Transparent;
            lbMenu.ForeColor = Color.White;
            lbMenu.Location = new Point(62, 25);
            lbMenu.Name = "lbMenu";
            lbMenu.Size = new Size(38, 15);
            lbMenu.TabIndex = 1;
            lbMenu.Text = "Menu";
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(9, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(47, 45);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btHome);
            panel2.Location = new Point(3, 109);
            panel2.Name = "panel2";
            panel2.Size = new Size(177, 52);
            panel2.TabIndex = 2;
            // 
            // btHome
            // 
            btHome.Font = new Font("Bodoni Bk BT", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btHome.Image = (Image)resources.GetObject("btHome.Image");
            btHome.Location = new Point(-127, -11);
            btHome.Name = "btHome";
            btHome.Size = new Size(316, 78);
            btHome.TabIndex = 1;
            btHome.Text = "                              Inicio";
            btHome.UseVisualStyleBackColor = true;
            btHome.Click += btHome_Click;
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
            btnConheca.Image = (Image)resources.GetObject("btnConheca.Image");
            btnConheca.Location = new Point(-127, -11);
            btnConheca.Name = "btnConheca";
            btnConheca.Size = new Size(316, 78);
            btnConheca.TabIndex = 1;
            btnConheca.Text = "                                      Funcionário";
            btnConheca.UseVisualStyleBackColor = true;
            btnConheca.Click += btnConheca_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnLogin);
            panel5.Location = new Point(3, 225);
            panel5.Name = "panel5";
            panel5.Size = new Size(177, 52);
            panel5.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Bodoni Bk BT", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.Image = (Image)resources.GetObject("btnLogin.Image");
            btnLogin.Location = new Point(-125, -11);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(316, 78);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "                              Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnSobre);
            panel3.Location = new Point(3, 283);
            panel3.Name = "panel3";
            panel3.Size = new Size(177, 52);
            panel3.TabIndex = 3;
            // 
            // btnSobre
            // 
            btnSobre.Font = new Font("Bodoni Bk BT", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSobre.Image = (Image)resources.GetObject("btnSobre.Image");
            btnSobre.Location = new Point(-126, -11);
            btnSobre.Name = "btnSobre";
            btnSobre.Size = new Size(316, 78);
            btnSobre.TabIndex = 1;
            btnSobre.Text = "                              Sobre";
            btnSobre.UseVisualStyleBackColor = true;
            // 
            // sidebarTimer
            // 
            sidebarTimer.Interval = 10;
            sidebarTimer.Tick += sidebartimer_Tick;
            // 
            // TelaInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 550);
            Controls.Add(sidebar);
            Name = "TelaInicial";
            Text = "TelaInicial";
            Load += TelaInicial_Load;
            sidebar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel sidebar;
        private Panel panel1;
        private Button btHome;
        private Panel panel2;
        private Label lbMenu;
        private PictureBox pictureBox1;
        private Panel panel4;
        private Button btnConheca;
        private Panel panel5;
        private Button btnLogin;
        private Panel panel3;
        private Button btnSobre;
        private System.Windows.Forms.Timer sidebarTimer;
    }
}