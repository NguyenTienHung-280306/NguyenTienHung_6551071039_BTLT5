using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PhongKham
{
    public partial class frmLichHen : Form
    {
        List<string> dsLichHen = new List<string>();
        public frmLichHen()
        {
            InitializeComponent();
        }

        private void frmLichHen_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string lich = $"Ngày: {dateTimePicker1.Value.ToString("dd/MM/yyyy")} - Tên: {txtTenBN.Text}";
            dsLichHen.Add(lich); //
            listBoxLichHen.Items.Add(lich); //
        }
    }
}
