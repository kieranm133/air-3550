namespace air_3550
{
    partial class FlightManagerForm
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
            dataGridView_Scheduled_Flights = new DataGridView();
            btnViewManifest = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Scheduled_Flights).BeginInit();
            SuspendLayout();
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(713, 12);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 23);
            btnLogout.TabIndex = 0;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // dataGridView_Scheduled_Flights
            // 
            dataGridView_Scheduled_Flights.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Scheduled_Flights.Location = new Point(0, 12);
            dataGridView_Scheduled_Flights.Name = "dataGridView_Scheduled_Flights";
            dataGridView_Scheduled_Flights.RowTemplate.Height = 25;
            dataGridView_Scheduled_Flights.Size = new Size(654, 330);
            dataGridView_Scheduled_Flights.TabIndex = 1;
            // 
            // btnViewManifest
            // 
            btnViewManifest.Location = new Point(534, 348);
            btnViewManifest.Name = "btnViewManifest";
            btnViewManifest.Size = new Size(120, 23);
            btnViewManifest.TabIndex = 2;
            btnViewManifest.Text = "View Manifest";
            btnViewManifest.UseVisualStyleBackColor = true;
            btnViewManifest.Click += btnViewManifest_Click;
            // 
            // FlightManagerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnViewManifest);
            Controls.Add(dataGridView_Scheduled_Flights);
            Controls.Add(btnLogout);
            Name = "FlightManagerForm";
            Text = "Flight Manager Form";
            Load += FlightManagerForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_Scheduled_Flights).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnLogout;
        private DataGridView dataGridView_AllFlights;
        private DataGridView dataGridView_Scheduled_Flights;
        private Button btnViewManifest;
    }
}