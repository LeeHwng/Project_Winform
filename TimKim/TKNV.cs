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
    public partial class TKNV : Form
    {
        public TKNV()
        {
            InitializeComponent();
        }
        QLCHDataContext db = new QLCHDataContext();
        NHANVIEN tb = new NHANVIEN();
        void Load_Data()
        {
            dgvnv.DataSource = from table in db.NHANVIENs
                               select new
                               {
                                   table.Manhanvien,
                                   table.Tennhanvien,
                                   table.Ngaysinh,
                                   table.Ngayvaolam,
                                   table.Quequan,
                                   table.Dienthoai,
                                   table.Luongcoban,
                                   table.Phucap

                               };
            cbbmnv.Text = null;
            txttnv.Text = "";
            txtdt.Text = "";
            this.cbbmnv.DropDownStyle = ComboBoxStyle.DropDownList;
            

        }
        private void TKNV_Load(object sender, EventArgs e)
        {
            cbbmnv.DataSource = from table in db.NHANVIENs select table.Manhanvien;
            cbbmnv.SelectedIndex = -1;
            Load_Data();
            txttnv.Focus();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn muốn thoát?", " Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                this.Close();
        }

        private void btnlm_Click(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void btntk_Click(object sender, EventArgs e)
        {
            if (cbbmnv.Text != "" && txttnv.Text != "" && txtdt.Text != "")
            {

                dgvnv.DataSource = from table in db.NHANVIENs
                                   where table.Manhanvien == cbbmnv.SelectedItem.ToString() && table.Tennhanvien == txttnv.Text && table.Dienthoai == txtdt.Text
                                   select new
                                   {
                                       table.Manhanvien,
                                       table.Tennhanvien,
                                       table.Ngaysinh,
                                       table.Ngayvaolam,
                                       table.Quequan,
                                       table.Dienthoai,
                                       table.Luongcoban,
                                       table.Phucap
                                   };

            }
            else
             if (cbbmnv.Text != "" && txttnv.Text != "")
            {
                if (txtdt.Text == "")
                {
                    dgvnv.DataSource = from table in db.NHANVIENs
                                       where table.Manhanvien == cbbmnv.SelectedItem.ToString() && table.Tennhanvien == txttnv.Text
                                       select new
                                       {
                                           table.Manhanvien,
                                           table.Tennhanvien,
                                           table.Ngaysinh,
                                           table.Ngayvaolam,
                                           table.Quequan,
                                           table.Dienthoai,
                                           table.Luongcoban,
                                           table.Phucap
                                       };
                }
            }
            else
             if (cbbmnv.Text != "" && txtdt.Text != "")
            {
                if (txttnv.Text == "")
                {
                    dgvnv.DataSource = from table in db.NHANVIENs
                                       where table.Manhanvien == cbbmnv.SelectedItem.ToString() && table.Dienthoai == txtdt.Text
                                       select new
                                       {
                                           table.Manhanvien,
                                           table.Tennhanvien,
                                           table.Ngaysinh,
                                           table.Ngayvaolam,
                                           table.Quequan,
                                           table.Dienthoai,
                                           table.Luongcoban,
                                           table.Phucap
                                       };
                }
            }
            else
             if (txttnv.Text != "" && txtdt.Text != "")
            {
                if (cbbmnv.Text == "")
                {
                    dgvnv.DataSource = from table in db.NHANVIENs
                                       where table.Tennhanvien == txttnv.Text && table.Dienthoai == txtdt.Text
                                       select new
                                       {
                                           table.Manhanvien,
                                           table.Tennhanvien,
                                           table.Ngaysinh,
                                           table.Ngayvaolam,
                                           table.Quequan,
                                           table.Dienthoai,
                                           table.Luongcoban,
                                           table.Phucap
                                       };
                }
            }
            if (txttnv.Text != "")
            {
                if (cbbmnv.Text == "" && txtdt.Text == "")
                {
                    dgvnv.DataSource = from table in db.NHANVIENs
                                       where table.Tennhanvien == txttnv.Text
                                       select new
                                       {
                                           table.Manhanvien,
                                           table.Tennhanvien,
                                           table.Ngaysinh,
                                           table.Ngayvaolam,
                                           table.Quequan,
                                           table.Dienthoai,
                                           table.Luongcoban,
                                           table.Phucap
                                       };
                }
            }
            else
             if (txtdt.Text != "")
            {
                if (cbbmnv.Text == "" && txttnv.Text == "")
                {
                    dgvnv.DataSource = from table in db.NHANVIENs
                                       where table.Dienthoai == txtdt.Text
                                       select new
                                       {
                                           table.Manhanvien,
                                           table.Tennhanvien,
                                           table.Ngaysinh,
                                           table.Ngayvaolam,
                                           table.Quequan,
                                           table.Dienthoai,
                                           table.Luongcoban,
                                           table.Phucap
                                       };
                }
            }
            else
            if (cbbmnv.Text != "")
            {
                if (txtdt.Text == "" && txttnv.Text == "")
                {
                    dgvnv.DataSource = from table in db.NHANVIENs
                                       where table.Manhanvien == cbbmnv.SelectedItem.ToString()
                                       select new
                                       {
                                           table.Manhanvien,
                                           table.Tennhanvien,
                                           table.Ngaysinh,
                                           table.Ngayvaolam,
                                           table.Quequan,
                                           table.Dienthoai,
                                           table.Luongcoban,
                                           table.Phucap
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
        
