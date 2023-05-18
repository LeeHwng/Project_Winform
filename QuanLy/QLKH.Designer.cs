
namespace LeQuocHung_BlackMobile.QuanLy
{
    partial class QLKH
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
            this.dgvkh = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Makhachhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenkhachhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dienthoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.loimkh = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtdt = new System.Windows.Forms.TextBox();
            this.txtdc = new System.Windows.Forms.TextBox();
            this.txtmkh = new System.Windows.Forms.TextBox();
            this.txttkh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnthem = new DevComponents.DotNetBar.ButtonX();
            this.btnsua = new DevComponents.DotNetBar.ButtonX();
            this.btnxoa = new DevComponents.DotNetBar.ButtonX();
            this.btnnhapmoi = new DevComponents.DotNetBar.ButtonX();
            this.btnthoat = new DevComponents.DotNetBar.ButtonX();
            this.loitkh = new System.Windows.Forms.Label();
            this.loidc = new System.Windows.Forms.Label();
            this.loidt = new System.Windows.Forms.Label();
            this.loiemail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkh)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvkh
            // 
            this.dgvkh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvkh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Makhachhang,
            this.Tenkhachhang,
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
            this.dgvkh.Location = new System.Drawing.Point(-2, 242);
            this.dgvkh.Name = "dgvkh";
            this.dgvkh.RowHeadersWidth = 51;
            this.dgvkh.RowTemplate.Height = 24;
            this.dgvkh.Size = new System.Drawing.Size(1080, 309);
            this.dgvkh.TabIndex = 0;
            this.dgvkh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvkh_CellContentClick);
            this.dgvkh.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvkh_CellMouseClick);
            // 
            // Makhachhang
            // 
            this.Makhachhang.DataPropertyName = "Makhachhang";
            this.Makhachhang.HeaderText = "Mã khách hàng";
            this.Makhachhang.MinimumWidth = 6;
            this.Makhachhang.Name = "Makhachhang";
            this.Makhachhang.Width = 110;
            // 
            // Tenkhachhang
            // 
            this.Tenkhachhang.DataPropertyName = "Tenkhachhang";
            this.Tenkhachhang.HeaderText = "Tên khách hàng";
            this.Tenkhachhang.MinimumWidth = 6;
            this.Tenkhachhang.Name = "Tenkhachhang";
            this.Tenkhachhang.Width = 140;
            // 
            // Diachi
            // 
            this.Diachi.DataPropertyName = "Diachi";
            this.Diachi.HeaderText = "Địa chỉ";
            this.Diachi.MinimumWidth = 6;
            this.Diachi.Name = "Diachi";
            this.Diachi.Width = 240;
            // 
            // Dienthoai
            // 
            this.Dienthoai.DataPropertyName = "Dienthoai";
            this.Dienthoai.HeaderText = "Điện thoại";
            this.Dienthoai.MinimumWidth = 6;
            this.Dienthoai.Name = "Dienthoai";
            this.Dienthoai.Width = 90;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Width = 160;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.loiemail);
            this.panel1.Controls.Add(this.loidt);
            this.panel1.Controls.Add(this.loidc);
            this.panel1.Controls.Add(this.loitkh);
            this.panel1.Controls.Add(this.loimkh);
            this.panel1.Controls.Add(this.txtemail);
            this.panel1.Controls.Add(this.txtdt);
            this.panel1.Controls.Add(this.txtdc);
            this.panel1.Controls.Add(this.txtmkh);
            this.panel1.Controls.Add(this.txttkh);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1079, 225);
            this.panel1.TabIndex = 1;
            // 
            // loimkh
            // 
            this.loimkh.AutoSize = true;
            this.loimkh.BackColor = System.Drawing.Color.White;
            this.loimkh.Location = new System.Drawing.Point(476, 30);
            this.loimkh.Name = "loimkh";
            this.loimkh.Size = new System.Drawing.Size(0, 17);
            this.loimkh.TabIndex = 11;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(685, 100);
            this.txtemail.Multiline = true;
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(341, 27);
            this.txtemail.TabIndex = 5;
            this.txtemail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtemail_KeyPress);
            // 
            // txtdt
            // 
            this.txtdt.Location = new System.Drawing.Point(685, 25);
            this.txtdt.Multiline = true;
            this.txtdt.Name = "txtdt";
            this.txtdt.Size = new System.Drawing.Size(341, 27);
            this.txtdt.TabIndex = 4;
            this.txtdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdt_KeyPress);
            // 
            // txtdc
            // 
            this.txtdc.Location = new System.Drawing.Point(168, 177);
            this.txtdc.Multiline = true;
            this.txtdc.Name = "txtdc";
            this.txtdc.Size = new System.Drawing.Size(341, 27);
            this.txtdc.TabIndex = 3;
            this.txtdc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdc_KeyPress);
            // 
            // txtmkh
            // 
            this.txtmkh.Location = new System.Drawing.Point(168, 25);
            this.txtmkh.Multiline = true;
            this.txtmkh.Name = "txtmkh";
            this.txtmkh.Size = new System.Drawing.Size(341, 27);
            this.txtmkh.TabIndex = 1;
            this.txtmkh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmkh_KeyPress);
            // 
            // txttkh
            // 
            this.txttkh.Location = new System.Drawing.Point(168, 100);
            this.txttkh.Multiline = true;
            this.txttkh.Name = "txttkh";
            this.txttkh.Size = new System.Drawing.Size(341, 27);
            this.txttkh.TabIndex = 2;
            this.txttkh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttkh_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(541, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(541, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(24, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Địa chỉ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mã khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(24, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên khách hàng ";
            // 
            // btnthem
            // 
            this.btnthem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnthem.BackColor = System.Drawing.Color.Transparent;
            this.btnthem.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnthem.Location = new System.Drawing.Point(12, 580);
            this.btnthem.Name = "btnthem";
            this.btnthem.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnthem.Size = new System.Drawing.Size(130, 50);
            this.btnthem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnthem.Symbol = "57669";
            this.btnthem.SymbolColor = System.Drawing.Color.Black;
            this.btnthem.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnthem.SymbolSize = 17F;
            this.btnthem.TabIndex = 8;
            this.btnthem.Text = "Thêm";
            this.btnthem.TextColor = System.Drawing.Color.Black;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnsua.BackColor = System.Drawing.Color.Transparent;
            this.btnsua.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnsua.Location = new System.Drawing.Point(221, 580);
            this.btnsua.Name = "btnsua";
            this.btnsua.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnsua.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.AltEnter);
            this.btnsua.Size = new System.Drawing.Size(130, 50);
            this.btnsua.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnsua.Symbol = "57899";
            this.btnsua.SymbolColor = System.Drawing.Color.Black;
            this.btnsua.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnsua.SymbolSize = 12F;
            this.btnsua.TabIndex = 9;
            this.btnsua.Text = "Sửa";
            this.btnsua.TextColor = System.Drawing.Color.Black;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnxoa.BackColor = System.Drawing.Color.Transparent;
            this.btnxoa.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnxoa.Location = new System.Drawing.Point(468, 580);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnxoa.Size = new System.Drawing.Size(130, 50);
            this.btnxoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnxoa.Symbol = "57676";
            this.btnxoa.SymbolColor = System.Drawing.Color.Red;
            this.btnxoa.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnxoa.SymbolSize = 17F;
            this.btnxoa.TabIndex = 10;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.TextColor = System.Drawing.Color.Black;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnnhapmoi
            // 
            this.btnnhapmoi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnnhapmoi.BackColor = System.Drawing.Color.Transparent;
            this.btnnhapmoi.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnnhapmoi.Location = new System.Drawing.Point(701, 580);
            this.btnnhapmoi.Name = "btnnhapmoi";
            this.btnnhapmoi.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnnhapmoi.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F5);
            this.btnnhapmoi.Size = new System.Drawing.Size(130, 50);
            this.btnnhapmoi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnnhapmoi.Symbol = "57384";
            this.btnnhapmoi.SymbolColor = System.Drawing.Color.Black;
            this.btnnhapmoi.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnnhapmoi.SymbolSize = 15F;
            this.btnnhapmoi.TabIndex = 11;
            this.btnnhapmoi.Text = "Nhập mới";
            this.btnnhapmoi.TextColor = System.Drawing.Color.Black;
            this.btnnhapmoi.Click += new System.EventHandler(this.btnnhapmoi_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnthoat.BackColor = System.Drawing.Color.Transparent;
            this.btnthoat.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnthoat.Location = new System.Drawing.Point(940, 580);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnthoat.Size = new System.Drawing.Size(130, 50);
            this.btnthoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnthoat.Symbol = "59550";
            this.btnthoat.SymbolColor = System.Drawing.Color.Black;
            this.btnthoat.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnthoat.SymbolSize = 14F;
            this.btnthoat.TabIndex = 12;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.TextColor = System.Drawing.Color.Black;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // loitkh
            // 
            this.loitkh.AutoSize = true;
            this.loitkh.BackColor = System.Drawing.Color.White;
            this.loitkh.Location = new System.Drawing.Point(481, 105);
            this.loitkh.Name = "loitkh";
            this.loitkh.Size = new System.Drawing.Size(0, 17);
            this.loitkh.TabIndex = 12;
            // 
            // loidc
            // 
            this.loidc.AutoSize = true;
            this.loidc.BackColor = System.Drawing.Color.White;
            this.loidc.Location = new System.Drawing.Point(475, 182);
            this.loidc.Name = "loidc";
            this.loidc.Size = new System.Drawing.Size(0, 17);
            this.loidc.TabIndex = 13;
            // 
            // loidt
            // 
            this.loidt.AutoSize = true;
            this.loidt.BackColor = System.Drawing.Color.White;
            this.loidt.Location = new System.Drawing.Point(995, 30);
            this.loidt.Name = "loidt";
            this.loidt.Size = new System.Drawing.Size(0, 17);
            this.loidt.TabIndex = 14;
            // 
            // loiemail
            // 
            this.loiemail.AutoSize = true;
            this.loiemail.BackColor = System.Drawing.Color.White;
            this.loiemail.Location = new System.Drawing.Point(993, 105);
            this.loiemail.Name = "loiemail";
            this.loiemail.Size = new System.Drawing.Size(0, 17);
            this.loiemail.TabIndex = 15;
            // 
            // QLKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.Controls.Add(this.dgvkh);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnnhapmoi);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.panel1);
            this.Name = "QLKH";
            this.Text = "QLKH";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.QLKH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvkh)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgvkh;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.ButtonX btnthem;
        private DevComponents.DotNetBar.ButtonX btnsua;
        private DevComponents.DotNetBar.ButtonX btnxoa;
        private DevComponents.DotNetBar.ButtonX btnnhapmoi;
        private DevComponents.DotNetBar.ButtonX btnthoat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtdt;
        private System.Windows.Forms.TextBox txtdc;
        private System.Windows.Forms.TextBox txtmkh;
        private System.Windows.Forms.TextBox txttkh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Makhachhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenkhachhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dienthoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.Label loimkh;
        private System.Windows.Forms.Label loiemail;
        private System.Windows.Forms.Label loidt;
        private System.Windows.Forms.Label loidc;
        private System.Windows.Forms.Label loitkh;
    }
}