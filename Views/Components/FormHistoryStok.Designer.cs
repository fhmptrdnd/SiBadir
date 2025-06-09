namespace SiBadir.Views.Components
{
    partial class FormHistoryStok
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
            DataHistory = new DataGridView();
            MenuPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)DataHistory).BeginInit();
            SuspendLayout();
            // 
            // DataHistory
            // 
            DataHistory.AllowUserToAddRows = false;
            DataHistory.AllowUserToDeleteRows = false;
            DataHistory.AllowUserToResizeColumns = false;
            DataHistory.AllowUserToResizeRows = false;
            DataHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataHistory.Location = new Point(0, 234);
            DataHistory.Name = "DataHistory";
            DataHistory.RowHeadersWidth = 51;
            DataHistory.Size = new Size(1084, 468);
            DataHistory.TabIndex = 1;
            // 
            // MenuPanel
            // 
            MenuPanel.Location = new Point(0, 0);
            MenuPanel.Name = "MenuPanel";
            MenuPanel.Size = new Size(1084, 235);
            MenuPanel.TabIndex = 2;
            // 
            // FormHistoryStok
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 700);
            Controls.Add(MenuPanel);
            Controls.Add(DataHistory);
            Name = "FormHistoryStok";
            Text = "FormHistoryStok";
            ((System.ComponentModel.ISupportInitialize)DataHistory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DataHistory;
        private Panel MenuPanel;
    }
}