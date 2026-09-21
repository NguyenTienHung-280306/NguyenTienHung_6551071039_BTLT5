namespace SieuThi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OnlyNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Chặn không cho ký tự xuất hiện vào TextBox
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maSP = txtMaSP.Text.Trim();
            string soLuong = txtSoLuong.Text.Trim();
            string donGia = txtDonGia.Text.Trim();

            if (string.IsNullOrEmpty(maSP) || string.IsNullOrEmpty(soLuong) || string.IsNullOrEmpty(donGia))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Thêm vào ListBox theo định dạng: "MaSP | SoLuong | DonGia"
            string item = $"{maSP} | {soLuong} | {donGia}";
            lstKetQua.Items.Add(item);
        }

        private void btnXoaTrang_Click(object sender, EventArgs e)
        {
            txtMaSP.Clear();
            txtSoLuong.Clear();
            txtDonGia.Clear();
            txtMaSP.Focus();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                btnThem.PerformClick(); // Gọi sự kiện click của btnThem
                e.Handled = true;
            }
            // Nhấn F5 -> Kích hoạt nút btnXoaTrang
            else if (e.KeyCode == Keys.F5)
            {
                btnXoaTrang.PerformClick(); // Gọi sự kiện click của btnXoaTrang
                e.Handled = true;
            }
            // Nhấn Escape -> Hỏi xác nhận thoát
            else if (e.KeyCode == Keys.Escape)
            {
                DialogResult result = MessageBox.Show(
                    "Bạn có muốn thoát?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    this.Close(); // Đóng Form
                }
                e.Handled = true;
            }
        }
    }
}
