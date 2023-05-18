
namespace LeQuocHung_BlackMobile.QuanLy
{
    partial class QLCTHD
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtsl = new System.Windows.Forms.TextBox();
            this.txtgb = new System.Windows.Forms.TextBox();
            this.btnthoat = new DevComponents.DotNetBar.ButtonX();
            this.btnnhapmoi = new DevComponents.DotNetBar.ButtonX();
            this.btnsua = new DevComponents.DotNetBar.ButtonX();
            this.btnthem = new DevComponents.DotNetBar.ButtonX();
            this.dgvcthd = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Macongty = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            this.Mahang = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            this.Soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Giaban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hinhthucthanhtoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txthttt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnxoa = new DevComponents.DotNetBar.ButtonX();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbmh = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbbshd = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loisl = new System.Windows.Forms.Label();
            this.loigb = new System.Windows.Forms.Label();
            this.loihttt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcthd)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtsl
            // 
            this.txtsl.Location = new System.Drawing.Point(168, 152);
            this.txtsl.Multiline = true;
            this.txtsl.Name = "txtsl";
            this.txtsl.Size = new System.Drawing.Size(341, 27);
            this.txtsl.TabIndex = 3;
            this.txtsl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsl_KeyPress);
            // 
            // txtgb
            // 
            this.txtgb.Location = new System.Drawing.Point(726, 22);
            this.txtgb.Multiline = true;
            this.txtgb.Name = "txtgb";
            this.txtgb.Size = new System.Drawing.Size(341, 27);
            this.txtgb.TabIndex = 4;
            this.txtgb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtgb_KeyPress);
            // 
            // btnthoat
            // 
            this.btnthoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnthoat.BackColor = System.Drawing.Color.Transparent;
            this.btnthoat.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnthoat.Location = new System.Drawing.Point(942, 585);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnthoat.Size = new System.Drawing.Size(130, 50);
            this.btnthoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnthoat.Symbol = "59550";
            this.btnthoat.SymbolColor = System.Drawing.Color.Black;
            this.btnthoat.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnthoat.SymbolSize = 15F;
            this.btnthoat.TabIndex = 40;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.TextColor = System.Drawing.Color.Black;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnnhapmoi
            // 
            this.btnnhapmoi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnnhapmoi.BackColor = System.Drawing.Color.Transparent;
            this.btnnhapmoi.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnnhapmoi.Location = new System.Drawing.Point(703, 585);
            this.btnnhapmoi.Name = "btnnhapmoi";
            this.btnnhapmoi.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnnhapmoi.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F5);
            this.btnnhapmoi.Size = new System.Drawing.Size(130, 50);
            this.btnnhapmoi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnnhapmoi.Symbol = "57384";
            this.btnnhapmoi.SymbolColor = System.Drawing.Color.Black;
            this.btnnhapmoi.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnnhapmoi.SymbolSize = 14F;
            this.btnnhapmoi.TabIndex = 37;
            this.btnnhapmoi.Text = "Nhập mới";
            this.btnnhapmoi.TextColor = System.Drawing.Color.Black;
            this.btnnhapmoi.Click += new System.EventHandler(this.btnnhapmoi_Click);
            // 
            // btnsua
            // 
            this.btnsua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnsua.BackColor = System.Drawing.Color.Transparent;
            this.btnsua.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnsua.Location = new System.Drawing.Point(223, 585);
            this.btnsua.Name = "btnsua";
            this.btnsua.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnsua.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.AltEnter);
            this.btnsua.Size = new System.Drawing.Size(130, 50);
            this.btnsua.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnsua.Symbol = "57899";
            this.btnsua.SymbolColor = System.Drawing.Color.Black;
            this.btnsua.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnsua.SymbolSize = 12F;
            this.btnsua.TabIndex = 35;
            this.btnsua.Text = "Sửa";
            this.btnsua.TextColor = System.Drawing.Color.Black;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnthem.BackColor = System.Drawing.Color.Transparent;
            this.btnthem.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnthem.Location = new System.Drawing.Point(14, 585);
            this.btnthem.Name = "btnthem";
            this.btnthem.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnthem.Size = new System.Drawing.Size(130, 50);
            this.btnthem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnthem.Symbol = "57669";
            this.btnthem.SymbolColor = System.Drawing.Color.Black;
            this.btnthem.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnthem.SymbolSize = 11F;
            this.btnthem.TabIndex = 34;
            this.btnthem.Text = "Thêm";
            this.btnthem.TextColor = System.Drawing.Color.Black;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // dgvcthd
            // 
            this.dgvcthd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcthd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Macongty,
            this.Mahang,
            this.Soluong,
            this.Giaban,
            this.Hinhthucthanhtoan});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvcthd.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvcthd.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvcthd.Location = new System.Drawing.Point(0, 247);
            this.dgvcthd.Name = "dgvcthd";
            this.dgvcthd.RowHeadersWidth = 51;
            this.dgvcthd.RowTemplate.Height = 24;
            this.dgvcthd.Size = new System.Drawing.Size(1080, 309);
            this.dgvcthd.TabIndex = 38;
            this.dgvcthd.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvcthd_CellMouseClick);
            // 
            // Macongty
            // 
            this.Macongty.DataPropertyName = "Sohoadon";
            this.Macongty.DisplayMember = "Text";
            this.Macongty.DropDownHeight = 106;
            this.Macongty.DropDownWidth = 121;
            this.Macongty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Macongty.HeaderText = "Số hóa đơn";
            this.Macongty.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Macongty.IntegralHeight = false;
            this.Macongty.ItemHeight = 17;
            this.Macongty.MinimumWidth = 6;
            this.Macongty.Name = "Macongty";
            this.Macongty.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Macongty.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Macongty.Width = 110;
            // 
            // Mahang
            // 
            this.Mahang.DataPropertyName = "Mahang";
            this.Mahang.DisplayMember = "Text";
            this.Mahang.DropDownHeight = 106;
            this.Mahang.DropDownWidth = 121;
            this.Mahang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mahang.HeaderText = "Mã hàng";
            this.Mahang.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Mahang.IntegralHeight = false;
            this.Mahang.ItemHeight = 17;
            this.Mahang.MinimumWidth = 6;
            this.Mahang.Name = "Mahang";
            this.Mahang.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Mahang.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Mahang.Width = 140;
            // 
            // Soluong
            // 
            this.Soluong.DataPropertyName = "Soluong";
            this.Soluong.HeaderText = "Số lượng";
            this.Soluong.MinimumWidth = 6;
            this.Soluong.Name = "Soluong";
            this.Soluong.Width = 125;
            // 
            // Giaban
            // 
            this.Giaban.DataPropertyName = "Giaban";
            this.Giaban.HeaderText = "Giá bán";
            this.Giaban.MinimumWidth = 6;
            this.Giaban.Name = "Giaban";
            this.Giaban.Width = 125;
            // 
            // Hinhthucthanhtoan
            // 
            this.Hinhthucthanhtoan.DataPropertyName = "Hinhthucthanhtoan";
            this.Hinhthucthanhtoan.HeaderText = "Hình thức thánh toán";
            this.Hinhthucthanhtoan.MinimumWidth = 6;
            this.Hinhthucthanhtoan.Name = "Hinhthucthanhtoan";
            this.Hinhthucthanhtoan.Width = 125;
            // 
            // txthttt
            // 
            this.txthttt.Location = new System.Drawing.Point(726, 81);
            this.txthttt.Multiline = true;
            this.txthttt.Name = "txthttt";
            this.txthttt.Size = new System.Drawing.Size(341, 27);
            this.txthttt.TabIndex = 5;
            this.txthttt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txthttt_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(24, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = " Số lượng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(555, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Giá bán";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(555, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Hình thức thanh toán";
            // 
            // btnxoa
            // 
            this.btnxoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnxoa.BackColor = System.Drawing.Color.Transparent;
            this.btnxoa.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnxoa.Location = new System.Drawing.Point(470, 585);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnxoa.Size = new System.Drawing.Size(130, 50);
            this.btnxoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnxoa.Symbol = "57676";
            this.btnxoa.SymbolColor = System.Drawing.Color.Red;
            this.btnxoa.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnxoa.SymbolSize = 13F;
            this.btnxoa.TabIndex = 36;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.TextColor = System.Drawing.Color.Black;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.loihttt);
            this.panel1.Controls.Add(this.loigb);
            this.panel1.Controls.Add(this.loisl);
            this.panel1.Controls.Add(this.cbbmh);
            this.panel1.Controls.Add(this.cbbshd);
            this.panel1.Controls.Add(this.txtsl);
            this.panel1.Controls.Add(this.txtgb);
            this.panel1.Controls.Add(this.txthttt);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1076, 225);
            this.panel1.TabIndex = 39;
            // 
            // cbbmh
            // 
            this.cbbmh.DisplayMember = "Text";
            this.cbbmh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbmh.FormattingEnabled = true;
            this.cbbmh.ItemHeight = 16;
            this.cbbmh.Location = new System.Drawing.Point(168, 86);
            this.cbbmh.Name = "cbbmh";
            this.cbbmh.Size = new System.Drawing.Size(341, 22);
            this.cbbmh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbbmh.TabIndex = 2;
            // 
            // cbbshd
            // 
            this.cbbshd.DisplayMember = "Text";
            this.cbbshd.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbshd.FormattingEnabled = true;
            this.cbbshd.ItemHeight = 16;
            this.cbbshd.Location = new System.Drawing.Point(168, 20);
            this.cbbshd.Name = "cbbshd";
            this.cbbshd.Size = new System.Drawing.Size(341, 22);
            this.cbbshd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbbshd.TabIndex = 1;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(24, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã hàng";
            // 
            // loisl
            // 
            this.loisl.AutoSize = true;
            this.loisl.BackColor = System.Drawing.Color.White;
            this.loisl.Location = new System.Drawing.Point(470, 157);
            this.loisl.Name = "loisl";
            this.loisl.Size = new System.Drawing.Size(0, 17);
            this.loisl.TabIndex = 18;
            // 
            // loigb
            // 
            this.loigb.AutoSize = true;
            this.loigb.BackColor = System.Drawing.Color.White;
            this.loigb.Location = new System.Drawing.Point(1038, 27);
            this.loigb.Name = "loigb";
            this.loigb.Size = new System.Drawing.Size(0, 17);
            this.loigb.TabIndex = 19;
            // 
            // loihttt
            // 
            this.loihttt.AutoSize = true;
            this.loihttt.BackColor = System.Drawing.Color.White;
            this.loihttt.Location = new System.Drawing.Point(1038, 86);
            this.loihttt.Name = "loihttt";
            this.loihttt.Size = new System.Drawing.Size(0, 17);
            this.loihttt.TabIndex = 41;
            // 
            // QLCTHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnnhapmoi);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dgvcthd);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.panel1);
            this.Name = "QLCTHD";
            this.Text = "QLCTHD";
            this.Load += new System.EventHandler(this.QLCTHDcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcthd)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtsl;
        private System.Windows.Forms.TextBox txtgb;
        private DevComponents.DotNetBar.ButtonX btnthoat;
        private DevComponents.DotNetBar.ButtonX btnnhapmoi;
        private DevComponents.DotNetBar.ButtonX btnsua;
        private DevComponents.DotNetBar.ButtonX btnthem;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvcthd;
        private System.Windows.Forms.TextBox txthttt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private DevComponents.DotNetBar.ButtonX btnxoa;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbbmh;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbbshd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn Macongty;
        private DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn Mahang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Giaban;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hinhthucthanhtoan;
        private System.Windows.Forms.Label loihttt;
        private System.Windows.Forms.Label loigb;
        private System.Windows.Forms.Label loisl;
    }
}