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
    public partial class QLMH : Form
    {
        public QLMH()
        {
            InitializeComponent();
        }
        QLCHDataContext db = new QLCHDataContext();
        MATHANG tb = new MATHANG();
        void Load_Data()
        {
            dgvmh.DataSource = from table in db.MATHANGs
                               select new
                               {
                                   table.Mahang,
                                   table.Tenhang,
                                   table.Macongty,
                                   table.Maloaihang,
                                   table.Soluong,
                                   table.Thoigianbaohanh,
                                   table.Donvitinh,
                                   table.Giahang,
                                   table.Ngaynhaphang,



                               };
            txtmh.Text = "";
            txtth.Text = "";
            cbbmct.DataSource = from tb in db.NHACUNGCAPs select tb.Macongty;
            cbbmlh.DataSource = from tb in db.LOAIHANGs select tb.Maloaihang;
            txtsl.Text = "";
            txttgbh.Text = "";
            txtdvt.Text = "";
            txtgh.Text = "";
            dtpnnh.Text = "";
            loimh.Text = "";
            loith.Text = "";
            loisl.Text = "";
            loitgbh.Text = "";
            loidvt.Text = "";
            loigh.Text = "";

        
            txtmh.MaxLength = 30;
            txtth.MaxLength = 100;
            txttgbh.MaxLength = 15;
            txtdvt.MaxLength =10;
          


            txtmh.Focus();
            this.cbbmct.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbbmlh.DropDownStyle = ComboBoxStyle.DropDownList;
        }
            private void QLMH_Load(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {


            try
            {
                QLCHDataContext db = new QLCHDataContext();
                MATHANG tb = new MATHANG();
                if (txtmh.Text != "")
                {
                    tb.Mahang = txtmh.Text;
                }
                if (txtth.Text != "")
                {
                    tb.Tenhang = txtth.Text;
                }
               
                    tb.Macongty = cbbmct.Text;
               
               
                    tb.Maloaihang = cbbmlh.Text;
                
                if (txtsl.Text != "")
                {
                    tb.Soluong = int.Parse(txtsl.Text.ToString());
                }
                if (txttgbh.Text != "")
                {
                    tb.Thoigianbaohanh = txttgbh.Text;
                }
                if (txtdvt.Text != "")
                {
                    tb.Donvitinh = txtdvt.Text;
                }
                if (txtgh.Text != "")
                {
                    tb.Giahang = int.Parse(txtgh.Text.ToString());
                }
                if (DateTime.Parse(dtpnnh.Text.ToString()) <= DateTime.Now)
                {
                    tb.Ngaynhaphang = DateTime.Parse(dtpnnh.Text.ToString());
                }
               


                db.MATHANGs.InsertOnSubmit(tb);
                db.SubmitChanges();
                MessageBox.Show("Đã thêm xong!", "Thông báo");
                Load_Data();
            }
            catch
            {
               // MessageBox.Show("Không Được để trống!", "Thông báo!");
                if (txtmh.Text == "")
                {
                    loimh.ForeColor = Color.Red;
                    loimh.Text = "Lỗi";
                }
                if (txtth.Text == "")
                {
                    loith.ForeColor = Color.Red;
                    loith.Text = "Lỗi";
                }
                if (txtsl.Text == "")
                {
                    loisl.ForeColor = Color.Red;
                    loisl.Text = "Lỗi";
                }
                if (txttgbh.Text == "")
                {
                    loitgbh.ForeColor = Color.Red;
                    loitgbh.Text = "Lỗi";
                }
                if (txtdvt.Text == "")
                {
                    loidvt.ForeColor = Color.Red;
                    loidvt.Text = "Lỗi";
                }
                if (txtgh.Text == "")
                {
                    loigh.ForeColor = Color.Red;
                    loigh.Text = "Lỗi";
                }
                if (DateTime.Parse(dtpnnh.Text.ToString()) > DateTime.Now)
                {
                    MessageBox.Show("Bạn đã chọn ngày trong tương lai. Vui lòng chọn lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
            

        private void btnsua_Click(object sender, EventArgs e)
        {
            try
            {
            tb = (from table in db.MATHANGs
            where table.Mahang == txtmh.Text
            select table).Single();
                if (txtth.Text != "")
                {
                    tb.Tenhang = txtth.Text;
                }

                tb.Macongty = cbbmct.Text;


                tb.Maloaihang = cbbmlh.Text;

                if (txtsl.Text != "")
                {
                    tb.Soluong = int.Parse(txtsl.Text.ToString());
                }
                if (txttgbh.Text != "")
                {
                    tb.Thoigianbaohanh = txttgbh.Text;
                }
                if (txtdvt.Text != "")
                {
                    tb.Donvitinh = txtdvt.Text;
                }
                if (txtgh.Text != "")
                {
                    tb.Giahang = int.Parse(txtgh.Text.ToString());
                }
                if (DateTime.Parse(dtpnnh.Text.ToString()) <= DateTime.Now)
                {
                    tb.Ngaynhaphang = DateTime.Parse(dtpnnh.Text.ToString());
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
                tb = (from table in db.MATHANGs
                  where table.Mahang == txtmh.Text
                  select table).Single();
            db.MATHANGs.DeleteOnSubmit(tb);
            db.SubmitChanges();
            MessageBox.Show("Đã xóa xong!", "Thông báo!");
            Load_Data();
            }
            catch { MessageBox.Show("Vui lòng chọn mục cần xóa!", "Thông báo!"); }
        }

        private void dgvmh_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvmh.Rows[e.RowIndex];
            txtmh.Text = row.Cells[0].Value.ToString();
            txtth.Text = row.Cells[1].Value.ToString();
            cbbmct.Text = row.Cells[2].Value.ToString();
            cbbmlh.Text = row.Cells[3].Value.ToString();
            txtsl.Text = row.Cells[4].Value.ToString();
            txttgbh.Text = row.Cells[5].Value.ToString();
            txtdvt.Text = row.Cells[6].Value.ToString();
            txtgh.Text = row.Cells[7].Value.ToString();
            dtpnnh.Text = row.Cells[8].Value.ToString();
        }

        private void dgvmh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

         
        }

        private void txtsl_TextChanged(object sender, EventArgs e)
        {
            
           
        }

        private void txtmh_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= (char)0) && (e.KeyChar <= (char)7) || (e.KeyChar >= (char)9) && (e.KeyChar <= (char)31) || (e.KeyChar >= (char)33) && (e.KeyChar <= (char)44) || (e.KeyChar == (char)47) || (e.KeyChar >= (char)58) && (e.KeyChar <= (char)64) || (e.KeyChar >= (char)91) && (e.KeyChar <= (char)96) || (e.KeyChar >= (char)123) && (e.KeyChar <= (char)191)))
            {

                e.Handled = false;
                loimh.Text = "";
            }
            else
            {
                loimh.ForeColor = Color.Red;
                loimh.Text = "Lỗi";
                txtmh.Text = "";
                e.Handled = true;
            }
        }

        private void txtth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= (char)0) && (e.KeyChar <= (char)7) || (e.KeyChar >= (char)9) && (e.KeyChar <= (char)31) || (e.KeyChar >= (char)33) && (e.KeyChar <= (char)44) || (e.KeyChar == (char)47) || (e.KeyChar >= (char)58) && (e.KeyChar <= (char)64) || (e.KeyChar >= (char)91) && (e.KeyChar <= (char)96) || (e.KeyChar >= (char)123) && (e.KeyChar <= (char)191)))
            {

                e.Handled = false;
                loith.Text = "";
            }
            else
            {
                loith.ForeColor = Color.Red;
                loith.Text = "Lỗi";
                txtth.Text = "";
                e.Handled = true;
            }
        }

        private void txttgbh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= (char)0) && (e.KeyChar <= (char)7) || (e.KeyChar >= (char)9) && (e.KeyChar <= (char)31) || (e.KeyChar >= (char)33) && (e.KeyChar <= (char)44) || (e.KeyChar == (char)47) || (e.KeyChar >= (char)58) && (e.KeyChar <= (char)64) || (e.KeyChar >= (char)91) && (e.KeyChar <= (char)96) || (e.KeyChar >= (char)123) && (e.KeyChar <= (char)191)))
            {

                e.Handled = false;
                loitgbh.Text = "";
            }
            else
            {
                loitgbh.ForeColor = Color.Red;
                loitgbh.Text = "Lỗi";
                txttgbh.Text = "";
                e.Handled = true;
            }
        }

        private void txtdvt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= (char)0) && (e.KeyChar <= (char)7) || (e.KeyChar >= (char)9) && (e.KeyChar <= (char)31) || (e.KeyChar >= (char)33) && (e.KeyChar <= (char)44) || (e.KeyChar == (char)47) || (e.KeyChar >= (char)58) && (e.KeyChar <= (char)64) || (e.KeyChar >= (char)91) && (e.KeyChar <= (char)96) || (e.KeyChar >= (char)123) && (e.KeyChar <= (char)191)))
            {

                e.Handled = false;
                loidvt.Text = "";
            }
            else
            {
                loidvt.ForeColor = Color.Red;
                loidvt.Text = "Lỗi";
                txtdvt.Text = "";
                e.Handled = true;
            }
        }

        private void txtgh_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtsl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= (char)48) && (e.KeyChar <= (char)57) || (e.KeyChar == (char)44) || (e.KeyChar == (char)46) || (e.KeyChar == (char)8))
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

        private void txtgh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= (char)48) && (e.KeyChar <= (char)57) || (e.KeyChar == (char)44) || (e.KeyChar == (char)46) || (e.KeyChar == (char)8))
            {

                e.Handled = false;
                loigh.Text = "";
            }
            else
            {
                loigh.ForeColor = Color.Red;
                loigh.Text = "Lỗi";
                txtgh.Text = "";
                e.Handled = true;
            }
        }
    }
}
