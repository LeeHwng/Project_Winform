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
    public partial class TKHD : Form
    {
        public TKHD()
        {
            InitializeComponent();
        }
        QLCHDataContext db = new QLCHDataContext();
        HOADON tb = new HOADON();
        void Load_Data()
        {
            dgvhd.DataSource = from table in db.HOADONs
                               select new
                               {
                                   table.Sohoadon,
                                   table.Makhachhang,
                                   table.Manhanvien,
                                   table.Ngaymuahang

                               };

            cbbshd.Text = null;
            txtmkh.Text = "";
            txtmnv.Text = "";
            this.cbbshd.DropDownStyle = ComboBoxStyle.DropDownList;


        }

        private void TKHD_Load(object sender, EventArgs e)
        {
            cbbshd.DataSource = from table in db.HOADONs select table.Sohoadon;
            cbbshd.SelectedIndex = -1;
            Load_Data();
            txtmkh.Focus();
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
            if (cbbshd.Text != "" && txtmkh.Text != "" && txtmnv.Text != "")
            {

                dgvhd.DataSource = from table in db.HOADONs
                                   where table.Sohoadon == cbbshd.SelectedItem.ToString() && table.Makhachhang == txtmkh.Text && table.Manhanvien == txtmnv.Text
                                   select new
                                   {
                                       table.Sohoadon,
                                       table.Makhachhang,
                                       table.Manhanvien,
                                       table.Ngaymuahang
                                   };

            }
            else
            if (cbbshd.Text != "" && txtmkh.Text != "")
            {
                if (txtmnv.Text == "")
                {
                    dgvhd.DataSource = from table in db.HOADONs
                                       where table.Sohoadon == cbbshd.SelectedItem.ToString() && table.Makhachhang == txtmkh.Text
                                       select new
                                       {
                                           table.Sohoadon,
                                           table.Makhachhang,
                                           table.Manhanvien,
                                           table.Ngaymuahang
                                       };
                }
            }
            else
            if (cbbshd.Text != "" && txtmnv.Text != "")
            {
                if (txtmkh.Text == "")
                {
                    dgvhd.DataSource = from table in db.HOADONs
                                       where table.Sohoadon == cbbshd.SelectedItem.ToString() && table.Manhanvien == txtmnv.Text
                                       select new
                                       {
                                           table.Sohoadon,
                                           table.Makhachhang,
                                           table.Manhanvien,
                                           table.Ngaymuahang
                                       };
                }
            }
            else
            if (txtmkh.Text != "" && txtmnv.Text != "")
            {
                if (cbbshd.Text == "")
                {
                    dgvhd.DataSource = from table in db.HOADONs
                                       where table.Makhachhang == txtmkh.Text && table.Manhanvien == txtmnv.Text
                                       select new
                                       {
                                           table.Sohoadon,
                                           table.Makhachhang,
                                           table.Manhanvien,
                                           table.Ngaymuahang
                                       };
                }
            }
            if (txtmkh.Text != "")
            {
                if (cbbshd.Text == "" && txtmnv.Text == "")
                {
                    dgvhd.DataSource = from table in db.HOADONs
                                       where table.Makhachhang == txtmkh.Text
                                       select new
                                       {
                                           table.Sohoadon,
                                           table.Makhachhang,
                                           table.Manhanvien,
                                           table.Ngaymuahang
                                       };
                }
            }
            else
             if (txtmnv.Text != "")
            {
                if (cbbshd.Text == "" && txtmkh.Text == "")
                {
                    dgvhd.DataSource = from table in db.HOADONs
                                       where table.Manhanvien == txtmnv.Text
                                       select new
                                       {
                                           table.Sohoadon,
                                           table.Makhachhang,
                                           table.Manhanvien,
                                           table.Ngaymuahang
                                       };
                }
            }
            else
            if (cbbshd.Text != "")
            {
                if (txtmnv.Text == "" && txtmkh.Text == "")
                {
                    dgvhd.DataSource = from table in db.HOADONs
                                       where table.Sohoadon == cbbshd.SelectedItem.ToString()
                                       select new
                                       {
                                           table.Sohoadon,
                                           table.Makhachhang,
                                           table.Manhanvien,
                                           table.Ngaymuahang
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
      
