namespace air_3550
{
    partial class LoadEngineerForm
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
            btnLogout = new Button();
            dataGridViewSchedule = new DataGridView();
            comboBoxOrigin = new ComboBox();
            comboBoxDestination = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            btnRemoveFromSchedule = new Button();
            btnAddToSchedule = new Button();
            dateTimePickerDepartureTime = new DateTimePicker();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSchedule).BeginInit();
            SuspendLayout();
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(713, 12);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 23);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // dataGridViewSchedule
            // 
            dataGridViewSchedule.BackgroundColor = SystemColors.Control;
            dataGridViewSchedule.CellBorderStyle = DataGridViewCellBorderStyle.RaisedVertical;
            dataGridViewSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSchedule.Location = new Point(12, 128);
            dataGridViewSchedule.MultiSelect = false;
            dataGridViewSchedule.Name = "dataGridViewSchedule";
            dataGridViewSchedule.RowTemplate.Height = 25;
            dataGridViewSchedule.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewSchedule.Size = new Size(650, 281);
            dataGridViewSchedule.TabIndex = 2;
            dataGridViewSchedule.SelectionChanged += dataGridViewSchedule_SelectionChanged;
            // 
            // comboBoxOrigin
            // 
            comboBoxOrigin.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxOrigin.FormattingEnabled = true;
            comboBoxOrigin.Location = new Point(341, 12);
            comboBoxOrigin.Name = "comboBoxOrigin";
            comboBoxOrigin.Size = new Size(321, 23);
            comboBoxOrigin.TabIndex = 3;
            comboBoxOrigin.SelectedIndexChanged += comboBox_SelectedIndexChanged;
            // 
            // comboBoxDestination
            // 
            comboBoxDestination.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDestination.FormattingEnabled = true;
            comboBoxDestination.Location = new Point(341, 41);
            comboBoxDestination.Name = "comboBoxDestination";
            comboBoxDestination.Size = new Size(321, 23);
            comboBoxDestination.TabIndex = 4;
            comboBoxDestination.SelectedIndexChanged += comboBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(295, 15);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 5;
            label1.Text = "Origin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(268, 44);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 6;
            label2.Text = "Destination";
            // 
            // btnRemoveFromSchedule
            // 
            btnRemoveFromSchedule.Enabled = false;
            btnRemoveFromSchedule.Location = new Point(513, 415);
            btnRemoveFromSchedule.Name = "btnRemoveFromSchedule";
            btnRemoveFromSchedule.Size = new Size(149, 23);
            btnRemoveFromSchedule.TabIndex = 7;
            btnRemoveFromSchedule.Text = "Remove from schedule";
            btnRemoveFromSchedule.UseVisualStyleBackColor = true;
            btnRemoveFromSchedule.Click += btnRemoveFromSchedule_Click;
            // 
            // btnAddToSchedule
            // 
            btnAddToSchedule.Enabled = false;
            btnAddToSchedule.Location = new Point(523, 99);
            btnAddToSchedule.Name = "btnAddToSchedule";
            btnAddToSchedule.Size = new Size(139, 23);
            btnAddToSchedule.TabIndex = 8;
            btnAddToSchedule.Text = "Add to schedule";
            btnAddToSchedule.UseVisualStyleBackColor = true;
            btnAddToSchedule.Click += btnAddToSchedule_Click;
            // 
            // dateTimePickerDepartureTime
            // 
            dateTimePickerDepartureTime.CustomFormat = "hh:mm tt";
            dateTimePickerDepartureTime.Format = DateTimePickerFormat.Custom;
            dateTimePickerDepartureTime.Location = new Point(587, 70);
            dateTimePickerDepartureTime.Name = "dateTimePickerDepartureTime";
            dateTimePickerDepartureTime.ShowUpDown = true;
            dateTimePickerDepartureTime.Size = new Size(75, 23);
            dateTimePickerDepartureTime.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(495, 74);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 10;
            label3.Text = "Departure time";
            // 
            // LoadEngineerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(dateTimePickerDepartureTime);
            Controls.Add(btnAddToSchedule);
            Controls.Add(btnRemoveFromSchedule);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxDestination);
            Controls.Add(comboBoxOrigin);
            Controls.Add(dataGridViewSchedule);
            Controls.Add(btnLogout);
            Name = "LoadEngineerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Load Engineer Form";
            Load += LoadEngineerForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewSchedule).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogout;
        private DataGridView dataGridViewSchedule;
        private ComboBox comboBoxOrigin;
        private ComboBox comboBoxDestination;
        private Label label1;
        private Label label2;
        private Button btnRemoveFromSchedule;
        private Button btnAddToSchedule;
        private DateTimePicker dateTimePickerDepartureTime;
        private Label label3;
    }
}