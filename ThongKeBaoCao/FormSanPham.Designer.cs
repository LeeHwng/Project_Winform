
namespace LeQuocHung_BlackMobile.ThongKeBaoCao
{
    partial class FormSanPham
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
            this.SanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DtsSanPham = new LeQuocHung_BlackMobile.ThongKeBaoCao.DtsSanPham();
            this.SanPhamKhongBanDuocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SanPhamTableAdapter = new LeQuocHung_BlackMobile.ThongKeBaoCao.DtsSanPhamTableAdapters.SanPhamTableAdapter();
            this.SanPhamKhongBanDuocTableAdapter = new LeQuocHung_BlackMobile.ThongKeBaoCao.DtsSanPhamTableAdapters.SanPhamKhongBanDuocTableAdapter();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.SanPhamDaBanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SanPhamDaBanTableAdapter = new LeQuocHung_BlackMobile.ThongKeBaoCao.DtsSanPhamTableAdapters.SanPhamDaBanTableAdapter();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SanPhamTonKhoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SanPhamTonKhoTableAdapter = new LeQuocHung_BlackMobile.ThongKeBaoCao.DtsSanPhamTableAdapters.SanPhamTonKhoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SanPhamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtsSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SanPhamKhongBanDuocBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SanPhamDaBanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SanPhamTonKhoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SanPhamBindingSource
            // 
            this.SanPhamBindingSource.DataMember = "SanPham";
            this.SanPhamBindingSource.DataSource = this.DtsSanPham;
            // 
            // DtsSanPham
            // 
            this.DtsSanPham.DataSetName = "DtsSanPham";
            this.DtsSanPham.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SanPhamKhongBanDuocBindingSource
            // 
            this.SanPhamKhongBanDuocBindingSource.DataMember = "SanPhamKhongBanDuoc";
            this.SanPhamKhongBanDuocBindingSource.DataSource = this.DtsSanPham;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.reportViewer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thống Kê Sản Phẩm Đã Nhập";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SanPhamBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "LeQuocHung_BlackMobile.ThongKeBaoCao.RpSanPhamDaNhap.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(786, 415);
            this.reportViewer1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.reportViewer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thống Kê Sản Phẩm Đã Bán ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.SanPhamDaBanBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "LeQuocHung_BlackMobile.ThongKeBaoCao.RpSPDaBan.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(3, 3);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(786, 415);
            this.reportViewer2.TabIndex = 0;
            // 
            // SanPhamTableAdapter
            // 
            this.SanPhamTableAdapter.ClearBeforeFill = true;
            // 
            // SanPhamKhongBanDuocTableAdapter
            // 
            this.SanPhamKhongBanDuocTableAdapter.ClearBeforeFill = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.reportViewer3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(792, 421);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Thống Kê Sản Phẩm Tồn Kho ";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // SanPhamDaBanBindingSource
            // 
            this.SanPhamDaBanBindingSource.DataMember = "SanPhamDaBan";
            this.SanPhamDaBanBindingSource.DataSource = this.DtsSanPham;
            // 
            // SanPhamDaBanTableAdapter
            // 
            this.SanPhamDaBanTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer3
            // 
            this.reportViewer3.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.SanPhamTonKhoBindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "LeQuocHung_BlackMobile.ThongKeBaoCao.RpSPTonKho.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(0, 0);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.ServerReport.BearerToken = null;
            this.reportViewer3.Size = new System.Drawing.Size(792, 421);
            this.reportViewer3.TabIndex = 0;
            // 
            // SanPhamTonKhoBindingSource
            // 
            this.SanPhamTonKhoBindingSource.DataMember = "SanPhamTonKho";
            this.SanPhamTonKhoBindingSource.DataSource = this.DtsSanPham;
            // 
            // SanPhamTonKhoTableAdapter
            // 
            this.SanPhamTonKhoTableAdapter.ClearBeforeFill = true;
            // 
            // FormSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormSanPham";
            this.Text = "FormSanPham";
            this.Load += new System.EventHandler(this.FormSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SanPhamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtsSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SanPhamKhongBanDuocBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SanPhamDaBanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SanPhamTonKhoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource SanPhamBindingSource;
        private DtsSanPham DtsSanPham;
        private DtsSanPhamTableAdapters.SanPhamTableAdapter SanPhamTableAdapter;
        private System.Windows.Forms.BindingSource SanPhamKhongBanDuocBindingSource;
        private DtsSanPhamTableAdapters.SanPhamKhongBanDuocTableAdapter SanPhamKhongBanDuocTableAdapter;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.BindingSource SanPhamDaBanBindingSource;
        private DtsSanPhamTableAdapters.SanPhamDaBanTableAdapter SanPhamDaBanTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private System.Windows.Forms.BindingSource SanPhamTonKhoBindingSource;
        private DtsSanPhamTableAdapters.SanPhamTonKhoTableAdapter SanPhamTonKhoTableAdapter;
    }
}