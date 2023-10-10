namespace Stahanova6.МодельEF
{
    partial class Form2Authorization
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
            this.buttonCome = new System.Windows.Forms.Button();
            this.loginLb = new System.Windows.Forms.Label();
            this.labelPsw = new System.Windows.Forms.Label();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.textBoxPas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonCome
            // 
            this.buttonCome.Location = new System.Drawing.Point(123, 374);
            this.buttonCome.Name = "buttonCome";
            this.buttonCome.Size = new System.Drawing.Size(75, 23);
            this.buttonCome.TabIndex = 0;
            this.buttonCome.Text = "Войти";
            this.buttonCome.UseVisualStyleBackColor = true;
            this.buttonCome.Click += new System.EventHandler(this.buttonCome_Click);
            // 
            // loginLb
            // 
            this.loginLb.AutoSize = true;
            this.loginLb.Location = new System.Drawing.Point(43, 137);
            this.loginLb.Name = "loginLb";
            this.loginLb.Size = new System.Drawing.Size(36, 13);
            this.loginLb.TabIndex = 1;
            this.loginLb.Text = "Login:";
            // 
            // labelPsw
            // 
            this.labelPsw.AutoSize = true;
            this.labelPsw.Location = new System.Drawing.Point(43, 170);
            this.labelPsw.Name = "labelPsw";
            this.labelPsw.Size = new System.Drawing.Size(53, 13);
            this.labelPsw.TabIndex = 2;
            this.labelPsw.Text = "Password";
            // 
            // textBoxLog
            // 
            this.textBoxLog.Location = new System.Drawing.Point(123, 137);
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.Size = new System.Drawing.Size(171, 20);
            this.textBoxLog.TabIndex = 3;
            // 
            // textBoxPas
            // 
            this.textBoxPas.Location = new System.Drawing.Point(123, 170);
            this.textBoxPas.Name = "textBoxPas";
            this.textBoxPas.PasswordChar = '*';
            this.textBoxPas.Size = new System.Drawing.Size(171, 20);
            this.textBoxPas.TabIndex = 4;
            // 
            // Form2Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 425);
            this.Controls.Add(this.textBoxPas);
            this.Controls.Add(this.textBoxLog);
            this.Controls.Add(this.labelPsw);
            this.Controls.Add(this.loginLb);
            this.Controls.Add(this.buttonCome);
            this.Name = "Form2Authorization";
            this.Text = "Form2Authorization";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCome;
        private System.Windows.Forms.Label loginLb;
        private System.Windows.Forms.Label labelPsw;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.TextBox textBoxPas;
    }
}