namespace PhongKham
{
    public partial class frmParent : Form
    {
        public frmParent()
        {
            InitializeComponent();
        }

        private void cửaSổToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLichHen frmLH = new frmLichHen(); //[cite: 1]
            frmLH.MdiParent = this; //[cite: 1]
            frmLH.Show(); //[cite: 1]
        }

        private void thôngTinBệnhNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            frmBenhNhan frmBN = new frmBenhNhan(); 
                                                 
            frmBN.MdiParent = this;
            frmBN.Show(); 
        }
    }
}
