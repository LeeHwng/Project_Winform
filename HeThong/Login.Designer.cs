
namespace LeQuocHung_BlackMobile.HeThong
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.dgvdn = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tendangnhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matkhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quanly = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txttdn = new System.Windows.Forms.TextBox();
            this.txtmk = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btndn = new DevComponents.DotNetBar.ButtonX();
            this.btnthoat = new DevComponents.DotNetBar.ButtonX();
            this.hien = new System.Windows.Forms.PictureBox();
            this.an = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.an)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvdn
            // 
            this.dgvdn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Tendangnhap,
            this.Matkhau,
            this.Quanly});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdn.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvdn.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvdn.Location = new System.Drawing.Point(284, 50);
            this.dgvdn.Name = "dgvdn";
            this.dgvdn.RowHeadersWidth = 51;
            this.dgvdn.RowTemplate.Height = 24;
            this.dgvdn.Size = new System.Drawing.Size(10, 10);
            this.dgvdn.TabIndex = 0;
            this.dgvdn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdn_CellContentClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 125;
            // 
            // Tendangnhap
            // 
            this.Tendangnhap.DataPropertyName = "Tendangnhap";
            this.Tendangnhap.HeaderText = "Tên đăng nhập";
            this.Tendangnhap.MinimumWidth = 6;
            this.Tendangnhap.Name = "Tendangnhap";
            this.Tendangnhap.Width = 125;
            // 
            // Matkhau
            // 
            this.Matkhau.DataPropertyName = "Matkhau";
            this.Matkhau.HeaderText = "Mật khẩu";
            this.Matkhau.MinimumWidth = 6;
            this.Matkhau.Name = "Matkhau";
            this.Matkhau.Width = 125;
            // 
            // Quanly
            // 
            this.Quanly.DataPropertyName = "Quanly";
            this.Quanly.HeaderText = "Quản lý";
            this.Quanly.MinimumWidth = 6;
            this.Quanly.Name = "Quanly";
            this.Quanly.Width = 125;
            // 
            // txttdn
            // 
            this.txttdn.Location = new System.Drawing.Point(142, 289);
            this.txttdn.Multiline = true;
            this.txttdn.Name = "txttdn";
            this.txttdn.Size = new System.Drawing.Size(380, 40);
            this.txttdn.TabIndex = 1;
            // 
            // txtmk
            // 
            this.txtmk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtmk.Location = new System.Drawing.Point(142, 397);
            this.txtmk.MaxLength = 15;
            this.txtmk.Multiline = true;
            this.txtmk.Name = "txtmk";
            this.txtmk.Size = new System.Drawing.Size(380, 40);
            this.txtmk.TabIndex = 2;
            this.txtmk.TextChanged += new System.EventHandler(this.txtmk_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(159, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Đăng Nhập Hệ Thống";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(68, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên đăng nhập ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(68, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mật khẩu";
            // 
            // btndn
            // 
            this.btndn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btndn.BackColor = System.Drawing.Color.Transparent;
            this.btndn.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btndn.Location = new System.Drawing.Point(164, 501);
            this.btndn.Name = "btndn";
            this.btndn.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btndn.Size = new System.Drawing.Size(130, 50);
            this.btndn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btndn.Symbol = "";
            this.btndn.SymbolColor = System.Drawing.Color.Black;
            this.btndn.TabIndex = 7;
            this.btndn.Text = "Đăng nhập ";
            this.btndn.TextColor = System.Drawing.Color.Black;
            this.btndn.Click += new System.EventHandler(this.btndn_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnthoat.BackColor = System.Drawing.Color.Transparent;
            this.btnthoat.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnthoat.Location = new System.Drawing.Point(373, 501);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnthoat.Size = new System.Drawing.Size(130, 50);
            this.btnthoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnthoat.Symbol = "";
            this.btnthoat.SymbolColor = System.Drawing.Color.Black;
            this.btnthoat.TabIndex = 8;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.TextColor = System.Drawing.Color.Black;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // hien
            // 
            this.hien.BackColor = System.Drawing.Color.White;
            this.hien.Image = global::LeQuocHung_BlackMobile.Properties.Resources.hien2;
            this.hien.Location = new System.Drawing.Point(462, 402);
            this.hien.Name = "hien";
            this.hien.Size = new System.Drawing.Size(60, 30);
            this.hien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hien.TabIndex = 10;
            this.hien.TabStop = false;
            this.hien.Click += new System.EventHandler(this.hien_Click);
            // 
            // an
            // 
            this.an.BackColor = System.Drawing.Color.White;
            this.an.Image = global::LeQuocHung_BlackMobile.Properties.Resources.an2;
            this.an.Location = new System.Drawing.Point(462, 402);
            this.an.Name = "an";
            this.an.Size = new System.Drawing.Size(60, 30);
            this.an.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.an.TabIndex = 9;
            this.an.TabStop = false;
            this.an.Click += new System.EventHandler(this.an_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::LeQuocHung_BlackMobile.Properties.Resources.ok;
            this.pictureBox1.Location = new System.Drawing.Point(237, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = global::LeQuocHung_BlackMobile.Properties.Resources.pexels_laproid_114900661;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(582, 603);
            this.Controls.Add(this.hien);
            this.Controls.Add(this.an);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btndn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtmk);
            this.Controls.Add(this.txttdn);
            this.Controls.Add(this.dgvdn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.an)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgvdn;
        private System.Windows.Forms.TextBox txttdn;
        private System.Windows.Forms.TextBox txtmk;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevComponents.DotNetBar.ButtonX btndn;
        private DevComponents.DotNetBar.ButtonX btnthoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tendangnhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matkhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quanly;
        private System.Windows.Forms.PictureBox an;
        private System.Windows.Forms.PictureBox hien;
    }
}