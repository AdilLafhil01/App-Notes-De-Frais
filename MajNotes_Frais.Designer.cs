﻿namespace WindowsFormsApp2
{
    partial class MajNotes_Frais
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
            System.Windows.Forms.Label matricule_EmployerLabel1;
            System.Windows.Forms.Label id_intervenantLabel;
            System.Windows.Forms.Label description_ObjetLabel;
            this.memoire_fraisDataGridView = new System.Windows.Forms.DataGridView();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionObjetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carburantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contrôleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notes_de_fraisDataSet = new WindowsFormsApp2.notes_de_fraisDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataTable1TableAdapter = new WindowsFormsApp2.notes_de_fraisDataSetTableAdapters.DataTable1TableAdapter();
            this.tableAdapterManager = new WindowsFormsApp2.notes_de_fraisDataSetTableAdapters.TableAdapterManager();
            this.employersTableAdapter = new WindowsFormsApp2.notes_de_fraisDataSetTableAdapters.EmployersTableAdapter();
            this.employersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.matricule_EmployerComboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.description_ObjetComboBox = new System.Windows.Forms.ComboBox();
            this.id_intervenantComboBox = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            matricule_EmployerLabel1 = new System.Windows.Forms.Label();
            id_intervenantLabel = new System.Windows.Forms.Label();
            description_ObjetLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.memoire_fraisDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notes_de_fraisDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employersBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // matricule_EmployerLabel1
            // 
            matricule_EmployerLabel1.AutoSize = true;
            matricule_EmployerLabel1.Location = new System.Drawing.Point(3, 93);
            matricule_EmployerLabel1.Name = "matricule_EmployerLabel1";
            matricule_EmployerLabel1.Size = new System.Drawing.Size(144, 16);
            matricule_EmployerLabel1.TabIndex = 6;
            matricule_EmployerLabel1.Text = "matricule Employer:";
            // 
            // id_intervenantLabel
            // 
            id_intervenantLabel.AutoSize = true;
            id_intervenantLabel.Location = new System.Drawing.Point(27, 48);
            id_intervenantLabel.Name = "id_intervenantLabel";
            id_intervenantLabel.Size = new System.Drawing.Size(104, 16);
            id_intervenantLabel.TabIndex = 11;
            id_intervenantLabel.Text = "id intervenant:";
            // 
            // description_ObjetLabel
            // 
            description_ObjetLabel.AutoSize = true;
            description_ObjetLabel.Location = new System.Drawing.Point(3, 6);
            description_ObjetLabel.Name = "description_ObjetLabel";
            description_ObjetLabel.Size = new System.Drawing.Size(131, 16);
            description_ObjetLabel.TabIndex = 12;
            description_ObjetLabel.Text = "Description Objet:";
            // 
            // memoire_fraisDataGridView
            // 
            this.memoire_fraisDataGridView.AutoGenerateColumns = false;
            this.memoire_fraisDataGridView.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.memoire_fraisDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.memoire_fraisDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.descriptionObjetDataGridViewTextBoxColumn,
            this.hotelDataGridViewTextBoxColumn,
            this.transportDataGridViewTextBoxColumn,
            this.carburantDataGridViewTextBoxColumn,
            this.repasDataGridViewTextBoxColumn,
            this.autresDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.contrôleDataGridViewTextBoxColumn});
            this.memoire_fraisDataGridView.DataSource = this.dataTable1BindingSource;
            this.memoire_fraisDataGridView.GridColor = System.Drawing.SystemColors.InactiveBorder;
            this.memoire_fraisDataGridView.Location = new System.Drawing.Point(149, 257);
            this.memoire_fraisDataGridView.Name = "memoire_fraisDataGridView";
            this.memoire_fraisDataGridView.RowHeadersWidth = 51;
            this.memoire_fraisDataGridView.RowTemplate.Height = 24;
            this.memoire_fraisDataGridView.Size = new System.Drawing.Size(1180, 387);
            this.memoire_fraisDataGridView.TabIndex = 1;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionObjetDataGridViewTextBoxColumn
            // 
            this.descriptionObjetDataGridViewTextBoxColumn.DataPropertyName = "Description_Objet";
            this.descriptionObjetDataGridViewTextBoxColumn.HeaderText = "Description_Objet";
            this.descriptionObjetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionObjetDataGridViewTextBoxColumn.Name = "descriptionObjetDataGridViewTextBoxColumn";
            this.descriptionObjetDataGridViewTextBoxColumn.Width = 125;
            // 
            // hotelDataGridViewTextBoxColumn
            // 
            this.hotelDataGridViewTextBoxColumn.DataPropertyName = "Hotel";
            this.hotelDataGridViewTextBoxColumn.HeaderText = "Hotel";
            this.hotelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hotelDataGridViewTextBoxColumn.Name = "hotelDataGridViewTextBoxColumn";
            this.hotelDataGridViewTextBoxColumn.Width = 125;
            // 
            // transportDataGridViewTextBoxColumn
            // 
            this.transportDataGridViewTextBoxColumn.DataPropertyName = "Transport";
            this.transportDataGridViewTextBoxColumn.HeaderText = "Transport";
            this.transportDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.transportDataGridViewTextBoxColumn.Name = "transportDataGridViewTextBoxColumn";
            this.transportDataGridViewTextBoxColumn.Width = 125;
            // 
            // carburantDataGridViewTextBoxColumn
            // 
            this.carburantDataGridViewTextBoxColumn.DataPropertyName = "Carburant";
            this.carburantDataGridViewTextBoxColumn.HeaderText = "Carburant";
            this.carburantDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.carburantDataGridViewTextBoxColumn.Name = "carburantDataGridViewTextBoxColumn";
            this.carburantDataGridViewTextBoxColumn.Width = 125;
            // 
            // repasDataGridViewTextBoxColumn
            // 
            this.repasDataGridViewTextBoxColumn.DataPropertyName = "Repas";
            this.repasDataGridViewTextBoxColumn.HeaderText = "Repas";
            this.repasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.repasDataGridViewTextBoxColumn.Name = "repasDataGridViewTextBoxColumn";
            this.repasDataGridViewTextBoxColumn.Width = 125;
            // 
            // autresDataGridViewTextBoxColumn
            // 
            this.autresDataGridViewTextBoxColumn.DataPropertyName = "Autres";
            this.autresDataGridViewTextBoxColumn.HeaderText = "Autres";
            this.autresDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.autresDataGridViewTextBoxColumn.Name = "autresDataGridViewTextBoxColumn";
            this.autresDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.Width = 125;
            // 
            // contrôleDataGridViewTextBoxColumn
            // 
            this.contrôleDataGridViewTextBoxColumn.DataPropertyName = "Contrôle";
            this.contrôleDataGridViewTextBoxColumn.HeaderText = "Contrôle";
            this.contrôleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contrôleDataGridViewTextBoxColumn.Name = "contrôleDataGridViewTextBoxColumn";
            this.contrôleDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.notes_de_fraisDataSet;
            // 
            // notes_de_fraisDataSet
            // 
            this.notes_de_fraisDataSet.DataSetName = "notes_de_fraisDataSet";
            this.notes_de_fraisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(149, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(252, 41);
            this.button1.TabIndex = 2;
            this.button1.Text = "Imprimer Rapport D\'activité";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBox1.Location = new System.Drawing.Point(409, 87);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(136, 24);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox1.Location = new System.Drawing.Point(652, 89);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.authentificationTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DepartementsTableAdapter = null;
            this.tableAdapterManager.DépensesTableAdapter = null;
            this.tableAdapterManager.EmployersTableAdapter = this.employersTableAdapter;
            this.tableAdapterManager.Memoire_fraisTableAdapter = null;
            this.tableAdapterManager.objetsTableAdapter = null;
            this.tableAdapterManager.Rapport_activitéTableAdapter = null;
            this.tableAdapterManager.statusTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp2.notes_de_fraisDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // employersTableAdapter
            // 
            this.employersTableAdapter.ClearBeforeFill = true;
            // 
            // employersBindingSource
            // 
            this.employersBindingSource.DataMember = "Employers";
            this.employersBindingSource.DataSource = this.notes_de_fraisDataSet;
            // 
            // matricule_EmployerComboBox1
            // 
            this.matricule_EmployerComboBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.matricule_EmployerComboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employersBindingSource, "matricule_Employer", true));
            this.matricule_EmployerComboBox1.DataSource = this.employersBindingSource;
            this.matricule_EmployerComboBox1.DisplayMember = "Nom_Employer";
            this.matricule_EmployerComboBox1.FormattingEnabled = true;
            this.matricule_EmployerComboBox1.Location = new System.Drawing.Point(150, 90);
            this.matricule_EmployerComboBox1.Name = "matricule_EmployerComboBox1";
            this.matricule_EmployerComboBox1.Size = new System.Drawing.Size(136, 24);
            this.matricule_EmployerComboBox1.TabIndex = 7;
            this.matricule_EmployerComboBox1.ValueMember = "matricule_Employer";
            this.matricule_EmployerComboBox1.SelectedIndexChanged += new System.EventHandler(this.matricule_EmployerComboBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(149, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(252, 43);
            this.button2.TabIndex = 8;
            this.button2.Text = "Imprimer Notes De Frais";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Crimson;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(644, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 43);
            this.button4.TabIndex = 10;
            this.button4.Text = "Filtrer";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.memoire_fraisDataGridView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1403, 711);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(matricule_EmployerLabel1);
            this.panel2.Controls.Add(description_ObjetLabel);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.description_ObjetComboBox);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(id_intervenantLabel);
            this.panel2.Controls.Add(this.matricule_EmployerComboBox1);
            this.panel2.Controls.Add(this.id_intervenantComboBox);
            this.panel2.Location = new System.Drawing.Point(482, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 136);
            this.panel2.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(576, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Annee";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(332, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mois";
            // 
            // description_ObjetComboBox
            // 
            this.description_ObjetComboBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.description_ObjetComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataTable1BindingSource, "Description_Objet", true));
            this.description_ObjetComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataTable1BindingSource, "Description_Objet", true));
            this.description_ObjetComboBox.DataSource = this.dataTable1BindingSource;
            this.description_ObjetComboBox.DisplayMember = "Description_Objet";
            this.description_ObjetComboBox.FormattingEnabled = true;
            this.description_ObjetComboBox.Location = new System.Drawing.Point(150, 3);
            this.description_ObjetComboBox.Name = "description_ObjetComboBox";
            this.description_ObjetComboBox.Size = new System.Drawing.Size(250, 24);
            this.description_ObjetComboBox.TabIndex = 13;
            this.description_ObjetComboBox.ValueMember = "Description_Objet";
            this.description_ObjetComboBox.SelectedIndexChanged += new System.EventHandler(this.description_ObjetComboBox_SelectedIndexChanged);
            // 
            // id_intervenantComboBox
            // 
            this.id_intervenantComboBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.id_intervenantComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataTable1BindingSource, "id_intervenant", true));
            this.id_intervenantComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataTable1BindingSource, "id_intervenant", true));
            this.id_intervenantComboBox.DataSource = this.dataTable1BindingSource;
            this.id_intervenantComboBox.DisplayMember = "id_intervenant";
            this.id_intervenantComboBox.FormattingEnabled = true;
            this.id_intervenantComboBox.Location = new System.Drawing.Point(150, 45);
            this.id_intervenantComboBox.Name = "id_intervenantComboBox";
            this.id_intervenantComboBox.Size = new System.Drawing.Size(250, 24);
            this.id_intervenantComboBox.TabIndex = 12;
            this.id_intervenantComboBox.ValueMember = "id_intervenant";
            this.id_intervenantComboBox.SelectedIndexChanged += new System.EventHandler(this.id_intervenantComboBox_SelectedIndexChanged);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Crimson;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(1316, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(87, 47);
            this.button5.TabIndex = 14;
            this.button5.Text = "Exit";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Crimson;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(149, 176);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(252, 39);
            this.button3.TabIndex = 11;
            this.button3.Text = "Imprimer Order De Mission";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // MajNotes_Frais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1403, 711);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MajNotes_Frais";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.memoire_fraisDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notes_de_fraisDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employersBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView memoire_fraisDataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private notes_de_fraisDataSet notes_de_fraisDataSet;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private notes_de_fraisDataSetTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private notes_de_fraisDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private notes_de_fraisDataSetTableAdapters.EmployersTableAdapter employersTableAdapter;
        private System.Windows.Forms.BindingSource employersBindingSource;
        private System.Windows.Forms.ComboBox matricule_EmployerComboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionObjetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carburantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn repasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contrôleDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox id_intervenantComboBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox description_ObjetComboBox;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}