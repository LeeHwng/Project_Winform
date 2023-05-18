
namespace LeQuocHung_BlackMobile.QuanLy
{
    partial class QLNCC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.btnxoa = new DevComponents.DotNetBar.ButtonX();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtdc = new System.Windows.Forms.TextBox();
            this.txtdt = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtmct = new System.Windows.Forms.TextBox();
            this.txttct = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnthoat = new DevComponents.DotNetBar.ButtonX();
            this.btnnhapmoi = new DevComponents.DotNetBar.ButtonX();
            this.btnsua = new DevComponents.DotNetBar.ButtonX();
            this.btnthem = new DevComponents.DotNetBar.ButtonX();
            this.dgvkh = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Macongty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tencongty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dienthoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loimct = new System.Windows.Forms.Label();
            this.loitct = new System.Windows.Forms.Label();
            this.loidc = new System.Windows.Forms.Label();
            this.loidt = new System.Windows.Forms.Label();
            this.loiemail = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkh)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(24, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = " Tên công ty";
            // 
            // btnxoa
            // 
            this.btnxoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnxoa.BackColor = System.Drawing.Color.Transparent;
            this.btnxoa.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnxoa.Location = new System.Drawing.Point(469, 587);
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
            this.panel1.Controls.Add(this.loiemail);
            this.panel1.Controls.Add(this.loidt);
            this.panel1.Controls.Add(this.loidc);
            this.panel1.Controls.Add(this.loitct);
            this.panel1.Controls.Add(this.loimct);
            this.panel1.Controls.Add(this.txtdc);
            this.panel1.Controls.Add(this.txtdt);
            this.panel1.Controls.Add(this.txtemail);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtmct);
            this.panel1.Controls.Add(this.txttct);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(3, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1076, 225);
            this.panel1.TabIndex = 32;
            // 
            // txtdc
            // 
            this.txtdc.Location = new System.Drawing.Point(168, 152);
            this.txtdc.Multiline = true;
            this.txtdc.Name = "txtdc";
            this.txtdc.Size = new System.Drawing.Size(341, 27);
            this.txtdc.TabIndex = 3;
            this.txtdc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdc_KeyPress);
            // 
            // txtdt
            // 
            this.txtdt.Location = new System.Drawing.Point(726, 22);
            this.txtdt.Multiline = true;
            this.txtdt.Name = "txtdt";
            this.txtdt.Size = new System.Drawing.Size(341, 27);
            this.txtdt.TabIndex = 4;
            this.txtdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdt_KeyPress);
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(726, 81);
            this.txtemail.Multiline = true;
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(341, 27);
            this.txtemail.TabIndex = 5;
            this.txtemail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtemail_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(24, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Địa chỉ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(555, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = " Điện thoại";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(555, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Email";
            // 
            // txtmct
            // 
            this.txtmct.Location = new System.Drawing.Point(168, 22);
            this.txtmct.Multiline = true;
            this.txtmct.Name = "txtmct";
            this.txtmct.Size = new System.Drawing.Size(341, 27);
            this.txtmct.TabIndex = 1;
            this.txtmct.TextChanged += new System.EventHandler(this.txtmct_TextChanged);
            this.txtmct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmct_KeyPress);
            // 
            // txttct
            // 
            this.txttct.Location = new System.Drawing.Point(168, 86);
            this.txttct.Multiline = true;
            this.txttct.Name = "txttct";
            this.txttct.Size = new System.Drawing.Size(341, 27);
            this.txttct.TabIndex = 2;
            this.txttct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttct_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = " Mã công ty ";
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
            this.btnthoat.SymbolSize = 15F;
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
            this.btnnhapmoi.Location = new System.Drawing.Point(702, 587);
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
            // btnsua
            // 
            this.btnsua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnsua.BackColor = System.Drawing.Color.Transparent;
            this.btnsua.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnsua.Location = new System.Drawing.Point(222, 587);
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
            // btnthem
            // 
            this.btnthem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnthem.BackColor = System.Drawing.Color.Transparent;
            this.btnthem.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnthem.Location = new System.Drawing.Point(13, 587);
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
            // dgvkh
            // 
            this.dgvkh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvkh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Macongty,
            this.Tencongty,
            this.Diachi,
            this.Dienthoai,
            this.Email});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvkh.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvkh.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvkh.Location = new System.Drawing.Point(-1, 249);
            this.dgvkh.Name = "dgvkh";
            this.dgvkh.RowHeadersWidth = 51;
            this.dgvkh.RowTemplate.Height = 24;
            this.dgvkh.Size = new System.Drawing.Size(1080, 309);
            this.dgvkh.TabIndex = 31;
            this.dgvkh.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvkh_CellMouseClick);
            // 
            // Macongty
            // 
            this.Macongty.DataPropertyName = "Macongty";
            this.Macongty.HeaderText = "Mã công ty";
            this.Macongty.MinimumWidth = 6;
            this.Macongty.Name = "Macongty";
            this.Macongty.Width = 110;
            // 
            // Tencongty
            // 
            this.Tencongty.DataPropertyName = "Tencongty";
            this.Tencongty.HeaderText = "Tên công ty";
            this.Tencongty.MinimumWidth = 6;
            this.Tencongty.Name = "Tencongty";
            this.Tencongty.Width = 140;
            // 
            // Diachi
            // 
            this.Diachi.DataPropertyName = "Diachi";
            this.Diachi.HeaderText = "Địa chỉ";
            this.Diachi.MinimumWidth = 6;
            this.Diachi.Name = "Diachi";
            this.Diachi.Width = 125;
            // 
            // Dienthoai
            // 
            this.Dienthoai.DataPropertyName = "Dienthoai";
            this.Dienthoai.HeaderText = "Điện thoại";
            this.Dienthoai.MinimumWidth = 6;
            this.Dienthoai.Name = "Dienthoai";
            this.Dienthoai.Width = 125;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Width = 125;
            // 
            // loimct
            // 
            this.loimct.AutoSize = true;
            this.loimct.BackColor = System.Drawing.Color.White;
            this.loimct.Location = new System.Drawing.Point(475, 27);
            this.loimct.Name = "loimct";
            this.loimct.Size = new System.Drawing.Size(12, 17);
            this.loimct.TabIndex = 18;
            this.loimct.Text = " ";
            // 
            // loitct
            // 
            this.loitct.AutoSize = true;
            this.loitct.BackColor = System.Drawing.Color.White;
            this.loitct.Location = new System.Drawing.Point(475, 91);
            this.loitct.Name = "loitct";
            this.loitct.Size = new System.Drawing.Size(12, 17);
            this.loitct.TabIndex = 19;
            this.loitct.Text = " ";
            // 
            // loidc
            // 
            this.loidc.AutoSize = true;
            this.loidc.BackColor = System.Drawing.Color.White;
            this.loidc.Location = new System.Drawing.Point(475, 157);
            this.loidc.Name = "loidc";
            this.loidc.Size = new System.Drawing.Size(12, 17);
            this.loidc.TabIndex = 20;
            this.loidc.Text = " ";
            // 
            // loidt
            // 
            this.loidt.AutoSize = true;
            this.loidt.BackColor = System.Drawing.Color.White;
            this.loidt.Location = new System.Drawing.Point(1034, 26);
            this.loidt.Name = "loidt";
            this.loidt.Size = new System.Drawing.Size(12, 17);
            this.loidt.TabIndex = 21;
            this.loidt.Text = " ";
            // 
            // loiemail
            // 
            this.loiemail.AutoSize = true;
            this.loiemail.BackColor = System.Drawing.Color.White;
            this.loiemail.Location = new System.Drawing.Point(1034, 86);
            this.loiemail.Name = "loiemail";
            this.loiemail.Size = new System.Drawing.Size(12, 17);
            this.loiemail.TabIndex = 22;
            this.loiemail.Text = " ";
            // 
            // QLNCC
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
            this.Name = "QLNCC";
            this.Text = "QLNCC";
            this.Load += new System.EventHandler(this.QLNCC_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.ButtonX btnxoa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtdc;
        private System.Windows.Forms.TextBox txtdt;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtmct;
        private System.Windows.Forms.TextBox txttct;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.ButtonX btnthoat;
        private DevComponents.DotNetBar.ButtonX btnnhapmoi;
        private DevComponents.DotNetBar.ButtonX btnsua;
        private DevComponents.DotNetBar.ButtonX btnthem;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvkh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Macongty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tencongty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dienthoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.Label loiemail;
        private System.Windows.Forms.Label loidt;
        private System.Windows.Forms.Label loidc;
        private System.Windows.Forms.Label loitct;
        private System.Windows.Forms.Label loimct;
    }
}