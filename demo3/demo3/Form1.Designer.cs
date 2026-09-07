namespace demo3
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
            label2 = new Label();
            txtHo = new TextBox();
            txtTen = new TextBox();
            btnHo = new Button();
            btnTen = new Button();
            btnHoTen = new Button();
            btnThoatChuongTrinh = new Button();
            lblHoTen = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(132, 123);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 0;
            label1.Text = "Họ Lót";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(154, 167);
            label2.Name = "label2";
            label2.Size = new Size(32, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên";
            label2.Click += label2_Click;
            // 
            // txtHo
            // 
            txtHo.Location = new Point(192, 120);
            txtHo.Name = "txtHo";
            txtHo.Size = new Size(325, 27);
            txtHo.TabIndex = 2;
            // 
            // txtTen
            // 
            txtTen.BackColor = Color.FromArgb(255, 192, 255);
            txtTen.ForeColor = Color.Black;
            txtTen.Location = new Point(192, 160);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(325, 27);
            txtTen.TabIndex = 3;
            // 
            // btnHo
            // 
            btnHo.Location = new Point(81, 252);
            btnHo.Name = "btnHo";
            btnHo.Size = new Size(105, 52);
            btnHo.TabIndex = 4;
            btnHo.Text = "Họ Lót";
            btnHo.UseVisualStyleBackColor = true;
            btnHo.Click += btnHo_Click;
            // 
            // btnTen
            // 
            btnTen.Location = new Point(291, 252);
            btnTen.Name = "btnTen";
            btnTen.Size = new Size(104, 52);
            btnTen.TabIndex = 5;
            btnTen.Text = "Tên";
            btnTen.UseVisualStyleBackColor = true;
            btnTen.Click += btnTen_Click;
            // 
            // btnHoTen
            // 
            btnHoTen.Location = new Point(518, 252);
            btnHoTen.Name = "btnHoTen";
            btnHoTen.Size = new Size(90, 52);
            btnHoTen.TabIndex = 6;
            btnHoTen.Text = "Họ Và Tên";
            btnHoTen.UseVisualStyleBackColor = true;
            btnHoTen.Click += btnHoTen_Click;
            // 
            // btnThoatChuongTrinh
            // 
            btnThoatChuongTrinh.Location = new Point(210, 345);
            btnThoatChuongTrinh.Name = "btnThoatChuongTrinh";
            btnThoatChuongTrinh.Size = new Size(241, 60);
            btnThoatChuongTrinh.TabIndex = 7;
            btnThoatChuongTrinh.Text = "Thoát Chương Trình";
            btnThoatChuongTrinh.UseVisualStyleBackColor = true;
            btnThoatChuongTrinh.Click += btnThoatChuongTrinh_Click;
            // 
            // lblHoTen
            // 
            lblHoTen.BackColor = Color.Blue;
            lblHoTen.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblHoTen.ForeColor = Color.FromArgb(255, 255, 128);
            lblHoTen.Location = new Point(0, -2);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(801, 101);
            lblHoTen.TabIndex = 8;
            lblHoTen.TextAlign = ContentAlignment.MiddleCenter;
            lblHoTen.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblHoTen);
            Controls.Add(btnThoatChuongTrinh);
            Controls.Add(btnHoTen);
            Controls.Add(btnTen);
            Controls.Add(btnHo);
            Controls.Add(txtTen);
            Controls.Add(txtHo);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Bài Tập Họ Tên";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtHo;
        private TextBox txtTen;
        private Button btnHo;
        private Button btnTen;
        private Button btnHoTen;
        private Button btnThoatChuongTrinh;
        private Label lblHoTen;
    }
}
