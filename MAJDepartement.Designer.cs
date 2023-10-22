namespace WindowsFormsApp2
{
    partial class MAJDepartement
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
            this.localisationLabel = new System.Windows.Forms.Label();
            this.nom_DepartementTextBox = new System.Windows.Forms.TextBox();
            this.localisationTextBox = new System.Windows.Forms.TextBox();
            this.notes_de_fraisDataSet = new WindowsFormsApp2.notes_de_fraisDataSet();
            this.departementsTableAdapter = new WindowsFormsApp2.notes_de_fraisDataSetTableAdapters.DepartementsTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp2.notes_de_fraisDataSetTableAdapters.TableAdapterManager();
            this.departementsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departementsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.nom_DepartementLabel = new System.Windows.Forms.Label();
            this.id_DepartementComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.notes_de_fraisDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departementsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departementsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // localisationLabel
            // 
            this.localisationLabel.AutoSize = true;
            this.localisationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.localisationLabel.Location = new System.Drawing.Point(50, 156);
            this.localisationLabel.Name = "localisationLabel";
            this.localisationLabel.Size = new System.Drawing.Size(127, 25);
            this.localisationLabel.TabIndex = 5;
            this.localisationLabel.Text = "localisation:";
            // 
            // nom_DepartementTextBox
            // 
            this.nom_DepartementTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom_DepartementTextBox.Location = new System.Drawing.Point(55, 117);
            this.nom_DepartementTextBox.Name = "nom_DepartementTextBox";
            this.nom_DepartementTextBox.Size = new System.Drawing.Size(411, 30);
            this.nom_DepartementTextBox.TabIndex = 4;
            // 
            // localisationTextBox
            // 
            this.localisationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.localisationTextBox.Location = new System.Drawing.Point(55, 184);
            this.localisationTextBox.Name = "localisationTextBox";
            this.localisationTextBox.Size = new System.Drawing.Size(415, 30);
            this.localisationTextBox.TabIndex = 6;
            this.localisationTextBox.TextChanged += new System.EventHandler(this.localisationTextBox_TextChanged);
            // 
            // notes_de_fraisDataSet
            // 
            this.notes_de_fraisDataSet.DataSetName = "notes_de_fraisDataSet";
            this.notes_de_fraisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departementsTableAdapter
            // 
            this.departementsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.authentificationTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DepartementsTableAdapter = this.departementsTableAdapter;
            this.tableAdapterManager.DépensesTableAdapter = null;
            this.tableAdapterManager.EmployersTableAdapter = null;
            this.tableAdapterManager.Memoire_fraisTableAdapter = null;
            this.tableAdapterManager.objetsTableAdapter = null;
            this.tableAdapterManager.Rapport_activitéTableAdapter = null;
            this.tableAdapterManager.statusTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp2.notes_de_fraisDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // departementsBindingSource
            // 
            this.departementsBindingSource.DataMember = "Departements";
            this.departementsBindingSource.DataSource = this.notes_de_fraisDataSet;
            // 
            // departementsDataGridView
            // 
            this.departementsDataGridView.AutoGenerateColumns = false;
            this.departementsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.departementsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.departementsDataGridView.DataSource = this.departementsBindingSource;
            this.departementsDataGridView.Location = new System.Drawing.Point(55, 238);
            this.departementsDataGridView.Name = "departementsDataGridView";
            this.departementsDataGridView.RowHeadersWidth = 51;
            this.departementsDataGridView.RowTemplate.Height = 24;
            this.departementsDataGridView.Size = new System.Drawing.Size(399, 220);
            this.departementsDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_Departement";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_Departement";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nom_Departement";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nom_Departement";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "localisation";
            this.dataGridViewTextBoxColumn3.HeaderText = "localisation";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(546, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 27);
            this.button1.TabIndex = 8;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(520, 273);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 39);
            this.button2.TabIndex = 9;
            this.button2.Text = "ajouter";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Crimson;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(520, 318);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 39);
            this.button3.TabIndex = 10;
            this.button3.Text = "modifier";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Crimson;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(520, 363);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(97, 39);
            this.button5.TabIndex = 12;
            this.button5.Text = "nouveaux";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // nom_DepartementLabel
            // 
            this.nom_DepartementLabel.AutoSize = true;
            this.nom_DepartementLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom_DepartementLabel.Location = new System.Drawing.Point(50, 89);
            this.nom_DepartementLabel.Name = "nom_DepartementLabel";
            this.nom_DepartementLabel.Size = new System.Drawing.Size(192, 25);
            this.nom_DepartementLabel.TabIndex = 3;
            this.nom_DepartementLabel.Text = "Nom Departement:";
            // 
            // id_DepartementComboBox
            // 
            this.id_DepartementComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.departementsBindingSource, "id_Departement", true));
            this.id_DepartementComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.departementsBindingSource, "id_Departement", true));
            this.id_DepartementComboBox.DataSource = this.departementsBindingSource;
            this.id_DepartementComboBox.DisplayMember = "id_Departement";
            this.id_DepartementComboBox.FormattingEnabled = true;
            this.id_DepartementComboBox.Location = new System.Drawing.Point(55, 62);
            this.id_DepartementComboBox.Name = "id_DepartementComboBox";
            this.id_DepartementComboBox.Size = new System.Drawing.Size(155, 24);
            this.id_DepartementComboBox.TabIndex = 13;
            this.id_DepartementComboBox.ValueMember = "id_Departement";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Id_Departement:";
            // 
            // MAJDepartement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 536);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.id_DepartementComboBox);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.departementsDataGridView);
            this.Controls.Add(this.nom_DepartementLabel);
            this.Controls.Add(this.nom_DepartementTextBox);
            this.Controls.Add(this.localisationLabel);
            this.Controls.Add(this.localisationTextBox);
            this.Name = "MAJDepartement";
            this.Text = "MAJDepartement";
            this.Load += new System.EventHandler(this.MAJDepartement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.notes_de_fraisDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departementsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departementsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox nom_DepartementTextBox;
        private System.Windows.Forms.TextBox localisationTextBox;
        private System.Windows.Forms.Label localisationLabel;
        private notes_de_fraisDataSet notes_de_fraisDataSet;
        private notes_de_fraisDataSetTableAdapters.DepartementsTableAdapter departementsTableAdapter;
        private notes_de_fraisDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource departementsBindingSource;
        private System.Windows.Forms.DataGridView departementsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label nom_DepartementLabel;
        private System.Windows.Forms.ComboBox id_DepartementComboBox;
        private System.Windows.Forms.Label label1;
    }
}