namespace TesteTecnico2023
{
    partial class Login
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
            this.btnAcesso1 = new System.Windows.Forms.Button();
            this.lblname1 = new System.Windows.Forms.Label();
            this.txtnome1 = new System.Windows.Forms.TextBox();
            this.txtsenha1 = new System.Windows.Forms.TextBox();
            this.lblsenha1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAcesso1
            // 
            this.btnAcesso1.Location = new System.Drawing.Point(71, 162);
            this.btnAcesso1.Name = "btnAcesso1";
            this.btnAcesso1.Size = new System.Drawing.Size(90, 23);
            this.btnAcesso1.TabIndex = 0;
            this.btnAcesso1.Text = "Acesso";
            this.btnAcesso1.UseVisualStyleBackColor = true;
            this.btnAcesso1.Click += new System.EventHandler(this.btnAcesso1_Click);
            // 
            // lblname1
            // 
            this.lblname1.AutoSize = true;
            this.lblname1.Location = new System.Drawing.Point(30, 83);
            this.lblname1.Name = "lblname1";
            this.lblname1.Size = new System.Drawing.Size(35, 13);
            this.lblname1.TabIndex = 1;
            this.lblname1.Text = "Nome";
            // 
            // txtnome1
            // 
            this.txtnome1.Location = new System.Drawing.Point(71, 76);
            this.txtnome1.Name = "txtnome1";
            this.txtnome1.Size = new System.Drawing.Size(118, 20);
            this.txtnome1.TabIndex = 2;
            // 
            // txtsenha1
            // 
            this.txtsenha1.Location = new System.Drawing.Point(71, 118);
            this.txtsenha1.Name = "txtsenha1";
            this.txtsenha1.Size = new System.Drawing.Size(118, 20);
            this.txtsenha1.TabIndex = 4;
            this.txtsenha1.UseSystemPasswordChar = true;
            // 
            // lblsenha1
            // 
            this.lblsenha1.AutoSize = true;
            this.lblsenha1.Location = new System.Drawing.Point(30, 125);
            this.lblsenha1.Name = "lblsenha1";
            this.lblsenha1.Size = new System.Drawing.Size(38, 13);
            this.lblsenha1.TabIndex = 3;
            this.lblsenha1.Text = "Senha";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 228);
            this.Controls.Add(this.txtsenha1);
            this.Controls.Add(this.lblsenha1);
            this.Controls.Add(this.txtnome1);
            this.Controls.Add(this.lblname1);
            this.Controls.Add(this.btnAcesso1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAcesso1;
        private System.Windows.Forms.Label lblname1;
        private System.Windows.Forms.TextBox txtnome1;
        private System.Windows.Forms.TextBox txtsenha1;
        private System.Windows.Forms.Label lblsenha1;
    }
}