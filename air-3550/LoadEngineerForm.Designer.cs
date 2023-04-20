﻿namespace air_3550
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
            dataGridViewSchedule.CellBorderStyle = DataGridViewCellBorderStyle.RaisedVertical;
            dataGridViewSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSchedule.Location = new Point(12, 129);
            dataGridViewSchedule.Name = "dataGridViewSchedule";
            dataGridViewSchedule.RowTemplate.Height = 25;
            dataGridViewSchedule.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewSchedule.Size = new Size(650, 271);
            dataGridViewSchedule.TabIndex = 2;
            // 
            // comboBoxOrigin
            // 
            comboBoxOrigin.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxOrigin.FormattingEnabled = true;
            comboBoxOrigin.Location = new Point(89, 13);
            comboBoxOrigin.Name = "comboBoxOrigin";
            comboBoxOrigin.Size = new Size(221, 23);
            comboBoxOrigin.TabIndex = 3;
            comboBoxOrigin.SelectedIndexChanged += comboBox_SelectedIndexChanged;
            // 
            // comboBoxDestination
            // 
            comboBoxDestination.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDestination.FormattingEnabled = true;
            comboBoxDestination.Location = new Point(89, 42);
            comboBoxDestination.Name = "comboBoxDestination";
            comboBoxDestination.Size = new Size(221, 23);
            comboBoxDestination.TabIndex = 4;
            comboBoxDestination.SelectedIndexChanged += comboBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 16);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 5;
            label1.Text = "Origin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 45);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 6;
            label2.Text = "Destination";
            // 
            // btnRemoveFromSchedule
            // 
            btnRemoveFromSchedule.Enabled = false;
            btnRemoveFromSchedule.Location = new Point(513, 406);
            btnRemoveFromSchedule.Name = "btnRemoveFromSchedule";
            btnRemoveFromSchedule.Size = new Size(149, 23);
            btnRemoveFromSchedule.TabIndex = 7;
            btnRemoveFromSchedule.Text = "Remove from schedule";
            btnRemoveFromSchedule.UseVisualStyleBackColor = true;
            // 
            // btnAddToSchedule
            // 
            btnAddToSchedule.Enabled = false;
            btnAddToSchedule.Location = new Point(171, 100);
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
            dateTimePickerDepartureTime.Location = new Point(235, 71);
            dateTimePickerDepartureTime.Name = "dateTimePickerDepartureTime";
            dateTimePickerDepartureTime.ShowUpDown = true;
            dateTimePickerDepartureTime.Size = new Size(75, 23);
            dateTimePickerDepartureTime.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(143, 75);
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