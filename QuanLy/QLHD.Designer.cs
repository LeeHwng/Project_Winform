
namespace LeQuocHung_BlackMobile.QuanLy
{
    partial class QLHD
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnnhapmoi = new DevComponents.DotNetBar.ButtonX();
            this.cbbmkh = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.label2 = new System.Windows.Forms.Label();
            this.btnxoa = new DevComponents.DotNetBar.ButtonX();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpndh = new System.Windows.Forms.DateTimePicker();
            this.cbbmnv = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtshd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsua = new DevComponents.DotNetBar.ButtonX();
            this.btnthem = new DevComponents.DotNetBar.ButtonX();
            this.btnthoat = new DevComponents.DotNetBar.ButtonX();
            this.dgvkh = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Sohoadon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Makhachhang = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            this.Manhanvien = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            this.Ngaymuahang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loishd = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkh)).BeginInit();
            this.SuspendLayout();
            // 
            // btnnhapmoi
            // 
            this.btnnhapmoi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnnhapmoi.BackColor = System.Drawing.Color.Transparent;
            this.btnnhapmoi.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnnhapmoi.Location = new System.Drawing.Point(703, 586);
            this.btnnhapmoi.Name = "btnnhapmoi";
            this.btnnhapmoi.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnnhapmoi.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F5);
            this.btnnhapmoi.Size = new System.Drawing.Size(130, 50);
            this.btnnhapmoi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnnhapmoi.Symbol = "57384";
            this.btnnhapmoi.SymbolColor = System.Drawing.Color.Black;
            this.btnnhapmoi.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnnhapmoi.SymbolSize = 14F;
            this.btnnhapmoi.TabIndex = 44;
            this.btnnhapmoi.Text = "Nhập mới";
            this.btnnhapmoi.TextColor = System.Drawing.Color.Black;
            this.btnnhapmoi.Click += new System.EventHandler(this.btnnhapmoi_Click);
            // 
            // cbbmkh
            // 
            this.cbbmkh.DisplayMember = "Text";
            this.cbbmkh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbmkh.FormattingEnabled = true;
            this.cbbmkh.ItemHeight = 16;
            this.cbbmkh.Location = new System.Drawing.Point(168, 86);
            this.cbbmkh.Name = "cbbmkh";
            this.cbbmkh.Size = new System.Drawing.Size(341, 22);
            this.cbbmkh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbbmkh.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(24, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã khách hàng";
            // 
            // btnxoa
            // 
            this.btnxoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnxoa.BackColor = System.Drawing.Color.Transparent;
            this.btnxoa.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnxoa.Location = new System.Drawing.Point(470, 586);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnxoa.Size = new System.Drawing.Size(130, 50);
            this.btnxoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnxoa.Symbol = "57676";
            this.btnxoa.SymbolColor = System.Drawing.Color.Red;
            this.btnxoa.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnxoa.SymbolSize = 13F;
            this.btnxoa.TabIndex = 43;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.TextColor = System.Drawing.Color.Black;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.loishd);
            this.panel1.Controls.Add(this.dtpndh);
            this.panel1.Controls.Add(this.cbbmnv);
            this.panel1.Controls.Add(this.cbbmkh);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtshd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(4, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1076, 225);
            this.panel1.TabIndex = 46;
            // 
            // dtpndh
            // 
            this.dtpndh.Location = new System.Drawing.Point(699, 22);
            this.dtpndh.Name = "dtpndh";
            this.dtpndh.Size = new System.Drawing.Size(341, 22);
            this.dtpndh.TabIndex = 4;
            // 
            // cbbmnv
            // 
            this.cbbmnv.DisplayMember = "Text";
            this.cbbmnv.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbmnv.FormattingEnabled = true;
            this.cbbmnv.ItemHeight = 16;
            this.cbbmnv.Location = new System.Drawing.Point(168, 152);
            this.cbbmnv.Name = "cbbmnv";
            this.cbbmnv.Size = new System.Drawing.Size(341, 22);
            this.cbbmnv.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbbmnv.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(24, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Mã nhân viên";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(555, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Ngày mua hàng";
            // 
            // txtshd
            // 
            this.txtshd.Location = new System.Drawing.Point(168, 22);
            this.txtshd.Multiline = true;
            this.txtshd.Name = "txtshd";
            this.txtshd.Size = new System.Drawing.Size(341, 27);
            this.txtshd.TabIndex = 1;
            this.txtshd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtshd_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Số hóa đơn";
            // 
            // btnsua
            // 
            this.btnsua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnsua.BackColor = System.Drawing.Color.Transparent;
            this.btnsua.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnsua.Location = new System.Drawing.Point(223, 586);
            this.btnsua.Name = "btnsua";
            this.btnsua.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnsua.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.AltEnter);
            this.btnsua.Size = new System.Drawing.Size(130, 50);
            this.btnsua.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnsua.Symbol = "57899";
            this.btnsua.SymbolColor = System.Drawing.Color.Black;
            this.btnsua.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnsua.SymbolSize = 12F;
            this.btnsua.TabIndex = 42;
            this.btnsua.Text = "Sửa";
            this.btnsua.TextColor = System.Drawing.Color.Black;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnthem.BackColor = System.Drawing.Color.Transparent;
            this.btnthem.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnthem.Location = new System.Drawing.Point(14, 586);
            this.btnthem.Name = "btnthem";
            this.btnthem.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnthem.Size = new System.Drawing.Size(130, 50);
            this.btnthem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnthem.Symbol = "57669";
            this.btnthem.SymbolColor = System.Drawing.Color.Black;
            this.btnthem.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnthem.SymbolSize = 11F;
            this.btnthem.TabIndex = 41;
            this.btnthem.Text = "Thêm";
            this.btnthem.TextColor = System.Drawing.Color.Black;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnthoat.BackColor = System.Drawing.Color.Transparent;
            this.btnthoat.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnthoat.Location = new System.Drawing.Point(942, 586);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnthoat.Size = new System.Drawing.Size(130, 50);
            this.btnthoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnthoat.Symbol = "59550";
            this.btnthoat.SymbolColor = System.Drawing.Color.Black;
            this.btnthoat.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnthoat.SymbolSize = 15F;
            this.btnthoat.TabIndex = 47;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.TextColor = System.Drawing.Color.Black;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // dgvkh
            // 
            this.dgvkh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvkh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sohoadon,
            this.Makhachhang,
            this.Manhanvien,
            this.Ngaymuahang});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvkh.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvkh.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvkh.Location = new System.Drawing.Point(0, 248);
            this.dgvkh.Name = "dgvkh";
            this.dgvkh.RowHeadersWidth = 51;
            this.dgvkh.RowTemplate.Height = 24;
            this.dgvkh.Size = new System.Drawing.Size(1080, 309);
            this.dgvkh.TabIndex = 45;
            this.dgvkh.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvkh_CellMouseClick);
            // 
            // Sohoadon
            // 
            this.Sohoadon.DataPropertyName = "Sohoadon";
            this.Sohoadon.HeaderText = "Số hóa đơn ";
            this.Sohoadon.MinimumWidth = 6;
            this.Sohoadon.Name = "Sohoadon";
            this.Sohoadon.Width = 110;
            // 
            // Makhachhang
            // 
            this.Makhachhang.DataPropertyName = "Makhachhang";
            this.Makhachhang.DisplayMember = "Text";
            this.Makhachhang.DropDownHeight = 106;
            this.Makhachhang.DropDownWidth = 121;
            this.Makhachhang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Makhachhang.HeaderText = "Mã khách hàng";
            this.Makhachhang.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Makhachhang.IntegralHeight = false;
            this.Makhachhang.ItemHeight = 17;
            this.Makhachhang.MinimumWidth = 6;
            this.Makhachhang.Name = "Makhachhang";
            this.Makhachhang.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Makhachhang.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Makhachhang.Width = 140;
            // 
            // Manhanvien
            // 
            this.Manhanvien.DataPropertyName = "Manhanvien";
            this.Manhanvien.DisplayMember = "Text";
            this.Manhanvien.DropDownHeight = 106;
            this.Manhanvien.DropDownWidth = 121;
            this.Manhanvien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Manhanvien.HeaderText = "Mã nhân viên";
            this.Manhanvien.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Manhanvien.IntegralHeight = false;
            this.Manhanvien.ItemHeight = 17;
            this.Manhanvien.MinimumWidth = 6;
            this.Manhanvien.Name = "Manhanvien";
            this.Manhanvien.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Manhanvien.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Manhanvien.Width = 125;
            // 
            // Ngaymuahang
            // 
            this.Ngaymuahang.DataPropertyName = "Ngaymuahang";
            this.Ngaymuahang.HeaderText = "Ngày mua hàng";
            this.Ngaymuahang.MinimumWidth = 6;
            this.Ngaymuahang.Name = "Ngaymuahang";
            this.Ngaymuahang.Width = 125;
            // 
            // loishd
            // 
            this.loishd.AutoSize = true;
            this.loishd.BackColor = System.Drawing.Color.White;
            this.loishd.Location = new System.Drawing.Point(474, 27);
            this.loishd.Name = "loishd";
            this.loishd.Size = new System.Drawing.Size(0, 17);
            this.loishd.TabIndex = 18;
            // 
            // QLHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.Controls.Add(this.btnnhapmoi);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.dgvkh);
            this.Name = "QLHD";
            this.Text = "QLHD";
            this.Load += new System.EventHandler(this.QLHD_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnnhapmoi;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbbmkh;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.ButtonX btnxoa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtshd;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.ButtonX btnsua;
        private DevComponents.DotNetBar.ButtonX btnthem;
        private DevComponents.DotNetBar.ButtonX btnthoat;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvkh;
        private System.Windows.Forms.DateTimePicker dtpndh;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbbmnv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sohoadon;
        private DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn Makhachhang;
        private DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn Manhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaymuahang;
        private System.Windows.Forms.Label loishd;
    }
}