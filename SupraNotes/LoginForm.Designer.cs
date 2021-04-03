namespace SupraNotes
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.btnLogin = new System.Windows.Forms.Button();
            this.loginGroupBox = new System.Windows.Forms.GroupBox();
            this.labelRegister = new System.Windows.Forms.Label();
            this.labelForgotPassword = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.loginGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnLogin.Location = new System.Drawing.Point(397, 122);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(88, 30);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // loginGroupBox
            // 
            this.loginGroupBox.BackColor = System.Drawing.Color.AliceBlue;
            this.loginGroupBox.Controls.Add(this.labelRegister);
            this.loginGroupBox.Controls.Add(this.labelForgotPassword);
            this.loginGroupBox.Controls.Add(this.textBox2);
            this.loginGroupBox.Controls.Add(this.textBox1);
            this.loginGroupBox.Controls.Add(this.labelPassword);
            this.loginGroupBox.Controls.Add(this.btnLogin);
            this.loginGroupBox.Controls.Add(this.labelLogin);
            this.loginGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.loginGroupBox.Location = new System.Drawing.Point(0, 378);
            this.loginGroupBox.Name = "loginGroupBox";
            this.loginGroupBox.Size = new System.Drawing.Size(942, 228);
            this.loginGroupBox.TabIndex = 1;
            this.loginGroupBox.TabStop = false;
            // 
            // labelRegister
            // 
            this.labelRegister.AutoSize = true;
            this.labelRegister.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelRegister.Location = new System.Drawing.Point(394, 201);
            this.labelRegister.Name = "labelRegister";
            this.labelRegister.Size = new System.Drawing.Size(94, 15);
            this.labelRegister.TabIndex = 6;
            this.labelRegister.Text = "Got no account?";
            // 
            // labelForgotPassword
            // 
            this.labelForgotPassword.AutoSize = true;
            this.labelForgotPassword.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelForgotPassword.Location = new System.Drawing.Point(391, 169);
            this.labelForgotPassword.Name = "labelForgotPassword";
            this.labelForgotPassword.Size = new System.Drawing.Size(100, 15);
            this.labelForgotPassword.TabIndex = 4;
            this.labelForgotPassword.Text = "Forgot password?";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(391, 75);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(124, 23);
            this.textBox2.TabIndex = 3;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(391, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(124, 23);
            this.textBox1.TabIndex = 3;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(328, 79);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(57, 15);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Password";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(328, 40);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(37, 15);
            this.labelLogin.TabIndex = 2;
            this.labelLogin.Text = "Login";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Beige;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(174, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(578, 356);
            this.panel1.TabIndex = 4;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(942, 606);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.loginGroupBox);
            this.Name = "LoginForm";
            this.Text = "SUPRANOTESS";
            this.loginGroupBox.ResumeLayout(false);
            this.loginGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.GroupBox loginGroupBox;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelRegister;
        private System.Windows.Forms.Label labelForgotPassword;
    }
}