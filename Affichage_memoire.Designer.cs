namespace WindowsFormsApp2
{
    partial class Affichage_memoire
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
            this.memoirefraisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notes_de_fraisDataSet = new WindowsFormsApp2.notes_de_fraisDataSet();
            this.memoire_fraisTableAdapter = new WindowsFormsApp2.notes_de_fraisDataSetTableAdapters.Memoire_fraisTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp2.notes_de_fraisDataSetTableAdapters.TableAdapterManager();
            this.memoire_fraisDataGridView = new System.Windows.Forms.DataGridView();
            this.notes_de_fraisDataSet1 = new WindowsFormsApp2.notes_de_fraisDataSet1();
            this.memoirefraisBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.memoire_fraisTableAdapter1 = new WindowsFormsApp2.notes_de_fraisDataSet1TableAdapters.Memoire_fraisTableAdapter();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carburantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contrôleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matriculeemployerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datedepartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datearriverDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lieudeplacementDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idintervenantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.memoirefraisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notes_de_fraisDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoire_fraisDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notes_de_fraisDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoirefraisBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // memoirefraisBindingSource
            // 
            this.memoirefraisBindingSource.DataMember = "Memoire_frais";
            this.memoirefraisBindingSource.DataSource = this.notes_de_fraisDataSet;
            // 
            // notes_de_fraisDataSet
            // 
            this.notes_de_fraisDataSet.DataSetName = "notes_de_fraisDataSet";
            this.notes_de_fraisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // memoire_fraisTableAdapter
            // 
            this.memoire_fraisTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.authentificationTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DepartementsTableAdapter = null;
            this.tableAdapterManager.DépensesTableAdapter = null;
            this.tableAdapterManager.EmployersTableAdapter = null;
            this.tableAdapterManager.Memoire_fraisTableAdapter = this.memoire_fraisTableAdapter;
            this.tableAdapterManager.objetsTableAdapter = null;
            this.tableAdapterManager.statusTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp2.notes_de_fraisDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // memoire_fraisDataGridView
            // 
            this.memoire_fraisDataGridView.AllowUserToAddRows = false;
            this.memoire_fraisDataGridView.AllowUserToDeleteRows = false;
            this.memoire_fraisDataGridView.AutoGenerateColumns = false;
            this.memoire_fraisDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.memoire_fraisDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.discriptionDataGridViewTextBoxColumn,
            this.hotelDataGridViewTextBoxColumn,
            this.transportDataGridViewTextBoxColumn,
            this.carburantDataGridViewTextBoxColumn,
            this.repasDataGridViewTextBoxColumn,
            this.autresDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.contrôleDataGridViewTextBoxColumn,
            this.matriculeemployerDataGridViewTextBoxColumn,
            this.datedepartDataGridViewTextBoxColumn,
            this.datearriverDataGridViewTextBoxColumn,
            this.lieudeplacementDataGridViewTextBoxColumn,
            this.objetDataGridViewTextBoxColumn,
            this.idintervenantDataGridViewTextBoxColumn});
            this.memoire_fraisDataGridView.DataSource = this.memoirefraisBindingSource1;
            this.memoire_fraisDataGridView.Location = new System.Drawing.Point(24, 52);
            this.memoire_fraisDataGridView.Name = "memoire_fraisDataGridView";
            this.memoire_fraisDataGridView.ReadOnly = true;
            this.memoire_fraisDataGridView.RowHeadersWidth = 51;
            this.memoire_fraisDataGridView.RowTemplate.Height = 24;
            this.memoire_fraisDataGridView.Size = new System.Drawing.Size(1182, 408);
            this.memoire_fraisDataGridView.TabIndex = 0;
            // 
            // notes_de_fraisDataSet1
            // 
            this.notes_de_fraisDataSet1.DataSetName = "notes_de_fraisDataSet1";
            this.notes_de_fraisDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // memoirefraisBindingSource1
            // 
            this.memoirefraisBindingSource1.DataMember = "Memoire_frais";
            this.memoirefraisBindingSource1.DataSource = this.notes_de_fraisDataSet1;
            // 
            // memoire_fraisTableAdapter1
            // 
            this.memoire_fraisTableAdapter1.ClearBeforeFill = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // discriptionDataGridViewTextBoxColumn
            // 
            this.discriptionDataGridViewTextBoxColumn.DataPropertyName = "Discription";
            this.discriptionDataGridViewTextBoxColumn.HeaderText = "Discription";
            this.discriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.discriptionDataGridViewTextBoxColumn.Name = "discriptionDataGridViewTextBoxColumn";
            this.discriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.discriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // hotelDataGridViewTextBoxColumn
            // 
            this.hotelDataGridViewTextBoxColumn.DataPropertyName = "Hotel";
            this.hotelDataGridViewTextBoxColumn.HeaderText = "Hotel";
            this.hotelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hotelDataGridViewTextBoxColumn.Name = "hotelDataGridViewTextBoxColumn";
            this.hotelDataGridViewTextBoxColumn.ReadOnly = true;
            this.hotelDataGridViewTextBoxColumn.Width = 125;
            // 
            // transportDataGridViewTextBoxColumn
            // 
            this.transportDataGridViewTextBoxColumn.DataPropertyName = "Transport";
            this.transportDataGridViewTextBoxColumn.HeaderText = "Transport";
            this.transportDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.transportDataGridViewTextBoxColumn.Name = "transportDataGridViewTextBoxColumn";
            this.transportDataGridViewTextBoxColumn.ReadOnly = true;
            this.transportDataGridViewTextBoxColumn.Width = 125;
            // 
            // carburantDataGridViewTextBoxColumn
            // 
            this.carburantDataGridViewTextBoxColumn.DataPropertyName = "Carburant";
            this.carburantDataGridViewTextBoxColumn.HeaderText = "Carburant";
            this.carburantDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.carburantDataGridViewTextBoxColumn.Name = "carburantDataGridViewTextBoxColumn";
            this.carburantDataGridViewTextBoxColumn.ReadOnly = true;
            this.carburantDataGridViewTextBoxColumn.Width = 125;
            // 
            // repasDataGridViewTextBoxColumn
            // 
            this.repasDataGridViewTextBoxColumn.DataPropertyName = "Repas";
            this.repasDataGridViewTextBoxColumn.HeaderText = "Repas";
            this.repasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.repasDataGridViewTextBoxColumn.Name = "repasDataGridViewTextBoxColumn";
            this.repasDataGridViewTextBoxColumn.ReadOnly = true;
            this.repasDataGridViewTextBoxColumn.Width = 125;
            // 
            // autresDataGridViewTextBoxColumn
            // 
            this.autresDataGridViewTextBoxColumn.DataPropertyName = "Autres";
            this.autresDataGridViewTextBoxColumn.HeaderText = "Autres";
            this.autresDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.autresDataGridViewTextBoxColumn.Name = "autresDataGridViewTextBoxColumn";
            this.autresDataGridViewTextBoxColumn.ReadOnly = true;
            this.autresDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalDataGridViewTextBoxColumn.Width = 125;
            // 
            // contrôleDataGridViewTextBoxColumn
            // 
            this.contrôleDataGridViewTextBoxColumn.DataPropertyName = "Contrôle";
            this.contrôleDataGridViewTextBoxColumn.HeaderText = "Contrôle";
            this.contrôleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contrôleDataGridViewTextBoxColumn.Name = "contrôleDataGridViewTextBoxColumn";
            this.contrôleDataGridViewTextBoxColumn.ReadOnly = true;
            this.contrôleDataGridViewTextBoxColumn.Width = 125;
            // 
            // matriculeemployerDataGridViewTextBoxColumn
            // 
            this.matriculeemployerDataGridViewTextBoxColumn.DataPropertyName = "matricule_employer";
            this.matriculeemployerDataGridViewTextBoxColumn.HeaderText = "matricule_employer";
            this.matriculeemployerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.matriculeemployerDataGridViewTextBoxColumn.Name = "matriculeemployerDataGridViewTextBoxColumn";
            this.matriculeemployerDataGridViewTextBoxColumn.ReadOnly = true;
            this.matriculeemployerDataGridViewTextBoxColumn.Width = 125;
            // 
            // datedepartDataGridViewTextBoxColumn
            // 
            this.datedepartDataGridViewTextBoxColumn.DataPropertyName = "date_depart";
            this.datedepartDataGridViewTextBoxColumn.HeaderText = "date_depart";
            this.datedepartDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datedepartDataGridViewTextBoxColumn.Name = "datedepartDataGridViewTextBoxColumn";
            this.datedepartDataGridViewTextBoxColumn.ReadOnly = true;
            this.datedepartDataGridViewTextBoxColumn.Width = 125;
            // 
            // datearriverDataGridViewTextBoxColumn
            // 
            this.datearriverDataGridViewTextBoxColumn.DataPropertyName = "date_arriver";
            this.datearriverDataGridViewTextBoxColumn.HeaderText = "date_arriver";
            this.datearriverDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datearriverDataGridViewTextBoxColumn.Name = "datearriverDataGridViewTextBoxColumn";
            this.datearriverDataGridViewTextBoxColumn.ReadOnly = true;
            this.datearriverDataGridViewTextBoxColumn.Width = 125;
            // 
            // lieudeplacementDataGridViewTextBoxColumn
            // 
            this.lieudeplacementDataGridViewTextBoxColumn.DataPropertyName = "lieu_deplacement";
            this.lieudeplacementDataGridViewTextBoxColumn.HeaderText = "lieu_deplacement";
            this.lieudeplacementDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lieudeplacementDataGridViewTextBoxColumn.Name = "lieudeplacementDataGridViewTextBoxColumn";
            this.lieudeplacementDataGridViewTextBoxColumn.ReadOnly = true;
            this.lieudeplacementDataGridViewTextBoxColumn.Width = 125;
            // 
            // objetDataGridViewTextBoxColumn
            // 
            this.objetDataGridViewTextBoxColumn.DataPropertyName = "objet";
            this.objetDataGridViewTextBoxColumn.HeaderText = "objet";
            this.objetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.objetDataGridViewTextBoxColumn.Name = "objetDataGridViewTextBoxColumn";
            this.objetDataGridViewTextBoxColumn.ReadOnly = true;
            this.objetDataGridViewTextBoxColumn.Width = 125;
            // 
            // idintervenantDataGridViewTextBoxColumn
            // 
            this.idintervenantDataGridViewTextBoxColumn.DataPropertyName = "id_intervenant";
            this.idintervenantDataGridViewTextBoxColumn.HeaderText = "id_intervenant";
            this.idintervenantDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idintervenantDataGridViewTextBoxColumn.Name = "idintervenantDataGridViewTextBoxColumn";
            this.idintervenantDataGridViewTextBoxColumn.ReadOnly = true;
            this.idintervenantDataGridViewTextBoxColumn.Width = 125;
            // 
            // Affichage_memoire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 721);
            this.Controls.Add(this.memoire_fraisDataGridView);
            this.Name = "Affichage_memoire";
            this.Text = "Affichage_memoire";
            this.Load += new System.EventHandler(this.Affichage_memoire_Load);
            ((System.ComponentModel.ISupportInitialize)(this.memoirefraisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notes_de_fraisDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoire_fraisDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notes_de_fraisDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoirefraisBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private notes_de_fraisDataSet notes_de_fraisDataSet;
        private System.Windows.Forms.BindingSource memoirefraisBindingSource;
        private notes_de_fraisDataSetTableAdapters.Memoire_fraisTableAdapter memoire_fraisTableAdapter;
        private notes_de_fraisDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView memoire_fraisDataGridView;
        private notes_de_fraisDataSet1 notes_de_fraisDataSet1;
        private System.Windows.Forms.BindingSource memoirefraisBindingSource1;
        private notes_de_fraisDataSet1TableAdapters.Memoire_fraisTableAdapter memoire_fraisTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carburantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn repasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contrôleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matriculeemployerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datedepartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datearriverDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lieudeplacementDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn objetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idintervenantDataGridViewTextBoxColumn;
    }
}