
namespace LeQuocHung_BlackMobile.ThongKeBaoCao
{
    partial class FormNhanVien
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.reportViewer6 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.reportViewer4 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.reportViewer5 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SoHDDaLapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NhanVien = new LeQuocHung_BlackMobile.ThongKeBaoCao.NhanVien();
            this.SoHDDaLapTableAdapter = new LeQuocHung_BlackMobile.ThongKeBaoCao.NhanVienTableAdapters.SoHDDaLapTableAdapter();
            this.NhanVienLapNhieuHDNhatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NhanVienLapNhieuHDNhatTableAdapter = new LeQuocHung_BlackMobile.ThongKeBaoCao.NhanVienTableAdapters.NhanVienLapNhieuHDNhatTableAdapter();
            this.NhanVienLapItHDNhatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NhanVienLapItHDNhatTableAdapter = new LeQuocHung_BlackMobile.ThongKeBaoCao.NhanVienTableAdapters.NhanVienLapItHDNhatTableAdapter();
            this.NhanVienDTCaoNhatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NhanVienDTCaoNhatTableAdapter = new LeQuocHung_BlackMobile.ThongKeBaoCao.NhanVienTableAdapters.NhanVienDTCaoNhatTableAdapter();
            this.NhanVienDTThapNhatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NhanVienDTThapNhatTableAdapter = new LeQuocHung_BlackMobile.ThongKeBaoCao.NhanVienTableAdapters.NhanVienDTThapNhatTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SoHDDaLapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NhanVienLapNhieuHDNhatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NhanVienLapItHDNhatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NhanVienDTCaoNhatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NhanVienDTThapNhatBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(912, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.reportViewer6);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(904, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Số Hóa Đơn Đã Lập";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // reportViewer6
            // 
            this.reportViewer6.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SoHDDaLapBindingSource;
            this.reportViewer6.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer6.LocalReport.ReportEmbeddedResource = "LeQuocHung_BlackMobile.ThongKeBaoCao.HDDaLap.rdlc";
            this.reportViewer6.Location = new System.Drawing.Point(3, 3);
            this.reportViewer6.Name = "reportViewer6";
            this.reportViewer6.ServerReport.BearerToken = null;
            this.reportViewer6.Size = new System.Drawing.Size(898, 418);
            this.reportViewer6.TabIndex = 0;
            this.reportViewer6.Load += new System.EventHandler(this.reportViewer6_Load);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.reportViewer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(904, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Nhân Viên Lập Nhiều Hóa Đơn Nhất";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.NhanVienLapNhieuHDNhatBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "LeQuocHung_BlackMobile.ThongKeBaoCao.NVLNhieuHDNhat.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(3, 3);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(898, 418);
            this.reportViewer2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.reportViewer4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(904, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Nhân Viên Lập Ít Hóa Đơn Nhất";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // reportViewer4
            // 
            this.reportViewer4.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.NhanVienLapItHDNhatBindingSource;
            this.reportViewer4.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer4.LocalReport.ReportEmbeddedResource = "LeQuocHung_BlackMobile.ThongKeBaoCao.NVLItHDNhat.rdlc";
            this.reportViewer4.Location = new System.Drawing.Point(0, 0);
            this.reportViewer4.Name = "reportViewer4";
            this.reportViewer4.ServerReport.BearerToken = null;
            this.reportViewer4.Size = new System.Drawing.Size(904, 424);
            this.reportViewer4.TabIndex = 1;
            this.reportViewer4.Load += new System.EventHandler(this.reportViewer4_Load);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.reportViewer1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(904, 424);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Nhân Viên Đem Lại Doanh Thu Cao Nhất";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource4.Name = "DataSet1";
            reportDataSource4.Value = this.NhanVienDTCaoNhatBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "LeQuocHung_BlackMobile.ThongKeBaoCao.NV_DT_CaoNhat.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(904, 424);
            this.reportViewer1.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.reportViewer5);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(904, 424);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Nhân Viên Đem Lại Doanh Thu Thấp Nhất";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // reportViewer5
            // 
            this.reportViewer5.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource5.Name = "DataSet1";
            reportDataSource5.Value = this.NhanVienDTThapNhatBindingSource;
            this.reportViewer5.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer5.LocalReport.ReportEmbeddedResource = "LeQuocHung_BlackMobile.ThongKeBaoCao.NV_DT_ThapNhat.rdlc";
            this.reportViewer5.Location = new System.Drawing.Point(0, 0);
            this.reportViewer5.Name = "reportViewer5";
            this.reportViewer5.ServerReport.BearerToken = null;
            this.reportViewer5.Size = new System.Drawing.Size(904, 424);
            this.reportViewer5.TabIndex = 0;
            // 
            // SoHDDaLapBindingSource
            // 
            this.SoHDDaLapBindingSource.DataMember = "SoHDDaLap";
            this.SoHDDaLapBindingSource.DataSource = this.NhanVien;
            // 
            // NhanVien
            // 
            this.NhanVien.DataSetName = "NhanVien";
            this.NhanVien.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SoHDDaLapTableAdapter
            // 
            this.SoHDDaLapTableAdapter.ClearBeforeFill = true;
            // 
            // NhanVienLapNhieuHDNhatBindingSource
            // 
            this.NhanVienLapNhieuHDNhatBindingSource.DataMember = "NhanVienLapNhieuHDNhat";
            this.NhanVienLapNhieuHDNhatBindingSource.DataSource = this.NhanVien;
            // 
            // NhanVienLapNhieuHDNhatTableAdapter
            // 
            this.NhanVienLapNhieuHDNhatTableAdapter.ClearBeforeFill = true;
            // 
            // NhanVienLapItHDNhatBindingSource
            // 
            this.NhanVienLapItHDNhatBindingSource.DataMember = "NhanVienLapItHDNhat";
            this.NhanVienLapItHDNhatBindingSource.DataSource = this.NhanVien;
            // 
            // NhanVienLapItHDNhatTableAdapter
            // 
            this.NhanVienLapItHDNhatTableAdapter.ClearBeforeFill = true;
            // 
            // NhanVienDTCaoNhatBindingSource
            // 
            this.NhanVienDTCaoNhatBindingSource.DataMember = "NhanVienDTCaoNhat";
            this.NhanVienDTCaoNhatBindingSource.DataSource = this.NhanVien;
            // 
            // NhanVienDTCaoNhatTableAdapter
            // 
            this.NhanVienDTCaoNhatTableAdapter.ClearBeforeFill = true;
            // 
            // NhanVienDTThapNhatBindingSource
            // 
            this.NhanVienDTThapNhatBindingSource.DataMember = "NhanVienDTThapNhat";
            this.NhanVienDTThapNhatBindingSource.DataSource = this.NhanVien;
            // 
            // NhanVienDTThapNhatTableAdapter
            // 
            this.NhanVienDTThapNhatTableAdapter.ClearBeforeFill = true;
            // 
            // FormNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormNhanVien";
            this.Text = "FormNhanVien";
            this.Load += new System.EventHandler(this.FormNhanVien_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SoHDDaLapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NhanVienLapNhieuHDNhatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NhanVienLapItHDNhatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NhanVienDTCaoNhatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NhanVienDTThapNhatBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.TabPage tabPage5;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer4;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer5;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer6;
        private System.Windows.Forms.BindingSource SoHDDaLapBindingSource;
        private NhanVien NhanVien;
        private NhanVienTableAdapters.SoHDDaLapTableAdapter SoHDDaLapTableAdapter;
        private System.Windows.Forms.BindingSource NhanVienLapNhieuHDNhatBindingSource;
        private NhanVienTableAdapters.NhanVienLapNhieuHDNhatTableAdapter NhanVienLapNhieuHDNhatTableAdapter;
        private System.Windows.Forms.BindingSource NhanVienLapItHDNhatBindingSource;
        private NhanVienTableAdapters.NhanVienLapItHDNhatTableAdapter NhanVienLapItHDNhatTableAdapter;
        private System.Windows.Forms.BindingSource NhanVienDTCaoNhatBindingSource;
        private NhanVienTableAdapters.NhanVienDTCaoNhatTableAdapter NhanVienDTCaoNhatTableAdapter;
        private System.Windows.Forms.BindingSource NhanVienDTThapNhatBindingSource;
        private NhanVienTableAdapters.NhanVienDTThapNhatTableAdapter NhanVienDTThapNhatTableAdapter;
    }
}