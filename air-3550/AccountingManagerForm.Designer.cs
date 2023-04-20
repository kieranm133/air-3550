namespace air_3550
{
    partial class AccountingManagerForm
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
            btnLogout = new Button();
            dataGridView1 = new DataGridView();
            flightIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            scheduledFlightIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            departureDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            arrivalDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            flightBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)flightBindingSource).BeginInit();
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
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { flightIDDataGridViewTextBoxColumn, scheduledFlightIDDataGridViewTextBoxColumn, departureDateDataGridViewTextBoxColumn, arrivalDateDataGridViewTextBoxColumn });
            dataGridView1.DataSource = flightBindingSource;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(442, 400);
            dataGridView1.TabIndex = 2;
            // 
            // flightIDDataGridViewTextBoxColumn
            // 
            flightIDDataGridViewTextBoxColumn.DataPropertyName = "FlightID";
            flightIDDataGridViewTextBoxColumn.HeaderText = "FlightID";
            flightIDDataGridViewTextBoxColumn.Name = "flightIDDataGridViewTextBoxColumn";
            // 
            // scheduledFlightIDDataGridViewTextBoxColumn
            // 
            scheduledFlightIDDataGridViewTextBoxColumn.DataPropertyName = "ScheduledFlightID";
            scheduledFlightIDDataGridViewTextBoxColumn.HeaderText = "ScheduledFlightID";
            scheduledFlightIDDataGridViewTextBoxColumn.Name = "scheduledFlightIDDataGridViewTextBoxColumn";
            // 
            // departureDateDataGridViewTextBoxColumn
            // 
            departureDateDataGridViewTextBoxColumn.DataPropertyName = "DepartureDate";
            departureDateDataGridViewTextBoxColumn.HeaderText = "DepartureDate";
            departureDateDataGridViewTextBoxColumn.Name = "departureDateDataGridViewTextBoxColumn";
            // 
            // arrivalDateDataGridViewTextBoxColumn
            // 
            arrivalDateDataGridViewTextBoxColumn.DataPropertyName = "ArrivalDate";
            arrivalDateDataGridViewTextBoxColumn.HeaderText = "ArrivalDate";
            arrivalDateDataGridViewTextBoxColumn.Name = "arrivalDateDataGridViewTextBoxColumn";
            // 
            // flightBindingSource
            // 
            flightBindingSource.DataSource = typeof(Models.Flight);
            // 
            // AccountingManagerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnLogout);
            Name = "AccountingManagerForm";
            Text = "Accounting Manager Form";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)flightBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnLogout;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn flightIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn scheduledFlightIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn departureDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn arrivalDateDataGridViewTextBoxColumn;
        private BindingSource flightBindingSource;
    }
}