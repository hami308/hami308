using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDien_qlpks
{
    public partial class formchinh : Form
    {
        public formchinh()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
        private void quảnLýPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form quanlyphong = new quanlyphong();
            this.Hide();
            quanlyphong.ShowDialog();
            this.Show();
        }


        private void tàiKhoảnCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thôngTinCáNhânToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form Thongtincanhan = new Thongtincanhan();
            this.Hide();
            Thongtincanhan.ShowDialog();
            this.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form danhsachkhachhang = new danhsachkhachhang();
            this.Hide();
            danhsachkhachhang.ShowDialog();
            this.Show();
        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
