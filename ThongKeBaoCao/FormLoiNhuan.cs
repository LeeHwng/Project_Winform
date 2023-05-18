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
    public partial class FormLoiNhuan : Form
    {
        public FormLoiNhuan()
        {
            InitializeComponent();
        }

        private void FormLoiNhuan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetLoiNhuan.LoiNhuanKhachHang' table. You can move, or remove it, as needed.
            this.LoiNhuanKhachHangTableAdapter.Fill(this.DataSetLoiNhuan.LoiNhuanKhachHang);
            // TODO: This line of code loads data into the 'DataSetLoiNhuan.LoiNhuanNam' table. You can move, or remove it, as needed.
            this.LoiNhuanNamTableAdapter.Fill(this.DataSetLoiNhuan.LoiNhuanNam);
            // TODO: This line of code loads data into the 'DataSetLoiNhuan.LoiNhuanQuy' table. You can move, or remove it, as needed.
            this.LoiNhuanQuyTableAdapter.Fill(this.DataSetLoiNhuan.LoiNhuanQuy);
            // TODO: This line of code loads data into the 'DataSetLoiNhuan.LoiNhuanThang' table. You can move, or remove it, as needed.
            this.LoiNhuanThangTableAdapter.Fill(this.DataSetLoiNhuan.LoiNhuanThang);
            // TODO: This line of code loads data into the 'DataSetLoiNhuan.LoiNhuanNgay' table. You can move, or remove it, as needed.
            this.LoiNhuanNgayTableAdapter.Fill(this.DataSetLoiNhuan.LoiNhuanNgay);
            // TODO: This line of code loads data into the 'DataSetLoiNhuan.LoiNhuanSanpham' table. You can move, or remove it, as needed.
            this.LoiNhuanSanphamTableAdapter.Fill(this.DataSetLoiNhuan.LoiNhuanSanpham);

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
            this.reportViewer4.RefreshReport();
            this.reportViewer5.RefreshReport();
            this.reportViewer6.RefreshReport();
        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }
    }
}
