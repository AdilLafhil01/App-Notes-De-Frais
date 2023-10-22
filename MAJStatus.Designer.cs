namespace WindowsFormsApp2
{
    partial class MAJStatus
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label id_statutLabel;
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.notes_de_fraisDataSet = new WindowsFormsApp2.notes_de_fraisDataSet();
            this.statusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusTableAdapter = new WindowsFormsApp2.notes_de_fraisDataSetTableAdapters.statusTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp2.notes_de_fraisDataSetTableAdapters.TableAdapterManager();
            this.statusDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.id_statutComboBox = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            id_statutLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.notes_de_fraisDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(32, 88);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(127, 25);
            label1.TabIndex = 16;
            label1.Text = "Description:";
            // 
            // id_statutLabel
            // 
            id_statutLabel.AutoSize = true;
            id_statutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_statutLabel.Location = new System.Drawing.Point(33, 24);
            id_statutLabel.Name = "id_statutLabel";
            id_statutLabel.Size = new System.Drawing.Size(96, 25);
            id_statutLabel.TabIndex = 14;
            id_statutLabel.Text = "Id statut:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(37, 116);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(305, 31);
            this.descriptionTextBox.TabIndex = 4;
            // 
            // notes_de_fraisDataSet
            // 
            this.notes_de_fraisDataSet.DataSetName = "notes_de_fraisDataSet";
            this.notes_de_fraisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statusBindingSource
            // 
            this.statusBindingSource.DataMember = "status";
            this.statusBindingSource.DataSource = this.notes_de_fraisDataSet;
            // 
            // statusTableAdapter
            // 
            this.statusTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.authentificationTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DepartementsTableAdapter = null;
            this.tableAdapterManager.DépensesTableAdapter = null;
            this.tableAdapterManager.EmployersTableAdapter = null;
            this.tableAdapterManager.Memoire_fraisTableAdapter = null;
            this.tableAdapterManager.objetsTableAdapter = null;
            this.tableAdapterManager.Rapport_activitéTableAdapter = null;
            this.tableAdapterManager.statusTableAdapter = this.statusTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp2.notes_de_fraisDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // statusDataGridView
            // 
            this.statusDataGridView.AutoGenerateColumns = false;
            this.statusDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.statusDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.statusDataGridView.DataSource = this.statusBindingSource;
            this.statusDataGridView.Location = new System.Drawing.Point(37, 167);
            this.statusDataGridView.Name = "statusDataGridView";
            this.statusDataGridView.RowHeadersWidth = 51;
            this.statusDataGridView.RowTemplate.Height = 24;
            this.statusDataGridView.Size = new System.Drawing.Size(292, 220);
            this.statusDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_statut";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_statut";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn2.HeaderText = "Description";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(456, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 27);
            this.button1.TabIndex = 6;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(379, 193);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 39);
            this.button2.TabIndex = 7;
            this.button2.Text = "ajouter";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Crimson;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(379, 238);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 39);
            this.button3.TabIndex = 8;
            this.button3.Text = "modifier";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Crimson;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(379, 328);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(107, 39);
            this.button5.TabIndex = 10;
            this.button5.Text = "nouveaux";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // id_statutComboBox
            // 
            this.id_statutComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statusBindingSource, "id_statut", true));
            this.id_statutComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.statusBindingSource, "id_statut", true));
            this.id_statutComboBox.DataSource = this.statusBindingSource;
            this.id_statutComboBox.DisplayMember = "id_statut";
            this.id_statutComboBox.FormattingEnabled = true;
            this.id_statutComboBox.Location = new System.Drawing.Point(38, 52);
            this.id_statutComboBox.Name = "id_statutComboBox";
            this.id_statutComboBox.Size = new System.Drawing.Size(82, 24);
            this.id_statutComboBox.TabIndex = 15;
            this.id_statutComboBox.ValueMember = "id_statut";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Crimson;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(379, 283);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 39);
            this.button4.TabIndex = 9;
            this.button4.Text = "supprimer";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // MAJStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 453);
            this.ControlBox = false;
            this.Controls.Add(label1);
            this.Controls.Add(id_statutLabel);
            this.Controls.Add(this.id_statutComboBox);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.statusDataGridView);
            this.Controls.Add(this.descriptionTextBox);
            this.Name = "MAJStatus";
            this.Text = "MAJStatus";
            this.Load += new System.EventHandler(this.MAJStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.notes_de_fraisDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox descriptionTextBox;
        private notes_de_fraisDataSet notes_de_fraisDataSet;
        private System.Windows.Forms.BindingSource statusBindingSource;
        private notes_de_fraisDataSetTableAdapters.statusTableAdapter statusTableAdapter;
        private notes_de_fraisDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView statusDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox id_statutComboBox;
        private System.Windows.Forms.Button button4;
    }
}