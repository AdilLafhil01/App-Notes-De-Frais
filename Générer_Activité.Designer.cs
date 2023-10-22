namespace WindowsFormsApp2
{
    partial class Générer_Activité
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
            System.Windows.Forms.Label matricule_employerLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Générer_Activité));
            this.notes_de_fraisDataSet1 = new WindowsFormsApp2.notes_de_fraisDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tableAdapterManager1 = new WindowsFormsApp2.notes_de_fraisDataSetTableAdapters.TableAdapterManager();
            this.matricule_employerComboBox = new System.Windows.Forms.ComboBox();
            this.order_missionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            matricule_employerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.notes_de_fraisDataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.order_missionBindingSource1)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // matricule_employerLabel
            // 
            matricule_employerLabel.AutoSize = true;
            matricule_employerLabel.Location = new System.Drawing.Point(323, 59);
            matricule_employerLabel.Name = "matricule_employerLabel";
            matricule_employerLabel.Size = new System.Drawing.Size(124, 16);
            matricule_employerLabel.TabIndex = 5;
            matricule_employerLabel.Text = "matricule employer:";
            // 
            // notes_de_fraisDataSet1
            // 
            this.notes_de_fraisDataSet1.DataSetName = "notes_de_fraisDataSet";
            this.notes_de_fraisDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Location = new System.Drawing.Point(113, 126);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1049, 505);
            this.panel1.TabIndex = 1;
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.EnableExternalImages = true;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp2.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1043, 499);
            this.reportViewer1.TabIndex = 0;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.authentificationTableAdapter = null;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.DepartementsTableAdapter = null;
            this.tableAdapterManager1.DépensesTableAdapter = null;
            this.tableAdapterManager1.EmployersTableAdapter = null;
            this.tableAdapterManager1.Memoire_fraisTableAdapter = null;
            this.tableAdapterManager1.objetsTableAdapter = null;
            this.tableAdapterManager1.statusTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = WindowsFormsApp2.notes_de_fraisDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // matricule_employerComboBox
            // 
            this.matricule_employerComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.order_missionBindingSource1, "matricule_employer", true));
            this.matricule_employerComboBox.DataSource = this.order_missionBindingSource1;
            this.matricule_employerComboBox.DisplayMember = "matricule_employer";
            this.matricule_employerComboBox.FormattingEnabled = true;
            this.matricule_employerComboBox.Location = new System.Drawing.Point(499, 56);
            this.matricule_employerComboBox.Name = "matricule_employerComboBox";
            this.matricule_employerComboBox.Size = new System.Drawing.Size(299, 24);
            this.matricule_employerComboBox.TabIndex = 6;
            this.matricule_employerComboBox.ValueMember = "matricule_employer";
            this.matricule_employerComboBox.SelectedIndexChanged += new System.EventHandler(this.matricule_employerComboBox_SelectedIndexChanged);
            // 
            // order_missionBindingSource1
            // 
            this.order_missionBindingSource1.DataMember = "Order_mission";
            this.order_missionBindingSource1.DataSource = this.notes_de_fraisDataSet1;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton,
            this.toolStripButton1});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(1322, 27);
            this.fillByToolStrip.TabIndex = 7;
            this.fillByToolStrip.Text = "fillByToolStrip";
            this.fillByToolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.fillByToolStrip_ItemClicked);
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(48, 24);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // Générer_Activité
            // 
            this.ClientSize = new System.Drawing.Size(1322, 837);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(matricule_employerLabel);
            this.Controls.Add(this.matricule_employerComboBox);
            this.Controls.Add(this.panel1);
            this.Name = "Générer_Activité";
            this.Load += new System.EventHandler(this.ordreMission_Load_3);
            ((System.ComponentModel.ISupportInitialize)(this.notes_de_fraisDataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.order_missionBindingSource1)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        //private System.Windows.Forms.Button btn_Importer;
        //private notes_de_fraisDataSet notes_de_fraisDataSet;
        //private System.Windows.Forms.BindingSource order_missionBindingSource;
        //private notes_de_fraisDataSetTableAdapters.Order_missionTableAdapter order_missionTableAdapter;
        private notes_de_fraisDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panel1;
        private notes_de_fraisDataSet notes_de_fraisDataSet1;
        private notes_de_fraisDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.ComboBox matricule_employerComboBox;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource order_missionBindingSource1;
        //private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        //private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        // private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}