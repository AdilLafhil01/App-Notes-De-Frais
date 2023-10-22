namespace WindowsFormsApp2
{
    partial class RaportOrderMission
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
            this.notes_de_fraisDataSet = new WindowsFormsApp2.notes_de_fraisDataSet();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1TableAdapter = new WindowsFormsApp2.notes_de_fraisDataSetTableAdapters.DataTable1TableAdapter();
            this.tableAdapterManager = new WindowsFormsApp2.notes_de_fraisDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.notes_de_fraisDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp2.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1249, 660);
            this.reportViewer1.TabIndex = 0;
            // 
            // notes_de_fraisDataSet
            // 
            this.notes_de_fraisDataSet.DataSetName = "notes_de_fraisDataSet";
            this.notes_de_fraisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.notes_de_fraisDataSet;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.authentificationTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DepartementsTableAdapter = null;
            this.tableAdapterManager.DépensesTableAdapter = null;
            this.tableAdapterManager.EmployersTableAdapter = null;
            this.tableAdapterManager.Memoire_fraisTableAdapter = null;
            this.tableAdapterManager.objetsTableAdapter = null;
            this.tableAdapterManager.Rapport_activitéTableAdapter = null;
            this.tableAdapterManager.statusTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp2.notes_de_fraisDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // RaportOrderMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 660);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RaportOrderMission";
            this.Text = "RaportOrderMission";
            this.Load += new System.EventHandler(this.RaportOrderMission_Load);
            ((System.ComponentModel.ISupportInitialize)(this.notes_de_fraisDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private notes_de_fraisDataSet notes_de_fraisDataSet;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private notes_de_fraisDataSetTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private notes_de_fraisDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}