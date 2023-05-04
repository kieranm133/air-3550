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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            tabControl1 = new TabControl();
            customerTabMyFlights = new TabPage();
            btnRightArrow = new Button();
            btnLeftArrow = new Button();
            tabBookings = new TabControl();
            tabCurrentlyBooked = new TabPage();
            currentBookingsView = new DataGridView();
            tabPreviousFlights = new TabPage();
            previousBookingsView = new DataGridView();
            tabCancelledFlights = new TabPage();
            cancelledBookingsView = new DataGridView();
            btnCancelFlight = new Button();
            boardingPassLabel = new Label();
            boardingPassView = new DataGridView();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            getTicketInfo = new Button();
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
            tabBookings.SuspendLayout();
            tabCurrentlyBooked.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)currentBookingsView).BeginInit();
            tabPreviousFlights.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)previousBookingsView).BeginInit();
            tabCancelledFlights.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cancelledBookingsView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)boardingPassView).BeginInit();
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
            customerTabMyFlights.Controls.Add(btnRightArrow);
            customerTabMyFlights.Controls.Add(btnLeftArrow);
            customerTabMyFlights.Controls.Add(tabBookings);
            customerTabMyFlights.Controls.Add(btnCancelFlight);
            customerTabMyFlights.Controls.Add(boardingPassLabel);
            customerTabMyFlights.Controls.Add(boardingPassView);
            customerTabMyFlights.Controls.Add(getTicketInfo);
            customerTabMyFlights.Location = new Point(4, 24);
            customerTabMyFlights.Name = "customerTabMyFlights";
            customerTabMyFlights.Padding = new Padding(3);
            customerTabMyFlights.Size = new Size(788, 416);
            customerTabMyFlights.TabIndex = 0;
            customerTabMyFlights.Text = "My Flights";
            customerTabMyFlights.UseVisualStyleBackColor = true;
            // 
            // btnRightArrow
            // 
            btnRightArrow.Location = new Point(654, 320);
            btnRightArrow.Name = "btnRightArrow";
            btnRightArrow.Size = new Size(127, 23);
            btnRightArrow.TabIndex = 8;
            btnRightArrow.Text = ">";
            btnRightArrow.UseVisualStyleBackColor = true;
            btnRightArrow.Visible = false;
            btnRightArrow.Click += btnRightArrow_Click;
            // 
            // btnLeftArrow
            // 
            btnLeftArrow.Location = new Point(517, 320);
            btnLeftArrow.Name = "btnLeftArrow";
            btnLeftArrow.Size = new Size(127, 23);
            btnLeftArrow.TabIndex = 7;
            btnLeftArrow.Text = "<";
            btnLeftArrow.UseVisualStyleBackColor = true;
            btnLeftArrow.Visible = false;
            btnLeftArrow.Click += btnLeftArrow_Click;
            // 
            // tabBookings
            // 
            tabBookings.Controls.Add(tabCurrentlyBooked);
            tabBookings.Controls.Add(tabPreviousFlights);
            tabBookings.Controls.Add(tabCancelledFlights);
            tabBookings.Location = new Point(6, 12);
            tabBookings.Name = "tabBookings";
            tabBookings.SelectedIndex = 0;
            tabBookings.Size = new Size(505, 370);
            tabBookings.TabIndex = 6;
            tabBookings.SelectedIndexChanged += tabBookings_SelectedIndexChanged;
            // 
            // tabCurrentlyBooked
            // 
            tabCurrentlyBooked.Controls.Add(currentBookingsView);
            tabCurrentlyBooked.Location = new Point(4, 24);
            tabCurrentlyBooked.Name = "tabCurrentlyBooked";
            tabCurrentlyBooked.Padding = new Padding(3);
            tabCurrentlyBooked.Size = new Size(497, 342);
            tabCurrentlyBooked.TabIndex = 0;
            tabCurrentlyBooked.Text = "Currently booked flights";
            tabCurrentlyBooked.UseVisualStyleBackColor = true;
            // 
            // currentBookingsView
            // 
            currentBookingsView.AllowUserToAddRows = false;
            currentBookingsView.AllowUserToDeleteRows = false;
            currentBookingsView.AllowUserToResizeColumns = false;
            currentBookingsView.AllowUserToResizeRows = false;
            currentBookingsView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            currentBookingsView.BackgroundColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            currentBookingsView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            currentBookingsView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            currentBookingsView.DefaultCellStyle = dataGridViewCellStyle2;
            currentBookingsView.Location = new Point(0, 0);
            currentBookingsView.MultiSelect = false;
            currentBookingsView.Name = "currentBookingsView";
            currentBookingsView.ReadOnly = true;
            currentBookingsView.RowHeadersVisible = false;
            currentBookingsView.RowTemplate.Height = 25;
            currentBookingsView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            currentBookingsView.Size = new Size(497, 342);
            currentBookingsView.TabIndex = 0;
            currentBookingsView.SelectionChanged += bookingsView_SelectionChanged;
            // 
            // tabPreviousFlights
            // 
            tabPreviousFlights.Controls.Add(previousBookingsView);
            tabPreviousFlights.Location = new Point(4, 24);
            tabPreviousFlights.Name = "tabPreviousFlights";
            tabPreviousFlights.Padding = new Padding(3);
            tabPreviousFlights.Size = new Size(497, 342);
            tabPreviousFlights.TabIndex = 1;
            tabPreviousFlights.Text = "Previous flights";
            tabPreviousFlights.UseVisualStyleBackColor = true;
            // 
            // previousBookingsView
            // 
            previousBookingsView.AllowUserToAddRows = false;
            previousBookingsView.AllowUserToDeleteRows = false;
            previousBookingsView.AllowUserToResizeColumns = false;
            previousBookingsView.AllowUserToResizeRows = false;
            previousBookingsView.BackgroundColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            previousBookingsView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            previousBookingsView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            previousBookingsView.Location = new Point(0, 0);
            previousBookingsView.MultiSelect = false;
            previousBookingsView.Name = "previousBookingsView";
            previousBookingsView.ReadOnly = true;
            previousBookingsView.RowHeadersVisible = false;
            previousBookingsView.RowTemplate.Height = 25;
            previousBookingsView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            previousBookingsView.Size = new Size(497, 342);
            previousBookingsView.TabIndex = 1;
            // 
            // tabCancelledFlights
            // 
            tabCancelledFlights.Controls.Add(cancelledBookingsView);
            tabCancelledFlights.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tabCancelledFlights.Location = new Point(4, 24);
            tabCancelledFlights.Name = "tabCancelledFlights";
            tabCancelledFlights.Padding = new Padding(3);
            tabCancelledFlights.Size = new Size(497, 342);
            tabCancelledFlights.TabIndex = 2;
            tabCancelledFlights.Text = "Cancelled flights";
            tabCancelledFlights.UseVisualStyleBackColor = true;
            // 
            // cancelledBookingsView
            // 
            cancelledBookingsView.AllowUserToAddRows = false;
            cancelledBookingsView.AllowUserToDeleteRows = false;
            cancelledBookingsView.AllowUserToResizeColumns = false;
            cancelledBookingsView.AllowUserToResizeRows = false;
            cancelledBookingsView.BackgroundColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            cancelledBookingsView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            cancelledBookingsView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            cancelledBookingsView.DefaultCellStyle = dataGridViewCellStyle5;
            cancelledBookingsView.Location = new Point(0, 0);
            cancelledBookingsView.MultiSelect = false;
            cancelledBookingsView.Name = "cancelledBookingsView";
            cancelledBookingsView.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            cancelledBookingsView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            cancelledBookingsView.RowHeadersVisible = false;
            cancelledBookingsView.RowTemplate.Height = 25;
            cancelledBookingsView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            cancelledBookingsView.Size = new Size(497, 342);
            cancelledBookingsView.TabIndex = 1;
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
            // boardingPassLabel
            // 
            boardingPassLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            boardingPassLabel.Location = new Point(576, 12);
            boardingPassLabel.Name = "boardingPassLabel";
            boardingPassLabel.Size = new Size(146, 21);
            boardingPassLabel.TabIndex = 4;
            boardingPassLabel.Text = "Boarding pass info";
            boardingPassLabel.TextAlign = ContentAlignment.MiddleCenter;
            boardingPassLabel.Visible = false;
            // 
            // boardingPassView
            // 
            boardingPassView.AllowUserToAddRows = false;
            boardingPassView.AllowUserToResizeColumns = false;
            boardingPassView.AllowUserToResizeRows = false;
            boardingPassView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            boardingPassView.BackgroundColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            boardingPassView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            boardingPassView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            boardingPassView.ColumnHeadersVisible = false;
            boardingPassView.Columns.AddRange(new DataGridViewColumn[] { Column3, Column4 });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Window;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            boardingPassView.DefaultCellStyle = dataGridViewCellStyle8;
            boardingPassView.Location = new Point(517, 36);
            boardingPassView.Name = "boardingPassView";
            boardingPassView.ReadOnly = true;
            boardingPassView.RowHeadersVisible = false;
            boardingPassView.RowTemplate.Height = 25;
            boardingPassView.Size = new Size(264, 278);
            boardingPassView.TabIndex = 2;
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
            getTicketInfo.Enabled = false;
            getTicketInfo.Location = new Point(515, 349);
            getTicketInfo.Name = "getTicketInfo";
            getTicketInfo.Size = new Size(268, 58);
            getTicketInfo.TabIndex = 2;
            getTicketInfo.Text = "Print Boarding Pass";
            getTicketInfo.UseVisualStyleBackColor = true;
            getTicketInfo.Click += getTicketInfo_Click;
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
            dataGridViewSearchResultsReturn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridViewSearchResultsReturn.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            dataGridViewSearchResultsReturn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewSearchResultsReturn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSearchResultsReturn.Location = new Point(319, 217);
            dataGridViewSearchResultsReturn.MultiSelect = false;
            dataGridViewSearchResultsReturn.Name = "dataGridViewSearchResultsReturn";
            dataGridViewSearchResultsReturn.ReadOnly = true;
            dataGridViewSearchResultsReturn.RowHeadersVisible = false;
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
            dataGridViewSearchResultsOutbound.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridViewSearchResultsOutbound.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.Control;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            dataGridViewSearchResultsOutbound.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewSearchResultsOutbound.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSearchResultsOutbound.Location = new Point(319, 31);
            dataGridViewSearchResultsOutbound.MultiSelect = false;
            dataGridViewSearchResultsOutbound.Name = "dataGridViewSearchResultsOutbound";
            dataGridViewSearchResultsOutbound.ReadOnly = true;
            dataGridViewSearchResultsOutbound.RowHeadersVisible = false;
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
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = SystemColors.Window;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Window;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            dataGridViewProfile.DefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewProfile.Location = new Point(6, 27);
            dataGridViewProfile.Name = "dataGridViewProfile";
            dataGridViewProfile.ReadOnly = true;
            dataGridViewProfile.RowHeadersVisible = false;
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
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Air 3550";
            Load += CustomerForm_Load;
            tabControl1.ResumeLayout(false);
            customerTabMyFlights.ResumeLayout(false);
            tabBookings.ResumeLayout(false);
            tabCurrentlyBooked.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)currentBookingsView).EndInit();
            tabPreviousFlights.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)previousBookingsView).EndInit();
            tabCancelledFlights.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)cancelledBookingsView).EndInit();
            ((System.ComponentModel.ISupportInitialize)boardingPassView).EndInit();
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
        private Label boardingPassLabel;
        private DataGridView boardingPassView;
        private Button getTicketInfo;
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
        private Button btnRightArrow;
        private Button btnLeftArrow;
        private TabControl tabBookings;
        private TabPage tabCurrentlyBooked;
        private DataGridView currentBookingsView;
        private TabPage tabPreviousFlights;
        private DataGridView previousBookingsView;
        private TabPage tabCancelledFlights;
        private DataGridView cancelledBookingsView;
    }
}