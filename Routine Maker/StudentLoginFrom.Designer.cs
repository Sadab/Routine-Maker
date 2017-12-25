namespace Routine_Maker
{
    partial class StudentLoginFrom
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
            this.exitBtn = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.passLbl = new System.Windows.Forms.Label();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.userNameLbl = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(292, 168);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 33);
            this.exitBtn.TabIndex = 11;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(166, 168);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 33);
            this.loginButton.TabIndex = 10;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passLbl
            // 
            this.passLbl.AutoSize = true;
            this.passLbl.Location = new System.Drawing.Point(81, 124);
            this.passLbl.Name = "passLbl";
            this.passLbl.Size = new System.Drawing.Size(69, 17);
            this.passLbl.TabIndex = 9;
            this.passLbl.Text = "Password";
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(166, 119);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(201, 22);
            this.passwordTB.TabIndex = 8;
            // 
            // userNameLbl
            // 
            this.userNameLbl.AutoSize = true;
            this.userNameLbl.Location = new System.Drawing.Point(81, 60);
            this.userNameLbl.Name = "userNameLbl";
            this.userNameLbl.Size = new System.Drawing.Size(79, 17);
            this.userNameLbl.TabIndex = 7;
            this.userNameLbl.Text = "User Name";
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(166, 57);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(201, 22);
            this.userName.TabIndex = 6;
            // 
            // StudentLoginFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 260);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passLbl);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.userNameLbl);
            this.Controls.Add(this.userName);
            this.Name = "StudentLoginFrom";
            this.Text = "StudentLoginFrom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label passLbl;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.Label userNameLbl;
        private System.Windows.Forms.TextBox userName;
    }
}