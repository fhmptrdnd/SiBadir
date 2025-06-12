namespace SiBadir.View
{
    partial class FormAddEditBahan
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
            SubmitBtn = new Button();
            StokBahanTextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            NamaBahanTextBox = new TextBox();
            Return_Button = new Button();
            label3 = new Label();
            labelMenu = new Label();
            SatuanBahanTextBox = new TextBox();
            label4 = new Label();
            IdKategoriTextBox = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // SubmitBtn
            // 
            SubmitBtn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SubmitBtn.ForeColor = SystemColors.ControlText;
            SubmitBtn.Location = new Point(821, 107);
            SubmitBtn.Margin = new Padding(4);
            SubmitBtn.Name = "SubmitBtn";
            SubmitBtn.Size = new Size(234, 128);
            SubmitBtn.TabIndex = 16;
            SubmitBtn.UseVisualStyleBackColor = true;
            // 
            // StokBahanTextBox
            // 
            StokBahanTextBox.Location = new Point(576, 145);
            StokBahanTextBox.Margin = new Padding(4);
            StokBahanTextBox.Name = "StokBahanTextBox";
            StokBahanTextBox.Size = new Size(198, 31);
            StokBahanTextBox.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(395, 149);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 25);
            label2.TabIndex = 14;
            label2.Text = "Stok Bahan";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(395, 110);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(112, 25);
            label1.TabIndex = 13;
            label1.Text = "Nama Bahan";
            // 
            // NamaBahanTextBox
            // 
            NamaBahanTextBox.Location = new Point(576, 106);
            NamaBahanTextBox.Margin = new Padding(4);
            NamaBahanTextBox.Name = "NamaBahanTextBox";
            NamaBahanTextBox.Size = new Size(198, 31);
            NamaBahanTextBox.TabIndex = 12;
            // 
            // Return_Button
            // 
            Return_Button.Location = new Point(142, 106);
            Return_Button.Margin = new Padding(4);
            Return_Button.Name = "Return_Button";
            Return_Button.Size = new Size(211, 129);
            Return_Button.TabIndex = 11;
            Return_Button.Text = "Kembali";
            Return_Button.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(643, 40);
            label3.Name = "label3";
            label3.Size = new Size(0, 25);
            label3.TabIndex = 17;
            // 
            // labelMenu
            // 
            labelMenu.AutoSize = true;
            labelMenu.BackColor = Color.Transparent;
            labelMenu.Font = new Font("Arial", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMenu.ForeColor = SystemColors.ControlLightLight;
            labelMenu.Location = new Point(428, 20);
            labelMenu.Margin = new Padding(4, 0, 4, 0);
            labelMenu.Name = "labelMenu";
            labelMenu.Size = new Size(285, 45);
            labelMenu.TabIndex = 18;
            labelMenu.Text = "Tambah Bahan";
            labelMenu.Click += labelMenu_Click;
            // 
            // SatuanBahanTextBox
            // 
            SatuanBahanTextBox.Location = new Point(576, 184);
            SatuanBahanTextBox.Margin = new Padding(4);
            SatuanBahanTextBox.Name = "SatuanBahanTextBox";
            SatuanBahanTextBox.Size = new Size(198, 31);
            SatuanBahanTextBox.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(395, 184);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(119, 25);
            label4.TabIndex = 19;
            label4.Text = "Satuan Bahan";
            // 
            // IdKategoriTextBox
            // 
            IdKategoriTextBox.Location = new Point(576, 223);
            IdKategoriTextBox.Margin = new Padding(4);
            IdKategoriTextBox.Name = "IdKategoriTextBox";
            IdKategoriTextBox.Size = new Size(198, 31);
            IdKategoriTextBox.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(395, 223);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(101, 25);
            label5.TabIndex = 21;
            label5.Text = "ID Kategori";
            // 
            // FormAddEditBahan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(1197, 294);
            Controls.Add(IdKategoriTextBox);
            Controls.Add(label5);
            Controls.Add(SatuanBahanTextBox);
            Controls.Add(label4);
            Controls.Add(labelMenu);
            Controls.Add(label3);
            Controls.Add(SubmitBtn);
            Controls.Add(StokBahanTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(NamaBahanTextBox);
            Controls.Add(Return_Button);
            Name = "FormAddEditBahan";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SubmitBtn;
        private TextBox StokBahanTextBox;
        private Label label2;
        private Label label1;
        private TextBox NamaBahanTextBox;
        private Button Return_Button;
        private Label label3;
        private Label labelMenu;
        private TextBox SatuanBahanTextBox;
        private Label label4;
        private TextBox IdKategoriTextBox;
        private Label label5;
    }
}