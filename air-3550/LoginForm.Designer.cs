﻿namespace air_3550
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelUserID = new Label();
            label2 = new Label();
            txtUserID = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnCreateAccount = new Button();
            SuspendLayout();
            // 
            // labelUserID
            // 
            labelUserID.AutoSize = true;
            labelUserID.Location = new Point(236, 166);
            labelUserID.Name = "labelUserID";
            labelUserID.Size = new Size(44, 15);
            labelUserID.TabIndex = 0;
            labelUserID.Text = "User ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(236, 209);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // txtUserID
            // 
            txtUserID.Location = new Point(299, 163);
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new Size(100, 23);
            txtUserID.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(299, 206);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(236, 249);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(181, 23);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.Location = new Point(262, 278);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(137, 23);
            btnCreateAccount.TabIndex = 5;
            btnCreateAccount.Text = "Create an account";
            btnCreateAccount.UseVisualStyleBackColor = true;
            btnCreateAccount.Click += btnCreateAccount_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCreateAccount);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUserID);
            Controls.Add(label2);
            Controls.Add(labelUserID);
            Name = "LoginForm";
            Text = "Login Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelUserID;
        private Label label2;
        private TextBox txtUserID;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnCreateAccount;
    }
}