namespace SiBadir
{
    partial class MainMenu
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
            sidebar = new Panel();
            HistoryStokBahanBtn = new Button();
            button2 = new Button();
            button1 = new Button();
            mainContainer = new Panel();
            sidebar.SuspendLayout();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.Controls.Add(HistoryStokBahanBtn);
            sidebar.Controls.Add(button2);
            sidebar.Controls.Add(button1);
            sidebar.Location = new Point(0, 0);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(245, 700);
            sidebar.TabIndex = 0;
            // 
            // HistoryStokBahanBtn
            // 
            HistoryStokBahanBtn.Location = new Point(0, 233);
            HistoryStokBahanBtn.Name = "HistoryStokBahanBtn";
            HistoryStokBahanBtn.Size = new Size(245, 45);
            HistoryStokBahanBtn.TabIndex = 2;
            HistoryStokBahanBtn.Text = "History Stok Bahan";
            HistoryStokBahanBtn.UseVisualStyleBackColor = true;
            HistoryStokBahanBtn.Click += HistoryStokBahanBtn_click;
            // 
            // button2
            // 
            button2.Location = new Point(0, 190);
            button2.Name = "button2";
            button2.Size = new Size(245, 45);
            button2.TabIndex = 1;
            button2.Text = "Stok Bahan";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(0, 147);
            button1.Name = "button1";
            button1.Size = new Size(245, 45);
            button1.TabIndex = 0;
            button1.Text = "Daftar Karyawan";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // mainContainer
            // 
            mainContainer.Location = new Point(242, 0);
            mainContainer.Name = "mainContainer";
            mainContainer.Size = new Size(1086, 700);
            mainContainer.TabIndex = 1;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1330, 700);
            Controls.Add(mainContainer);
            Controls.Add(sidebar);
            Name = "MainMenu";
            Text = "Form1";
            Load += Form1_Load;
            sidebar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel sidebar;
        private Panel mainContainer;
        private Button button1;
        private Button button2;
        private Button HistoryStokBahanBtn;
    }
}