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
    public partial class QLCTHD : Form
    {
        public QLCTHD()
        {
            InitializeComponent();
        }
        QLCHDataContext db = new QLCHDataContext();
        CHITIETHOADON tb = new CHITIETHOADON();
        void Load_Data()
        {
            dgvcthd.DataSource = from table in db.CHITIETHOADONs
                               select new
                               {
                                   table.Sohoadon,
                                   table.Mahang,
                                   table.Soluong,
                                   table.Giaban,
                                   table.Hinhthucthanhtoan


                               };
            cbbshd.DataSource = from tb in db.HOADONs select tb.Sohoadon;
            cbbmh.DataSource = from tb in db.MATHANGs select tb.Mahang;
            txtsl.Text = "";
            txtgb.Text = "";
            txthttt.Text = "";
            loisl.Text = "";
            loigb.Text = "";
            loihttt.Text = "";
            this.cbbshd.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbbmh.DropDownStyle = ComboBoxStyle.DropDownList;
            txthttt.MaxLength = 30;
            txtsl.Focus();
        }

        private void QLCTHDcs_Load(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                QLCHDataContext db = new QLCHDataContext();
                CHITIETHOADON tb = new CHITIETHOADON();
                tb.Sohoadon = cbbshd.Text;
                tb.Mahang = cbbmh.Text;
                if (txtsl.Text != "")
                {
                    tb.Soluong = int.Parse(txtsl.Text.ToString());
                }
                if (txtgb.Text != "")
                {
                    tb.Giaban = int.Parse(txtgb.Text.ToString());
                }
                if (txthttt.Text != "")
                {
                    tb.Hinhthucthanhtoan = txthttt.Text;
                }

                db.CHITIETHOADONs.InsertOnSubmit(tb);
                db.SubmitChanges();
                MessageBox.Show("Đã thêm xong!", "Thông báo");
                Load_Data();
            }
            catch
            {
                //MessageBox.Show("Không Được để trống!", "Thông báo!");
                if (txtsl.Text == "")
                {
                    loisl.ForeColor = Color.Red;
                    loisl.Text = "Lỗi";
                }
                if (txtgb.Text == "")
                {
                    loigb.ForeColor = Color.Red;
                    loigb.Text = "Lỗi";
                }
                if (txthttt.Text == "")
                {
                    loihttt.ForeColor = Color.Red;
                    loihttt.Text = "Lỗi";
                }
            }
        }
        private void btnsua_Click(object sender, EventArgs e)
        {
            try { 
            tb = (from table in db.CHITIETHOADONs
                  where table.Sohoadon == cbbshd.Text && table.Mahang == cbbmh.Text
                  select table).Single();
                if (txtsl.Text != "")
                {
                    tb.Soluong = int.Parse(txtsl.Text.ToString());
                }
                if (txtgb.Text != "")
                {
                    tb.Giaban = int.Parse(txtgb.Text.ToString());
                }
                if (txthttt.Text != "")
                {
                    tb.Hinhthucthanhtoan = txthttt.Text;
                }
              
           

            db.SubmitChanges();
            MessageBox.Show("Đã sửa xong!", "Thông báo!");
            Load_Data();
            }
            catch { 
                MessageBox.Show("Vui lòng chọn mục cần sửa!", "Thông báo!");
               
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                tb = (from table in db.CHITIETHOADONs
                  where table.Sohoadon == cbbshd.Text && table.Mahang == cbbmh.Text
                  select table).Single();
            db.CHITIETHOADONs.DeleteOnSubmit(tb);
            db.SubmitChanges();
            MessageBox.Show("Đã xóa xong!", "Thông báo!");
            Load_Data();
            }
            catch { MessageBox.Show("Vui lòng chọn mục cần xóa!", "Thông báo!"); }
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

        private void dgvcthd_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvcthd.Rows[e.RowIndex];
            cbbshd.Text = row.Cells[0].Value.ToString();
            cbbmh.Text = row.Cells[1].Value.ToString();
            txtsl.Text = row.Cells[2].Value.ToString();
            txtgb.Text = row.Cells[3].Value.ToString();
            txthttt.Text = row.Cells[4].Value.ToString();
        }

        private void txtsl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= (char)48) && (e.KeyChar <= (char)57) ||(e.KeyChar == (char)44) || (e.KeyChar == (char)46) || (e.KeyChar == (char)8))
            {

                e.Handled = false;
                loisl.Text = "";
            }
            else
            {
                loisl.ForeColor = Color.Red;
                loisl.Text = "Lỗi";
                txtsl.Text = "";
                e.Handled = true;
            }
        }

        private void txtgb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= (char)48) && (e.KeyChar <= (char)57) || (e.KeyChar == (char)44) || (e.KeyChar == (char)46) || (e.KeyChar == (char)8))
            {

                e.Handled = false;
                loigb.Text = "";
            }
            else
            {
                loigb.ForeColor = Color.Red;
                loigb.Text = "Lỗi";
                txtgb.Text = "";
                e.Handled = true;
            }
        }

        private void txthttt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= (char)0) && (e.KeyChar <= (char)7)|| (e.KeyChar >= (char)9) && (e.KeyChar <= (char)31) || (e.KeyChar >= (char)33) && (e.KeyChar <= (char)44) || (e.KeyChar == (char)47) || (e.KeyChar >= (char)58) && (e.KeyChar <= (char)64) || (e.KeyChar >= (char)91) && (e.KeyChar <= (char)96) || (e.KeyChar >= (char)123) && (e.KeyChar <= (char)191)))
            {

                e.Handled = false;
                loihttt.Text = "";
            }
            else
            {
                loihttt.ForeColor = Color.Red;
                loihttt.Text = "Lỗi";
                txthttt.Text = "";
                e.Handled = true;
            }
        }
    }
}
