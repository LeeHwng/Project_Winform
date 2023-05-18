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
    public partial class TKKH : Form
    {
        public TKKH()
        {
            InitializeComponent();
        }
        QLCHDataContext db = new QLCHDataContext();
        KHACHHANG tb = new KHACHHANG();
        void Load_Data()
        {
            dgvkh.DataSource = from table in db.KHACHHANGs
                               select new
                               {
                                   table.Makhachhang,
                                   table.Tenkhachhang,
                                   table.Diachi,
                                   table.Dienthoai,
                                   table.Email
                               };
            
            cbbmkh.Text = null;
            txttkh.Text = "";
            txtdt.Text = "";
            this.cbbmkh.DropDownStyle = ComboBoxStyle.DropDownList;



        }

        private void TKKH_Load(object sender, EventArgs e)
        {
            cbbmkh.DataSource = from table in db.KHACHHANGs select table.Makhachhang;
            cbbmkh.SelectedIndex = -1;
            Load_Data();
            txttkh.Focus();
        }

        private void btnlm_Click(object sender, EventArgs e)
        {
            Load_Data();
            /*dgvkh.Rows.Clear();
            dgvkh.Refresh();*/

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
           
            if (cbbmkh.Text != "" && txttkh.Text != "" && txtdt.Text != "" )
            {
               
                    dgvkh.DataSource = from table in db.KHACHHANGs
                                       where table.Makhachhang == cbbmkh.SelectedItem.ToString() && table.Tenkhachhang == txttkh.Text && table.Dienthoai == txtdt.Text 
                                       select new
                                       {
                                           table.Makhachhang,
                                           table.Tenkhachhang,
                                           table.Diachi,
                                           table.Dienthoai,
                                           table.Email
                                       }; 
                
            }
            else
             if (cbbmkh.Text != "" && txttkh.Text != "")
            {
                if (txtdt.Text == "")
                {
                    dgvkh.DataSource = from table in db.KHACHHANGs
                                       where table.Makhachhang == cbbmkh.SelectedItem.ToString() && table.Tenkhachhang == txttkh.Text
                                       select new
                                       {
                                           table.Makhachhang,
                                           table.Tenkhachhang,
                                           table.Diachi,
                                           table.Dienthoai,
                                           table.Email
                                       }; 
                }
            }
            else
             if (cbbmkh.Text != "" && txtdt.Text != "")
            {
                if (txttkh.Text == "")
                {
                    dgvkh.DataSource = from table in db.KHACHHANGs
                                       where table.Makhachhang == cbbmkh.SelectedItem.ToString() && table.Dienthoai == txtdt.Text
                                       select new
                                       {
                                           table.Makhachhang,
                                           table.Tenkhachhang,
                                           table.Diachi,
                                           table.Dienthoai,
                                           table.Email
                                       };
                }
            }
            else
             if ( txttkh.Text != "" && txtdt.Text != "")
            {
                if (cbbmkh.Text == "")
                {
                    dgvkh.DataSource = from table in db.KHACHHANGs
                                       where table.Tenkhachhang == txttkh.Text && table.Dienthoai == txtdt.Text
                                       select new
                                       {
                                           table.Makhachhang,
                                           table.Tenkhachhang,
                                           table.Diachi,
                                           table.Dienthoai,
                                           table.Email
                                       }; 
                }
            }
            if (txttkh.Text != "")
            {
                if (cbbmkh.Text == "" && txtdt.Text == "")
                {
                    dgvkh.DataSource = from table in db.KHACHHANGs
                                       where table.Tenkhachhang == txttkh.Text
                                       select new
                                       {
                                           table.Makhachhang,
                                           table.Tenkhachhang,
                                           table.Diachi,
                                           table.Dienthoai,
                                           table.Email
                                       };
                }
            }
            else
             if (txtdt.Text != "")
            {
                if (cbbmkh.Text == "" && txttkh.Text == "")
                {
                    dgvkh.DataSource = from table in db.KHACHHANGs
                                       where table.Dienthoai == txtdt.Text
                                       select new
                                       {
                                           table.Makhachhang,
                                           table.Tenkhachhang,
                                           table.Diachi,
                                           table.Dienthoai,
                                           table.Email
                                       };
                }
            }
            else
            if (cbbmkh.Text != "")
            {
                if (txtdt.Text == "" && txttkh.Text == "")
                {
                    dgvkh.DataSource = from table in db.KHACHHANGs
                                       where table.Makhachhang == cbbmkh.SelectedItem.ToString()
                                       select new
                                       {
                                           table.Makhachhang,
                                           table.Tenkhachhang,
                                           table.Diachi,
                                           table.Dienthoai,
                                           table.Email
                                       };
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập dữ liệu cần tìm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

         
    }
    
}
