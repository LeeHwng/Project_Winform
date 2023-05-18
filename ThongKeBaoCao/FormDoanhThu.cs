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
    public partial class FormDoanhThu : Form
    {
        public FormDoanhThu()
        {
            InitializeComponent();
        }

        private void FormDoanhThu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DoanhThu.DoanhThuKhachHang' table. You can move, or remove it, as needed.
            this.DoanhThuKhachHangTableAdapter.Fill(this.DoanhThu.DoanhThuKhachHang);
            // TODO: This line of code loads data into the 'DoanhThu.DoanhThuSanPham' table. You can move, or remove it, as needed.
            this.DoanhThuSanPhamTableAdapter.Fill(this.DoanhThu.DoanhThuSanPham);
            // TODO: This line of code loads data into the 'DoanhThu.DoanhThuNam' table. You can move, or remove it, as needed.
            this.DoanhThuNamTableAdapter.Fill(this.DoanhThu.DoanhThuNam);
            // TODO: This line of code loads data into the 'DoanhThu.DoanhThuQuy' table. You can move, or remove it, as needed.
            this.DoanhThuQuyTableAdapter.Fill(this.DoanhThu.DoanhThuQuy);
            // TODO: This line of code loads data into the 'DoanhThu.DOANHTHUTHANG' table. You can move, or remove it, as needed.
            this.DOANHTHUTHANGTableAdapter.Fill(this.DoanhThu.DOANHTHUTHANG);
            // TODO: This line of code loads data into the 'DoanhThu.DoanhThuNgay' table. You can move, or remove it, as needed.
            this.DoanhThuNgayTableAdapter.Fill(this.DoanhThu.DoanhThuNgay);

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
            this.reportViewer4.RefreshReport();
            this.reportViewer5.RefreshReport();
            this.reportViewer6.RefreshReport();
        }
    }
}
