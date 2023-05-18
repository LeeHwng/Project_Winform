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
    public partial class FormNhanVien : Form
    {
        public FormNhanVien()
        {
            InitializeComponent();
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'NhanVien.NhanVienDTThapNhat' table. You can move, or remove it, as needed.
            this.NhanVienDTThapNhatTableAdapter.Fill(this.NhanVien.NhanVienDTThapNhat);
            // TODO: This line of code loads data into the 'NhanVien.NhanVienDTCaoNhat' table. You can move, or remove it, as needed.
            this.NhanVienDTCaoNhatTableAdapter.Fill(this.NhanVien.NhanVienDTCaoNhat);
            // TODO: This line of code loads data into the 'NhanVien.NhanVienLapItHDNhat' table. You can move, or remove it, as needed.
            this.NhanVienLapItHDNhatTableAdapter.Fill(this.NhanVien.NhanVienLapItHDNhat);
            // TODO: This line of code loads data into the 'NhanVien.NhanVienLapNhieuHDNhat' table. You can move, or remove it, as needed.
            this.NhanVienLapNhieuHDNhatTableAdapter.Fill(this.NhanVien.NhanVienLapNhieuHDNhat);
            // TODO: This line of code loads data into the 'NhanVien.SoHDDaLap' table. You can move, or remove it, as needed.
            this.SoHDDaLapTableAdapter.Fill(this.NhanVien.SoHDDaLap);

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer4.RefreshReport();
            this.reportViewer5.RefreshReport();
            this.reportViewer5.RefreshReport();
            this.reportViewer6.RefreshReport();
        }

        private void reportViewer4_Load(object sender, EventArgs e)
        {

        }

        private void reportViewer6_Load(object sender, EventArgs e)
        {

        }
    }
}
