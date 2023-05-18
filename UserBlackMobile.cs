using LeQuocHung_BlackMobile.HeThong;
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
    public partial class UserBlackMobile : Form
    {
        public UserBlackMobile()
        {
            InitializeComponent();
        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void UserBlackMobile_Load(object sender, EventArgs e)
        {
            Form frm = new BLACK_MOBILE();
           // AddForm(frm);
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn muốn muốn đăng xuất?", " Trả Lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
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
                // Application.Exit();
                this.Close();
           
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void chiThiếtHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void mặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void loạiHàngToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void UserBlackMobile_FormClosing(object sender, FormClosingEventArgs e)
        {

             Application.Exit();
            
            
        }

        private void nhânViênToolStripMenuItem1_Click(object sender, EventArgs e)
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

        private void kháchHàngToolStripMenuItem1_Click(object sender, EventArgs e)
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

        private void hướngDẫnSửDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://bom.so/jfOEex");
        
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

        private void trởVềToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pntk.Controls.Clear();
            this.Text = "BLACK MOBILE";
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
