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
    public partial class TKMH : Form
    {
        public TKMH()
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
                                   table.Ngaynhaphang
                               };

            cbbmh.Text = null;
            txtth.Text = "";
            txtgh.Text = "";
            this.cbbmh.DropDownStyle = ComboBoxStyle.DropDownList;


        }

        private void TKMH_Load(object sender, EventArgs e)
        {
            cbbmh.DataSource = from table in db.MATHANGs select table.Mahang;
            cbbmh.SelectedIndex = -1;
            Load_Data();
            txtth.Focus();
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
            if (cbbmh.Text != "" && txtth.Text != "" && txtgh.Text != "")
            {

                dgvmh.DataSource = from table in db.MATHANGs
                                   where table.Mahang == cbbmh.SelectedItem.ToString() && table.Tenhang == txtth.Text && table.Giahang == int.Parse(txtgh.Text.ToString())
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
                                       table.Ngaynhaphang
                                   };

            }
            else
            if (cbbmh.Text != "" && txtth.Text != "")
            {
                if (txtgh.Text == "")
                {
                    dgvmh.DataSource = from table in db.MATHANGs
                                       where table.Mahang == cbbmh.SelectedItem.ToString() && table.Tenhang == txtth.Text
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
                                           table.Ngaynhaphang
                                       };
                }
            }
            else
            if (cbbmh.Text != "" && txtgh.Text != "")
            {
                if (txtth.Text == "")
                {
                    dgvmh.DataSource = from table in db.MATHANGs
                                       where table.Mahang == cbbmh.SelectedItem.ToString() && table.Giahang == int.Parse(txtgh.Text.ToString())
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
                                           table.Ngaynhaphang
                                       };
                }
            }
            else
            if (txtth.Text != "" && txtgh.Text != "")
            {
                if (cbbmh.Text == "")
                {
                    dgvmh.DataSource = from table in db.MATHANGs
                                       where table.Tenhang == txtth.Text && table.Giahang == int.Parse(txtgh.Text.ToString())
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
                                           table.Ngaynhaphang
                                       };
                }
            }
            if (txtth.Text != "")
            {
                if (cbbmh.Text == "" && txtgh.Text == "")
                {
                    dgvmh.DataSource = from table in db.MATHANGs
                                       where table.Tenhang == txtth.Text
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
                                           table.Ngaynhaphang
                                       };
                }
            }
            else
             if (txtgh.Text != "")
            {
                if (cbbmh.Text == "" && txtth.Text == "")
                {
                    dgvmh.DataSource = from table in db.MATHANGs
                                       where table.Giahang == int.Parse(txtgh.Text.ToString())
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
                                           table.Ngaynhaphang
                                       };
                }
            }
            else
            if (cbbmh.Text != "")
            {
                if (txtgh.Text == "" && txtth.Text == "")
                {
                    dgvmh.DataSource = from table in db.MATHANGs
                                       where table.Mahang == cbbmh.SelectedItem.ToString()
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
                                           table.Ngaynhaphang
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
