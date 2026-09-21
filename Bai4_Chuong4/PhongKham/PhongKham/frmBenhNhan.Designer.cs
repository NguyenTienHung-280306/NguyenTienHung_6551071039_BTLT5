namespace PhongKham
{
    partial class frmBenhNhan
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
            txtHoTen = new TextBox();
            txtTrieuChung = new TextBox();
            label1 = new Label();
            label2 = new Label();
            numericUpDownTuoi = new NumericUpDown();
            label3 = new Label();
            btnLuuTam = new Button();
            listBoxBenhNhan = new ListBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTuoi).BeginInit();
            SuspendLayout();
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(198, 123);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(195, 27);
            txtHoTen.TabIndex = 0;
            // 
            // txtTrieuChung
            // 
            txtTrieuChung.Location = new Point(198, 260);
            txtTrieuChung.Name = "txtTrieuChung";
            txtTrieuChung.Size = new Size(195, 27);
            txtTrieuChung.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(124, 123);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 2;
            label1.Text = "Họ tên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(92, 263);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 3;
            label2.Text = "Triệu chứng:";
            // 
            // numericUpDownTuoi
            // 
            numericUpDownTuoi.Location = new Point(198, 195);
            numericUpDownTuoi.Name = "numericUpDownTuoi";
            numericUpDownTuoi.Size = new Size(195, 27);
            numericUpDownTuoi.TabIndex = 4;
            numericUpDownTuoi.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(140, 195);
            label3.MaximumSize = new Size(100, 0);
            label3.MinimumSize = new Size(1, 0);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 5;
            label3.Text = "Tuổi:";
            // 
            // btnLuuTam
            // 
            btnLuuTam.BackColor = Color.DarkSlateGray;
            btnLuuTam.Font = new Font("Snap ITC", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLuuTam.ForeColor = Color.Chocolate;
            btnLuuTam.Location = new Point(198, 330);
            btnLuuTam.Name = "btnLuuTam";
            btnLuuTam.Size = new Size(161, 41);
            btnLuuTam.TabIndex = 6;
            btnLuuTam.Text = "Lưu tạm";
            btnLuuTam.UseVisualStyleBackColor = false;
            btnLuuTam.Click += btnLuuTam_Click;
            // 
            // listBoxBenhNhan
            // 
            listBoxBenhNhan.FormattingEnabled = true;
            listBoxBenhNhan.Location = new Point(449, 123);
            listBoxBenhNhan.Name = "listBoxBenhNhan";
            listBoxBenhNhan.Size = new Size(248, 224);
            listBoxBenhNhan.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Snap ITC", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Crimson;
            label4.Location = new Point(258, 42);
            label4.Name = "label4";
            label4.Size = new Size(326, 44);
            label4.TabIndex = 8;
            label4.Text = "Thêm bệnh nhân";
            // 
            // frmBenhNhan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(listBoxBenhNhan);
            Controls.Add(btnLuuTam);
            Controls.Add(label3);
            Controls.Add(numericUpDownTuoi);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTrieuChung);
            Controls.Add(txtHoTen);
            Name = "frmBenhNhan";
            Text = "frmBenhNhan";
            Load += frmBenhNhan_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownTuoi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtHoTen;
        private TextBox txtTrieuChung;
        private Label label1;
        private Label label2;
        private NumericUpDown numericUpDownTuoi;
        private Label label3;
        private Button btnLuuTam;
        private ListBox listBoxBenhNhan;
        private Label label4;
    }
}