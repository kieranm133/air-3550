namespace air_3550
{
    partial class CustomerForm
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
            tabControl1 = new TabControl();
            customerTabMyFlights = new TabPage();
            customerTabSearchFlights = new TabPage();
            customerTabProfile = new TabPage();
            btnLogout = new Button();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(customerTabMyFlights);
            tabControl1.Controls.Add(customerTabSearchFlights);
            tabControl1.Controls.Add(customerTabProfile);
            tabControl1.Location = new Point(3, 7);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(796, 444);
            tabControl1.TabIndex = 2;
            // 
            // customerTabMyFlights
            // 
            customerTabMyFlights.Location = new Point(4, 24);
            customerTabMyFlights.Name = "customerTabMyFlights";
            customerTabMyFlights.Padding = new Padding(3);
            customerTabMyFlights.Size = new Size(788, 416);
            customerTabMyFlights.TabIndex = 0;
            customerTabMyFlights.Text = "My Flights";
            customerTabMyFlights.UseVisualStyleBackColor = true;
            // 
            // customerTabSearchFlights
            // 
            customerTabSearchFlights.Location = new Point(4, 24);
            customerTabSearchFlights.Name = "customerTabSearchFlights";
            customerTabSearchFlights.Padding = new Padding(3);
            customerTabSearchFlights.Size = new Size(788, 416);
            customerTabSearchFlights.TabIndex = 1;
            customerTabSearchFlights.Text = "Search for flights";
            customerTabSearchFlights.UseVisualStyleBackColor = true;
            // 
            // customerTabProfile
            // 
            customerTabProfile.Location = new Point(4, 24);
            customerTabProfile.Name = "customerTabProfile";
            customerTabProfile.Padding = new Padding(3);
            customerTabProfile.Size = new Size(788, 416);
            customerTabProfile.TabIndex = 2;
            customerTabProfile.Text = "My Profile";
            customerTabProfile.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(713, 2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 23);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogout);
            Controls.Add(tabControl1);
            Name = "CustomerForm";
            Text = "Customer Form";
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage customerTabMyFlights;
        private TabPage customerTabSearchFlights;
        private TabPage customerTabProfile;
        private Button btnLogout;
    }
}