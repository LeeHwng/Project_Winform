using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeQuocHung_BlackMobile.TimKim
{
    public partial class TKCTHD : Form
    {
        public TKCTHD()
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

            cbbshd.Text = null;
            cbbmh.Text = null;
            this.cbbshd.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbbmh.DropDownStyle = ComboBoxStyle.DropDownList;
            txtgb.Text = "";



        }

        private void TKCTHD_Load(object sender, EventArgs e)
        {
            cbbshd.DataSource = from table in db.CHITIETHOADONs select table.Sohoadon;
            cbbshd.SelectedIndex = -1;
            cbbmh.DataSource = from table in db.CHITIETHOADONs select table.Mahang;
            cbbmh.SelectedIndex = -1;
            Load_Data();
            txtgb.Focus();
        }

        private void btnlm_Click(object sender, EventArgs e)
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

        private void btntk_Click(object sender, EventArgs e)
        {
            if (cbbshd.Text != "" && cbbmh.Text != "" && txtgb.Text != "")
            {

                dgvcthd.DataSource = from table in db.CHITIETHOADONs
                                   where table.Sohoadon == cbbshd.SelectedItem.ToString() && table.Mahang == cbbmh.Text && table.Giaban == int.Parse(txtgb.Text.ToString())
                select new
                                   {
                                       table.Sohoadon,
                                       table.Mahang,
                                       table.Soluong,
                                       table.Giaban,
                                       table.Hinhthucthanhtoan
                                   };

            }
            else
            if (cbbshd.Text != "" && cbbmh.Text != "")
            {
                if (txtgb.Text == "")
                {
                    dgvcthd.DataSource = from table in db.CHITIETHOADONs
                                       where table.Sohoadon == cbbshd.SelectedItem.ToString() && table.Mahang == cbbmh.Text
                                       select new
                                       {
                                           table.Sohoadon,
                                           table.Mahang,
                                           table.Soluong,
                                           table.Giaban,
                                           table.Hinhthucthanhtoan
                                       };
                }
            }
            else
            if (cbbshd.Text != "" && txtgb.Text != "")
            {
                if (cbbmh.Text == "")
                {
                    dgvcthd.DataSource = from table in db.CHITIETHOADONs
                                       where table.Sohoadon == cbbshd.SelectedItem.ToString() && table.Giaban ==  int.Parse(txtgb.Text.ToString())                                      

                                       select new
                                       {
                                           table.Sohoadon,
                                           table.Mahang,
                                           table.Soluong,
                                           table.Giaban,
                                           table.Hinhthucthanhtoan
                                       };
                }
            }
            else
            if (cbbmh.Text != "" && txtgb.Text != "")
            {
                if (cbbshd.Text == "")
                {
                    dgvcthd.DataSource = from table in db.CHITIETHOADONs
                                       where table.Mahang == cbbmh.Text && table.Giaban == int.Parse(txtgb.Text.ToString())
                    select new
                                       {
                                           table.Sohoadon,
                                           table.Mahang,
                                           table.Soluong,
                                           table.Giaban,
                                           table.Hinhthucthanhtoan
                                       };
                }
            }
            if (cbbmh.Text != "")
            {
                if (cbbshd.Text == "" && txtgb.Text == "")
                {
                    dgvcthd.DataSource = from table in db.CHITIETHOADONs
                                         where table.Mahang == cbbmh.Text
                                         select new
                                         {
                                             table.Sohoadon,
                                             table.Mahang,
                                             table.Soluong,
                                             table.Giaban,
                                             table.Hinhthucthanhtoan
                                         };
                }
            }
            else
             if (txtgb.Text != "")
            {
                if (cbbshd.Text == "" && cbbmh.Text == "")
                {
                    dgvcthd.DataSource = from table in db.CHITIETHOADONs
                                         where table.Giaban == int.Parse(txtgb.Text.ToString())
                                         select new
                                         {
                                             table.Sohoadon,
                                             table.Mahang,
                                             table.Soluong,
                                             table.Giaban,
                                             table.Hinhthucthanhtoan
                                         };
                }
            }
            else
            if (cbbshd.Text != "")
            {
                if (txtgb.Text == "" && cbbmh.Text == "")
                {
                    dgvcthd.DataSource = from table in db.CHITIETHOADONs
                                         where table.Sohoadon == cbbshd.SelectedItem.ToString()
                                         select new
                                         {
                                             table.Sohoadon,
                                             table.Mahang,
                                             table.Soluong,
                                             table.Giaban,
                                             table.Hinhthucthanhtoan
                                         };
                }
            }

            else 
            {
                MessageBox.Show("Vui lòng nhập dữ liệu cần tìm","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Error); 
            }
        }

        private void cbbshd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
        
