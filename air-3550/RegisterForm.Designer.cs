namespace air_3550
{
    partial class RegisterForm
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
            txtPassword = new TextBox();
            txtUserID = new TextBox();
            label2 = new Label();
            labelUserID = new Label();
            txtFirstName = new TextBox();
            label3 = new Label();
            txtLastName = new TextBox();
            label1 = new Label();
            txtAge = new TextBox();
            label4 = new Label();
            txtAddress = new TextBox();
            label5 = new Label();
            txtPhone = new TextBox();
            label6 = new Label();
            txtCreditCard = new TextBox();
            label7 = new Label();
            btnSignUp = new Button();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(168, 129);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 7;
            // 
            // txtUserID
            // 
            txtUserID.Location = new Point(168, 100);
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new Size(100, 23);
            txtUserID.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(91, 132);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // labelUserID
            // 
            labelUserID.AutoSize = true;
            labelUserID.Location = new Point(91, 103);
            labelUserID.Name = "labelUserID";
            labelUserID.Size = new Size(44, 15);
            labelUserID.TabIndex = 4;
            labelUserID.Text = "User ID";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(168, 158);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(100, 23);
            txtFirstName.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(91, 161);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 8;
            label3.Text = "First name";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(168, 187);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(100, 23);
            txtLastName.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 190);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 11;
            label1.Text = "Last name";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(168, 216);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(100, 23);
            txtAge.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(91, 219);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 13;
            label4.Text = "Age";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(168, 274);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(100, 23);
            txtAddress.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(91, 277);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 17;
            label5.Text = "Address";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(168, 245);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(100, 23);
            txtPhone.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(91, 248);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 15;
            label6.Text = "Phone #";
            // 
            // txtCreditCard
            // 
            txtCreditCard.Location = new Point(168, 303);
            txtCreditCard.Name = "txtCreditCard";
            txtCreditCard.Size = new Size(100, 23);
            txtCreditCard.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(91, 306);
            label7.Name = "label7";
            label7.Size = new Size(74, 15);
            label7.TabIndex = 19;
            label7.Text = "Credit Card#";
            // 
            // btnSignUp
            // 
            btnSignUp.Location = new Point(193, 332);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(75, 23);
            btnSignUp.TabIndex = 21;
            btnSignUp.Text = "Sign up";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSignUp);
            Controls.Add(txtCreditCard);
            Controls.Add(label7);
            Controls.Add(txtAddress);
            Controls.Add(label5);
            Controls.Add(txtPhone);
            Controls.Add(label6);
            Controls.Add(txtAge);
            Controls.Add(label4);
            Controls.Add(txtLastName);
            Controls.Add(label1);
            Controls.Add(txtFirstName);
            Controls.Add(label3);
            Controls.Add(txtPassword);
            Controls.Add(txtUserID);
            Controls.Add(label2);
            Controls.Add(labelUserID);
            Name = "RegisterForm";
            Text = "Create a new account";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPassword;
        private TextBox txtUserID;
        private Label label2;
        private Label labelUserID;
        private TextBox txtFirstName;
        private Label label3;
        private TextBox txtLastName;
        private Label label1;
        private TextBox txtAge;
        private Label label4;
        private TextBox txtAddress;
        private Label label5;
        private TextBox txtPhone;
        private Label label6;
        private TextBox txtCreditCard;
        private Label label7;
        private Button btnSignUp;
    }
}