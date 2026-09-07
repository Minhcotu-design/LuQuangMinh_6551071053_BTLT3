namespace demo5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtNhapTen = new TextBox();
            groupBox1 = new GroupBox();
            radBlack = new RadioButton();
            radBlue = new RadioButton();
            radGreen = new RadioButton();
            radRed = new RadioButton();
            groupBox2 = new GroupBox();
            chkUnderLine = new CheckBox();
            chkItalic = new CheckBox();
            chkBold = new CheckBox();
            label2 = new Label();
            lblLapTrinh = new TextBox();
            btnThoat = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(0, 192, 0);
            label1.Location = new Point(29, 17);
            label1.Name = "label1";
            label1.Size = new Size(77, 24);
            label1.TabIndex = 0;
            label1.Text = "Nhập Tên";
            // 
            // txtNhapTen
            // 
            txtNhapTen.Location = new Point(112, 17);
            txtNhapTen.Name = "txtNhapTen";
            txtNhapTen.Size = new Size(326, 27);
            txtNhapTen.TabIndex = 1;
            txtNhapTen.TextChanged += txtNhapTen_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(radBlack);
            groupBox1.Controls.Add(radBlue);
            groupBox1.Controls.Add(radGreen);
            groupBox1.Controls.Add(radRed);
            groupBox1.Location = new Point(29, 75);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(186, 213);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Color";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // radBlack
            // 
            radBlack.AutoSize = true;
            radBlack.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            radBlack.Location = new Point(37, 147);
            radBlack.Name = "radBlack";
            radBlack.Size = new Size(66, 24);
            radBlack.TabIndex = 3;
            radBlack.TabStop = true;
            radBlack.Text = "black";
            radBlack.UseVisualStyleBackColor = true;
            radBlack.CheckedChanged += radBlack_CheckedChanged;
            // 
            // radBlue
            // 
            radBlue.AutoSize = true;
            radBlue.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            radBlue.ForeColor = Color.FromArgb(0, 0, 192);
            radBlue.Location = new Point(37, 108);
            radBlue.Name = "radBlue";
            radBlue.Size = new Size(60, 24);
            radBlue.TabIndex = 2;
            radBlue.TabStop = true;
            radBlue.Text = "blue";
            radBlue.UseVisualStyleBackColor = true;
            radBlue.CheckedChanged += radBlue_CheckedChanged;
            // 
            // radGreen
            // 
            radGreen.AutoSize = true;
            radGreen.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            radGreen.ForeColor = Color.Green;
            radGreen.Location = new Point(37, 67);
            radGreen.Name = "radGreen";
            radGreen.Size = new Size(70, 24);
            radGreen.TabIndex = 1;
            radGreen.TabStop = true;
            radGreen.Text = "green";
            radGreen.UseVisualStyleBackColor = true;
            radGreen.CheckedChanged += radGreen_CheckedChanged;
            // 
            // radRed
            // 
            radRed.AutoSize = true;
            radRed.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            radRed.ForeColor = Color.Red;
            radRed.Location = new Point(37, 26);
            radRed.Name = "radRed";
            radRed.Size = new Size(53, 24);
            radRed.TabIndex = 0;
            radRed.TabStop = true;
            radRed.Text = "red";
            radRed.UseVisualStyleBackColor = true;
            radRed.CheckedChanged += radRed_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(255, 224, 192);
            groupBox2.Controls.Add(chkUnderLine);
            groupBox2.Controls.Add(chkItalic);
            groupBox2.Controls.Add(chkBold);
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.Location = new Point(298, 75);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(223, 213);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Font";
            // 
            // chkUnderLine
            // 
            chkUnderLine.AutoSize = true;
            chkUnderLine.FlatStyle = FlatStyle.Flat;
            chkUnderLine.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline);
            chkUnderLine.ForeColor = Color.FromArgb(0, 0, 192);
            chkUnderLine.Location = new Point(27, 148);
            chkUnderLine.Name = "chkUnderLine";
            chkUnderLine.Size = new Size(101, 24);
            chkUnderLine.TabIndex = 2;
            chkUnderLine.Text = "Gạch Chân";
            chkUnderLine.UseVisualStyleBackColor = true;
            chkUnderLine.CheckedChanged += chkUnderLine_CheckedChanged;
            // 
            // chkItalic
            // 
            chkItalic.AutoSize = true;
            chkItalic.FlatStyle = FlatStyle.Flat;
            chkItalic.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            chkItalic.ForeColor = Color.FromArgb(0, 0, 192);
            chkItalic.Location = new Point(27, 92);
            chkItalic.Name = "chkItalic";
            chkItalic.Size = new Size(129, 24);
            chkItalic.TabIndex = 1;
            chkItalic.Text = "Nghiêng Italic";
            chkItalic.UseVisualStyleBackColor = true;
            chkItalic.CheckedChanged += chkItalic_CheckedChanged;
            // 
            // chkBold
            // 
            chkBold.AutoSize = true;
            chkBold.FlatStyle = FlatStyle.Flat;
            chkBold.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            chkBold.ForeColor = Color.FromArgb(0, 0, 192);
            chkBold.Location = new Point(27, 39);
            chkBold.Name = "chkBold";
            chkBold.Size = new Size(96, 24);
            chkBold.TabIndex = 0;
            chkBold.Text = "Đậm Bold";
            chkBold.UseVisualStyleBackColor = true;
            chkBold.CheckedChanged += chkBold_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(29, 347);
            label2.Name = "label2";
            label2.Size = new Size(142, 28);
            label2.TabIndex = 4;
            label2.Text = "Lập Trình Bởi:";
            // 
            // lblLapTrinh
            // 
            lblLapTrinh.ForeColor = Color.Lime;
            lblLapTrinh.Location = new Point(172, 348);
            lblLapTrinh.Name = "lblLapTrinh";
            lblLapTrinh.Size = new Size(214, 27);
            lblLapTrinh.TabIndex = 5;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(422, 337);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(122, 49);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(583, 425);
            Controls.Add(btnThoat);
            Controls.Add(lblLapTrinh);
            Controls.Add(label2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(txtNhapTen);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Định Dạng(Formarter)";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNhapTen;
        private GroupBox groupBox1;
        private RadioButton radBlack;
        private RadioButton radBlue;
        private RadioButton radGreen;
        private RadioButton radRed;
        private GroupBox groupBox2;
        private CheckBox chkUnderLine;
        private CheckBox chkItalic;
        private CheckBox chkBold;
        private Label label2;
        private TextBox lblLapTrinh;
        private Button btnThoat;
    }
}
