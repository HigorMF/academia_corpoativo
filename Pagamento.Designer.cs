namespace academia_corpoativo
{
    partial class Pagamento
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
            lblID_Plano = new Label();
            lblDataPagamento = new Label();
            lblValor = new Label();
            lblFormaPagamento = new Label();
            lblStatusPagamento = new Label();
            txtIDPlano = new TextBox();
            mtbDataPagamento = new MaskedTextBox();
            txtValor = new TextBox();
            cmbFormaPagamento = new ComboBox();
            cmbStatusPagamento = new ComboBox();
            btnOK = new Button();
            SuspendLayout();
            // 
            // lblID_Plano
            // 
            lblID_Plano.AutoSize = true;
            lblID_Plano.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblID_Plano.Location = new Point(85, 93);
            lblID_Plano.Name = "lblID_Plano";
            lblID_Plano.Size = new Size(65, 17);
            lblID_Plano.TabIndex = 0;
            lblID_Plano.Text = "ID Plano:";
            // 
            // lblDataPagamento
            // 
            lblDataPagamento.AutoSize = true;
            lblDataPagamento.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDataPagamento.Location = new Point(84, 149);
            lblDataPagamento.Name = "lblDataPagamento";
            lblDataPagamento.Size = new Size(115, 17);
            lblDataPagamento.TabIndex = 1;
            lblDataPagamento.Text = "Data Pagamento:";
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblValor.Location = new Point(84, 202);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(45, 17);
            lblValor.TabIndex = 2;
            lblValor.Text = "Valor:";
            // 
            // lblFormaPagamento
            // 
            lblFormaPagamento.AutoSize = true;
            lblFormaPagamento.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFormaPagamento.Location = new Point(84, 262);
            lblFormaPagamento.Name = "lblFormaPagamento";
            lblFormaPagamento.Size = new Size(144, 17);
            lblFormaPagamento.TabIndex = 3;
            lblFormaPagamento.Text = "Forma de Pagamento:";
            // 
            // lblStatusPagamento
            // 
            lblStatusPagamento.AutoSize = true;
            lblStatusPagamento.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatusPagamento.Location = new Point(85, 320);
            lblStatusPagamento.Name = "lblStatusPagamento";
            lblStatusPagamento.Size = new Size(144, 17);
            lblStatusPagamento.TabIndex = 4;
            lblStatusPagamento.Text = "Status do pagamento:";
            // 
            // txtIDPlano
            // 
            txtIDPlano.Location = new Point(154, 90);
            txtIDPlano.Name = "txtIDPlano";
            txtIDPlano.Size = new Size(168, 23);
            txtIDPlano.TabIndex = 5;
            // 
            // mtbDataPagamento
            // 
            mtbDataPagamento.Location = new Point(205, 148);
            mtbDataPagamento.Name = "mtbDataPagamento";
            mtbDataPagamento.Size = new Size(154, 23);
            mtbDataPagamento.TabIndex = 6;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(135, 201);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(147, 23);
            txtValor.TabIndex = 7;
            // 
            // cmbFormaPagamento
            // 
            cmbFormaPagamento.FormattingEnabled = true;
            cmbFormaPagamento.Location = new Point(244, 261);
            cmbFormaPagamento.Name = "cmbFormaPagamento";
            cmbFormaPagamento.Size = new Size(142, 23);
            cmbFormaPagamento.TabIndex = 8;
            // 
            // cmbStatusPagamento
            // 
            cmbStatusPagamento.FormattingEnabled = true;
            cmbStatusPagamento.Location = new Point(248, 319);
            cmbStatusPagamento.Name = "cmbStatusPagamento";
            cmbStatusPagamento.Size = new Size(138, 23);
            cmbStatusPagamento.TabIndex = 9;
            // 
            // btnOK
            // 
            btnOK.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOK.Location = new Point(220, 384);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(102, 34);
            btnOK.TabIndex = 10;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // Pagamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 507);
            Controls.Add(btnOK);
            Controls.Add(cmbStatusPagamento);
            Controls.Add(cmbFormaPagamento);
            Controls.Add(txtValor);
            Controls.Add(mtbDataPagamento);
            Controls.Add(txtIDPlano);
            Controls.Add(lblStatusPagamento);
            Controls.Add(lblFormaPagamento);
            Controls.Add(lblValor);
            Controls.Add(lblDataPagamento);
            Controls.Add(lblID_Plano);
            Name = "Pagamento";
            Text = "Pagamento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblID_Plano;
        private Label lblDataPagamento;
        private Label lblValor;
        private Label lblFormaPagamento;
        private Label lblStatusPagamento;
        private TextBox txtIDPlano;
        private MaskedTextBox mtbDataPagamento;
        private TextBox txtValor;
        private ComboBox cmbFormaPagamento;
        private ComboBox cmbStatusPagamento;
        private Button btnOK;
    }
}