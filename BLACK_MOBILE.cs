using LeQuocHung_BlackMobile.HeThong;
using LeQuocHung_BlackMobile.QuanLy;
using LeQuocHung_BlackMobile.ThongKeBaoCao;
using LeQuocHung_BlackMobile.TimKim;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace LeQuocHung_BlackMobile
{
    public partial class BLACK_MOBILE : Form
    {
        public BLACK_MOBILE()
        {
            InitializeComponent();
        }


        private void qLKHToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            pntk.Controls.Clear();
            QLKH frm = new QLKH();
            frm.TopLevel = false;
            pntk.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            this.Text = frm.Text;
            frm.Show();
        }

        private void qLNVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pntk.Controls.Clear();
            QLNV frm = new QLNV();
            frm.TopLevel = false;
            pntk.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            this.Text = frm.Text;
            frm.Show();
        }

        private void qLMHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pntk.Controls.Clear();
            QLMH frm = new QLMH();
            frm.TopLevel = false;
            pntk.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            this.Text = frm.Text;
            frm.Show();
        }

        private void qLCTHDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pntk.Controls.Clear();
            QLCTHD frm = new QLCTHD();
            frm.TopLevel = false;
            pntk.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            this.Text = frm.Text;
            frm.Show();
        }

        private void qLHDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pntk.Controls.Clear();
            QLHD frm = new QLHD();
            frm.TopLevel = false;
            pntk.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            this.Text = frm.Text;
            frm.Show();
        }

        private void qLNCCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pntk.Controls.Clear();
            QLNCC frm = new QLNCC();
            frm.TopLevel = false;
            pntk.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            this.Text = frm.Text;
            frm.Show();
        }

        private void qLLHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pntk.Controls.Clear();
            QLLH frm = new QLLH();
            frm.TopLevel = false;
            pntk.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            this.Text = frm.Text;
            frm.Show();
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          //  Form frm = new BLACK_MOBILE();
          //  AddForm(frm);
        }
       /* private void AddForm(Form frm)
        {
            pntk.Controls.Clear();
            frm.TopLevel = false ;
            frm.AutoScroll = true ;
            frm.FormBorderStyle = FormBorderStyle.None ;
            frm.Dock = DockStyle.Fill ;
             this.pntk.Controls.Add (frm) ;
           // Show();
        }*/

        private void tiềmKiếmNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pntk.Controls.Clear();
            TKNV frm = new TKNV();
            frm.TopLevel = false;
            pntk.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            this.Text = frm.Text;
            frm.Show();
        }

        private void tiềmKiếmKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pntk.Controls.Clear();
            TKKH frm = new TKKH();
            frm.TopLevel = false;
            pntk.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            this.Text = frm.Text;
            frm.Show();
        }

        private void tiềmKiếmNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pntk.Controls.Clear();
            TKNCC frm = new TKNCC();
            frm.TopLevel = false;
            pntk.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            this.Text = frm.Text;
            frm.Show();
        }

        private void tiềmKiếmLoạiHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pntk.Controls.Clear();
            TKLH frm = new TKLH();
            frm.TopLevel = false;
            pntk.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            this.Text = frm.Text;
            frm.Show();
        }

        private void tiềmKiếmHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pntk.Controls.Clear();
            TKHD frm = new TKHD();
            frm.TopLevel = false;
            pntk.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            this.Text = frm.Text;
            frm.Show();
        }

        private void tiềmKiếmChiTiếtHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pntk.Controls.Clear();
            TKCTHD frm = new TKCTHD();
            frm.TopLevel = false;
            pntk.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            this.Text = frm.Text;
            frm.Show();
        }

        private void tiềmKiếmMặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pntk.Controls.Clear();
            TKMH frm = new TKMH();
            frm.TopLevel = false;
            pntk.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            this.Text = frm.Text;
            frm.Show();
        }

        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pntk.Controls.Clear();
            QLTK frm = new QLTK();
            frm.TopLevel = false;
            pntk.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            this.Text = frm.Text;
            frm.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn muốn muốn đăng xuất?", " Trả Lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK) { 
            Login f = new Login();
                this.Hide();
            f.ShowDialog(); 
               
        }
    }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult traloi;
            traloi = MessageBox.Show("Bạn muốn thoát?", " Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();

        }

        private void qLKHToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pntk.Controls.Clear();
            FormDoanhThu frm = new FormDoanhThu();
            frm.TopLevel = false;
            pntk.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            this.Text = frm.Text;
            frm.Show();
        }

        private void lợiNhuậnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pntk.Controls.Clear();
            FormLoiNhuan frm = new FormLoiNhuan();
            frm.TopLevel = false;
            pntk.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            this.Text = frm.Text;
            frm.Show();
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {

            pntk.Controls.Clear();
            FormSanPham frm = new FormSanPham();
            frm.TopLevel = false;
            pntk.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            this.Text = frm.Text;
            frm.Show();
        }

        private void BLACK_MOBILE_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pntk.Controls.Clear();
            FormNhanVien frm = new FormNhanVien();
            frm.TopLevel = false;
            pntk.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            this.Text = frm.Text;
            frm.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pntk.Controls.Clear();
            FormKhachHang frm = new FormKhachHang();
            frm.TopLevel = false;
            pntk.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            this.Text = frm.Text;
            frm.Show();
        }

        private void tácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pntk.Controls.Clear();
            TacGia frm = new TacGia();
            frm.TopLevel = false;
            pntk.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            this.Text = frm.Text;
            frm.Show();
        }

        private void hướngDẫnSửDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://bom.so/jfOEex");
        }

        private void trởVềToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pntk.Controls.Clear();
            this.Text = "BLACK MOBILE";
        }
    }
}
