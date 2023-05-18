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
    public partial class QLLH : Form
    {
        
        public QLLH()
        {
            InitializeComponent();
        }
        QLCHDataContext db = new QLCHDataContext();
        LOAIHANG tb = new LOAIHANG();
        void Load_Data()
        {
            dgvkh.DataSource = from table in db.LOAIHANGs
                               select new
                               {
                                   table.Maloaihang,
                                   table.Tenloaihang
                               };
            txtmlh.Text = "";
            txttlh.Text = "";
            txtmlh.MaxLength = 10;
            txttlh.MaxLength = 30;
            txtmlh.Focus();

        }

        private void mlh_Click(object sender, EventArgs e)
        {

        }

        private void QLLH_Load(object sender, EventArgs e)
        {
            Load_Data();
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
                tb = (from table in db.LOAIHANGs
                      where table.Maloaihang == txtmlh.Text
                      select table).Single();
                db.LOAIHANGs.DeleteOnSubmit(tb);
                db.SubmitChanges();
                MessageBox.Show("Đã xóa xong!", "Thông báo!");
                Load_Data();
            }
            catch { MessageBox.Show("Chọn mục cần xóa!", "Thông báo!"); }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                QLCHDataContext db = new QLCHDataContext();
            LOAIHANG tb = new LOAIHANG();
           
                if (txtmlh.Text != ""  ) {
                   
                tb.Maloaihang = txtmlh.Text; 
                } 
                if (txttlh.Text != "") {
                    
                tb.Tenloaihang = txttlh.Text;
                } 
                db.LOAIHANGs.InsertOnSubmit(tb);
                db.SubmitChanges();
                MessageBox.Show("Đã thêm xong!", "Thông báo");
                Load_Data();
            }
            catch
            {
              //  MessageBox.Show("Không Được để trống!", "Thông báo!");
                if (txtmlh.Text == "")
                {
                    loiml.ForeColor = Color.Red;
                    loiml.Text = "Lỗi";
                }
                if (txttlh.Text == "")
                {
                    loitl.ForeColor = Color.Red;
                    loitl.Text = "Lỗi";
                }
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            try
            {
                tb = (from table in db.LOAIHANGs
                 where table.Maloaihang == txtmlh.Text
                 select table).Single();
                 if (txttlh.Text != "")
                {   
                tb.Tenloaihang = txttlh.Text;
                } 
            

            db.SubmitChanges();
            MessageBox.Show("Đã sửa xong!", "Thông báo!");
            Load_Data();
            }
            catch { MessageBox.Show("Chọn mục cần sửa!", "Thông báo!"); }
        }

        private void dgvkh_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvkh.Rows[e.RowIndex];
            txtmlh.Text = row.Cells[0].Value.ToString();
            txttlh.Text = row.Cells[1].Value.ToString();
        }

        private void txtmlh_TextChanged(object sender, EventArgs e)
        {
             
        }


        private void txtmlh_KeyPress(object sender, KeyPressEventArgs e)
        {



            if (!((e.KeyChar >= (char)0) && (e.KeyChar <= (char)7) || (e.KeyChar >= (char)9) && (e.KeyChar <= (char)31) || (e.KeyChar >= (char)33) && (e.KeyChar <= (char)44) || (e.KeyChar == (char)47) || (e.KeyChar >= (char)58) && (e.KeyChar <= (char)64) || (e.KeyChar >= (char)91) && (e.KeyChar <= (char)96) || (e.KeyChar >= (char)123) && (e.KeyChar <= (char)191)))
            {

                e.Handled = false;
                loiml.Text = "";
            }
            else
            {
                loiml.ForeColor = Color.Red;
                loiml.Text = "Lỗi";
                txtmlh.Text = "";
                e.Handled = true;
            }

        }

        private void txttlh_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttlh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= (char)0) && (e.KeyChar <= (char)7) || (e.KeyChar >= (char)9) && (e.KeyChar <= (char)31) || (e.KeyChar >= (char)33) && (e.KeyChar <= (char)44) || (e.KeyChar == (char)47) || (e.KeyChar >= (char)58) && (e.KeyChar <= (char)64) || (e.KeyChar >= (char)91) && (e.KeyChar <= (char)96) || (e.KeyChar >= (char)123) && (e.KeyChar <= (char)191)))
            {

                e.Handled = false;
               loitl.Text = "";
            }
            else
            {
                loitl.ForeColor = Color.Red;
                loitl.Text = "Lỗi";
                txttlh.Text = "";
                e.Handled = true;
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
