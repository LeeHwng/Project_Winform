
namespace LeQuocHung_BlackMobile.QuanLy
{
    partial class QLNV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtmnv = new System.Windows.Forms.TextBox();
            this.txttnv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnthoat = new DevComponents.DotNetBar.ButtonX();
            this.btnnhapmoi = new DevComponents.DotNetBar.ButtonX();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsua = new DevComponents.DotNetBar.ButtonX();
            this.btnthem = new DevComponents.DotNetBar.ButtonX();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvkh = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Manhanvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tennhanvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngayvaolam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quequan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dienthoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Luongcoban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phucap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnxoa = new DevComponents.DotNetBar.ButtonX();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpnvl = new System.Windows.Forms.DateTimePicker();
            this.dtpns = new System.Windows.Forms.DateTimePicker();
            this.txtpc = new System.Windows.Forms.TextBox();
            this.txtlcb = new System.Windows.Forms.TextBox();
            this.txtquequan = new System.Windows.Forms.TextBox();
            this.txtdt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.loimnv = new System.Windows.Forms.Label();
            this.loitnv = new System.Windows.Forms.Label();
            this.loiqq = new System.Windows.Forms.Label();
            this.loidt = new System.Windows.Forms.Label();
            this.loilcb = new System.Windows.Forms.Label();
            this.loipc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkh)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtmnv
            // 
            this.txtmnv.Location = new System.Drawing.Point(168, 25);
            this.txtmnv.Multiline = true;
            this.txtmnv.Name = "txtmnv";
            this.txtmnv.Size = new System.Drawing.Size(341, 27);
            this.txtmnv.TabIndex = 1;
            this.txtmnv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmnv_KeyPress);
            // 
            // txttnv
            // 
            this.txttnv.Location = new System.Drawing.Point(168, 81);
            this.txttnv.Multiline = true;
            this.txttnv.Name = "txttnv";
            this.txttnv.Size = new System.Drawing.Size(341, 27);
            this.txttnv.TabIndex = 2;
            this.txttnv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttnv_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(24, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ngày vào làm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(24, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ngày sinh";
            // 
            // btnthoat
            // 
            this.btnthoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnthoat.BackColor = System.Drawing.Color.Transparent;
            this.btnthoat.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnthoat.Location = new System.Drawing.Point(940, 587);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnthoat.Size = new System.Drawing.Size(130, 50);
            this.btnthoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnthoat.Symbol = "59550";
            this.btnthoat.SymbolColor = System.Drawing.Color.Black;
            this.btnthoat.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnthoat.SymbolSize = 14F;
            this.btnthoat.TabIndex = 19;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.TextColor = System.Drawing.Color.Black;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnnhapmoi
            // 
            this.btnnhapmoi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnnhapmoi.BackColor = System.Drawing.Color.Transparent;
            this.btnnhapmoi.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnnhapmoi.Location = new System.Drawing.Point(703, 587);
            this.btnnhapmoi.Name = "btnnhapmoi";
            this.btnnhapmoi.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnnhapmoi.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F5);
            this.btnnhapmoi.Size = new System.Drawing.Size(130, 50);
            this.btnnhapmoi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnnhapmoi.Symbol = "57384";
            this.btnnhapmoi.SymbolColor = System.Drawing.Color.Black;
            this.btnnhapmoi.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnnhapmoi.SymbolSize = 15F;
            this.btnnhapmoi.TabIndex = 18;
            this.btnnhapmoi.Text = "Nhập mới";
            this.btnnhapmoi.TextColor = System.Drawing.Color.Black;
            this.btnnhapmoi.Click += new System.EventHandler(this.btnnhapmoi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = " Mã nhân viên";
            // 
            // btnsua
            // 
            this.btnsua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnsua.BackColor = System.Drawing.Color.Transparent;
            this.btnsua.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnsua.Location = new System.Drawing.Point(223, 587);
            this.btnsua.Name = "btnsua";
            this.btnsua.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnsua.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.AltEnter);
            this.btnsua.Size = new System.Drawing.Size(130, 50);
            this.btnsua.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnsua.Symbol = "57899";
            this.btnsua.SymbolColor = System.Drawing.Color.Black;
            this.btnsua.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnsua.SymbolSize = 12F;
            this.btnsua.TabIndex = 16;
            this.btnsua.Text = "Sửa";
            this.btnsua.TextColor = System.Drawing.Color.Black;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnthem.BackColor = System.Drawing.Color.Transparent;
            this.btnthem.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnthem.Location = new System.Drawing.Point(14, 587);
            this.btnthem.Name = "btnthem";
            this.btnthem.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnthem.Size = new System.Drawing.Size(130, 50);
            this.btnthem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnthem.Symbol = "57669";
            this.btnthem.SymbolColor = System.Drawing.Color.Black;
            this.btnthem.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnthem.SymbolSize = 17F;
            this.btnthem.TabIndex = 15;
            this.btnthem.Text = "Thêm";
            this.btnthem.TextColor = System.Drawing.Color.Black;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(24, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên nhân viên";
            // 
            // dgvkh
            // 
            this.dgvkh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvkh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Manhanvien,
            this.Tennhanvien,
            this.Ngaysinh,
            this.Ngayvaolam,
            this.Quequan,
            this.Dienthoai,
            this.Luongcoban,
            this.Phucap});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvkh.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvkh.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvkh.Location = new System.Drawing.Point(0, 249);
            this.dgvkh.Name = "dgvkh";
            this.dgvkh.RowHeadersWidth = 51;
            this.dgvkh.RowTemplate.Height = 24;
            this.dgvkh.Size = new System.Drawing.Size(1080, 309);
            this.dgvkh.TabIndex = 13;
            this.dgvkh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvkh_CellContentClick);
            this.dgvkh.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvkh_CellMouseClick);
            // 
            // Manhanvien
            // 
            this.Manhanvien.DataPropertyName = "Manhanvien";
            this.Manhanvien.HeaderText = "Mã nhân viên";
            this.Manhanvien.MinimumWidth = 6;
            this.Manhanvien.Name = "Manhanvien";
            this.Manhanvien.Width = 110;
            // 
            // Tennhanvien
            // 
            this.Tennhanvien.DataPropertyName = "Tennhanvien";
            this.Tennhanvien.HeaderText = "Tên nhân viên";
            this.Tennhanvien.MinimumWidth = 6;
            this.Tennhanvien.Name = "Tennhanvien";
            this.Tennhanvien.Width = 140;
            // 
            // Ngaysinh
            // 
            this.Ngaysinh.DataPropertyName = "Ngaysinh";
            this.Ngaysinh.HeaderText = "Ngày Sinh";
            this.Ngaysinh.MinimumWidth = 6;
            this.Ngaysinh.Name = "Ngaysinh";
            this.Ngaysinh.Width = 125;
            // 
            // Ngayvaolam
            // 
            this.Ngayvaolam.DataPropertyName = "Ngayvaolam";
            this.Ngayvaolam.HeaderText = "Ngày vào làm";
            this.Ngayvaolam.MinimumWidth = 6;
            this.Ngayvaolam.Name = "Ngayvaolam";
            this.Ngayvaolam.Width = 125;
            // 
            // Quequan
            // 
            this.Quequan.DataPropertyName = "Quequan";
            this.Quequan.HeaderText = "Quê quán";
            this.Quequan.MinimumWidth = 6;
            this.Quequan.Name = "Quequan";
            this.Quequan.Width = 125;
            // 
            // Dienthoai
            // 
            this.Dienthoai.DataPropertyName = "Dienthoai";
            this.Dienthoai.HeaderText = "Điện thoại";
            this.Dienthoai.MinimumWidth = 6;
            this.Dienthoai.Name = "Dienthoai";
            this.Dienthoai.Width = 125;
            // 
            // Luongcoban
            // 
            this.Luongcoban.DataPropertyName = "Luongcoban";
            this.Luongcoban.HeaderText = "Lương cơ bản";
            this.Luongcoban.MinimumWidth = 6;
            this.Luongcoban.Name = "Luongcoban";
            this.Luongcoban.Width = 125;
            // 
            // Phucap
            // 
            this.Phucap.DataPropertyName = "Phucap";
            this.Phucap.HeaderText = "Phụ cấp";
            this.Phucap.MinimumWidth = 6;
            this.Phucap.Name = "Phucap";
            this.Phucap.Width = 125;
            // 
            // btnxoa
            // 
            this.btnxoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnxoa.BackColor = System.Drawing.Color.Transparent;
            this.btnxoa.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnxoa.Location = new System.Drawing.Point(470, 587);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnxoa.Size = new System.Drawing.Size(130, 50);
            this.btnxoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnxoa.Symbol = "57676";
            this.btnxoa.SymbolColor = System.Drawing.Color.Red;
            this.btnxoa.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnxoa.SymbolSize = 17F;
            this.btnxoa.TabIndex = 17;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.TextColor = System.Drawing.Color.Black;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.loipc);
            this.panel1.Controls.Add(this.loilcb);
            this.panel1.Controls.Add(this.loidt);
            this.panel1.Controls.Add(this.loiqq);
            this.panel1.Controls.Add(this.loitnv);
            this.panel1.Controls.Add(this.loimnv);
            this.panel1.Controls.Add(this.dtpnvl);
            this.panel1.Controls.Add(this.dtpns);
            this.panel1.Controls.Add(this.txtpc);
            this.panel1.Controls.Add(this.txtlcb);
            this.panel1.Controls.Add(this.txtquequan);
            this.panel1.Controls.Add(this.txtdt);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtmnv);
            this.panel1.Controls.Add(this.txttnv);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(4, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1076, 225);
            this.panel1.TabIndex = 14;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dtpnvl
            // 
            this.dtpnvl.Location = new System.Drawing.Point(168, 184);
            this.dtpnvl.Name = "dtpnvl";
            this.dtpnvl.Size = new System.Drawing.Size(341, 22);
            this.dtpnvl.TabIndex = 4;
            // 
            // dtpns
            // 
            this.dtpns.Location = new System.Drawing.Point(168, 137);
            this.dtpns.Name = "dtpns";
            this.dtpns.Size = new System.Drawing.Size(341, 22);
            this.dtpns.TabIndex = 3;
            // 
            // txtpc
            // 
            this.txtpc.Location = new System.Drawing.Point(699, 177);
            this.txtpc.Multiline = true;
            this.txtpc.Name = "txtpc";
            this.txtpc.Size = new System.Drawing.Size(341, 27);
            this.txtpc.TabIndex = 8;
            this.txtpc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpc_KeyPress);
            // 
            // txtlcb
            // 
            this.txtlcb.Location = new System.Drawing.Point(699, 132);
            this.txtlcb.Multiline = true;
            this.txtlcb.Name = "txtlcb";
            this.txtlcb.Size = new System.Drawing.Size(341, 27);
            this.txtlcb.TabIndex = 7;
            this.txtlcb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtlcb_KeyPress);
            // 
            // txtquequan
            // 
            this.txtquequan.Location = new System.Drawing.Point(699, 25);
            this.txtquequan.Multiline = true;
            this.txtquequan.Name = "txtquequan";
            this.txtquequan.Size = new System.Drawing.Size(341, 27);
            this.txtquequan.TabIndex = 5;
            this.txtquequan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtquequan_KeyPress);
            // 
            // txtdt
            // 
            this.txtdt.Location = new System.Drawing.Point(699, 81);
            this.txtdt.Multiline = true;
            this.txtdt.Name = "txtdt";
            this.txtdt.Size = new System.Drawing.Size(341, 27);
            this.txtdt.TabIndex = 6;
            this.txtdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdt_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(555, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = " Phụ cấp";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(555, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = " Lương cơ bản";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(555, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Quê quán";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(555, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = " Điện Thoại";
            // 
            // loimnv
            // 
            this.loimnv.AutoSize = true;
            this.loimnv.BackColor = System.Drawing.Color.White;
            this.loimnv.Location = new System.Drawing.Point(468, 30);
            this.loimnv.Name = "loimnv";
            this.loimnv.Size = new System.Drawing.Size(12, 17);
            this.loimnv.TabIndex = 19;
            this.loimnv.Text = " ";
            // 
            // loitnv
            // 
            this.loitnv.AutoSize = true;
            this.loitnv.BackColor = System.Drawing.Color.White;
            this.loitnv.Location = new System.Drawing.Point(468, 86);
            this.loitnv.Name = "loitnv";
            this.loitnv.Size = new System.Drawing.Size(12, 17);
            this.loitnv.TabIndex = 20;
            this.loitnv.Text = " ";
            // 
            // loiqq
            // 
            this.loiqq.AutoSize = true;
            this.loiqq.BackColor = System.Drawing.Color.White;
            this.loiqq.Location = new System.Drawing.Point(1005, 30);
            this.loiqq.Name = "loiqq";
            this.loiqq.Size = new System.Drawing.Size(12, 17);
            this.loiqq.TabIndex = 21;
            this.loiqq.Text = " ";
            // 
            // loidt
            // 
            this.loidt.AutoSize = true;
            this.loidt.BackColor = System.Drawing.Color.White;
            this.loidt.Location = new System.Drawing.Point(1005, 86);
            this.loidt.Name = "loidt";
            this.loidt.Size = new System.Drawing.Size(12, 17);
            this.loidt.TabIndex = 22;
            this.loidt.Text = " ";
            // 
            // loilcb
            // 
            this.loilcb.AutoSize = true;
            this.loilcb.BackColor = System.Drawing.Color.White;
            this.loilcb.Location = new System.Drawing.Point(1005, 137);
            this.loilcb.Name = "loilcb";
            this.loilcb.Size = new System.Drawing.Size(12, 17);
            this.loilcb.TabIndex = 23;
            this.loilcb.Text = " ";
            // 
            // loipc
            // 
            this.loipc.AutoSize = true;
            this.loipc.BackColor = System.Drawing.Color.White;
            this.loipc.Location = new System.Drawing.Point(1005, 182);
            this.loipc.Name = "loipc";
            this.loipc.Size = new System.Drawing.Size(12, 17);
            this.loipc.TabIndex = 24;
            this.loipc.Text = " ";
            // 
            // QLNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnnhapmoi);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dgvkh);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.panel1);
            this.Name = "QLNV";
            this.Text = "QLNV";
            this.Load += new System.EventHandler(this.QLNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvkh)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtmnv;
        private System.Windows.Forms.TextBox txttnv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private DevComponents.DotNetBar.ButtonX btnthoat;
        private DevComponents.DotNetBar.ButtonX btnnhapmoi;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.ButtonX btnsua;
        private DevComponents.DotNetBar.ButtonX btnthem;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvkh;
        private DevComponents.DotNetBar.ButtonX btnxoa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtpc;
        private System.Windows.Forms.TextBox txtlcb;
        private System.Windows.Forms.TextBox txtquequan;
        private System.Windows.Forms.TextBox txtdt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpns;
        private System.Windows.Forms.DateTimePicker dtpnvl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tennhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngayvaolam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quequan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dienthoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Luongcoban;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phucap;
        private System.Windows.Forms.Label loipc;
        private System.Windows.Forms.Label loilcb;
        private System.Windows.Forms.Label loidt;
        private System.Windows.Forms.Label loiqq;
        private System.Windows.Forms.Label loitnv;
        private System.Windows.Forms.Label loimnv;
    }
}