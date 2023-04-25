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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            tabControl1 = new TabControl();
            customerTabMyFlights = new TabPage();
            btnCancelFlight = new Button();
            label2 = new Label();
            dataGridView2 = new DataGridView();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            getTicketInfo = new Button();
            label1 = new Label();
            bookingView = new DataGridView();
            customerTabSearchFlights = new TabPage();
            labelFlightsNotFound = new Label();
            label11 = new Label();
            label10 = new Label();
            dataGridViewSearchResultsReturn = new DataGridView();
            label9 = new Label();
            paymentMethod = new ComboBox();
            buttonSearch = new Button();
            dateTimePickerReturn = new DateTimePicker();
            dateTimePickerDeparture = new DateTimePicker();
            bookFlightBtn = new Button();
            label7 = new Label();
            dataGridViewSearchResultsOutbound = new DataGridView();
            radioButtonOneWay = new RadioButton();
            radioButtonRoundTrip = new RadioButton();
            comboBoxTo = new ComboBox();
            comboBoxFrom = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            customerTabProfile = new TabPage();
            btnSubmitPasswordChange = new Button();
            label14 = new Label();
            txtNewPass = new TextBox();
            label13 = new Label();
            txtCurrentPass = new TextBox();
            label12 = new Label();
            dataGridViewProfile = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            label8 = new Label();
            bookingBindingSource = new BindingSource(components);
            btnLogoutCus = new Button();
            tabControl1.SuspendLayout();
            customerTabMyFlights.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookingView).BeginInit();
            customerTabSearchFlights.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSearchResultsReturn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSearchResultsOutbound).BeginInit();
            customerTabProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProfile).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookingBindingSource).BeginInit();
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
            customerTabMyFlights.Controls.Add(btnCancelFlight);
            customerTabMyFlights.Controls.Add(label2);
            customerTabMyFlights.Controls.Add(dataGridView2);
            customerTabMyFlights.Controls.Add(getTicketInfo);
            customerTabMyFlights.Controls.Add(label1);
            customerTabMyFlights.Controls.Add(bookingView);
            customerTabMyFlights.Location = new Point(4, 24);
            customerTabMyFlights.Name = "customerTabMyFlights";
            customerTabMyFlights.Padding = new Padding(3);
            customerTabMyFlights.Size = new Size(788, 416);
            customerTabMyFlights.TabIndex = 0;
            customerTabMyFlights.Text = "My Flights";
            customerTabMyFlights.UseVisualStyleBackColor = true;
            // 
            // btnCancelFlight
            // 
            btnCancelFlight.Enabled = false;
            btnCancelFlight.Location = new Point(352, 384);
            btnCancelFlight.Name = "btnCancelFlight";
            btnCancelFlight.Size = new Size(159, 23);
            btnCancelFlight.TabIndex = 5;
            btnCancelFlight.Text = "Cancel flight";
            btnCancelFlight.UseVisualStyleBackColor = true;
            btnCancelFlight.Click += btnCancelFlight_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(622, 18);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 4;
            label2.Text = "Ticket info";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.BackgroundColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.ColumnHeadersVisible = false;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column3, Column4 });
            dataGridView2.Location = new Point(517, 36);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(264, 342);
            dataGridView2.TabIndex = 2;
            // 
            // Column3
            // 
            Column3.HeaderText = "";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // getTicketInfo
            // 
            getTicketInfo.Location = new Point(583, 384);
            getTicketInfo.Name = "getTicketInfo";
            getTicketInfo.Size = new Size(135, 23);
            getTicketInfo.TabIndex = 2;
            getTicketInfo.Text = "Print Boarding Pass";
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
            // bookingView
            // 
            bookingView.AllowUserToAddRows = false;
            bookingView.AllowUserToDeleteRows = false;
            bookingView.BackgroundColor = SystemColors.ControlLightLight;
            bookingView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            bookingView.Location = new Point(6, 36);
            bookingView.MultiSelect = false;
            bookingView.Name = "bookingView";
            bookingView.ReadOnly = true;
            bookingView.RowTemplate.Height = 25;
            bookingView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            bookingView.Size = new Size(505, 342);
            bookingView.TabIndex = 0;
            bookingView.SelectionChanged += bookingView_SelectionChanged;
            // 
            // customerTabSearchFlights
            // 
            customerTabSearchFlights.BackColor = SystemColors.Control;
            customerTabSearchFlights.Controls.Add(labelFlightsNotFound);
            customerTabSearchFlights.Controls.Add(label11);
            customerTabSearchFlights.Controls.Add(label10);
            customerTabSearchFlights.Controls.Add(dataGridViewSearchResultsReturn);
            customerTabSearchFlights.Controls.Add(label9);
            customerTabSearchFlights.Controls.Add(paymentMethod);
            customerTabSearchFlights.Controls.Add(buttonSearch);
            customerTabSearchFlights.Controls.Add(dateTimePickerReturn);
            customerTabSearchFlights.Controls.Add(dateTimePickerDeparture);
            customerTabSearchFlights.Controls.Add(bookFlightBtn);
            customerTabSearchFlights.Controls.Add(label7);
            customerTabSearchFlights.Controls.Add(dataGridViewSearchResultsOutbound);
            customerTabSearchFlights.Controls.Add(radioButtonOneWay);
            customerTabSearchFlights.Controls.Add(radioButtonRoundTrip);
            customerTabSearchFlights.Controls.Add(comboBoxTo);
            customerTabSearchFlights.Controls.Add(comboBoxFrom);
            customerTabSearchFlights.Controls.Add(label5);
            customerTabSearchFlights.Controls.Add(label6);
            customerTabSearchFlights.Controls.Add(label4);
            customerTabSearchFlights.Controls.Add(label3);
            customerTabSearchFlights.Location = new Point(4, 24);
            customerTabSearchFlights.Name = "customerTabSearchFlights";
            customerTabSearchFlights.Padding = new Padding(3);
            customerTabSearchFlights.Size = new Size(788, 416);
            customerTabSearchFlights.TabIndex = 1;
            customerTabSearchFlights.Text = "Search for flights";
            // 
            // labelFlightsNotFound
            // 
            labelFlightsNotFound.AutoSize = true;
            labelFlightsNotFound.ForeColor = SystemColors.Highlight;
            labelFlightsNotFound.Location = new Point(86, 251);
            labelFlightsNotFound.Name = "labelFlightsNotFound";
            labelFlightsNotFound.Size = new Size(176, 30);
            labelFlightsNotFound.TabIndex = 23;
            labelFlightsNotFound.Text = "No flights were found matching\r\nthe search criteria\r\n";
            labelFlightsNotFound.TextAlign = ContentAlignment.MiddleCenter;
            labelFlightsNotFound.Visible = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(208, 388);
            label11.Name = "label11";
            label11.Size = new Size(91, 15);
            label11.TabIndex = 22;
            label11.Text = "Points Available";
            label11.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(319, 199);
            label10.Name = "label10";
            label10.Size = new Size(79, 15);
            label10.TabIndex = 21;
            label10.Text = "Return results";
            // 
            // dataGridViewSearchResultsReturn
            // 
            dataGridViewSearchResultsReturn.AllowUserToAddRows = false;
            dataGridViewSearchResultsReturn.AllowUserToDeleteRows = false;
            dataGridViewSearchResultsReturn.BackgroundColor = SystemColors.Control;
            dataGridViewSearchResultsReturn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSearchResultsReturn.Location = new Point(319, 217);
            dataGridViewSearchResultsReturn.MultiSelect = false;
            dataGridViewSearchResultsReturn.Name = "dataGridViewSearchResultsReturn";
            dataGridViewSearchResultsReturn.ReadOnly = true;
            dataGridViewSearchResultsReturn.RowTemplate.Height = 25;
            dataGridViewSearchResultsReturn.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewSearchResultsReturn.Size = new Size(463, 161);
            dataGridViewSearchResultsReturn.TabIndex = 20;
            dataGridViewSearchResultsReturn.SelectionChanged += UpdateBookFlightBtnState;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(339, 388);
            label9.Name = "label9";
            label9.Size = new Size(99, 15);
            label9.TabIndex = 19;
            label9.Text = "Payment Method";
            // 
            // paymentMethod
            // 
            paymentMethod.FormattingEnabled = true;
            paymentMethod.Location = new Point(444, 384);
            paymentMethod.Name = "paymentMethod";
            paymentMethod.Size = new Size(121, 23);
            paymentMethod.TabIndex = 18;
            // 
            // buttonSearch
            // 
            buttonSearch.Enabled = false;
            buttonSearch.Location = new Point(45, 221);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(254, 23);
            buttonSearch.TabIndex = 17;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // dateTimePickerReturn
            // 
            dateTimePickerReturn.Enabled = false;
            dateTimePickerReturn.Format = DateTimePickerFormat.Short;
            dateTimePickerReturn.Location = new Point(45, 192);
            dateTimePickerReturn.MinDate = new DateTime(2023, 4, 21, 0, 0, 0, 0);
            dateTimePickerReturn.Name = "dateTimePickerReturn";
            dateTimePickerReturn.Size = new Size(99, 23);
            dateTimePickerReturn.TabIndex = 16;
            // 
            // dateTimePickerDeparture
            // 
            dateTimePickerDeparture.Format = DateTimePickerFormat.Short;
            dateTimePickerDeparture.Location = new Point(45, 139);
            dateTimePickerDeparture.MinDate = new DateTime(2023, 4, 21, 0, 0, 0, 0);
            dateTimePickerDeparture.Name = "dateTimePickerDeparture";
            dateTimePickerDeparture.Size = new Size(99, 23);
            dateTimePickerDeparture.TabIndex = 15;
            dateTimePickerDeparture.ValueChanged += dateTimePickerDeparture_ValueChanged;
            // 
            // bookFlightBtn
            // 
            bookFlightBtn.Enabled = false;
            bookFlightBtn.Location = new Point(584, 384);
            bookFlightBtn.Name = "bookFlightBtn";
            bookFlightBtn.Size = new Size(197, 23);
            bookFlightBtn.TabIndex = 14;
            bookFlightBtn.Text = "Book flight";
            bookFlightBtn.UseVisualStyleBackColor = true;
            bookFlightBtn.Click += bookFlightBtn_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(319, 13);
            label7.Name = "label7";
            label7.Size = new Size(99, 15);
            label7.TabIndex = 13;
            label7.Text = "Outbound results";
            // 
            // dataGridViewSearchResultsOutbound
            // 
            dataGridViewSearchResultsOutbound.AllowUserToAddRows = false;
            dataGridViewSearchResultsOutbound.AllowUserToDeleteRows = false;
            dataGridViewSearchResultsOutbound.BackgroundColor = SystemColors.Control;
            dataGridViewSearchResultsOutbound.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSearchResultsOutbound.Location = new Point(319, 31);
            dataGridViewSearchResultsOutbound.MultiSelect = false;
            dataGridViewSearchResultsOutbound.Name = "dataGridViewSearchResultsOutbound";
            dataGridViewSearchResultsOutbound.ReadOnly = true;
            dataGridViewSearchResultsOutbound.RowTemplate.Height = 25;
            dataGridViewSearchResultsOutbound.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewSearchResultsOutbound.Size = new Size(463, 161);
            dataGridViewSearchResultsOutbound.TabIndex = 12;
            dataGridViewSearchResultsOutbound.SelectionChanged += UpdateBookFlightBtnState;
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
            radioButtonOneWay.CheckedChanged += radioButtonOneWay_CheckedChanged;
            // 
            // radioButtonRoundTrip
            // 
            radioButtonRoundTrip.AutoSize = true;
            radioButtonRoundTrip.Location = new Point(45, 87);
            radioButtonRoundTrip.Name = "radioButtonRoundTrip";
            radioButtonRoundTrip.Size = new Size(78, 19);
            radioButtonRoundTrip.TabIndex = 10;
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
            comboBoxTo.SelectedIndexChanged += comboBox_SelectedIndexChanged;
            // 
            // comboBoxFrom
            // 
            comboBoxFrom.FormattingEnabled = true;
            comboBoxFrom.Location = new Point(45, 49);
            comboBoxFrom.Name = "comboBoxFrom";
            comboBoxFrom.Size = new Size(121, 23);
            comboBoxFrom.TabIndex = 8;
            comboBoxFrom.SelectedIndexChanged += comboBox_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 174);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 7;
            label5.Text = "Return date";
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
            customerTabProfile.BackColor = SystemColors.Control;
            customerTabProfile.Controls.Add(btnSubmitPasswordChange);
            customerTabProfile.Controls.Add(label14);
            customerTabProfile.Controls.Add(txtNewPass);
            customerTabProfile.Controls.Add(label13);
            customerTabProfile.Controls.Add(txtCurrentPass);
            customerTabProfile.Controls.Add(label12);
            customerTabProfile.Controls.Add(dataGridViewProfile);
            customerTabProfile.Controls.Add(label8);
            customerTabProfile.Location = new Point(4, 24);
            customerTabProfile.Name = "customerTabProfile";
            customerTabProfile.Padding = new Padding(3);
            customerTabProfile.Size = new Size(788, 416);
            customerTabProfile.TabIndex = 2;
            customerTabProfile.Text = "My Profile";
            // 
            // btnSubmitPasswordChange
            // 
            btnSubmitPasswordChange.Location = new Point(144, 336);
            btnSubmitPasswordChange.Name = "btnSubmitPasswordChange";
            btnSubmitPasswordChange.Size = new Size(98, 23);
            btnSubmitPasswordChange.TabIndex = 8;
            btnSubmitPasswordChange.Text = "Submit";
            btnSubmitPasswordChange.UseVisualStyleBackColor = true;
            btnSubmitPasswordChange.Click += btnSubmitPasswordChange_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(24, 310);
            label14.Name = "label14";
            label14.Size = new Size(84, 15);
            label14.TabIndex = 7;
            label14.Text = "New password";
            // 
            // txtNewPass
            // 
            txtNewPass.Location = new Point(114, 307);
            txtNewPass.Name = "txtNewPass";
            txtNewPass.PasswordChar = '*';
            txtNewPass.Size = new Size(128, 23);
            txtNewPass.TabIndex = 6;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(8, 281);
            label13.Name = "label13";
            label13.Size = new Size(100, 15);
            label13.TabIndex = 5;
            label13.Text = "Current password";
            // 
            // txtCurrentPass
            // 
            txtCurrentPass.Location = new Point(114, 278);
            txtCurrentPass.Name = "txtCurrentPass";
            txtCurrentPass.PasswordChar = '*';
            txtCurrentPass.Size = new Size(128, 23);
            txtCurrentPass.TabIndex = 4;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(83, 246);
            label12.Name = "label12";
            label12.Size = new Size(159, 20);
            label12.TabIndex = 3;
            label12.Text = "Change your password";
            // 
            // dataGridViewProfile
            // 
            dataGridViewProfile.AllowUserToAddRows = false;
            dataGridViewProfile.AllowUserToDeleteRows = false;
            dataGridViewProfile.AllowUserToResizeColumns = false;
            dataGridViewProfile.AllowUserToResizeRows = false;
            dataGridViewProfile.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridViewProfile.BackgroundColor = SystemColors.Control;
            dataGridViewProfile.BorderStyle = BorderStyle.None;
            dataGridViewProfile.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProfile.ColumnHeadersVisible = false;
            dataGridViewProfile.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridViewProfile.Cursor = Cursors.SizeNESW;
            dataGridViewProfile.Location = new Point(6, 27);
            dataGridViewProfile.Name = "dataGridViewProfile";
            dataGridViewProfile.ReadOnly = true;
            dataGridViewProfile.RowTemplate.Height = 25;
            dataGridViewProfile.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProfile.Size = new Size(544, 216);
            dataGridViewProfile.TabIndex = 2;
            // 
            // Column1
            // 
            Column1.HeaderText = "";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 200;
            // 
            // Column2
            // 
            Column2.HeaderText = "";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 300;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(6, 4);
            label8.Name = "label8";
            label8.Size = new Size(82, 20);
            label8.TabIndex = 1;
            label8.Text = "Profile Info";
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
            BackColor = SystemColors.Control;
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
            ((System.ComponentModel.ISupportInitialize)bookingView).EndInit();
            customerTabSearchFlights.ResumeLayout(false);
            customerTabSearchFlights.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSearchResultsReturn).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSearchResultsOutbound).EndInit();
            customerTabProfile.ResumeLayout(false);
            customerTabProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProfile).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookingBindingSource).EndInit();
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
        private DataGridView bookingView;
        private Label label5;
        private Label label6;
        private Label label4;
        private Label label3;
        private RadioButton radioButtonOneWay;
        private RadioButton radioButtonRoundTrip;
        private ComboBox comboBoxTo;
        private ComboBox comboBoxFrom;
        private DataGridView dataGridViewSearchResultsOutbound;
        private Label label7;
        private Label label8;
        private Button bookFlightBtn;
        private BindingSource bookingBindingSource;
        private DataGridView dataGridViewProfile;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DateTimePicker dateTimePickerReturn;
        private DateTimePicker dateTimePickerDeparture;
        private Button buttonSearch;
        private ComboBox paymentMethod;
        private Label label9;
        private Label label10;
        private DataGridView dataGridViewSearchResultsReturn;
        private Label label11;
        private Button btnCancelFlight;
        private Label label13;
        private TextBox txtCurrentPass;
        private Label label12;
        private Label label14;
        private TextBox txtNewPass;
        private Button btnSubmitPasswordChange;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Label labelFlightsNotFound;
    }
}