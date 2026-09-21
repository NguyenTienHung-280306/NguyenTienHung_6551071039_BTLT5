namespace BangVeMini
{
    public partial class Form1 : Form
    {
        private bool isDrawing = false;
        private Point previousPoint;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pnlCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            // Nếu nhấn chuột trái -> Bắt đầu vẽ
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = true;
                previousPoint = e.Location; // Lưu tọa độ điểm bắt đầu
                lblTrangThai.Text = "Đang vẽ...";
            }
        }

        private void pnlCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            // 1. Luôn cập nhật tọa độ chuột lên Label lblViTri
            lblViTri.Text = $"Tọa độ: X = {e.X}, Y = {e.Y}";

            // 2. Nếu đang giữ chuột trái thì thực hiện vẽ
            if (isDrawing)
            {
                // Tạo đối tượng Graphics từ Panel để vẽ trực tiếp
                using (Graphics g = pnlCanvas.CreateGraphics())
                {
                    // Bật tính năng làm mượt nét vẽ (AntiAlias)
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                    // Tạo bút vẽ màu đen, độ dày 2px
                    using (Pen pen = new Pen(Color.Black, 2))
                    {
                        // Vẽ đường thẳng nối từ điểm cũ đến vị trí hiện tại của chuột
                        g.DrawLine(pen, previousPoint, e.Location);
                    }
                }

                // Cập nhật điểm cũ bằng vị trí chuột hiện tại để chuẩn bị cho đoạn tiếp theo
                previousPoint = e.Location;
            }
        }

        private void pnlCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            // Khi nhả chuột trái -> Ngừng vẽ
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = false;
                lblTrangThai.Text = "Sẵn sàng";
            }
        }

        private void pnlCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            // Nếu nhấn chuột phải -> Xóa toàn bộ nét vẽ
            if (e.Button == MouseButtons.Right)
            {
                pnlCanvas.Invalidate(); // Làm mới Panel (xóa sạch hình đã vẽ)
                lblTrangThai.Text = "Sẵn sàng";
            }
        }
    }
}
