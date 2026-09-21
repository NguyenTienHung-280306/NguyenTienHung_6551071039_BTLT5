namespace GymFitLife
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text) || string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập đầy đủ Họ tên và Số điện thoại",
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            else
            {
                // Tổng hợp thông tin đăng ký
                string thôngTin = $"Họ tên: {txtHoTen.Text.Trim()}\n" +
                                  $"SĐT: {txtSDT.Text.Trim()}\n" +
                                  $"Gói tập: {cboGoiTap.SelectedItem?.ToString()}\n" +
                                  $"Số buổi/tuần: {numSoBuoiTuan.Value}";

                MessageBox.Show(
                    thôngTin,
                    "Thông tin đăng ký thành công",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
