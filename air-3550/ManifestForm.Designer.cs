namespace air_3550
{
    partial class ManifestForm
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
            dataGridViewManifest = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewManifest).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewManifest
            // 
            dataGridViewManifest.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewManifest.Location = new Point(12, 12);
            dataGridViewManifest.Name = "dataGridViewManifest";
            dataGridViewManifest.RowTemplate.Height = 25;
            dataGridViewManifest.Size = new Size(776, 426);
            dataGridViewManifest.TabIndex = 0;
            dataGridViewManifest.CellContentClick += dataGridViewManifest_CellContentClick;
            // 
            // ManifestForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewManifest);
            Name = "ManifestForm";
            Text = "ManifestForm";
            Load += ManifestForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewManifest).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewManifest;
    }
}