namespace CryptoDate
{
    partial class Inicio
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
            this.cSHA1 = new System.Windows.Forms.Button();
            this.txtHora = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmpTexto = new System.Windows.Forms.TextBox();
            this.limpar = new System.Windows.Forms.Button();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.cSHA256 = new System.Windows.Forms.Button();
            this.cSHA512 = new System.Windows.Forms.Button();
            this.SC = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.n_car = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cSHA1
            // 
            this.cSHA1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cSHA1.AutoSize = true;
            this.cSHA1.Location = new System.Drawing.Point(210, 270);
            this.cSHA1.Name = "cSHA1";
            this.cSHA1.Size = new System.Drawing.Size(120, 25);
            this.cSHA1.TabIndex = 1;
            this.cSHA1.Text = "Criptografar em SHA1";
            this.cSHA1.UseVisualStyleBackColor = true;
            this.cSHA1.Click += new System.EventHandler(this.cSHA1_Click);
            // 
            // txtHora
            // 
            this.txtHora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHora.AutoSize = true;
            this.txtHora.Location = new System.Drawing.Point(141, 163);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(58, 13);
            this.txtHora.TabIndex = 0;
            this.txtHora.Text = "Resultado:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Insira o texto para criptografar:";
            // 
            // cmpTexto
            // 
            this.cmpTexto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmpTexto.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.cmpTexto.Location = new System.Drawing.Point(211, 90);
            this.cmpTexto.Name = "cmpTexto";
            this.cmpTexto.Size = new System.Drawing.Size(461, 20);
            this.cmpTexto.TabIndex = 0;
            // 
            // limpar
            // 
            this.limpar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.limpar.AutoSize = true;
            this.limpar.Location = new System.Drawing.Point(597, 270);
            this.limpar.Name = "limpar";
            this.limpar.Size = new System.Drawing.Size(75, 25);
            this.limpar.TabIndex = 2;
            this.limpar.Text = "Limpar";
            this.limpar.UseVisualStyleBackColor = true;
            this.limpar.Click += new System.EventHandler(this.limpar_Click);
            // 
            // resultBox
            // 
            this.resultBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.resultBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resultBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.resultBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultBox.Location = new System.Drawing.Point(211, 158);
            this.resultBox.Multiline = true;
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            this.resultBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.resultBox.Size = new System.Drawing.Size(461, 40);
            this.resultBox.TabIndex = 6;
            this.resultBox.WordWrap = false;
            this.resultBox.TextChanged += new System.EventHandler(this.carac);
            // 
            // cSHA256
            // 
            this.cSHA256.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cSHA256.AutoSize = true;
            this.cSHA256.Location = new System.Drawing.Point(335, 270);
            this.cSHA256.Name = "cSHA256";
            this.cSHA256.Size = new System.Drawing.Size(119, 25);
            this.cSHA256.TabIndex = 2;
            this.cSHA256.Text = "Criptografar em SHA2";
            this.cSHA256.UseVisualStyleBackColor = true;
            this.cSHA256.Click += new System.EventHandler(this.cSHA256_Click);
            // 
            // cSHA512
            // 
            this.cSHA512.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cSHA512.AutoSize = true;
            this.cSHA512.Location = new System.Drawing.Point(460, 270);
            this.cSHA512.Name = "cSHA512";
            this.cSHA512.Size = new System.Drawing.Size(131, 25);
            this.cSHA512.TabIndex = 7;
            this.cSHA512.Text = "Criptografar em SHA512";
            this.cSHA512.UseVisualStyleBackColor = true;
            this.cSHA512.Click += new System.EventHandler(this.cSHA512_Click);
            // 
            // SC
            // 
            this.SC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SC.AutoSize = true;
            this.SC.Location = new System.Drawing.Point(376, 311);
            this.SC.Name = "SC";
            this.SC.Size = new System.Drawing.Size(101, 23);
            this.SC.TabIndex = 8;
            this.SC.Text = "Super Criptografia";
            this.SC.UseVisualStyleBackColor = true;
            this.SC.Click += new System.EventHandler(this.SC_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nº de caracteres: ";
            // 
            // n_car
            // 
            this.n_car.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.n_car.AutoSize = true;
            this.n_car.Location = new System.Drawing.Point(442, 218);
            this.n_car.Name = "n_car";
            this.n_car.Size = new System.Drawing.Size(0, 13);
            this.n_car.TabIndex = 10;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(840, 346);
            this.Controls.Add(this.n_car);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SC);
            this.Controls.Add(this.cSHA512);
            this.Controls.Add(this.cSHA256);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.limpar);
            this.Controls.Add(this.cmpTexto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cSHA1);
            this.Controls.Add(this.txtHora);
            this.Name = "Inicio";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.limpar_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cSHA1;
        private System.Windows.Forms.Label txtHora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cmpTexto;
		private System.Windows.Forms.Button limpar;
		private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Button cSHA256;
        private System.Windows.Forms.Button cSHA512;
        private System.Windows.Forms.Button SC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label n_car;
	}
}

