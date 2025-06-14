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
            MenuPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHistory).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewHistory
            // 
            dataGridViewHistory.BackgroundColor = Color.IndianRed;
            dataGridViewHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHistory.Location = new Point(-8, 241);
            dataGridViewHistory.Name = "dataGridViewHistory";
            dataGridViewHistory.RowHeadersWidth = 62;
            dataGridViewHistory.Size = new Size(1215, 638);
            dataGridViewHistory.TabIndex = 0;
            dataGridViewHistory.CellContentClick += dataGridViewHistory_CellContentClick;
            // 
            // MenuPanel
            // 
            MenuPanel.Location = new Point(0, 0);
            MenuPanel.Name = "MenuPanel";
            MenuPanel.Size = new Size(1196, 235);
            MenuPanel.TabIndex = 3;
            // 
            // FormHistoryBahan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(1197, 875);
            Controls.Add(MenuPanel);
            Controls.Add(dataGridViewHistory);
            Name = "FormHistoryBahan";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewHistory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewHistory;
        private Panel MenuPanel;
    }
}