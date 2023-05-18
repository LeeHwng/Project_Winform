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
    public partial class FormSanPham : Form
    {
        public FormSanPham()
        {
            InitializeComponent();
        }

        private void FormSanPham_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DtsSanPham.SanPhamTonKho' table. You can move, or remove it, as needed.
            this.SanPhamTonKhoTableAdapter.Fill(this.DtsSanPham.SanPhamTonKho);
            // TODO: This line of code loads data into the 'DtsSanPham.SanPhamDaBan' table. You can move, or remove it, as needed.
            this.SanPhamDaBanTableAdapter.Fill(this.DtsSanPham.SanPhamDaBan);
            // TODO: This line of code loads data into the 'DtsSanPham.SanPhamKhongBanDuoc' table. You can move, or remove it, as needed.
            this.SanPhamKhongBanDuocTableAdapter.Fill(this.DtsSanPham.SanPhamKhongBanDuoc);
            // TODO: This line of code loads data into the 'DtsSanPham.SanPham' table. You can move, or remove it, as needed.
            this.SanPhamTableAdapter.Fill(this.DtsSanPham.SanPham);

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
        }
    }
}
