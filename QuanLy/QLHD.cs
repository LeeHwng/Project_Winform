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
    public partial class QLHD : Form
    {
        public QLHD()
        {
            InitializeComponent();
        }
        QLCHDataContext db = new QLCHDataContext();
        HOADON tb = new HOADON();
        void Load_Data()
        {
            dgvkh.DataSource = from table in db.HOADONs
                               select new
                               {
                                   table.Sohoadon,
                                   table.Makhachhang,
                                   table.Manhanvien,
                                   table.Ngaymuahang
                                   

                               };
            txtshd.Text = "";
            cbbmkh.DataSource = from tb in db.KHACHHANGs select tb.Makhachhang   ;
            cbbmnv.DataSource = from tb in db.NHANVIENs select tb.Manhanvien;
            dtpndh.Text = "";
            loishd.Text = "";
            this.cbbmkh.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbbmnv.DropDownStyle = ComboBoxStyle.DropDownList;
            txtshd.MaxLength = 10;
            txtshd.Focus();
        }

            private void QLHD_Load(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                QLCHDataContext db = new QLCHDataContext();
                HOADON tb = new HOADON();
                if (txtshd.Text != "")
                {
                    tb.Sohoadon = txtshd.Text;
                }
                tb.Makhachhang = cbbmkh.Text;
                tb.Manhanvien = cbbmnv.Text;
                if (DateTime.Parse(dtpndh.Text.ToString()) <= DateTime.Now)
                {
                    tb.Ngaymuahang = DateTime.Parse(dtpndh.Text.ToString());
                }
                db.HOADONs.InsertOnSubmit(tb);
                db.SubmitChanges();
                MessageBox.Show("Đã thêm xong!", "Thông báo");
                Load_Data();
            }
            catch
            {
                //  MessageBox.Show("Không Được để trống!", "Thông báo!");
                if (txtshd.Text == "")
                {
                    loishd.ForeColor = Color.Red;
                    loishd.Text = "Lỗi";
                }
                if (DateTime.Parse(dtpndh.Text.ToString()) > DateTime.Now)
                {
                    MessageBox.Show("Bạn đã chọn ngày trong tương lai. Vui lòng chọn lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            try
            {
                tb = (from table in db.HOADONs
                     where table.Sohoadon == txtshd.Text
                     select table).Single();
                     tb.Makhachhang = cbbmkh.Text;
                     tb.Manhanvien = cbbmnv.Text;
                if (DateTime.Parse(dtpndh.Text.ToString()) <= DateTime.Now)
                {
                    tb.Ngaymuahang = DateTime.Parse(dtpndh.Text.ToString());
                }
                db.SubmitChanges();
            MessageBox.Show("Đã sửa xong!", "Thông báo!");
            Load_Data();
            }
            catch { MessageBox.Show("Vui lòng chọn mục cần sửa!", "Thông báo!"); }

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                tb = (from table in db.HOADONs
                  where table.Sohoadon == txtshd.Text
                  select table).Single();
            db.HOADONs.DeleteOnSubmit(tb);
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

        private void dgvkh_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvkh.Rows[e.RowIndex];
            txtshd.Text = row.Cells[0].Value.ToString();
            cbbmkh.Text = row.Cells[1].Value.ToString();
            cbbmnv.Text = row.Cells[2].Value.ToString();
            dtpndh.Text = row.Cells[3].Value.ToString();
            
        }

        private void txtshd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= (char)0) && (e.KeyChar <= (char)7) || (e.KeyChar >= (char)9) && (e.KeyChar <= (char)31) || (e.KeyChar >= (char)33) && (e.KeyChar <= (char)44) || (e.KeyChar == (char)47) || (e.KeyChar >= (char)58) && (e.KeyChar <= (char)64) || (e.KeyChar >= (char)91) && (e.KeyChar <= (char)96) || (e.KeyChar >= (char)123) && (e.KeyChar <= (char)191)))
            {

                e.Handled = false;
                loishd.Text = "";
            }
            else
            {
                loishd.ForeColor = Color.Red;
                loishd.Text = "Lỗi";
                txtshd.Text = "";
                e.Handled = true;
            }
        }
    }
}
