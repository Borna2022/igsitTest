﻿namespace igsit
{
    partial class ReportForm1
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.igsitDBTestDataSet1 = new igsit.igsitDBTestDataSet1();
            this.tPersonsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_PersonsTableAdapter = new igsit.igsitDBTestDataSet1TableAdapters.T_PersonsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.igsitDBTestDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPersonsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tPersonsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "igsit.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // igsitDBTestDataSet1
            // 
            this.igsitDBTestDataSet1.DataSetName = "igsitDBTestDataSet1";
            this.igsitDBTestDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tPersonsBindingSource
            // 
            this.tPersonsBindingSource.DataMember = "T_Persons";
            this.tPersonsBindingSource.DataSource = this.igsitDBTestDataSet1;
            // 
            // t_PersonsTableAdapter
            // 
            this.t_PersonsTableAdapter.ClearBeforeFill = true;
            // 
            // ReportForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportForm1";
            this.Text = "ReportForm1";
            this.Load += new System.EventHandler(this.ReportForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.igsitDBTestDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPersonsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private igsitDBTestDataSet1 igsitDBTestDataSet1;
        private System.Windows.Forms.BindingSource tPersonsBindingSource;
        private igsitDBTestDataSet1TableAdapters.T_PersonsTableAdapter t_PersonsTableAdapter;
    }
}