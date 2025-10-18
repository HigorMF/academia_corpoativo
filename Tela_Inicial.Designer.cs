namespace academia_corpoativo
{
    partial class Tela_Inicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_Inicial));
            sidebar = new FlowLayoutPanel();
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            btnBotao = new PictureBox();
            HomeContainer = new Panel();
            button4 = new Button();
            panel3 = new Panel();
            panel4 = new Panel();
            bntLogin = new Button();
            panel5 = new Panel();
            panel6 = new Panel();
            btnCadastro = new Button();
            panel7 = new Panel();
            panel8 = new Panel();
            btnSobre = new Button();
            sidebarTime = new System.Windows.Forms.Timer(components);
            sidebar.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnBotao).BeginInit();
            HomeContainer.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.Black;
            sidebar.Controls.Add(panel1);
            sidebar.Controls.Add(HomeContainer);
            sidebar.Controls.Add(panel3);
            sidebar.Controls.Add(panel5);
            sidebar.Controls.Add(panel7);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.MaximumSize = new Size(223, 570);
            sidebar.MinimumSize = new Size(68, 570);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(223, 570);
            sidebar.TabIndex = 0;
            sidebar.Paint += flowLayoutPanel1_Paint_1;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(220, 159);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnBotao);
            panel2.Location = new Point(-3, -3);
            panel2.Name = "panel2";
            panel2.Size = new Size(223, 165);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Schadow BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(66, 30);
            label1.Name = "label1";
            label1.Size = new Size(48, 19);
            label1.TabIndex = 4;
            label1.Text = "Menu";
            label1.Click += label1_Click;
            // 
            // btnBotao
            // 
            btnBotao.Cursor = Cursors.Hand;
            btnBotao.Image = Properties.Resources.imagem;
            btnBotao.Location = new Point(12, 30);
            btnBotao.Name = "btnBotao";
            btnBotao.Size = new Size(48, 50);
            btnBotao.SizeMode = PictureBoxSizeMode.CenterImage;
            btnBotao.TabIndex = 0;
            btnBotao.TabStop = false;
            btnBotao.Click += btnBotao_Click;
            // 
            // HomeContainer
            // 
            HomeContainer.BackColor = Color.Black;
            HomeContainer.Controls.Add(button4);
            HomeContainer.Location = new Point(3, 168);
            HomeContainer.Name = "HomeContainer";
            HomeContainer.Size = new Size(220, 69);
            HomeContainer.TabIndex = 7;
            // 
            // button4
            // 
            button4.BackColor = Color.Black;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Schadow BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Image = Properties.Resources.imagem;
            button4.ImageAlign = ContentAlignment.TopLeft;
            button4.Location = new Point(-26, -6);
            button4.Name = "button4";
            button4.Padding = new Padding(30, 0, 0, 0);
            button4.Size = new Size(255, 97);
            button4.TabIndex = 3;
            button4.Text = "              Inicio";
            button4.TextAlign = ContentAlignment.TopLeft;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaptionText;
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(bntLogin);
            panel3.Location = new Point(3, 243);
            panel3.Name = "panel3";
            panel3.Size = new Size(220, 56);
            panel3.TabIndex = 7;
            // 
            // panel4
            // 
            panel4.Location = new Point(0, 106);
            panel4.Name = "panel4";
            panel4.Size = new Size(220, 56);
            panel4.TabIndex = 1;
            // 
            // bntLogin
            // 
            bntLogin.FlatStyle = FlatStyle.Flat;
            bntLogin.Font = new Font("Schadow BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bntLogin.ForeColor = Color.White;
            bntLogin.Image = Properties.Resources.imagem;
            bntLogin.ImageAlign = ContentAlignment.TopLeft;
            bntLogin.Location = new Point(-26, 0);
            bntLogin.Name = "bntLogin";
            bntLogin.Padding = new Padding(30, 0, 0, 0);
            bntLogin.Size = new Size(255, 69);
            bntLogin.TabIndex = 3;
            bntLogin.Text = "              Login";
            bntLogin.TextAlign = ContentAlignment.MiddleLeft;
            bntLogin.UseVisualStyleBackColor = true;
            bntLogin.Click += bntLogin_Click;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ActiveCaptionText;
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(btnCadastro);
            panel5.Location = new Point(3, 305);
            panel5.Name = "panel5";
            panel5.Size = new Size(220, 56);
            panel5.TabIndex = 8;
            // 
            // panel6
            // 
            panel6.Location = new Point(0, 106);
            panel6.Name = "panel6";
            panel6.Size = new Size(220, 56);
            panel6.TabIndex = 1;
            // 
            // btnCadastro
            // 
            btnCadastro.FlatStyle = FlatStyle.Flat;
            btnCadastro.Font = new Font("Schadow BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadastro.ForeColor = Color.White;
            btnCadastro.Image = Properties.Resources.imagem;
            btnCadastro.ImageAlign = ContentAlignment.TopLeft;
            btnCadastro.Location = new Point(-26, 3);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.Padding = new Padding(30, 0, 0, 0);
            btnCadastro.Size = new Size(255, 69);
            btnCadastro.TabIndex = 3;
            btnCadastro.Text = "              Modalidades";
            btnCadastro.TextAlign = ContentAlignment.MiddleLeft;
            btnCadastro.UseVisualStyleBackColor = true;
            btnCadastro.Click += btnCadastro_Click;
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.ActiveCaptionText;
            panel7.Controls.Add(panel8);
            panel7.Controls.Add(btnSobre);
            panel7.Location = new Point(3, 367);
            panel7.Name = "panel7";
            panel7.Size = new Size(220, 56);
            panel7.TabIndex = 9;
            // 
            // panel8
            // 
            panel8.Location = new Point(0, 106);
            panel8.Name = "panel8";
            panel8.Size = new Size(220, 56);
            panel8.TabIndex = 1;
            // 
            // btnSobre
            // 
            btnSobre.FlatStyle = FlatStyle.Flat;
            btnSobre.Font = new Font("Schadow BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSobre.ForeColor = Color.White;
            btnSobre.Image = Properties.Resources.imagem;
            btnSobre.ImageAlign = ContentAlignment.TopLeft;
            btnSobre.Location = new Point(-26, 3);
            btnSobre.Name = "btnSobre";
            btnSobre.Padding = new Padding(30, 0, 0, 0);
            btnSobre.Size = new Size(255, 69);
            btnSobre.TabIndex = 3;
            btnSobre.Text = "              Sobre";
            btnSobre.TextAlign = ContentAlignment.MiddleLeft;
            btnSobre.UseVisualStyleBackColor = true;
            btnSobre.Click += btnSobre_Click;
            // 
            // sidebarTime
            // 
            sidebarTime.Interval = 1;
            sidebarTime.Tick += sidebarTime_Tick;
            // 
            // Tela_Inicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1095, 563);
            Controls.Add(sidebar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Tela_Inicial";
            Text = "Tela_Inicial";
            Load += Tela_Inicial_Load;
            sidebar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnBotao).EndInit();
            HomeContainer.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel sidebar;
        private Panel panel3;
        private Panel panel4;
        private Button bntLogin;
        private Panel panel5;
        private Panel panel6;
        private Button btnCadastro;
        private Panel panel7;
        private Panel panel8;
        private Button btnSobre;
        private System.Windows.Forms.Timer sidebarTime;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Panel HomeContainer;
        private Button button4;
        private PictureBox btnBotao;
    }
}