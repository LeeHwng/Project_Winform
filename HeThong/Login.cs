using LeQuocHung_BlackMobile.QuanLy;
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

namespace LeQuocHung_BlackMobile.HeThong
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }
        QLCHDataContext db = new QLCHDataContext();
        TAIKHOAN tb = new TAIKHOAN();
        void Load_Data()
        {
            dgvdn.DataSource = from table in db.TAIKHOANs
                               select new
                               {
                                   table.ID,
                                   table.Tendangnhap,
                                   table.Matkhau,
                                   table.Quanly

                               };

            txttdn.Text = "";
            txtmk.Text = "";
            txtmk.PasswordChar = '*';
            txttdn.Focus();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void dgvdn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Load_Data();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn muốn thoát?", " Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)

                // Application.Exit();
                this.Close();
        }

        private void btndn_Click(object sender, EventArgs e)
        {
            try
            {
               
                for (int i = 0; i <= dgvdn.Rows.Count; i++)
                {


                    if (txttdn.Text == dgvdn.Rows[i].Cells[1].Value.ToString() &&
                       txtmk.Text == dgvdn.Rows[i].Cells[2].Value.ToString())
                    {
                     

                        switch (dgvdn.Rows[i].Cells[3].Value.ToString())
                        {
                            case "co":
                                MessageBox.Show("Chào " + txttdn.Text.ToUpper() + " Đến Với Black Mobile", "Chào Mừng");
                                Form ct = new BLACK_MOBILE();
                                this.Hide();
                                ct.ShowDialog();
                                txttdn.Text = "";
                                txtmk.Text = "";
                                break;
                            case "khong":
                                MessageBox.Show("Chào " + txttdn.Text.ToUpper() + " Đến Với Black Mobile", "Chào Mừng");
                                Form ff = new UserBlackMobile();
                                this.Hide();
                                ff.ShowDialog();
                                txttdn.Text = "";
                                txtmk.Text = "";
                                break;

                        }
                    }

                    else

                      if (txttdn.Text == dgvdn.Rows[i].Cells[1].Value.ToString() &&
                         dgvdn.Rows[i].Cells[2].Value.ToString() != txtmk.Text)

                     {
                         txttdn.Text = "";
                         txtmk.Text = "";
                         MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!!! Vui lòng thử lại!!", "Thông Báo");
                         break;

                     }
                    if (txttdn.Text == "" && (txtmk.Text == ""))
                    { MessageBox.Show("Chưa nhập tên đăng nhập và mật khẩu ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); break; }
                    else if (txttdn.Text == "")
                    { MessageBox.Show("Chưa nhập tên đăng nhập", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); break; }
                    else if (txtmk.Text == "")
                    { MessageBox.Show("Chưa nhập mật khẩu ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); break; }

                    else if (i +1 == dgvdn.Rows.Count)
                      {
                       
                          MessageBox.Show("Tài khoản không tồn tại!!! Vui lòng thử lại!!" , "Thông Báo");
                        

                      }

                }
            }
            catch
            {
                if (txttdn.Text == "" && (txtmk.Text == ""))
                { MessageBox.Show("Chưa nhập tên đăng nhập và mật khẩu ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                else if (txttdn.Text == "")
                { MessageBox.Show("Chưa nhập tên đăng nhập", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                else if (txtmk.Text == "")
                { MessageBox.Show("Chưa nhập mật khẩu ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
        } 

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtmk_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void an_Click(object sender, EventArgs e)
        {
            if (txtmk.PasswordChar == '\0')
            {
                hien.BringToFront();
                txtmk.PasswordChar = '*';
            }
        }

        private void hien_Click(object sender, EventArgs e)
        {
           
            if (txtmk.PasswordChar == '*')
            {
                an.BringToFront();
                txtmk.PasswordChar = '\0';
            }
        }

        
    }


    }


