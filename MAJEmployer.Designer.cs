namespace WindowsFormsApp2
{
    partial class MAJEmployer
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
            System.Windows.Forms.Label id_departementLabel;
            this.matricule_EmployerLabel = new System.Windows.Forms.Label();
            this.nom_EmployerLabel = new System.Windows.Forms.Label();
            this.prenom_EmployerLabel = new System.Windows.Forms.Label();
            this.adressLabel = new System.Windows.Forms.Label();
            this.telLabel = new System.Windows.Forms.Label();
            this.date_affectationLabel = new System.Windows.Forms.Label();
            this.matricule_EmployerTextBox = new System.Windows.Forms.TextBox();
            this.nom_EmployerTextBox = new System.Windows.Forms.TextBox();
            this.prenom_EmployerTextBox = new System.Windows.Forms.TextBox();
            this.adressTextBox = new System.Windows.Forms.TextBox();
            this.telTextBox = new System.Windows.Forms.TextBox();
            this.date_affectationDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.statusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.notes_de_fraisDataSet = new WindowsFormsApp2.notes_de_fraisDataSet();
            this.tableAdapterManager = new WindowsFormsApp2.notes_de_fraisDataSetTableAdapters.TableAdapterManager();
            this.statusTableAdapter = new WindowsFormsApp2.notes_de_fraisDataSetTableAdapters.statusTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.employersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employersTableAdapter = new WindowsFormsApp2.notes_de_fraisDataSetTableAdapters.EmployersTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.id_statutComboBox = new System.Windows.Forms.ComboBox();
            this.id_departementComboBox = new System.Windows.Forms.ComboBox();
            this.fKMemoirefraisEmployersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.memoire_fraisTableAdapter = new WindowsFormsApp2.notes_de_fraisDataSetTableAdapters.Memoire_fraisTableAdapter();
            id_departementLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notes_de_fraisDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKMemoirefraisEmployersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // id_departementLabel
            // 
            id_departementLabel.AutoSize = true;
            id_departementLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_departementLabel.Location = new System.Drawing.Point(61, 272);
            id_departementLabel.Name = "id_departementLabel";
            id_departementLabel.Size = new System.Drawing.Size(140, 20);
            id_departementLabel.TabIndex = 34;
            id_departementLabel.Text = "id departement:";
            // 
            // matricule_EmployerLabel
            // 
            this.matricule_EmployerLabel.AutoSize = true;
            this.matricule_EmployerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matricule_EmployerLabel.Location = new System.Drawing.Point(61, 80);
            this.matricule_EmployerLabel.Name = "matricule_EmployerLabel";
            this.matricule_EmployerLabel.Size = new System.Drawing.Size(177, 20);
            this.matricule_EmployerLabel.TabIndex = 1;
            this.matricule_EmployerLabel.Text = "matricule Employer:";
            // 
            // nom_EmployerLabel
            // 
            this.nom_EmployerLabel.AutoSize = true;
            this.nom_EmployerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom_EmployerLabel.Location = new System.Drawing.Point(61, 117);
            this.nom_EmployerLabel.Name = "nom_EmployerLabel";
            this.nom_EmployerLabel.Size = new System.Drawing.Size(137, 20);
            this.nom_EmployerLabel.TabIndex = 3;
            this.nom_EmployerLabel.Text = "Nom Employer:";
            // 
            // prenom_EmployerLabel
            // 
            this.prenom_EmployerLabel.AutoSize = true;
            this.prenom_EmployerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenom_EmployerLabel.Location = new System.Drawing.Point(61, 154);
            this.prenom_EmployerLabel.Name = "prenom_EmployerLabel";
            this.prenom_EmployerLabel.Size = new System.Drawing.Size(163, 20);
            this.prenom_EmployerLabel.TabIndex = 5;
            this.prenom_EmployerLabel.Text = "Prenom Employer:";
            // 
            // adressLabel
            // 
            this.adressLabel.AutoSize = true;
            this.adressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adressLabel.Location = new System.Drawing.Point(61, 191);
            this.adressLabel.Name = "adressLabel";
            this.adressLabel.Size = new System.Drawing.Size(72, 20);
            this.adressLabel.TabIndex = 7;
            this.adressLabel.Text = "adress:";
            // 
            // telLabel
            // 
            this.telLabel.AutoSize = true;
            this.telLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telLabel.Location = new System.Drawing.Point(61, 239);
            this.telLabel.Name = "telLabel";
            this.telLabel.Size = new System.Drawing.Size(41, 20);
            this.telLabel.TabIndex = 9;
            this.telLabel.Text = "Tel:";
            // 
            // date_affectationLabel
            // 
            this.date_affectationLabel.AutoSize = true;
            this.date_affectationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_affectationLabel.Location = new System.Drawing.Point(61, 350);
            this.date_affectationLabel.Name = "date_affectationLabel";
            this.date_affectationLabel.Size = new System.Drawing.Size(146, 20);
            this.date_affectationLabel.TabIndex = 15;
            this.date_affectationLabel.Text = "date affectation:";
            // 
            // matricule_EmployerTextBox
            // 
            this.matricule_EmployerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matricule_EmployerTextBox.Location = new System.Drawing.Point(254, 73);
            this.matricule_EmployerTextBox.Name = "matricule_EmployerTextBox";
            this.matricule_EmployerTextBox.Size = new System.Drawing.Size(309, 30);
            this.matricule_EmployerTextBox.TabIndex = 2;
            // 
            // nom_EmployerTextBox
            // 
            this.nom_EmployerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom_EmployerTextBox.Location = new System.Drawing.Point(254, 112);
            this.nom_EmployerTextBox.Name = "nom_EmployerTextBox";
            this.nom_EmployerTextBox.Size = new System.Drawing.Size(309, 30);
            this.nom_EmployerTextBox.TabIndex = 4;
            // 
            // prenom_EmployerTextBox
            // 
            this.prenom_EmployerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenom_EmployerTextBox.Location = new System.Drawing.Point(254, 151);
            this.prenom_EmployerTextBox.Name = "prenom_EmployerTextBox";
            this.prenom_EmployerTextBox.Size = new System.Drawing.Size(309, 30);
            this.prenom_EmployerTextBox.TabIndex = 6;
            // 
            // adressTextBox
            // 
            this.adressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adressTextBox.Location = new System.Drawing.Point(254, 190);
            this.adressTextBox.Name = "adressTextBox";
            this.adressTextBox.Size = new System.Drawing.Size(309, 30);
            this.adressTextBox.TabIndex = 8;
            // 
            // telTextBox
            // 
            this.telTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telTextBox.Location = new System.Drawing.Point(254, 229);
            this.telTextBox.Name = "telTextBox";
            this.telTextBox.Size = new System.Drawing.Size(309, 30);
            this.telTextBox.TabIndex = 10;
            // 
            // date_affectationDateTimePicker
            // 
            this.date_affectationDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_affectationDateTimePicker.Location = new System.Drawing.Point(254, 341);
            this.date_affectationDateTimePicker.Name = "date_affectationDateTimePicker";
            this.date_affectationDateTimePicker.Size = new System.Drawing.Size(309, 30);
            this.date_affectationDateTimePicker.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(655, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 29);
            this.button1.TabIndex = 19;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // notes_de_fraisDataSet
            // 
            this.notes_de_fraisDataSet.DataSetName = "notes_de_fraisDataSet";
            this.notes_de_fraisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // statusTableAdapter
            // 
            this.statusTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(586, 92);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 39);
            this.button2.TabIndex = 22;
            this.button2.Text = "ajouter";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Crimson;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(586, 137);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 39);
            this.button3.TabIndex = 23;
            this.button3.Text = "modifier";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Crimson;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(586, 180);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 39);
            this.button4.TabIndex = 24;
            this.button4.Text = "supprimer";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Crimson;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(586, 229);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(103, 39);
            this.button5.TabIndex = 25;
            this.button5.Text = "nouveaux";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Crimson;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(235, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(39, 29);
            this.button6.TabIndex = 29;
            this.button6.Text = ">";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Crimson;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(171, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(39, 29);
            this.button7.TabIndex = 28;
            this.button7.Text = "<";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Crimson;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(299, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(39, 29);
            this.button8.TabIndex = 27;
            this.button8.Text = ">>";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Crimson;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(105, 2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(39, 29);
            this.button9.TabIndex = 26;
            this.button9.Text = "<<";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // employersBindingSource
            // 
            this.employersBindingSource.DataMember = "Employers";
            this.employersBindingSource.DataSource = this.notes_de_fraisDataSet;
            // 
            // employersTableAdapter
            // 
            this.employersTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Id_Statut :";
            // 
            // id_statutComboBox
            // 
            this.id_statutComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employersBindingSource, "id_statut", true));
            this.id_statutComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.employersBindingSource, "id_statut", true));
            this.id_statutComboBox.DataSource = this.employersBindingSource;
            this.id_statutComboBox.DisplayMember = "id_statut";
            this.id_statutComboBox.FormattingEnabled = true;
            this.id_statutComboBox.Location = new System.Drawing.Point(254, 305);
            this.id_statutComboBox.Name = "id_statutComboBox";
            this.id_statutComboBox.Size = new System.Drawing.Size(309, 24);
            this.id_statutComboBox.TabIndex = 34;
            this.id_statutComboBox.ValueMember = "id_statut";
            // 
            // id_departementComboBox
            // 
            this.id_departementComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employersBindingSource, "id_departement", true));
            this.id_departementComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.employersBindingSource, "id_departement", true));
            this.id_departementComboBox.DataSource = this.employersBindingSource;
            this.id_departementComboBox.DisplayMember = "id_departement";
            this.id_departementComboBox.FormattingEnabled = true;
            this.id_departementComboBox.Location = new System.Drawing.Point(254, 272);
            this.id_departementComboBox.Name = "id_departementComboBox";
            this.id_departementComboBox.Size = new System.Drawing.Size(309, 24);
            this.id_departementComboBox.TabIndex = 35;
            this.id_departementComboBox.ValueMember = "id_departement";
            // 
            // fKMemoirefraisEmployersBindingSource
            // 
            this.fKMemoirefraisEmployersBindingSource.DataMember = "FK_Memoire_frais_Employers";
            this.fKMemoirefraisEmployersBindingSource.DataSource = this.employersBindingSource;
            // 
            // memoire_fraisTableAdapter
            // 
            this.memoire_fraisTableAdapter.ClearBeforeFill = true;
            // 
            // MAJEmployer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 409);
            this.ControlBox = false;
            this.Controls.Add(id_departementLabel);
            this.Controls.Add(this.id_departementComboBox);
            this.Controls.Add(this.id_statutComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.matricule_EmployerLabel);
            this.Controls.Add(this.matricule_EmployerTextBox);
            this.Controls.Add(this.nom_EmployerLabel);
            this.Controls.Add(this.nom_EmployerTextBox);
            this.Controls.Add(this.prenom_EmployerLabel);
            this.Controls.Add(this.prenom_EmployerTextBox);
            this.Controls.Add(this.adressLabel);
            this.Controls.Add(this.adressTextBox);
            this.Controls.Add(this.telLabel);
            this.Controls.Add(this.telTextBox);
            this.Controls.Add(this.date_affectationLabel);
            this.Controls.Add(this.date_affectationDateTimePicker);
            this.Name = "MAJEmployer";
            this.Text = "MAJEmployer";
            this.Load += new System.EventHandler(this.MAJEmployer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notes_de_fraisDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKMemoirefraisEmployersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox matricule_EmployerTextBox;
        private System.Windows.Forms.TextBox nom_EmployerTextBox;
        private System.Windows.Forms.TextBox prenom_EmployerTextBox;
        private System.Windows.Forms.TextBox adressTextBox;
        private System.Windows.Forms.TextBox telTextBox;
        private System.Windows.Forms.DateTimePicker date_affectationDateTimePicker;
        private System.Windows.Forms.BindingSource statusBindingSource;
        private System.Windows.Forms.Label matricule_EmployerLabel;
        private System.Windows.Forms.Label nom_EmployerLabel;
        private System.Windows.Forms.Label prenom_EmployerLabel;
        private System.Windows.Forms.Label adressLabel;
        private System.Windows.Forms.Label telLabel;
        private System.Windows.Forms.Label date_affectationLabel;
        private System.Windows.Forms.Button button1;
        private notes_de_fraisDataSet notes_de_fraisDataSet;
        private notes_de_fraisDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private notes_de_fraisDataSetTableAdapters.statusTableAdapter statusTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.BindingSource employersBindingSource;
        private notes_de_fraisDataSetTableAdapters.EmployersTableAdapter employersTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox id_statutComboBox;
        private System.Windows.Forms.ComboBox id_departementComboBox;
        private System.Windows.Forms.BindingSource fKMemoirefraisEmployersBindingSource;
        private notes_de_fraisDataSetTableAdapters.Memoire_fraisTableAdapter memoire_fraisTableAdapter;
    }
}