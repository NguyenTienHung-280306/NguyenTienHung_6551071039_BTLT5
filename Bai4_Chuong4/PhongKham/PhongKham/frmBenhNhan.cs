using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PhongKham
{
    public partial class frmBenhNhan : Form
    {
        List<string> dsBenhNhan = new List<string>();
        public frmBenhNhan()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void frmBenhNhan_Load(object sender, EventArgs e)
        {

        }

        private void btnLuuTam_Click(object sender, EventArgs e)
        {
            string thongTin = $"Tên: {txtHoTen.Text} - Tuổi: {numericUpDownTuoi.Value} - Triệu chứng: {txtTrieuChung.Text}";

            // Thêm vào List và hiển thị lên ListBox
            dsBenhNhan.Add(thongTin); //
            listBoxBenhNhan.Items.Add(thongTin); //
        }
    }
}
