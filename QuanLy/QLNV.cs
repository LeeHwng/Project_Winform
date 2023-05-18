using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeQuocHung_BlackMobile.QuanLy
{
    public partial class QLNV : Form
    {
        public QLNV()
        {
            InitializeComponent();
        }
        QLCHDataContext db = new QLCHDataContext();
        NHANVIEN tb = new NHANVIEN();
        void Load_Data()
        {
            dgvkh.DataSource = from table in db.NHANVIENs
                               select new
                               {
                                   table.Manhanvien,
                                   table.Tennhanvien,
                                   table.Ngaysinh,
                                   table.Ngayvaolam,
                                   table.Quequan,
                                   table.Dienthoai,
                                   table.Luongcoban,
                                   table.Phucap
                                   
                               };
            txtmnv.Text = "";
            txttnv.Text = "";
            txtquequan.Text = "";
            txtdt.Text = "";
            txtlcb.Text = "";
            txtpc.Text = "";
            loimnv.Text = "";
            loitnv.Text = "";
            loiqq.Text = "";
            loidt.Text = "";
            loilcb.Text = "";
            loipc.Text = "";
            txtmnv.MaxLength = 10;
            txttnv.MaxLength = 50;
            txtquequan.MaxLength = 150;
            txtdt.MaxLength = 15;
            txtmnv.Focus();

        }

        private void QLNV_Load(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvkh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
          
        }

        private void btnnhapmoi_Click(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn muốn thoát?", " Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                this.Close();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                tb = (from table in db.NHANVIENs
                  where table.Manhanvien == txtmnv.Text
                  select table).Single();
            db.NHANVIENs.DeleteOnSubmit(tb);
            db.SubmitChanges();
            MessageBox.Show("Đã xóa xong!", "Thông báo!");
            Load_Data();
            }
            catch { MessageBox.Show("Vui lòng chọn mục cần xóa!", "Thông báo!"); }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                QLCHDataContext db = new QLCHDataContext();
                NHANVIEN tb = new NHANVIEN();
                if (txtmnv.Text != "")
                {
                    tb.Manhanvien = txtmnv.Text;
                }
                if (txttnv.Text != "")
                {
                    tb.Tennhanvien = txttnv.Text;
                }
                if (DateTime.Parse(dtpns.Text.ToString()) <= DateTime.Now)
                {
                    tb.Ngaysinh = DateTime.Parse(dtpns.Text.ToString());
                }
                if (DateTime.Parse(dtpnvl.Text.ToString()) <= DateTime.Now)
                {
                    tb.Ngayvaolam = DateTime.Parse(dtpnvl.Text.ToString());
                }
                
                if (txtquequan.Text != "")
                {
                    tb.Quequan = txtquequan.Text;
                }
                if (txtdt.Text != "")
                {
                    tb.Dienthoai = txtdt.Text;
                }
                if (txtlcb.Text != "")
                {
                    tb.Luongcoban = int.Parse(txtlcb.Text.ToString());
                }
                if (txtpc.Text != "")
                {
                    tb.Phucap = int.Parse(txtpc.Text.ToString());
                }
                db.NHANVIENs.InsertOnSubmit(tb);
                db.SubmitChanges();
                MessageBox.Show("Đã thêm xong!", "Thông báo");
                Load_Data();
            }
            catch
            {
              //  MessageBox.Show("Không Được để trống!", "Thông báo!");
                if (txtmnv.Text == "")
                {
                    loimnv.ForeColor = Color.Red;
                    loimnv.Text = "Lỗi";
                }
                if (txttnv.Text == "")
                {
                    loitnv.ForeColor = Color.Red;
                    loitnv.Text = "Lỗi";
                }
                if (txtquequan.Text == "")
                {
                    loiqq.ForeColor = Color.Red;
                    loiqq.Text = "Lỗi";
                }
                if (txtdt.Text == "")
                {
                    loidt.ForeColor = Color.Red;
                    loidt.Text = "Lỗi";
                }
                if (txtlcb.Text == "")
                {
                    loilcb.ForeColor = Color.Red;
                    loilcb.Text = "Lỗi";
                }
                if (txtpc.Text == "")
                {
                    loipc.ForeColor = Color.Red;
                    loipc.Text = "Lỗi";
                }
                if (DateTime.Parse(dtpns.Text.ToString()) > DateTime.Now || DateTime.Parse(dtpnvl.Text.ToString()) > DateTime.Now) 
                {
                    MessageBox.Show("Bạn đã chọn ngày trong tương lai. Vui lòng chọn lại","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if(DateTime.Parse(dtpns.Text.ToString()) >= DateTime.Parse(dtpnvl.Text.ToString()))
                {
                    MessageBox.Show("Ngày sinh phải bé hơn ngày vào làm","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
        }
        private void btnsua_Click(object sender, EventArgs e)
        {
            try
            {
                tb = (from table in db.NHANVIENs
                  where table.Manhanvien == txtmnv.Text
                  select table).Single();

                if (txttnv.Text != "")
                {
                    tb.Tennhanvien = txttnv.Text;
                }
                if (DateTime.Parse(dtpns.Text.ToString()) <= DateTime.Now)
                {
                    tb.Ngaysinh = DateTime.Parse(dtpns.Text.ToString());
                }
                if (DateTime.Parse(dtpnvl.Text.ToString()) <= DateTime.Now)
                {
                    tb.Ngayvaolam = DateTime.Parse(dtpnvl.Text.ToString());
                }

                if (txtquequan.Text != "")
                {
                    tb.Quequan = txtquequan.Text;
                }
                if (txtdt.Text != "")
                {
                    tb.Dienthoai = txtdt.Text;
                }
                if (txtlcb.Text != "")
                {
                    tb.Luongcoban = int.Parse(txtlcb.Text.ToString());
                }
                if (txtpc.Text != "")
                {
                    tb.Phucap = int.Parse(txtpc.Text.ToString());
                }

                db.SubmitChanges();
            MessageBox.Show("Đã sửa xong!", "Thông báo!");
            Load_Data();
            }
            catch { MessageBox.Show("Vui lòng chọn mục cần sửa!", "Thông báo!"); }
        }

        private void dgvkh_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvkh.Rows[e.RowIndex];
            txtmnv.Text = row.Cells[0].Value.ToString();
            txttnv.Text = row.Cells[1].Value.ToString();
            dtpns.Text = row.Cells[2].Value.ToString();
            dtpnvl.Text = row.Cells[3].Value.ToString();
            txtquequan.Text = row.Cells[4].Value.ToString();
            txtdt.Text = row.Cells[5].Value.ToString();
            txtlcb.Text = row.Cells[6].Value.ToString();
            txtpc.Text = row.Cells[7].Value.ToString();
        }

        private void txtmnv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= (char)0) && (e.KeyChar <= (char)7) || (e.KeyChar >= (char)9) && (e.KeyChar <= (char)31) || (e.KeyChar >= (char)33) && (e.KeyChar <= (char)44) || (e.KeyChar == (char)47) || (e.KeyChar >= (char)58) && (e.KeyChar <= (char)64) || (e.KeyChar >= (char)91) && (e.KeyChar <= (char)96) || (e.KeyChar >= (char)123) && (e.KeyChar <= (char)191)))
            {

                e.Handled = false;
                loimnv.Text = "";
            }
            else
            {
                loimnv.ForeColor = Color.Red;
                loimnv.Text = "Lỗi";
                txtmnv.Text = "";
                e.Handled = true;
            }
        }

        private void txttnv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= (char)0) && (e.KeyChar <= (char)7) || (e.KeyChar >= (char)9) && (e.KeyChar <= (char)31) || (e.KeyChar >= (char)33) && (e.KeyChar <= (char)44) || (e.KeyChar == (char)47) || (e.KeyChar >= (char)58) && (e.KeyChar <= (char)64) || (e.KeyChar >= (char)91) && (e.KeyChar <= (char)96) || (e.KeyChar >= (char)123) && (e.KeyChar <= (char)191)))
            {

                e.Handled = false;
                loitnv.Text = "";
            }
            else
            {
                loitnv.ForeColor = Color.Red;
                loitnv.Text = "Lỗi";
                txttnv.Text = "";
                e.Handled = true;
            }
        }

        private void txtquequan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= (char)0) && (e.KeyChar <= (char)7) || (e.KeyChar >= (char)9) && (e.KeyChar <= (char)31) || (e.KeyChar >= (char)33) && (e.KeyChar <= (char)43) || (e.KeyChar >= (char)58) && (e.KeyChar <= (char)64) || (e.KeyChar >= (char)91) && (e.KeyChar <= (char)96) || (e.KeyChar >= (char)123) && (e.KeyChar <= (char)191)))
            {

                e.Handled = false;
                loiqq.Text = "";
            }
            else
            {
                loiqq.ForeColor = Color.Red;
                loiqq.Text = "Lỗi";
                txtquequan.Text = "";
                e.Handled = true;
            }
        }

        private void txtdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= (char)48) && (e.KeyChar <= (char)57) || (e.KeyChar == (char)8))
            {

                e.Handled = false;
                loidt.Text = "";
            }
            else
            {
                loidt.ForeColor = Color.Red;
                loidt.Text = "Lỗi";
                txtdt.Text = "";
                e.Handled = true;
            }
        }

        private void txtlcb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= (char)48) && (e.KeyChar <= (char)57) || (e.KeyChar == (char)44) || (e.KeyChar == (char)46) || (e.KeyChar == (char)8))
            {

                e.Handled = false;
                loilcb.Text = "";
            }
            else
            {
                loilcb.ForeColor = Color.Red;
                loilcb.Text = "Lỗi";
                txtlcb.Text = "";
                e.Handled = true;
            }
        }

        private void txtpc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= (char)48) && (e.KeyChar <= (char)57) || (e.KeyChar == (char)44) || (e.KeyChar == (char)46) || (e.KeyChar == (char)8))
            {

                e.Handled = false;
                loipc.Text = "";
            }
            else
            {
                loipc.ForeColor = Color.Red;
                loipc.Text = "Lỗi";
                txtpc.Text = "";
                e.Handled = true;
            }
        }
    }
}
