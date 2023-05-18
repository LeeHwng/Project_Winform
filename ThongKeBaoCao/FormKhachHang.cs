using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeQuocHung_BlackMobile.ThongKeBaoCao
{
    public partial class FormKhachHang : Form
    {
        public FormKhachHang()
        {
            InitializeComponent();
        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DtsKhachHang.KhachHangVip' table. You can move, or remove it, as needed.
            this.KhachHangVipTableAdapter.Fill(this.DtsKhachHang.KhachHangVip);

            this.reportViewer1.RefreshReport();
        }
    }
}
