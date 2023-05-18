using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeQuocHung_BlackMobile.HeThong
{
    public partial class QLTK : Form
    {
        public QLTK()
        {
            InitializeComponent();
        }
        QLCHDataContext db = new QLCHDataContext();
        TAIKHOAN tb = new TAIKHOAN();
        void Load_Data()
        {
            dgvtk.DataSource = from table in db.TAIKHOANs
                               select new
                               {
                                   table.ID,
                                   table.Tendangnhap,
                                   table.Matkhau,
                                   table.Quanly
                                  



                               };
            
            txttdn.Text = "";
            txtmk.Text = "";
            txttdn.MaxLength = 15;
            txtmk.MaxLength = 15;
            txtid.Focus();
            
           

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void QLTK_Load(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                QLCHDataContext db = new QLCHDataContext();
                TAIKHOAN tb = new TAIKHOAN();
                //tb.ID = int.Parse(txtid.Text.ToString()); 
                if (txttdn.Text != "")
                {
                    tb.Tendangnhap = txttdn.Text;
                }
                if (txtmk.Text != "")
                {
                    tb.Matkhau = txtmk.Text;
                }
                tb.Quanly = ckbq.Text;
                if (ckbq.Checked)
                {
                    tb.Quanly = "co";
                }
                else
                {
                    tb.Quanly = "khong";
                }

                db.TAIKHOANs.InsertOnSubmit(tb);
                db.SubmitChanges();
                MessageBox.Show("Đã thêm xong!", "Thông báo");
                Load_Data();
            }
            catch
            {
                MessageBox.Show("Không Được để trống!", "Thông báo!");
                if (txttdn.Text == "")
                {
                    loitk.ForeColor = Color.Red;
                    loitk.Text = "Lỗi";
                }
                if (txtmk.Text == "")
                {
                    loimk.ForeColor = Color.Red;
                    loimk.Text = "Lỗi";
                }
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            try 
            { 
            tb = (from table in db.TAIKHOANs
                  where table.ID == int.Parse(txtid.Text.ToString())
            select table).Single();
            
            tb.Tendangnhap = txttdn.Text;
            tb.Matkhau = txtmk.Text;
            if (ckbq.Checked)
            {
                tb.Quanly = "co";
            }
            else
            {
                tb.Quanly = "khong";
            }

            db.SubmitChanges();
            MessageBox.Show("Đã sửa xong!", "Thông báo!");
            Load_Data();
            }
            catch { MessageBox.Show("Vui lòng chọn mục cần sửa!", "Thông báo!"); 
            }
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
                tb = (from table in db.TAIKHOANs
                      where table.ID == int.Parse(txtid.Text.ToString())
                      select table).Single();
                db.TAIKHOANs.DeleteOnSubmit(tb);
                db.SubmitChanges();
                MessageBox.Show("Đã xóa xong!", "Thông báo!");
                Load_Data();
            }
            catch { MessageBox.Show("Vui lòng chọn mục cần xóa!", "Thông báo!"); }

        }

        private void dgvtk_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvtk.Rows[e.RowIndex];
            txtid.Text = row.Cells[0].Value.ToString();
            txttdn.Text = row.Cells[1].Value.ToString();
            txtmk.Text = row.Cells[2].Value.ToString();
            if (dgvtk.Rows[e.RowIndex].Cells[3].Value.ToString() == "co")
            {
                ckbq.Checked = true;
            }
            else
            {
                ckbq.Checked = false;
            }
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

      

        private void txttdn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= (char)48) && (e.KeyChar <= (char)57)||(e.KeyChar >= (char)65) && (e.KeyChar <= (char)90) || (e.KeyChar >= (char)97) && (e.KeyChar <= (char)122)|| (e.KeyChar == (char)8))
            {

                e.Handled = false;
                loitk.Text = "";
            }
            else
            {
                loitk.ForeColor = Color.Red;
                loitk.Text = "Lỗi";
                txttdn.Text = "";
                e.Handled = true;
            }
        }

        private void txtmk_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= (char)0) && (e.KeyChar <= (char)255) ) 
            {

                e.Handled = false;
                loimk.Text = "";
            }
            else
            {
                loimk.ForeColor = Color.Red;
                loimk.Text = "Lỗi";
                txtmk.Text = "";
                e.Handled = true;
            }

           
        }
    }
}
