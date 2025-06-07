namespace SiBadir.View
{
    partial class TambahKaryawan
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
            Return_Button = new Button();
            NamaKaryawanTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            AlamatKaryawanTextBox = new TextBox();
            SubmitBtn = new Button();
            labelMenu = new Label();
            SuspendLayout();
            // 
            // Return_Button
            // 
            Return_Button.Location = new Point(12, 59);
            Return_Button.Name = "Return_Button";
            Return_Button.Size = new Size(254, 110);
            Return_Button.TabIndex = 5;
            Return_Button.Text = "Kembali";
            Return_Button.UseVisualStyleBackColor = true;
            Return_Button.Click += Return_Button_Click;
            // 
            // NamaKaryawanTextBox
            // 
            NamaKaryawanTextBox.Location = new Point(477, 59);
            NamaKaryawanTextBox.Name = "NamaKaryawanTextBox";
            NamaKaryawanTextBox.Size = new Size(323, 27);
            NamaKaryawanTextBox.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(332, 62);
            label1.Name = "label1";
            label1.Size = new Size(117, 20);
            label1.TabIndex = 7;
            label1.Text = "Nama Karyawan";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(332, 104);
            label2.Name = "label2";
            label2.Size = new Size(125, 20);
            label2.TabIndex = 8;
            label2.Text = "Alamat Karyawan";
            // 
            // AlamatKaryawanTextBox
            // 
            AlamatKaryawanTextBox.Location = new Point(477, 101);
            AlamatKaryawanTextBox.Name = "AlamatKaryawanTextBox";
            AlamatKaryawanTextBox.Size = new Size(323, 27);
            AlamatKaryawanTextBox.TabIndex = 9;
            // 
            // SubmitBtn
            // 
            SubmitBtn.Location = new Point(864, 59);
            SubmitBtn.Name = "SubmitBtn";
            SubmitBtn.Size = new Size(187, 102);
            SubmitBtn.TabIndex = 10;
            //SubmitBtn.Text = "Tambah";
            SubmitBtn.UseVisualStyleBackColor = true;
            SubmitBtn.Click += SubmitBtn_Click;
            // 
            // labelMenu
            // 
            labelMenu.AutoSize = true;
            labelMenu.Font = new Font("Arial", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMenu.Location = new Point(425, 9);
            labelMenu.Name = "labelMenu";
            labelMenu.Size = new Size(258, 39);
            labelMenu.TabIndex = 11;
            //labelMenu.Text = "Menu Karyawan";
            // 
            // TambahKaryawan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 235);
            Controls.Add(labelMenu);
            Controls.Add(SubmitBtn);
            Controls.Add(AlamatKaryawanTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(NamaKaryawanTextBox);
            Controls.Add(Return_Button);
            Name = "TambahKaryawan";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Return_Button;
        private TextBox NamaKaryawanTextBox;
        private Label label1;
        private Label label2;
        private TextBox AlamatKaryawanTextBox;
        private Button SubmitBtn;
        private Label labelMenu;
    }
}