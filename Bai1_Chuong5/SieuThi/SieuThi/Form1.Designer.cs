namespace SieuThi
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
            txtDonGia = new TextBox();
            txtMaSP = new TextBox();
            txtSoLuong = new TextBox();
            btnThem = new Button();
            btnXoaTrang = new Button();
            lstKetQua = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(160, 282);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(242, 27);
            txtDonGia.TabIndex = 0;
            txtDonGia.KeyPress += OnlyNumber_KeyPress;
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(160, 107);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(242, 27);
            txtMaSP.TabIndex = 1;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(160, 194);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(242, 27);
            txtSoLuong.TabIndex = 2;
            txtSoLuong.KeyPress += OnlyNumber_KeyPress;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.ForeColor = Color.ForestGreen;
            btnThem.Location = new Point(185, 352);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(159, 44);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm (F2)";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoaTrang
            // 
            btnXoaTrang.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoaTrang.ForeColor = Color.Firebrick;
            btnXoaTrang.Location = new Point(481, 352);
            btnXoaTrang.Name = "btnXoaTrang";
            btnXoaTrang.Size = new Size(198, 42);
            btnXoaTrang.TabIndex = 4;
            btnXoaTrang.Text = "Xóa trắng (F5)";
            btnXoaTrang.UseVisualStyleBackColor = true;
            btnXoaTrang.Click += btnXoaTrang_Click;
            // 
            // lstKetQua
            // 
            lstKetQua.FormattingEnabled = true;
            lstKetQua.Location = new Point(438, 98);
            lstKetQua.Name = "lstKetQua";
            lstKetQua.Size = new Size(281, 224);
            lstKetQua.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 109);
            label1.Name = "label1";
            label1.Size = new Size(131, 25);
            label1.TabIndex = 6;
            label1.Text = "Mã sản phẩm:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(44, 196);
            label2.Name = "label2";
            label2.Size = new Size(93, 25);
            label2.TabIndex = 7;
            label2.Text = "Số lượng:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(54, 284);
            label3.Name = "label3";
            label3.Size = new Size(83, 25);
            label3.TabIndex = 8;
            label3.Text = "Đơn giá:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Snap ITC", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.LightSeaGreen;
            label4.Location = new Point(309, 31);
            label4.Name = "label4";
            label4.Size = new Size(179, 44);
            label4.TabIndex = 9;
            label4.Text = "Siêu thị";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstKetQua);
            Controls.Add(btnXoaTrang);
            Controls.Add(btnThem);
            Controls.Add(txtSoLuong);
            Controls.Add(txtMaSP);
            Controls.Add(txtDonGia);
            KeyPreview = true;
            Name = "Form1";
            Text = "Form1";
            KeyDown += Form1_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDonGia;
        private TextBox txtMaSP;
        private TextBox txtSoLuong;
        private Button btnThem;
        private Button btnXoaTrang;
        private ListBox lstKetQua;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
