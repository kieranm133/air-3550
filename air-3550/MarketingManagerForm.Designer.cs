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
            comboBoxPlanesAvailable = new ComboBox();
            buttonSetPlanes = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Scheduled_Flights).BeginInit();
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
            // dataGridView_Scheduled_Flights
            // 
            dataGridView_Scheduled_Flights.AllowUserToAddRows = false;
            dataGridView_Scheduled_Flights.AllowUserToDeleteRows = false;
            dataGridView_Scheduled_Flights.AllowUserToResizeColumns = false;
            dataGridView_Scheduled_Flights.AllowUserToResizeRows = false;
            dataGridView_Scheduled_Flights.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView_Scheduled_Flights.BackgroundColor = SystemColors.Control;
            dataGridView_Scheduled_Flights.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Scheduled_Flights.Location = new Point(12, 44);
            dataGridView_Scheduled_Flights.Name = "dataGridView_Scheduled_Flights";
            dataGridView_Scheduled_Flights.ReadOnly = true;
            dataGridView_Scheduled_Flights.RowHeadersVisible = false;
            dataGridView_Scheduled_Flights.RowTemplate.Height = 25;
            dataGridView_Scheduled_Flights.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_Scheduled_Flights.Size = new Size(776, 336);
            dataGridView_Scheduled_Flights.TabIndex = 2;
            // 
            // comboBoxPlanesAvailable
            // 
            comboBoxPlanesAvailable.FormattingEnabled = true;
            comboBoxPlanesAvailable.Location = new Point(578, 386);
            comboBoxPlanesAvailable.Name = "comboBoxPlanesAvailable";
            comboBoxPlanesAvailable.Size = new Size(210, 23);
            comboBoxPlanesAvailable.TabIndex = 4;
            comboBoxPlanesAvailable.SelectedIndexChanged += comboBoxPlanesAvailable_SelectedIndexChanged;
            // 
            // buttonSetPlanes
            // 
            buttonSetPlanes.Location = new Point(578, 415);
            buttonSetPlanes.Name = "buttonSetPlanes";
            buttonSetPlanes.Size = new Size(210, 23);
            buttonSetPlanes.TabIndex = 6;
            buttonSetPlanes.Text = "Set planes";
            buttonSetPlanes.UseVisualStyleBackColor = true;
            buttonSetPlanes.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(261, 21);
            label1.TabIndex = 7;
            label1.Text = "Choose aircraft for each flight below";
            // 
            // MarketingManagerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(buttonSetPlanes);
            Controls.Add(comboBoxPlanesAvailable);
            Controls.Add(dataGridView_Scheduled_Flights);
            Controls.Add(btnLogout);
            Name = "MarketingManagerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Aircraft Selection";
            Load += MarketingManagerForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_Scheduled_Flights).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogout;
        private DataGridView dataGridView_Scheduled_Flights;
        private ComboBox comboBoxPlanesAvailable;
        private Button buttonSetPlanes;
        private Label label1;
    }
}