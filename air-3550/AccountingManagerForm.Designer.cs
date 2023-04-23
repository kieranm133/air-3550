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
            flightBindingSource = new BindingSource(components);
            dataGridViewFlights = new DataGridView();
            dataGridViewSummary = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)flightBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFlights).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSummary).BeginInit();
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
            // flightBindingSource
            // 
            flightBindingSource.DataSource = typeof(Models.Flight);
            // 
            // dataGridViewFlights
            // 
            dataGridViewFlights.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFlights.Location = new Point(12, 12);
            dataGridViewFlights.Name = "dataGridViewFlights";
            dataGridViewFlights.RowTemplate.Height = 25;
            dataGridViewFlights.Size = new Size(658, 329);
            dataGridViewFlights.TabIndex = 2;
            // 
            // dataGridViewSummary
            // 
            dataGridViewSummary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSummary.Location = new Point(12, 347);
            dataGridViewSummary.Name = "dataGridViewSummary";
            dataGridViewSummary.RowTemplate.Height = 25;
            dataGridViewSummary.Size = new Size(226, 84);
            dataGridViewSummary.TabIndex = 4;
            // 
            // AccountingManagerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(841, 443);
            Controls.Add(dataGridViewSummary);
            Controls.Add(dataGridViewFlights);
            Controls.Add(btnLogout);
            Name = "AccountingManagerForm";
            Text = "Accounting Manager Form";
            Load += AccountingManagerForm_Load;
            ((System.ComponentModel.ISupportInitialize)flightBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFlights).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSummary).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnLogout;
        private BindingSource flightBindingSource;
        private DataGridView dataGridViewFlights;
        private DataGridView dataGridViewSummary;
    }
}