namespace to_do_list
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lstCongViec1.ContextMenuStrip = cmsCongViec;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCongViecMoi.Text))
            {
                lstCongViec1.Items.Add(txtCongViecMoi.Text.Trim());
                txtCongViecMoi.Clear();
                txtCongViecMoi.Focus(); // Con trỏ chuột tự quay lại ô nhập
            }
            else
            {
                MessageBox.Show("Vui lòng nhập nội dung công việc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tsmiDanhDauHoanThanh_Click(object sender, EventArgs e)
        {
            if (lstCongViec1.SelectedItem != null)
            {
                int index = lstCongViec1.SelectedIndex;
                string itemText = lstCongViec1.SelectedItem.ToString();
                string prefix = "[Hoàn thành] ";

                // Kiểm tra nếu chưa có tiền tố "[Hoàn thành] " thì mới thêm vào
                if (!itemText.StartsWith(prefix))
                {
                    lstCongViec1.Items[index] = prefix + itemText;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn công việc cần đánh dấu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tsmiXoaCongViec_Click(object sender, EventArgs e)
        {
            if (lstCongViec1.SelectedItem != null)
            {
                lstCongViec1.Items.Remove(lstCongViec1.SelectedItem);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn công việc cần xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tsmiXoaTatCa_Click(object sender, EventArgs e)
        {
            if (lstCongViec1.Items.Count > 0)
            {
                DialogResult dr = MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa toàn bộ danh sách không?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (dr == DialogResult.Yes)
                {
                    lstCongViec1.Items.Clear();
                }
            }
        }

        private void lstCongViec1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
