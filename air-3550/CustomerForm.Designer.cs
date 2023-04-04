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
            label2 = new Label();
            dataGridView2 = new DataGridView();
            button1 = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            customerTabSearchFlights = new TabPage();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label5 = new Label();
            textBox3 = new TextBox();
            label6 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            customerTabProfile = new TabPage();
            btnLogout = new Button();
            dataGridView3 = new DataGridView();
            label7 = new Label();
            dataGridView4 = new DataGridView();
            label8 = new Label();
            button2 = new Button();
            tabControl1.SuspendLayout();
            customerTabMyFlights.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            customerTabSearchFlights.SuspendLayout();
            customerTabProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
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
            customerTabMyFlights.Controls.Add(label2);
            customerTabMyFlights.Controls.Add(dataGridView2);
            customerTabMyFlights.Controls.Add(button1);
            customerTabMyFlights.Controls.Add(label1);
            customerTabMyFlights.Controls.Add(dataGridView1);
            customerTabMyFlights.Location = new Point(4, 24);
            customerTabMyFlights.Name = "customerTabMyFlights";
            customerTabMyFlights.Padding = new Padding(3);
            customerTabMyFlights.Size = new Size(788, 416);
            customerTabMyFlights.TabIndex = 0;
            customerTabMyFlights.Text = "My Flights";
            customerTabMyFlights.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(407, 18);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 4;
            label2.Text = "Ticket info";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(316, 36);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(240, 150);
            dataGridView2.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(111, 384);
            button1.Name = "button1";
            button1.Size = new Size(135, 23);
            button1.TabIndex = 2;
            button1.Text = "Get ticket info";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 18);
            label1.Name = "label1";
            label1.Size = new Size(135, 15);
            label1.TabIndex = 1;
            label1.Text = "Currently booked flights";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 36);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(240, 342);
            dataGridView1.TabIndex = 0;
            // 
            // customerTabSearchFlights
            // 
            customerTabSearchFlights.Controls.Add(button2);
            customerTabSearchFlights.Controls.Add(label7);
            customerTabSearchFlights.Controls.Add(dataGridView3);
            customerTabSearchFlights.Controls.Add(radioButton2);
            customerTabSearchFlights.Controls.Add(radioButton1);
            customerTabSearchFlights.Controls.Add(comboBox2);
            customerTabSearchFlights.Controls.Add(comboBox1);
            customerTabSearchFlights.Controls.Add(label5);
            customerTabSearchFlights.Controls.Add(textBox3);
            customerTabSearchFlights.Controls.Add(label6);
            customerTabSearchFlights.Controls.Add(textBox4);
            customerTabSearchFlights.Controls.Add(label4);
            customerTabSearchFlights.Controls.Add(label3);
            customerTabSearchFlights.Location = new Point(4, 24);
            customerTabSearchFlights.Name = "customerTabSearchFlights";
            customerTabSearchFlights.Padding = new Padding(3);
            customerTabSearchFlights.Size = new Size(788, 416);
            customerTabSearchFlights.TabIndex = 1;
            customerTabSearchFlights.Text = "Search for flights";
            customerTabSearchFlights.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(145, 87);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(73, 19);
            radioButton2.TabIndex = 11;
            radioButton2.TabStop = true;
            radioButton2.Text = "One-way";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(45, 87);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(78, 19);
            radioButton1.TabIndex = 10;
            radioButton1.TabStop = true;
            radioButton1.Text = "Roundtrip";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(178, 49);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 9;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(45, 49);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 174);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 7;
            label5.Text = "Arrival date";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(45, 192);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(45, 121);
            label6.Name = "label6";
            label6.Size = new Size(85, 15);
            label6.TabIndex = 5;
            label6.Text = "Departure date";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(45, 139);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(175, 31);
            label4.Name = "label4";
            label4.Size = new Size(19, 15);
            label4.TabIndex = 3;
            label4.Text = "To";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 31);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 1;
            label3.Text = "From";
            // 
            // customerTabProfile
            // 
            customerTabProfile.Controls.Add(label8);
            customerTabProfile.Controls.Add(dataGridView4);
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
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(319, 49);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowTemplate.Height = 25;
            dataGridView3.Size = new Size(240, 328);
            dataGridView3.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(319, 31);
            label7.Name = "label7";
            label7.Size = new Size(44, 15);
            label7.TabIndex = 13;
            label7.Text = "Results";
            // 
            // dataGridView4
            // 
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new Point(6, 22);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowTemplate.Height = 25;
            dataGridView4.Size = new Size(316, 184);
            dataGridView4.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 4);
            label8.Name = "label8";
            label8.Size = new Size(65, 15);
            label8.TabIndex = 1;
            label8.Text = "Profile Info";
            // 
            // button2
            // 
            button2.Location = new Point(432, 383);
            button2.Name = "button2";
            button2.Size = new Size(127, 23);
            button2.TabIndex = 14;
            button2.Text = "Book flight";
            button2.UseVisualStyleBackColor = true;
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
            customerTabMyFlights.ResumeLayout(false);
            customerTabMyFlights.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            customerTabSearchFlights.ResumeLayout(false);
            customerTabSearchFlights.PerformLayout();
            customerTabProfile.ResumeLayout(false);
            customerTabProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage customerTabMyFlights;
        private TabPage customerTabSearchFlights;
        private TabPage customerTabProfile;
        private Button btnLogout;
        private Label label2;
        private DataGridView dataGridView2;
        private Button button1;
        private Label label1;
        private DataGridView dataGridView1;
        private Label label5;
        private TextBox textBox3;
        private Label label6;
        private TextBox textBox4;
        private Label label4;
        private Label label3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private DataGridView dataGridView3;
        private Label label7;
        private Label label8;
        private DataGridView dataGridView4;
        private Button button2;
    }
}