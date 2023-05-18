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
    public partial class TKNCC : Form
    {
        public TKNCC()
        {
            InitializeComponent();
        }
        QLCHDataContext db = new QLCHDataContext();
        NHACUNGCAP tb = new NHACUNGCAP();
        void Load_Data()
        {
            dgvncc.DataSource = from table in db.NHACUNGCAPs
                               select new
                               {
                                   table.Macongty,
                                   table.Tencongty,
                                   table.Diachi,
                                   table.Dienthoai,
                                   table.Email
                               };

            cbbmct.Text = null;
            txttct.Text = "";
            txtdt.Text = "";
            this.cbbmct.DropDownStyle = ComboBoxStyle.DropDownList;


        }

        private void TKNCC_Load(object sender, EventArgs e)
        {
            cbbmct.DataSource = from table in db.NHACUNGCAPs select table.Macongty;
            cbbmct.SelectedIndex = -1;
            Load_Data();
            txttct.Focus();
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
            if (cbbmct.Text != "" && txttct.Text != "" && txtdt.Text != "")
            {

                dgvncc.DataSource = from table in db.NHACUNGCAPs
                                   where table.Macongty == cbbmct.SelectedItem.ToString() && table.Tencongty == txttct.Text && table.Dienthoai == txtdt.Text
                                   select new
                                   {
                                       table.Macongty,
                                       table.Tencongty,
                                       table.Diachi,
                                       table.Dienthoai,
                                       table.Email
                                   };

            }
            else
             if (cbbmct.Text != "" && txttct.Text != "")
            {
                if (txtdt.Text == "")
                {
                    dgvncc.DataSource = from table in db.NHACUNGCAPs
                                       where table.Macongty == cbbmct.SelectedItem.ToString() && table.Tencongty == txttct.Text
                                       select new
                                       {
                                           table.Macongty,
                                           table.Tencongty,
                                           table.Diachi,
                                           table.Dienthoai,
                                           table.Email
                                       };
                }
            }
            else
             if (cbbmct.Text != "" && txtdt.Text != "")
            {
                if (txttct.Text == "")
                {
                    dgvncc.DataSource = from table in db.NHACUNGCAPs
                                       where table.Macongty == cbbmct.SelectedItem.ToString() && table.Dienthoai == txtdt.Text
                                       select new
                                       {
                                           table.Macongty,
                                           table.Tencongty,
                                           table.Diachi,
                                           table.Dienthoai,
                                           table.Email
                                       };
                }
            }
            else
             if (txttct.Text != "" && txtdt.Text != "")
            {
                if (cbbmct.Text == "")
                {
                    dgvncc.DataSource = from table in db.NHACUNGCAPs
                                       where table.Tencongty == txttct.Text && table.Dienthoai == txtdt.Text
                                       select new
                                       {
                                           table.Macongty,
                                           table.Tencongty,
                                           table.Diachi,
                                           table.Dienthoai,
                                           table.Email
                                       };
                }
            }
            if (txttct.Text != "")
            {
                if (cbbmct.Text == "" && txtdt.Text == "")
                {
                    dgvncc.DataSource = from table in db.NHACUNGCAPs
                                        where table.Tencongty == txttct.Text
                                        select new
                                        {
                                            table.Macongty,
                                            table.Tencongty,
                                            table.Diachi,
                                            table.Dienthoai,
                                            table.Email
                                        };
                }
            }
            else
             if (txtdt.Text != "")
            {
                if (txttct.Text == "" && cbbmct.Text == "")
                {
                    dgvncc.DataSource = from table in db.NHACUNGCAPs
                                        where table.Dienthoai == txtdt.Text
                                        select new
                                        {
                                            table.Macongty,
                                            table.Tencongty,
                                            table.Diachi,
                                            table.Dienthoai,
                                            table.Email
                                        };
                }
            }
            else
            if (cbbmct.Text != "")
            {
                if (txtdt.Text == "" && txttct.Text == "")
                {
                    dgvncc.DataSource = from table in db.NHACUNGCAPs
                                        where table.Macongty == cbbmct.SelectedItem.ToString()
                                        select new
                                        {
                                            table.Macongty,
                                            table.Tencongty,
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
        
