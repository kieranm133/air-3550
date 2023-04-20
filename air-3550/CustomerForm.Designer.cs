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
            components = new System.ComponentModel.Container();
            tabControl1 = new TabControl();
            customerTabMyFlights = new TabPage();
            label2 = new Label();
            dataGridView2 = new DataGridView();
            getTicketInfo = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            bookingIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            customerIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            flightID1DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            flightID2DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            flightID3DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tripTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bookingDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            paymentMethodDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pointsUsedDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pricePaidDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isCancelledDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            bookingBindingSource = new BindingSource(components);
            customerTabSearchFlights = new TabPage();
            button2 = new Button();
            label7 = new Label();
            dataGridView3 = new DataGridView();
            radioButtonOneWay = new RadioButton();
            radioButtonRoundTrip = new RadioButton();
            comboBoxTo = new ComboBox();
            comboBoxFrom = new ComboBox();
            label5 = new Label();
            textBox3 = new TextBox();
            label6 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            customerTabProfile = new TabPage();
            label8 = new Label();
            dataGridView4 = new DataGridView();
            btnLogoutCus = new Button();
            tabControl1.SuspendLayout();
            customerTabMyFlights.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookingBindingSource).BeginInit();
            customerTabSearchFlights.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            customerTabProfile.SuspendLayout();
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
            customerTabMyFlights.Controls.Add(getTicketInfo);
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
            label2.Location = new Point(636, 18);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 4;
            label2.Text = "Ticket info";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(541, 36);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(240, 150);
            dataGridView2.TabIndex = 3;
            // 
            // getTicketInfo
            // 
            getTicketInfo.Location = new Point(604, 192);
            getTicketInfo.Name = "getTicketInfo";
            getTicketInfo.Size = new Size(135, 23);
            getTicketInfo.TabIndex = 2;
            getTicketInfo.Text = "Get ticket info";
            getTicketInfo.UseVisualStyleBackColor = true;
            getTicketInfo.Click += getTicketInfo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(199, 18);
            label1.Name = "label1";
            label1.Size = new Size(135, 15);
            label1.TabIndex = 1;
            label1.Text = "Currently booked flights";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { bookingIDDataGridViewTextBoxColumn, customerIDDataGridViewTextBoxColumn, flightID1DataGridViewTextBoxColumn, flightID2DataGridViewTextBoxColumn, flightID3DataGridViewTextBoxColumn, tripTypeDataGridViewTextBoxColumn, bookingDateDataGridViewTextBoxColumn, paymentMethodDataGridViewTextBoxColumn, pointsUsedDataGridViewTextBoxColumn, pricePaidDataGridViewTextBoxColumn, isCancelledDataGridViewCheckBoxColumn });
            dataGridView1.DataSource = bookingBindingSource;
            dataGridView1.Location = new Point(6, 36);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(529, 342);
            dataGridView1.TabIndex = 0;
            // 
            // bookingIDDataGridViewTextBoxColumn
            // 
            bookingIDDataGridViewTextBoxColumn.DataPropertyName = "BookingID";
            bookingIDDataGridViewTextBoxColumn.HeaderText = "BookingID";
            bookingIDDataGridViewTextBoxColumn.Name = "bookingIDDataGridViewTextBoxColumn";
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            // 
            // flightID1DataGridViewTextBoxColumn
            // 
            flightID1DataGridViewTextBoxColumn.DataPropertyName = "FlightID1";
            flightID1DataGridViewTextBoxColumn.HeaderText = "FlightID1";
            flightID1DataGridViewTextBoxColumn.Name = "flightID1DataGridViewTextBoxColumn";
            // 
            // flightID2DataGridViewTextBoxColumn
            // 
            flightID2DataGridViewTextBoxColumn.DataPropertyName = "FlightID2";
            flightID2DataGridViewTextBoxColumn.HeaderText = "FlightID2";
            flightID2DataGridViewTextBoxColumn.Name = "flightID2DataGridViewTextBoxColumn";
            // 
            // flightID3DataGridViewTextBoxColumn
            // 
            flightID3DataGridViewTextBoxColumn.DataPropertyName = "FlightID3";
            flightID3DataGridViewTextBoxColumn.HeaderText = "FlightID3";
            flightID3DataGridViewTextBoxColumn.Name = "flightID3DataGridViewTextBoxColumn";
            // 
            // tripTypeDataGridViewTextBoxColumn
            // 
            tripTypeDataGridViewTextBoxColumn.DataPropertyName = "TripType";
            tripTypeDataGridViewTextBoxColumn.HeaderText = "TripType";
            tripTypeDataGridViewTextBoxColumn.Name = "tripTypeDataGridViewTextBoxColumn";
            // 
            // bookingDateDataGridViewTextBoxColumn
            // 
            bookingDateDataGridViewTextBoxColumn.DataPropertyName = "BookingDate";
            bookingDateDataGridViewTextBoxColumn.HeaderText = "BookingDate";
            bookingDateDataGridViewTextBoxColumn.Name = "bookingDateDataGridViewTextBoxColumn";
            // 
            // paymentMethodDataGridViewTextBoxColumn
            // 
            paymentMethodDataGridViewTextBoxColumn.DataPropertyName = "PaymentMethod";
            paymentMethodDataGridViewTextBoxColumn.HeaderText = "PaymentMethod";
            paymentMethodDataGridViewTextBoxColumn.Name = "paymentMethodDataGridViewTextBoxColumn";
            // 
            // pointsUsedDataGridViewTextBoxColumn
            // 
            pointsUsedDataGridViewTextBoxColumn.DataPropertyName = "PointsUsed";
            pointsUsedDataGridViewTextBoxColumn.HeaderText = "PointsUsed";
            pointsUsedDataGridViewTextBoxColumn.Name = "pointsUsedDataGridViewTextBoxColumn";
            // 
            // pricePaidDataGridViewTextBoxColumn
            // 
            pricePaidDataGridViewTextBoxColumn.DataPropertyName = "PricePaid";
            pricePaidDataGridViewTextBoxColumn.HeaderText = "PricePaid";
            pricePaidDataGridViewTextBoxColumn.Name = "pricePaidDataGridViewTextBoxColumn";
            // 
            // isCancelledDataGridViewCheckBoxColumn
            // 
            isCancelledDataGridViewCheckBoxColumn.DataPropertyName = "IsCancelled";
            isCancelledDataGridViewCheckBoxColumn.HeaderText = "IsCancelled";
            isCancelledDataGridViewCheckBoxColumn.Name = "isCancelledDataGridViewCheckBoxColumn";
            // 
            // bookingBindingSource
            // 
            bookingBindingSource.DataSource = typeof(Models.Booking);
            // 
            // customerTabSearchFlights
            // 
            customerTabSearchFlights.Controls.Add(button2);
            customerTabSearchFlights.Controls.Add(label7);
            customerTabSearchFlights.Controls.Add(dataGridView3);
            customerTabSearchFlights.Controls.Add(radioButtonOneWay);
            customerTabSearchFlights.Controls.Add(radioButtonRoundTrip);
            customerTabSearchFlights.Controls.Add(comboBoxTo);
            customerTabSearchFlights.Controls.Add(comboBoxFrom);
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
            // button2
            // 
            button2.Location = new Point(432, 383);
            button2.Name = "button2";
            button2.Size = new Size(127, 23);
            button2.TabIndex = 14;
            button2.Text = "Book flight";
            button2.UseVisualStyleBackColor = true;
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
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(319, 49);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowTemplate.Height = 25;
            dataGridView3.Size = new Size(240, 328);
            dataGridView3.TabIndex = 12;
            // 
            // radioButtonOneWay
            // 
            radioButtonOneWay.AutoSize = true;
            radioButtonOneWay.Checked = true;
            radioButtonOneWay.Location = new Point(145, 87);
            radioButtonOneWay.Name = "radioButtonOneWay";
            radioButtonOneWay.Size = new Size(73, 19);
            radioButtonOneWay.TabIndex = 11;
            radioButtonOneWay.TabStop = true;
            radioButtonOneWay.Text = "One-way";
            radioButtonOneWay.UseVisualStyleBackColor = true;
            // 
            // radioButtonRoundTrip
            // 
            radioButtonRoundTrip.AutoSize = true;
            radioButtonRoundTrip.Location = new Point(45, 87);
            radioButtonRoundTrip.Name = "radioButtonRoundTrip";
            radioButtonRoundTrip.Size = new Size(78, 19);
            radioButtonRoundTrip.TabIndex = 10;
            radioButtonRoundTrip.TabStop = true;
            radioButtonRoundTrip.Text = "Roundtrip";
            radioButtonRoundTrip.UseVisualStyleBackColor = true;
            radioButtonRoundTrip.CheckedChanged += radioButtonRoundTrip_CheckedChanged;
            // 
            // comboBoxTo
            // 
            comboBoxTo.FormattingEnabled = true;
            comboBoxTo.Location = new Point(178, 49);
            comboBoxTo.Name = "comboBoxTo";
            comboBoxTo.Size = new Size(121, 23);
            comboBoxTo.TabIndex = 9;
            // 
            // comboBoxFrom
            // 
            comboBoxFrom.FormattingEnabled = true;
            comboBoxFrom.Location = new Point(45, 49);
            comboBoxFrom.Name = "comboBoxFrom";
            comboBoxFrom.Size = new Size(121, 23);
            comboBoxFrom.TabIndex = 8;
            comboBoxFrom.SelectedIndexChanged += comboBoxFrom_SelectedIndexChanged;
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
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 4);
            label8.Name = "label8";
            label8.Size = new Size(65, 15);
            label8.TabIndex = 1;
            label8.Text = "Profile Info";
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
            // btnLogoutCus
            // 
            btnLogoutCus.Location = new Point(713, 2);
            btnLogoutCus.Name = "btnLogoutCus";
            btnLogoutCus.Size = new Size(75, 23);
            btnLogoutCus.TabIndex = 3;
            btnLogoutCus.Text = "Logout";
            btnLogoutCus.UseVisualStyleBackColor = true;
            btnLogoutCus.Click += btnLogoutCus_Click_1;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogoutCus);
            Controls.Add(tabControl1);
            Name = "CustomerForm";
            Text = "Customer Form";
            Load += CustomerForm_Load;
            tabControl1.ResumeLayout(false);
            customerTabMyFlights.ResumeLayout(false);
            customerTabMyFlights.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookingBindingSource).EndInit();
            customerTabSearchFlights.ResumeLayout(false);
            customerTabSearchFlights.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            customerTabProfile.ResumeLayout(false);
            customerTabProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage customerTabMyFlights;
        private TabPage customerTabSearchFlights;
        private TabPage customerTabProfile;
        private Button btnLogoutCus;
        private Label label2;
        private DataGridView dataGridView2;
        private Button getTicketInfo;
        private Label label1;
        private DataGridView dataGridView1;
        private Label label5;
        private TextBox textBox3;
        private Label label6;
        private TextBox textBox4;
        private Label label4;
        private Label label3;
        private RadioButton radioButtonOneWay;
        private RadioButton radioButtonRoundTrip;
        private ComboBox comboBoxTo;
        private ComboBox comboBoxFrom;
        private DataGridView dataGridView3;
        private Label label7;
        private Label label8;
        private DataGridView dataGridView4;
        private Button button2;
        private DataGridViewTextBoxColumn bookingIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn flightID1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn flightID2DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn flightID3DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tripTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bookingDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn paymentMethodDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pointsUsedDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pricePaidDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isCancelledDataGridViewCheckBoxColumn;
        private BindingSource bookingBindingSource;
    }
}