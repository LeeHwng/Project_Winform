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
    public partial class QLNCC : Form
    {
        public QLNCC()
        {
            InitializeComponent();
        }
        QLCHDataContext db = new QLCHDataContext();
        NHACUNGCAP tb = new NHACUNGCAP();
        void Load_Data()
        {
            dgvkh.DataSource = from table in db.NHACUNGCAPs
                               select new
                               {
                                   table.Macongty,
                                   table.Tencongty,
                                   table.Diachi,
                                   table.Dienthoai,
                                   table.Email
                               };
            txtmct.Text = "";
            txttct.Text = "";
            txtdc.Text = "";
            txtdt.Text = "";
            txtemail.Text = "";
            loimct.Text = "";
            loitct.Text = "";
            loidc.Text = "";
            loidt.Text = "";
            loiemail.Text = "";

            txtmct.MaxLength = 10;
            txttct.MaxLength = 50;
            txtdc.MaxLength = 150;
            txtdt.MaxLength = 15;
            txtemail.MaxLength = 50;

            txtmct.Focus();
           
        }

        private void dgvkh_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvkh.Rows[e.RowIndex];
            txtmct.Text = row.Cells[0].Value.ToString();
            txttct.Text = row.Cells[1].Value.ToString();
            txtdc.Text = row.Cells[2].Value.ToString();
            txtdt.Text = row.Cells[3].Value.ToString();
            txtemail.Text = row.Cells[4].Value.ToString();
        }

        private void QLNCC_Load(object sender, EventArgs e)
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
                tb = (from table in db.NHACUNGCAPs
                  where table.Macongty == txtmct.Text
                  select table).Single();
            db.NHACUNGCAPs.DeleteOnSubmit(tb);
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
                NHACUNGCAP tb = new NHACUNGCAP();
                if (txtmct.Text != "")
                {
                    tb.Macongty = txtmct.Text;
                }
                if (txttct.Text != "")
                {
                    tb.Tencongty = txttct.Text;
                }
                if (txtdc.Text != "")
                {
                    tb.Diachi = txtdc.Text;
                }
                if (txtdt.Text != "")
                {
                    tb.Dienthoai = txtdt.Text;
                }
                
                    tb.Email = txtemail.Text;
                
                db.NHACUNGCAPs.InsertOnSubmit(tb);
                db.SubmitChanges();
                MessageBox.Show("Đã thêm xong!", "Thông báo");
                Load_Data();
            }
            catch
            {
              //  MessageBox.Show("Không Được để trống!", "Thông báo!");
                if (txtmct.Text == "")
                {
                    loimct.ForeColor = Color.Red;
                    loimct.Text = "Lỗi";
                }
                if (txttct.Text == "")
                {
                    loitct.ForeColor = Color.Red;
                    loitct.Text = "Lỗi";
                }
                if (txtdc.Text == "")
                {
                    loidc.ForeColor = Color.Red;
                    loidc.Text = "Lỗi";
                }
                if (txtdt.Text == "")
                {
                    loidt.ForeColor = Color.Red;
                    loidt.Text = "Lỗi";
                }
               
            }
        }
        private void btnsua_Click(object sender, EventArgs e)
        {
            try
            {
                tb = (from table in db.NHACUNGCAPs
                  where table.Macongty == txtmct.Text
                  select table).Single();
                if (txttct.Text != "")
                {
                    tb.Tencongty = txttct.Text;
                }
                if (txtdc.Text != "")
                {
                    tb.Diachi = txtdc.Text;
                }
                if (txtdt.Text != "")
                {
                    tb.Dienthoai = txtdt.Text;
                }
                if (txtemail.Text != "")
                {
                    tb.Email = txtemail.Text;
                }

                db.SubmitChanges();
            MessageBox.Show("Đã sửa xong!", "Thông báo!");
            Load_Data();
            }
            catch { MessageBox.Show("Vui lòng chọn mục cần sửa!", "Thông báo!"); }
        }

        private void btnnhapmoi_Click(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void txtmct_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmct_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= (char)0) && (e.KeyChar <= (char)7) || (e.KeyChar >= (char)9) && (e.KeyChar <= (char)31) || (e.KeyChar >= (char)33) && (e.KeyChar <= (char)44) || (e.KeyChar == (char)47) || (e.KeyChar >= (char)58) && (e.KeyChar <= (char)64) || (e.KeyChar >= (char)91) && (e.KeyChar <= (char)96) || (e.KeyChar >= (char)123) && (e.KeyChar <= (char)191)))
            {

                e.Handled = false;
                loimct.Text = "";
            }
            else
            {
                loimct.ForeColor = Color.Red;
                loimct.Text = "Lỗi";
                txtmct.Text = "";
                e.Handled = true;
            }
        }

        private void txttct_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= (char)0) && (e.KeyChar <= (char)7) || (e.KeyChar >= (char)9) && (e.KeyChar <= (char)31) || (e.KeyChar >= (char)33) && (e.KeyChar <= (char)44) || (e.KeyChar == (char)47) || (e.KeyChar >= (char)58) && (e.KeyChar <= (char)64) || (e.KeyChar >= (char)91) && (e.KeyChar <= (char)96) || (e.KeyChar >= (char)123) && (e.KeyChar <= (char)191)))
            {

                e.Handled = false;
                loitct.Text = "";
            }
            else
            {
                loitct.ForeColor = Color.Red;
                loitct.Text = "Lỗi";
                txttct.Text = "";
                e.Handled = true;
            }
        }

        private void txtdc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= (char)0) && (e.KeyChar <= (char)7) || (e.KeyChar >= (char)9) && (e.KeyChar <= (char)31) || (e.KeyChar >= (char)33) && (e.KeyChar <= (char)43) || (e.KeyChar >= (char)58) && (e.KeyChar <= (char)64) || (e.KeyChar >= (char)91) && (e.KeyChar <= (char)96) || (e.KeyChar >= (char)123) && (e.KeyChar <= (char)191)))
            {

                e.Handled = false;
                loidc.Text = "";
            }
            else
            {
                loidc.ForeColor = Color.Red;
                loidc.Text = "Lỗi";
                txtdc.Text = "";
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

        private void txtemail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)8) || (e.KeyChar == (char)46) || (e.KeyChar >= (char)48) && (e.KeyChar <= (char)57) || (e.KeyChar >= (char)64) && (e.KeyChar <= (char)90) || (e.KeyChar >= (char)97) && (e.KeyChar <= (char)122))
            {

                e.Handled = false;
                loiemail.Text = "";
            }
            else
            {
                loiemail.ForeColor = Color.Red;
                loiemail.Text = "Lỗi";
                txtemail.Text = "";
                e.Handled = true;
            }
        }
    }
    }

