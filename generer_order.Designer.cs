namespace WindowsFormsApp2
{
    partial class generer_order
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.notes_de_fraisDataSet1 = new WindowsFormsApp2.notes_de_fraisDataSet();
            this.order_missionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.notes_de_fraisDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_missionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.EnableExternalImages = true;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp2.Report.rdlc";
            this.reportViewer1.LocalReport.ReportPath = "Report.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(30, 24);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.ServerReport.ReportPath = "Report.rdlc";
            this.reportViewer1.Size = new System.Drawing.Size(1054, 542);
            this.reportViewer1.TabIndex = 0;
            // 
            // notes_de_fraisDataSet1
            // 
            this.notes_de_fraisDataSet1.DataSetName = "notes_de_fraisDataSet";
            this.notes_de_fraisDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // order_missionBindingSource
            // 
            this.order_missionBindingSource.DataMember = "Order_mission";
            this.order_missionBindingSource.DataSource = this.notes_de_fraisDataSet1;
            // 
            // generer_order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 724);
            this.Controls.Add(this.reportViewer1);
            this.Name = "generer_order";
            this.Text = "generer_order";
            this.Load += new System.EventHandler(this.generer_order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.notes_de_fraisDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_missionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private notes_de_fraisDataSet notes_de_fraisDataSet1;
        private System.Windows.Forms.BindingSource order_missionBindingSource;
    }
}