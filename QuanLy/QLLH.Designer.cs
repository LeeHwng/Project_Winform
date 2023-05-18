
namespace LeQuocHung_BlackMobile.QuanLy
{
    partial class QLLH
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnxoa = new DevComponents.DotNetBar.ButtonX();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txttlh = new System.Windows.Forms.TextBox();
            this.tlh = new System.Windows.Forms.Label();
            this.txtmlh = new System.Windows.Forms.TextBox();
            this.mlh = new System.Windows.Forms.Label();
            this.btnthoat = new DevComponents.DotNetBar.ButtonX();
            this.btnnhapmoi = new DevComponents.DotNetBar.ButtonX();
            this.btnsua = new DevComponents.DotNetBar.ButtonX();
            this.btnthem = new DevComponents.DotNetBar.ButtonX();
            this.dgvkh = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Maloaihang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenloaihang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhanVienLapItHDNhatTableAdapter1 = new LeQuocHung_BlackMobile.ThongKeBaoCao.NhanVienTableAdapters.NhanVienLapItHDNhatTableAdapter();
            this.loiml = new System.Windows.Forms.Label();
            this.loitl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkh)).BeginInit();
            this.SuspendLayout();
            // 
            // btnxoa
            // 
            this.btnxoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnxoa.BackColor = System.Drawing.Color.Transparent;
            this.btnxoa.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnxoa.Location = new System.Drawing.Point(468, 582);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnxoa.Size = new System.Drawing.Size(130, 50);
            this.btnxoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnxoa.Symbol = "57676";
            this.btnxoa.SymbolColor = System.Drawing.Color.Red;
            this.btnxoa.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnxoa.SymbolSize = 17F;
            this.btnxoa.TabIndex = 31;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.TextColor = System.Drawing.Color.Black;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.loitl);
            this.panel1.Controls.Add(this.loiml);
            this.panel1.Controls.Add(this.txttlh);
            this.panel1.Controls.Add(this.tlh);
            this.panel1.Controls.Add(this.txtmlh);
            this.panel1.Controls.Add(this.mlh);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1076, 225);
            this.panel1.TabIndex = 28;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txttlh
            // 
            this.txttlh.Location = new System.Drawing.Point(448, 135);
            this.txttlh.Multiline = true;
            this.txttlh.Name = "txttlh";
            this.txttlh.Size = new System.Drawing.Size(341, 27);
            this.txttlh.TabIndex = 2;
            this.txttlh.TextChanged += new System.EventHandler(this.txttlh_TextChanged);
            this.txttlh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttlh_KeyPress);
            // 
            // tlh
            // 
            this.tlh.AutoSize = true;
            this.tlh.BackColor = System.Drawing.Color.Transparent;
            this.tlh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.tlh.ForeColor = System.Drawing.Color.Black;
            this.tlh.Location = new System.Drawing.Point(257, 135);
            this.tlh.Name = "tlh";
            this.tlh.Size = new System.Drawing.Size(109, 20);
            this.tlh.TabIndex = 16;
            this.tlh.Text = "Tên loại hàng";
            // 
            // txtmlh
            // 
            this.txtmlh.Location = new System.Drawing.Point(448, 45);
            this.txtmlh.Multiline = true;
            this.txtmlh.Name = "txtmlh";
            this.txtmlh.Size = new System.Drawing.Size(341, 27);
            this.txtmlh.TabIndex = 1;
            this.txtmlh.TextChanged += new System.EventHandler(this.txtmlh_TextChanged);
            this.txtmlh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmlh_KeyPress);
            // 
            // mlh
            // 
            this.mlh.AutoSize = true;
            this.mlh.BackColor = System.Drawing.Color.Transparent;
            this.mlh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.mlh.ForeColor = System.Drawing.Color.Black;
            this.mlh.Location = new System.Drawing.Point(257, 45);
            this.mlh.Name = "mlh";
            this.mlh.Size = new System.Drawing.Size(109, 20);
            this.mlh.TabIndex = 7;
            this.mlh.Text = " Mã loại hàng";
            this.mlh.Click += new System.EventHandler(this.mlh_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnthoat.BackColor = System.Drawing.Color.Transparent;
            this.btnthoat.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnthoat.Location = new System.Drawing.Point(940, 582);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnthoat.Size = new System.Drawing.Size(130, 50);
            this.btnthoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnthoat.Symbol = "59550";
            this.btnthoat.SymbolColor = System.Drawing.Color.Black;
            this.btnthoat.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnthoat.SymbolSize = 14F;
            this.btnthoat.TabIndex = 33;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.TextColor = System.Drawing.Color.Black;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnnhapmoi
            // 
            this.btnnhapmoi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnnhapmoi.BackColor = System.Drawing.Color.Transparent;
            this.btnnhapmoi.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnnhapmoi.Location = new System.Drawing.Point(701, 582);
            this.btnnhapmoi.Name = "btnnhapmoi";
            this.btnnhapmoi.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnnhapmoi.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F5);
            this.btnnhapmoi.Size = new System.Drawing.Size(130, 50);
            this.btnnhapmoi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnnhapmoi.Symbol = "57384";
            this.btnnhapmoi.SymbolColor = System.Drawing.Color.Black;
            this.btnnhapmoi.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnnhapmoi.SymbolSize = 15F;
            this.btnnhapmoi.TabIndex = 32;
            this.btnnhapmoi.Text = "Nhập mới";
            this.btnnhapmoi.TextColor = System.Drawing.Color.Black;
            this.btnnhapmoi.Click += new System.EventHandler(this.btnnhapmoi_Click);
            // 
            // btnsua
            // 
            this.btnsua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnsua.BackColor = System.Drawing.Color.Transparent;
            this.btnsua.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnsua.Location = new System.Drawing.Point(221, 582);
            this.btnsua.Name = "btnsua";
            this.btnsua.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnsua.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.AltEnter);
            this.btnsua.Size = new System.Drawing.Size(130, 50);
            this.btnsua.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnsua.Symbol = "57899";
            this.btnsua.SymbolColor = System.Drawing.Color.Black;
            this.btnsua.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnsua.SymbolSize = 12F;
            this.btnsua.TabIndex = 30;
            this.btnsua.Text = "Sửa";
            this.btnsua.TextColor = System.Drawing.Color.Black;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnthem.BackColor = System.Drawing.Color.Transparent;
            this.btnthem.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnthem.Location = new System.Drawing.Point(12, 582);
            this.btnthem.Name = "btnthem";
            this.btnthem.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnthem.Size = new System.Drawing.Size(130, 50);
            this.btnthem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnthem.Symbol = "57669";
            this.btnthem.SymbolColor = System.Drawing.Color.Black;
            this.btnthem.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnthem.SymbolSize = 17F;
            this.btnthem.TabIndex = 29;
            this.btnthem.Text = "Thêm";
            this.btnthem.TextColor = System.Drawing.Color.Black;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // dgvkh
            // 
            this.dgvkh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvkh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Maloaihang,
            this.Tenloaihang});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvkh.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvkh.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvkh.Location = new System.Drawing.Point(-2, 244);
            this.dgvkh.Name = "dgvkh";
            this.dgvkh.RowHeadersWidth = 51;
            this.dgvkh.RowTemplate.Height = 24;
            this.dgvkh.Size = new System.Drawing.Size(1080, 309);
            this.dgvkh.TabIndex = 27;
            this.dgvkh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvkh_CellContentClick);
            this.dgvkh.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvkh_CellMouseClick);
            // 
            // Maloaihang
            // 
            this.Maloaihang.DataPropertyName = "Maloaihang";
            this.Maloaihang.HeaderText = "Mã loại hàng";
            this.Maloaihang.MinimumWidth = 6;
            this.Maloaihang.Name = "Maloaihang";
            this.Maloaihang.Width = 110;
            // 
            // Tenloaihang
            // 
            this.Tenloaihang.DataPropertyName = "Tenloaihang";
            this.Tenloaihang.HeaderText = "Tên loại hàng";
            this.Tenloaihang.MinimumWidth = 6;
            this.Tenloaihang.Name = "Tenloaihang";
            this.Tenloaihang.Width = 140;
            // 
            // nhanVienLapItHDNhatTableAdapter1
            // 
            this.nhanVienLapItHDNhatTableAdapter1.ClearBeforeFill = true;
            // 
            // loiml
            // 
            this.loiml.AutoSize = true;
            this.loiml.BackColor = System.Drawing.Color.White;
            this.loiml.Location = new System.Drawing.Point(759, 50);
            this.loiml.Name = "loiml";
            this.loiml.Size = new System.Drawing.Size(12, 17);
            this.loiml.TabIndex = 17;
            this.loiml.Text = " ";
            // 
            // loitl
            // 
            this.loitl.AutoSize = true;
            this.loitl.BackColor = System.Drawing.Color.White;
            this.loitl.Location = new System.Drawing.Point(757, 140);
            this.loitl.Name = "loitl";
            this.loitl.Size = new System.Drawing.Size(0, 17);
            this.loitl.TabIndex = 18;
            // 
            // QLLH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnnhapmoi);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dgvkh);
            this.Name = "QLLH";
            this.Text = "QLLH";
            this.Load += new System.EventHandler(this.QLLH_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnxoa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txttlh;
        private System.Windows.Forms.Label tlh;
        private System.Windows.Forms.TextBox txtmlh;
        private System.Windows.Forms.Label mlh;
        private DevComponents.DotNetBar.ButtonX btnthoat;
        private DevComponents.DotNetBar.ButtonX btnnhapmoi;
        private DevComponents.DotNetBar.ButtonX btnsua;
        private DevComponents.DotNetBar.ButtonX btnthem;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvkh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maloaihang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenloaihang;
        private System.Windows.Forms.Label loitl;
        private System.Windows.Forms.Label loiml;
        private ThongKeBaoCao.NhanVienTableAdapters.NhanVienLapItHDNhatTableAdapter nhanVienLapItHDNhatTableAdapter1;
    }
}