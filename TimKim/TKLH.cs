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
    public partial class TKLH : Form
    {
        public TKLH()
        {
            InitializeComponent();
        }
        QLCHDataContext db = new QLCHDataContext();
        LOAIHANG tb = new LOAIHANG();
        void Load_Data()
        {
            dgvlh.DataSource = from table in db.LOAIHANGs
                               select new
                               {
                                   table.Maloaihang,
                                   table.Tenloaihang


                               };

            cbbmlh.Text = null;
            txttlh.Text = "";
            this.cbbmlh.DropDownStyle = ComboBoxStyle.DropDownList;


        }
        private void TKLH_Load(object sender, EventArgs e)
        {
            cbbmlh.DataSource = from table in db.LOAIHANGs select table.Maloaihang;
            cbbmlh.SelectedIndex = -1;
            Load_Data();
            txttlh.Focus();
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



            if (cbbmlh.Text != "" && txttlh.Text != "")
            {
                dgvlh.DataSource = from table in db.LOAIHANGs
                                   where table.Maloaihang == cbbmlh.Text && table.Tenloaihang == txttlh.Text
                                   select new
                                   {

                                       table.Maloaihang,
                                       table.Tenloaihang
                                   };

            }
            else
            if (txttlh.Text != "")
            {
                if (cbbmlh.Text == "")
                {
                    dgvlh.DataSource = from table in db.LOAIHANGs
                                       where table.Tenloaihang == txttlh.Text
                                       select new
                                       {

                                           table.Maloaihang,
                                           table.Tenloaihang
                                       };
                }
            }
            else
           if (cbbmlh.Text != "")
            {
                if (txttlh.Text == "")
                {
                    dgvlh.DataSource = from table in db.LOAIHANGs
                                       where table.Maloaihang == cbbmlh.SelectedItem.ToString()
                                       select new
                                       {

                                           table.Maloaihang,
                                           table.Tenloaihang
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
        
