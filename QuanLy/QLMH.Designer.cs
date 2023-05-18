
namespace LeQuocHung_BlackMobile.QuanLy
{
    partial class QLMH
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnsua = new DevComponents.DotNetBar.ButtonX();
            this.Mahang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbbmct = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbbmlh = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtsl = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpnnh = new System.Windows.Forms.DateTimePicker();
            this.txtgh = new System.Windows.Forms.TextBox();
            this.txttgbh = new System.Windows.Forms.TextBox();
            this.txtdvt = new System.Windows.Forms.TextBox();
            this.Macongty = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            this.Maloaihang = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            this.Soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtmh = new System.Windows.Forms.TextBox();
            this.btnthem = new DevComponents.DotNetBar.ButtonX();
            this.Thoigianbaohanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Donvitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.Ngaynhaphang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtth = new System.Windows.Forms.TextBox();
            this.btnthoat = new DevComponents.DotNetBar.ButtonX();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Giahang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnxoa = new DevComponents.DotNetBar.ButtonX();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnnhapmoi = new DevComponents.DotNetBar.ButtonX();
            this.dgvmh = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.loisl = new System.Windows.Forms.Label();
            this.loigh = new System.Windows.Forms.Label();
            this.loimh = new System.Windows.Forms.Label();
            this.loith = new System.Windows.Forms.Label();
            this.loitgbh = new System.Windows.Forms.Label();
            this.loidvt = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmh)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsua
            // 
            this.btnsua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnsua.BackColor = System.Drawing.Color.Transparent;
            this.btnsua.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnsua.Location = new System.Drawing.Point(224, 591);
            this.btnsua.Name = "btnsua";
            this.btnsua.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnsua.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.AltEnter);
            this.btnsua.Size = new System.Drawing.Size(130, 50);
            this.btnsua.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnsua.Symbol = "57899";
            this.btnsua.SymbolColor = System.Drawing.Color.Black;
            this.btnsua.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnsua.SymbolSize = 12F;
            this.btnsua.TabIndex = 28;
            this.btnsua.Text = "Sửa";
            this.btnsua.TextColor = System.Drawing.Color.Black;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // Mahang
            // 
            this.Mahang.DataPropertyName = "Mahang";
            this.Mahang.HeaderText = "Mã hàng";
            this.Mahang.MinimumWidth = 6;
            this.Mahang.Name = "Mahang";
            this.Mahang.Width = 110;
            // 
            // Tenhang
            // 
            this.Tenhang.DataPropertyName = "Tenhang";
            this.Tenhang.HeaderText = "Tên hàng";
            this.Tenhang.MinimumWidth = 6;
            this.Tenhang.Name = "Tenhang";
            this.Tenhang.Width = 140;
            // 
            // cbbmct
            // 
            this.cbbmct.DisplayMember = "Text";
            this.cbbmct.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbmct.FormattingEnabled = true;
            this.cbbmct.ItemHeight = 16;
            this.cbbmct.Location = new System.Drawing.Point(168, 104);
            this.cbbmct.Name = "cbbmct";
            this.cbbmct.Size = new System.Drawing.Size(341, 22);
            this.cbbmct.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbbmct.TabIndex = 3;
            // 
            // cbbmlh
            // 
            this.cbbmlh.DisplayMember = "Text";
            this.cbbmlh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbmlh.FormattingEnabled = true;
            this.cbbmlh.ItemHeight = 16;
            this.cbbmlh.Location = new System.Drawing.Point(168, 149);
            this.cbbmlh.Name = "cbbmlh";
            this.cbbmlh.Size = new System.Drawing.Size(341, 22);
            this.cbbmlh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbbmlh.TabIndex = 4;
            // 
            // txtsl
            // 
            this.txtsl.Location = new System.Drawing.Point(168, 191);
            this.txtsl.Multiline = true;
            this.txtsl.Name = "txtsl";
            this.txtsl.Size = new System.Drawing.Size(341, 27);
            this.txtsl.TabIndex = 5;
            this.txtsl.TextChanged += new System.EventHandler(this.txtsl_TextChanged);
            this.txtsl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsl_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(24, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "Số lượng";
            // 
            // dtpnnh
            // 
            this.dtpnnh.Location = new System.Drawing.Point(709, 182);
            this.dtpnnh.Name = "dtpnnh";
            this.dtpnnh.Size = new System.Drawing.Size(341, 22);
            this.dtpnnh.TabIndex = 9;
            // 
            // txtgh
            // 
            this.txtgh.Location = new System.Drawing.Point(709, 132);
            this.txtgh.Multiline = true;
            this.txtgh.Name = "txtgh";
            this.txtgh.Size = new System.Drawing.Size(341, 27);
            this.txtgh.TabIndex = 8;
            this.txtgh.TextChanged += new System.EventHandler(this.txtgh_TextChanged);
            this.txtgh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtgh_KeyPress);
            // 
            // txttgbh
            // 
            this.txttgbh.Location = new System.Drawing.Point(709, 25);
            this.txttgbh.Multiline = true;
            this.txttgbh.Name = "txttgbh";
            this.txttgbh.Size = new System.Drawing.Size(341, 27);
            this.txttgbh.TabIndex = 6;
            this.txttgbh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttgbh_KeyPress);
            // 
            // txtdvt
            // 
            this.txtdvt.Location = new System.Drawing.Point(709, 81);
            this.txtdvt.Multiline = true;
            this.txtdvt.Name = "txtdvt";
            this.txtdvt.Size = new System.Drawing.Size(341, 27);
            this.txtdvt.TabIndex = 7;
            this.txtdvt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdvt_KeyPress);
            // 
            // Macongty
            // 
            this.Macongty.DataPropertyName = "Macongty";
            this.Macongty.DisplayMember = "Text";
            this.Macongty.DropDownHeight = 106;
            this.Macongty.DropDownWidth = 121;
            this.Macongty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Macongty.HeaderText = "Mã công ty";
            this.Macongty.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Macongty.IntegralHeight = false;
            this.Macongty.ItemHeight = 17;
            this.Macongty.MinimumWidth = 6;
            this.Macongty.Name = "Macongty";
            this.Macongty.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Macongty.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Macongty.Width = 125;
            // 
            // Maloaihang
            // 
            this.Maloaihang.DataPropertyName = "Maloaihang";
            this.Maloaihang.DisplayMember = "Text";
            this.Maloaihang.DropDownHeight = 106;
            this.Maloaihang.DropDownWidth = 121;
            this.Maloaihang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Maloaihang.HeaderText = "Mã loại hàng";
            this.Maloaihang.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Maloaihang.IntegralHeight = false;
            this.Maloaihang.ItemHeight = 17;
            this.Maloaihang.MinimumWidth = 6;
            this.Maloaihang.Name = "Maloaihang";
            this.Maloaihang.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Maloaihang.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Maloaihang.Width = 125;
            // 
            // Soluong
            // 
            this.Soluong.DataPropertyName = "Soluong";
            this.Soluong.HeaderText = "Số lượng";
            this.Soluong.MinimumWidth = 6;
            this.Soluong.Name = "Soluong";
            this.Soluong.Width = 125;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(542, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = " Ngày nhập hàng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(542, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Giá hàng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(542, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Thời gian bảo hành";
            // 
            // txtmh
            // 
            this.txtmh.Location = new System.Drawing.Point(168, 14);
            this.txtmh.Multiline = true;
            this.txtmh.Name = "txtmh";
            this.txtmh.Size = new System.Drawing.Size(341, 27);
            this.txtmh.TabIndex = 1;
            this.txtmh.TextChanged += new System.EventHandler(this.txtmh_TextChanged);
            this.txtmh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmh_KeyPress);
            // 
            // btnthem
            // 
            this.btnthem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnthem.BackColor = System.Drawing.Color.Transparent;
            this.btnthem.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnthem.Location = new System.Drawing.Point(15, 591);
            this.btnthem.Name = "btnthem";
            this.btnthem.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnthem.Size = new System.Drawing.Size(130, 50);
            this.btnthem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnthem.Symbol = "57669";
            this.btnthem.SymbolColor = System.Drawing.Color.Black;
            this.btnthem.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnthem.SymbolSize = 11F;
            this.btnthem.TabIndex = 27;
            this.btnthem.Text = "Thêm";
            this.btnthem.TextColor = System.Drawing.Color.Black;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // Thoigianbaohanh
            // 
            this.Thoigianbaohanh.DataPropertyName = "Thoigianbaohanh";
            this.Thoigianbaohanh.HeaderText = "Thời gian bảo hành";
            this.Thoigianbaohanh.MinimumWidth = 6;
            this.Thoigianbaohanh.Name = "Thoigianbaohanh";
            this.Thoigianbaohanh.Width = 125;
            // 
            // Donvitinh
            // 
            this.Donvitinh.DataPropertyName = "Donvitinh";
            this.Donvitinh.HeaderText = "Đơn vị tính";
            this.Donvitinh.MinimumWidth = 6;
            this.Donvitinh.Name = "Donvitinh";
            this.Donvitinh.Width = 125;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(542, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = " Đơn vị tính";
            // 
            // Ngaynhaphang
            // 
            this.Ngaynhaphang.DataPropertyName = "Ngaynhaphang";
            this.Ngaynhaphang.HeaderText = "Ngày nhập hàng";
            this.Ngaynhaphang.MinimumWidth = 6;
            this.Ngaynhaphang.Name = "Ngaynhaphang";
            this.Ngaynhaphang.Width = 125;
            // 
            // txtth
            // 
            this.txtth.Location = new System.Drawing.Point(168, 59);
            this.txtth.Multiline = true;
            this.txtth.Name = "txtth";
            this.txtth.Size = new System.Drawing.Size(341, 27);
            this.txtth.TabIndex = 2;
            this.txtth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtth_KeyPress);
            // 
            // btnthoat
            // 
            this.btnthoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnthoat.BackColor = System.Drawing.Color.Transparent;
            this.btnthoat.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnthoat.Location = new System.Drawing.Point(943, 591);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnthoat.Size = new System.Drawing.Size(130, 50);
            this.btnthoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnthoat.Symbol = "59550";
            this.btnthoat.SymbolColor = System.Drawing.Color.Black;
            this.btnthoat.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnthoat.SymbolSize = 15F;
            this.btnthoat.TabIndex = 33;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.TextColor = System.Drawing.Color.Black;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(24, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Mã loại hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(24, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mã công ty";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(24, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = " Mã hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(24, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên hàng";
            // 
            // Giahang
            // 
            this.Giahang.DataPropertyName = "Giahang";
            this.Giahang.HeaderText = "Giá hàng";
            this.Giahang.MinimumWidth = 6;
            this.Giahang.Name = "Giahang";
            this.Giahang.Width = 125;
            // 
            // btnxoa
            // 
            this.btnxoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnxoa.BackColor = System.Drawing.Color.Transparent;
            this.btnxoa.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnxoa.Location = new System.Drawing.Point(471, 591);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnxoa.Size = new System.Drawing.Size(130, 50);
            this.btnxoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnxoa.Symbol = "57676";
            this.btnxoa.SymbolColor = System.Drawing.Color.Red;
            this.btnxoa.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnxoa.SymbolSize = 13F;
            this.btnxoa.TabIndex = 29;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.TextColor = System.Drawing.Color.Black;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.loidvt);
            this.panel1.Controls.Add(this.loitgbh);
            this.panel1.Controls.Add(this.loith);
            this.panel1.Controls.Add(this.loimh);
            this.panel1.Controls.Add(this.loigh);
            this.panel1.Controls.Add(this.loisl);
            this.panel1.Controls.Add(this.cbbmct);
            this.panel1.Controls.Add(this.cbbmlh);
            this.panel1.Controls.Add(this.txtsl);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.dtpnnh);
            this.panel1.Controls.Add(this.txtgh);
            this.panel1.Controls.Add(this.txttgbh);
            this.panel1.Controls.Add(this.txtdvt);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtmh);
            this.panel1.Controls.Add(this.txtth);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(5, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1076, 225);
            this.panel1.TabIndex = 32;
            // 
            // btnnhapmoi
            // 
            this.btnnhapmoi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnnhapmoi.BackColor = System.Drawing.Color.Transparent;
            this.btnnhapmoi.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnnhapmoi.Location = new System.Drawing.Point(704, 591);
            this.btnnhapmoi.Name = "btnnhapmoi";
            this.btnnhapmoi.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnnhapmoi.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F5);
            this.btnnhapmoi.Size = new System.Drawing.Size(130, 50);
            this.btnnhapmoi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnnhapmoi.Symbol = "57384";
            this.btnnhapmoi.SymbolColor = System.Drawing.Color.Black;
            this.btnnhapmoi.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnnhapmoi.SymbolSize = 14F;
            this.btnnhapmoi.TabIndex = 30;
            this.btnnhapmoi.Text = "Nhập mới";
            this.btnnhapmoi.TextColor = System.Drawing.Color.Black;
            this.btnnhapmoi.Click += new System.EventHandler(this.btnnhapmoi_Click);
            // 
            // dgvmh
            // 
            this.dgvmh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mahang,
            this.Tenhang,
            this.Macongty,
            this.Maloaihang,
            this.Soluong,
            this.Thoigianbaohanh,
            this.Donvitinh,
            this.Giahang,
            this.Ngaynhaphang});
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvmh.DefaultCellStyle = dataGridViewCellStyle19;
            this.dgvmh.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvmh.Location = new System.Drawing.Point(1, 253);
            this.dgvmh.Name = "dgvmh";
            this.dgvmh.RowHeadersWidth = 51;
            this.dgvmh.RowTemplate.Height = 24;
            this.dgvmh.Size = new System.Drawing.Size(1080, 309);
            this.dgvmh.TabIndex = 31;
            this.dgvmh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvmh_CellContentClick);
            this.dgvmh.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvmh_CellMouseClick);
            // 
            // loisl
            // 
            this.loisl.AutoSize = true;
            this.loisl.BackColor = System.Drawing.Color.White;
            this.loisl.Location = new System.Drawing.Point(479, 196);
            this.loisl.Name = "loisl";
            this.loisl.Size = new System.Drawing.Size(0, 17);
            this.loisl.TabIndex = 24;
            // 
            // loigh
            // 
            this.loigh.AutoSize = true;
            this.loigh.BackColor = System.Drawing.Color.White;
            this.loigh.Location = new System.Drawing.Point(1021, 137);
            this.loigh.Name = "loigh";
            this.loigh.Size = new System.Drawing.Size(0, 17);
            this.loigh.TabIndex = 25;
            // 
            // loimh
            // 
            this.loimh.AutoSize = true;
            this.loimh.BackColor = System.Drawing.Color.White;
            this.loimh.Location = new System.Drawing.Point(479, 19);
            this.loimh.Name = "loimh";
            this.loimh.Size = new System.Drawing.Size(0, 17);
            this.loimh.TabIndex = 26;
            // 
            // loith
            // 
            this.loith.AutoSize = true;
            this.loith.BackColor = System.Drawing.Color.White;
            this.loith.Location = new System.Drawing.Point(480, 64);
            this.loith.Name = "loith";
            this.loith.Size = new System.Drawing.Size(0, 17);
            this.loith.TabIndex = 27;
            // 
            // loitgbh
            // 
            this.loitgbh.AutoSize = true;
            this.loitgbh.BackColor = System.Drawing.Color.White;
            this.loitgbh.Location = new System.Drawing.Point(1022, 30);
            this.loitgbh.Name = "loitgbh";
            this.loitgbh.Size = new System.Drawing.Size(0, 17);
            this.loitgbh.TabIndex = 28;
            // 
            // loidvt
            // 
            this.loidvt.AutoSize = true;
            this.loidvt.BackColor = System.Drawing.Color.White;
            this.loidvt.Location = new System.Drawing.Point(1022, 86);
            this.loidvt.Name = "loidvt";
            this.loidvt.Size = new System.Drawing.Size(0, 17);
            this.loidvt.TabIndex = 29;
            // 
            // QLMH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnnhapmoi);
            this.Controls.Add(this.dgvmh);
            this.Name = "QLMH";
            this.Text = "QLMH";
            this.Load += new System.EventHandler(this.QLMH_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnsua;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mahang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenhang;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbbmct;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbbmlh;
        private System.Windows.Forms.TextBox txtsl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpnnh;
        private System.Windows.Forms.TextBox txtgh;
        private System.Windows.Forms.TextBox txttgbh;
        private System.Windows.Forms.TextBox txtdvt;
        private DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn Macongty;
        private DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn Maloaihang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soluong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtmh;
        private DevComponents.DotNetBar.ButtonX btnthem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thoigianbaohanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Donvitinh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaynhaphang;
        private System.Windows.Forms.TextBox txtth;
        private DevComponents.DotNetBar.ButtonX btnthoat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Giahang;
        private DevComponents.DotNetBar.ButtonX btnxoa;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.ButtonX btnnhapmoi;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvmh;
        private System.Windows.Forms.Label loisl;
        private System.Windows.Forms.Label loigh;
        private System.Windows.Forms.Label loith;
        private System.Windows.Forms.Label loimh;
        private System.Windows.Forms.Label loidvt;
        private System.Windows.Forms.Label loitgbh;
    }
}