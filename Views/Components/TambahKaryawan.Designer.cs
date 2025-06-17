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
            Return_Button.Location = new Point(120, 87);
            Return_Button.Margin = new Padding(4);
            Return_Button.Name = "Return_Button";
            Return_Button.Size = new Size(211, 138);
            Return_Button.TabIndex = 5;
            Return_Button.Text = "Kembali";
            Return_Button.UseVisualStyleBackColor = true;
            Return_Button.Click += Return_Button_Click;
            // 
            // NamaKaryawanTextBox
            // 
            NamaKaryawanTextBox.Location = new Point(554, 115);
            NamaKaryawanTextBox.Margin = new Padding(4);
            NamaKaryawanTextBox.Name = "NamaKaryawanTextBox";
            NamaKaryawanTextBox.Size = new Size(198, 31);
            NamaKaryawanTextBox.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(373, 119);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(139, 25);
            label1.TabIndex = 7;
            label1.Text = "Nama Karyawan";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(373, 171);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(148, 25);
            label2.TabIndex = 8;
            label2.Text = "Alamat Karyawan";
            // 
            // AlamatKaryawanTextBox
            // 
            AlamatKaryawanTextBox.Location = new Point(554, 167);
            AlamatKaryawanTextBox.Margin = new Padding(4);
            AlamatKaryawanTextBox.Name = "AlamatKaryawanTextBox";
            AlamatKaryawanTextBox.Size = new Size(198, 31);
            AlamatKaryawanTextBox.TabIndex = 9;
            // 
            // SubmitBtn
            // 
            SubmitBtn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SubmitBtn.ForeColor = SystemColors.ControlText;
            SubmitBtn.Location = new Point(799, 92);
            SubmitBtn.Margin = new Padding(4);
            SubmitBtn.Name = "SubmitBtn";
            SubmitBtn.Size = new Size(234, 128);
            SubmitBtn.TabIndex = 10;
            SubmitBtn.UseVisualStyleBackColor = true;
            SubmitBtn.Click += SubmitBtn_Click;
            // 
            // labelMenu
            // 
            labelMenu.AutoSize = true;
            labelMenu.Font = new Font("Arial", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMenu.ForeColor = SystemColors.ControlLightLight;
            labelMenu.Location = new Point(380, 20);
            labelMenu.Margin = new Padding(4, 0, 4, 0);
            labelMenu.Name = "labelMenu";
            labelMenu.Size = new Size(0, 45);
            labelMenu.TabIndex = 11;
            // 
            // TambahKaryawan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(1197, 294);
            Controls.Add(labelMenu);
            Controls.Add(SubmitBtn);
            Controls.Add(AlamatKaryawanTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(NamaKaryawanTextBox);
            Controls.Add(Return_Button);
            Margin = new Padding(4);
            Name = "TambahKaryawan";
            Text = "Form1";
            Load += TambahKaryawan_Load;
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