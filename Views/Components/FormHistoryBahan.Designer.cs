namespace SiBadir.View
{
    partial class FormHistoryBahan
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
            dataGridViewHistory = new DataGridView();
            btnRefreshHistory = new Button();
            btnHapusHistory = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHistory).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewHistory
            // 
            dataGridViewHistory.BackgroundColor = Color.IndianRed;
            dataGridViewHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHistory.Location = new Point(-4, 165);
            dataGridViewHistory.Name = "dataGridViewHistory";
            dataGridViewHistory.RowHeadersWidth = 62;
            dataGridViewHistory.Size = new Size(1205, 716);
            dataGridViewHistory.TabIndex = 0;
            dataGridViewHistory.CellContentClick += dataGridViewHistory_CellContentClick;
            // 
            // btnRefreshHistory
            // 
            btnRefreshHistory.Location = new Point(312, 43);
            btnRefreshHistory.Name = "btnRefreshHistory";
            btnRefreshHistory.Size = new Size(256, 66);
            btnRefreshHistory.TabIndex = 1;
            btnRefreshHistory.Text = "Refresh";
            btnRefreshHistory.UseVisualStyleBackColor = true;
            btnRefreshHistory.Click += btnRefreshHistory_Click;
            // 
            // btnHapusHistory
            // 
            btnHapusHistory.Location = new Point(646, 43);
            btnHapusHistory.Name = "btnHapusHistory";
            btnHapusHistory.Size = new Size(256, 66);
            btnHapusHistory.TabIndex = 2;
            btnHapusHistory.Text = "Hapus Riwayat";
            btnHapusHistory.UseVisualStyleBackColor = true;
            btnHapusHistory.Click += btnHapusHistory_Click;
            // 
            // FormHistoryBahan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(1197, 875);
            Controls.Add(btnHapusHistory);
            Controls.Add(btnRefreshHistory);
            Controls.Add(dataGridViewHistory);
            Name = "FormHistoryBahan";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewHistory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewHistory;
        private Button btnRefreshHistory;
        private Button btnHapusHistory;
    }
}