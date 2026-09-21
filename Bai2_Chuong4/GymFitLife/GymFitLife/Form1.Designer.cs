namespace GymFitLife
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
            components = new System.ComponentModel.Container();
            txtHoTen = new TextBox();
            txtEmail = new TextBox();
            txtSDT = new TextBox();
            cboGoiTap = new ComboBox();
            numSoBuoiTuan = new NumericUpDown();
            btnDangKy = new Button();
            toolTip1 = new ToolTip(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)numSoBuoiTuan).BeginInit();
            SuspendLayout();
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(162, 73);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(125, 27);
            txtHoTen.TabIndex = 0;
            toolTip1.SetToolTip(txtHoTen, "Nhập đúng 10 chữ số, không chứa khoảng trắng hay ký tự đặc biệt");
            txtHoTen.TextChanged += textBox1_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(162, 237);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 1;
            toolTip1.SetToolTip(txtEmail, "Email dùng để nhận thông báo lịch tập và khuyến mãi");
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(162, 153);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(125, 27);
            txtSDT.TabIndex = 2;
            // 
            // cboGoiTap
            // 
            cboGoiTap.FormattingEnabled = true;
            cboGoiTap.Items.AddRange(new object[] { "Basic", "VIP", "Premium" });
            cboGoiTap.Location = new Point(488, 76);
            cboGoiTap.Name = "cboGoiTap";
            cboGoiTap.Size = new Size(151, 28);
            cboGoiTap.TabIndex = 3;
            toolTip1.SetToolTip(cboGoiTap, "Gói VIP và Premium có kèm huấn luyện viên riêng");
            // 
            // numSoBuoiTuan
            // 
            numSoBuoiTuan.Location = new Point(488, 158);
            numSoBuoiTuan.Maximum = new decimal(new int[] { 7, 0, 0, 0 });
            numSoBuoiTuan.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numSoBuoiTuan.Name = "numSoBuoiTuan";
            numSoBuoiTuan.Size = new Size(150, 27);
            numSoBuoiTuan.TabIndex = 4;
            numSoBuoiTuan.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnDangKy
            // 
            btnDangKy.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangKy.ForeColor = Color.DarkGreen;
            btnDangKy.Location = new Point(322, 347);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(154, 42);
            btnDangKy.TabIndex = 5;
            btnDangKy.Text = "Đăng ký";
            btnDangKy.UseVisualStyleBackColor = true;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 73);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 6;
            label1.Text = "Họ tên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 158);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 7;
            label2.Text = "Số điện thoại:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(77, 237);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 8;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(400, 76);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 9;
            label4.Text = "Gói tập:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(384, 160);
            label5.Name = "label5";
            label5.Size = new Size(98, 20);
            label5.TabIndex = 10;
            label5.Text = "Số buổi/tuần:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDangKy);
            Controls.Add(numSoBuoiTuan);
            Controls.Add(cboGoiTap);
            Controls.Add(txtSDT);
            Controls.Add(txtEmail);
            Controls.Add(txtHoTen);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numSoBuoiTuan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtHoTen;
        private TextBox txtEmail;
        private TextBox txtSDT;
        private ComboBox cboGoiTap;
        private NumericUpDown numSoBuoiTuan;
        private Button btnDangKy;
        private ToolTip toolTip1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
