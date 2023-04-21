namespace air_3550
{
    partial class MarketingManagerForm
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
            btn_ViewFlights = new Button();
            comboBoxPlanesAvailable = new ComboBox();
            btn_ViewPlanes = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Scheduled_Flights).BeginInit();
            SuspendLayout();
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(896, 12);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 23);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // dataGridView_Scheduled_Flights
            // 
            dataGridView_Scheduled_Flights.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Scheduled_Flights.Location = new Point(12, 12);
            dataGridView_Scheduled_Flights.Name = "dataGridView_Scheduled_Flights";
            dataGridView_Scheduled_Flights.RowTemplate.Height = 25;
            dataGridView_Scheduled_Flights.Size = new Size(598, 218);
            dataGridView_Scheduled_Flights.TabIndex = 2;
            // 
            // btn_ViewFlights
            // 
            btn_ViewFlights.AccessibleDescription = "View Flights";
            btn_ViewFlights.AccessibleName = "View Flights";
            btn_ViewFlights.Location = new Point(12, 245);
            btn_ViewFlights.Name = "btn_ViewFlights";
            btn_ViewFlights.Size = new Size(105, 23);
            btn_ViewFlights.TabIndex = 3;
            btn_ViewFlights.Text = "View Flights";
            btn_ViewFlights.UseVisualStyleBackColor = true;
            btn_ViewFlights.Click += btn_ViewFlights_Click;
            // 
            // comboBoxPlanesAvailable
            // 
            comboBoxPlanesAvailable.FormattingEnabled = true;
            comboBoxPlanesAvailable.Location = new Point(641, 12);
            comboBoxPlanesAvailable.Name = "comboBoxPlanesAvailable";
            comboBoxPlanesAvailable.Size = new Size(121, 23);
            comboBoxPlanesAvailable.TabIndex = 4;
            comboBoxPlanesAvailable.SelectedIndexChanged += comboBoxPlanesAvailable_SelectedIndexChanged;
            // 
            // btn_ViewPlanes
            // 
            btn_ViewPlanes.Location = new Point(768, 12);
            btn_ViewPlanes.Name = "btn_ViewPlanes";
            btn_ViewPlanes.Size = new Size(83, 23);
            btn_ViewPlanes.TabIndex = 5;
            btn_ViewPlanes.Text = "View Planes";
            btn_ViewPlanes.UseVisualStyleBackColor = true;
            btn_ViewPlanes.Click += btn_ViewPlanes_Click;
            // 
            // MarketingManagerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(983, 549);
            Controls.Add(btn_ViewPlanes);
            Controls.Add(comboBoxPlanesAvailable);
            Controls.Add(btn_ViewFlights);
            Controls.Add(dataGridView_Scheduled_Flights);
            Controls.Add(btnLogout);
            Name = "MarketingManagerForm";
            Text = "Marketing Manager Form";
            ((System.ComponentModel.ISupportInitialize)dataGridView_Scheduled_Flights).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnLogout;
        private DataGridView dataGridView_Scheduled_Flights;
        private Button btn_ViewFlights;
        private ComboBox comboBoxPlanesAvailable;
        private Button btn_ViewPlanes;
    }
}