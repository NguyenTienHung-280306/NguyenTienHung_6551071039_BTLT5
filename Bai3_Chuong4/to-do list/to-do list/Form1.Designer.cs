namespace to_do_list
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
            txtCongViecMoi = new TextBox();
            btnThem = new Button();
            cmsCongViec = new ContextMenuStrip(components);
            tsmiDanhDauHoanThanh = new ToolStripMenuItem();
            tsmiXoaCongViec = new ToolStripMenuItem();
            tsmiXoaTatCa = new ToolStripMenuItem();
            label1 = new Label();
            lstCongViec1 = new ListBox();
            label2 = new Label();
            cmsCongViec.SuspendLayout();
            SuspendLayout();
            // 
            // txtCongViecMoi
            // 
            txtCongViecMoi.Location = new Point(257, 95);
            txtCongViecMoi.Name = "txtCongViecMoi";
            txtCongViecMoi.Size = new Size(260, 27);
            txtCongViecMoi.TabIndex = 0;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.RosyBrown;
            btnThem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.ForeColor = Color.Black;
            btnThem.Location = new Point(541, 91);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(108, 35);
            btnThem.TabIndex = 1;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // cmsCongViec
            // 
            cmsCongViec.ImageScalingSize = new Size(20, 20);
            cmsCongViec.Items.AddRange(new ToolStripItem[] { tsmiDanhDauHoanThanh, tsmiXoaCongViec, tsmiXoaTatCa });
            cmsCongViec.Name = "cmsCongViec";
            cmsCongViec.Size = new Size(242, 76);
            cmsCongViec.Text = "Công cụ";
            // 
            // tsmiDanhDauHoanThanh
            // 
            tsmiDanhDauHoanThanh.Name = "tsmiDanhDauHoanThanh";
            tsmiDanhDauHoanThanh.Size = new Size(241, 24);
            tsmiDanhDauHoanThanh.Text = "Đánh dấu đã hoàn thành";
            tsmiDanhDauHoanThanh.Click += tsmiDanhDauHoanThanh_Click;
            // 
            // tsmiXoaCongViec
            // 
            tsmiXoaCongViec.Name = "tsmiXoaCongViec";
            tsmiXoaCongViec.Size = new Size(241, 24);
            tsmiXoaCongViec.Text = "Xóa công việc này";
            tsmiXoaCongViec.Click += tsmiXoaCongViec_Click;
            // 
            // tsmiXoaTatCa
            // 
            tsmiXoaTatCa.Name = "tsmiXoaTatCa";
            tsmiXoaTatCa.Size = new Size(241, 24);
            tsmiXoaTatCa.Text = "Xóa tất cả";
            tsmiXoaTatCa.Click += tsmiXoaTatCa_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(99, 91);
            label1.Name = "label1";
            label1.Size = new Size(152, 28);
            label1.TabIndex = 3;
            label1.Text = "Công việc mới:";
            // 
            // lstCongViec1
            // 
            lstCongViec1.ContextMenuStrip = cmsCongViec;
            lstCongViec1.Location = new Point(237, 169);
            lstCongViec1.Name = "lstCongViec1";
            lstCongViec1.Size = new Size(332, 204);
            lstCongViec1.TabIndex = 0;
            lstCongViec1.SelectedIndexChanged += lstCongViec1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Coral;
            label2.Location = new Point(203, 34);
            label2.Name = "label2";
            label2.Size = new Size(435, 35);
            label2.TabIndex = 4;
            label2.Text = "Công việc cần làm hôm nay";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(lstCongViec1);
            Controls.Add(label1);
            Controls.Add(btnThem);
            Controls.Add(txtCongViecMoi);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            cmsCongViec.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCongViecMoi;
        private Button btnThem;
        private ContextMenuStrip cmsCongViec;
        private ToolStripMenuItem tsmiDanhDauHoanThanh;
        private ToolStripMenuItem tsmiXoaCongViec;
        private ToolStripMenuItem tsmiXoaTatCa;
        private Label label1;
        private ListBox lstCongViec1;
        private Label label2;
    }
}
