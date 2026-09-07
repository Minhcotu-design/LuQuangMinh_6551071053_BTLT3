namespace demo2
{
    partial class Form1
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
            btnCLickMe = new Button();
            SuspendLayout();
            // 
            // btnCLickMe
            // 
            btnCLickMe.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 192);
            btnCLickMe.FlatAppearance.BorderSize = 5;
            btnCLickMe.FlatStyle = FlatStyle.Flat;
            btnCLickMe.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btnCLickMe.ForeColor = Color.Maroon;
            btnCLickMe.Location = new Point(274, 132);
            btnCLickMe.Name = "btnCLickMe";
            btnCLickMe.Size = new Size(266, 124);
            btnCLickMe.TabIndex = 0;
            btnCLickMe.Text = "Click Me";
            btnCLickMe.UseVisualStyleBackColor = true;
            btnCLickMe.Click += btnCLickMe_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCLickMe);
            Name = "Form1";
            Text = "Simple Event Example";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnCLickMe;
    }
}