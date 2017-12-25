namespace Routine_Maker
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
            this.userName = new System.Windows.Forms.TextBox();
            this.userNameLbl = new System.Windows.Forms.Label();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.passLbl = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.studentLoginBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(215, 80);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(201, 22);
            this.userName.TabIndex = 0;
            // 
            // userNameLbl
            // 
            this.userNameLbl.AutoSize = true;
            this.userNameLbl.Location = new System.Drawing.Point(130, 83);
            this.userNameLbl.Name = "userNameLbl";
            this.userNameLbl.Size = new System.Drawing.Size(79, 17);
            this.userNameLbl.TabIndex = 1;
            this.userNameLbl.Text = "User Name";
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(215, 142);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(201, 22);
            this.passwordTB.TabIndex = 2;
            // 
            // passLbl
            // 
            this.passLbl.AutoSize = true;
            this.passLbl.Location = new System.Drawing.Point(130, 147);
            this.passLbl.Name = "passLbl";
            this.passLbl.Size = new System.Drawing.Size(69, 17);
            this.passLbl.TabIndex = 3;
            this.passLbl.Text = "Password";
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(215, 191);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 33);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(341, 191);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 33);
            this.exitBtn.TabIndex = 5;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // studentLoginBtn
            // 
            this.studentLoginBtn.Location = new System.Drawing.Point(249, 243);
            this.studentLoginBtn.Name = "studentLoginBtn";
            this.studentLoginBtn.Size = new System.Drawing.Size(135, 34);
            this.studentLoginBtn.TabIndex = 6;
            this.studentLoginBtn.Text = "Student Login";
            this.studentLoginBtn.UseVisualStyleBackColor = true;
            this.studentLoginBtn.Click += new System.EventHandler(this.studentLoginBtn_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(611, 304);
            this.Controls.Add(this.studentLoginBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passLbl);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.userNameLbl);
            this.Controls.Add(this.userName);
            this.Name = "LoginForm";
            this.Text = "Login ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Label userNameLbl;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.Label passLbl;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button studentLoginBtn;
    }
}

