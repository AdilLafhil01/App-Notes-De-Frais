namespace WindowsFormsApp2
{
    partial class chercher_order
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
            System.Windows.Forms.Label nom_EmployerLabel;
            System.Windows.Forms.Label prenom_EmployerLabel;
            System.Windows.Forms.Label adressLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label matricule_EmployerLabel;
            System.Windows.Forms.Label id_DepartementLabel;
            System.Windows.Forms.Label id_intervenantLabel;
            System.Windows.Forms.Label nom_DepartementLabel;
            System.Windows.Forms.Label localisationLabel;
            System.Windows.Forms.Label date_departLabel;
            System.Windows.Forms.Label date_arriverLabel;
            System.Windows.Forms.Label lieu_deplacementLabel;
            System.Windows.Forms.Label date_departLabel2;
            System.Windows.Forms.Label date_arriverLabel2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(chercher_order));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.memoire_fraisBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.memoire_fraisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notes_de_fraisDataSet = new WindowsFormsApp2.notes_de_fraisDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.memoire_fraisBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nom_EmployerLabel1 = new System.Windows.Forms.Label();
            this.employersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prenom_EmployerLabel1 = new System.Windows.Forms.Label();
            this.adressLabel1 = new System.Windows.Forms.Label();
            this.descriptionLabel1 = new System.Windows.Forms.Label();
            this.statusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.matricule_EmployerComboBox = new System.Windows.Forms.ComboBox();
            this.id_DepartementComboBox = new System.Windows.Forms.ComboBox();
            this.departementsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.id_intervenantTextBox = new System.Windows.Forms.TextBox();
            this.nom_DepartementLabel1 = new System.Windows.Forms.Label();
            this.localisationLabel1 = new System.Windows.Forms.Label();
            this.date_departLabel1 = new System.Windows.Forms.Label();
            this.date_arriverLabel1 = new System.Windows.Forms.Label();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.memoire_fraisTableAdapter = new WindowsFormsApp2.notes_de_fraisDataSetTableAdapters.Memoire_fraisTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp2.notes_de_fraisDataSetTableAdapters.TableAdapterManager();
            this.departementsTableAdapter = new WindowsFormsApp2.notes_de_fraisDataSetTableAdapters.DepartementsTableAdapter();
            this.employersTableAdapter = new WindowsFormsApp2.notes_de_fraisDataSetTableAdapters.EmployersTableAdapter();
            this.statusTableAdapter = new WindowsFormsApp2.notes_de_fraisDataSetTableAdapters.statusTableAdapter();
            this.memoire_fraisBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lieu_deplacementLabel1 = new System.Windows.Forms.Label();
            this.date_departDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.date_arriverDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            nom_EmployerLabel = new System.Windows.Forms.Label();
            prenom_EmployerLabel = new System.Windows.Forms.Label();
            adressLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            matricule_EmployerLabel = new System.Windows.Forms.Label();
            id_DepartementLabel = new System.Windows.Forms.Label();
            id_intervenantLabel = new System.Windows.Forms.Label();
            nom_DepartementLabel = new System.Windows.Forms.Label();
            localisationLabel = new System.Windows.Forms.Label();
            date_departLabel = new System.Windows.Forms.Label();
            date_arriverLabel = new System.Windows.Forms.Label();
            lieu_deplacementLabel = new System.Windows.Forms.Label();
            date_departLabel2 = new System.Windows.Forms.Label();
            date_arriverLabel2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.memoire_fraisBindingNavigator)).BeginInit();
            this.memoire_fraisBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoire_fraisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notes_de_fraisDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departementsBindingSource)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoire_fraisBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // nom_EmployerLabel
            // 
            nom_EmployerLabel.AutoSize = true;
            nom_EmployerLabel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            nom_EmployerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nom_EmployerLabel.Location = new System.Drawing.Point(197, 118);
            nom_EmployerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nom_EmployerLabel.Name = "nom_EmployerLabel";
            nom_EmployerLabel.Size = new System.Drawing.Size(137, 20);
            nom_EmployerLabel.TabIndex = 5;
            nom_EmployerLabel.Text = "Nom Employer:";
            // 
            // prenom_EmployerLabel
            // 
            prenom_EmployerLabel.AutoSize = true;
            prenom_EmployerLabel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            prenom_EmployerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            prenom_EmployerLabel.Location = new System.Drawing.Point(197, 160);
            prenom_EmployerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            prenom_EmployerLabel.Name = "prenom_EmployerLabel";
            prenom_EmployerLabel.Size = new System.Drawing.Size(163, 20);
            prenom_EmployerLabel.TabIndex = 7;
            prenom_EmployerLabel.Text = "Prenom Employer:";
            // 
            // adressLabel
            // 
            adressLabel.AutoSize = true;
            adressLabel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            adressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            adressLabel.Location = new System.Drawing.Point(243, 244);
            adressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            adressLabel.Name = "adressLabel";
            adressLabel.Size = new System.Drawing.Size(72, 20);
            adressLabel.TabIndex = 9;
            adressLabel.Text = "adress:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descriptionLabel.Location = new System.Drawing.Point(227, 202);
            descriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(112, 20);
            descriptionLabel.TabIndex = 11;
            descriptionLabel.Text = "Description:";
            // 
            // matricule_EmployerLabel
            // 
            matricule_EmployerLabel.AutoSize = true;
            matricule_EmployerLabel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            matricule_EmployerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            matricule_EmployerLabel.Location = new System.Drawing.Point(187, 85);
            matricule_EmployerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            matricule_EmployerLabel.Name = "matricule_EmployerLabel";
            matricule_EmployerLabel.Size = new System.Drawing.Size(177, 20);
            matricule_EmployerLabel.TabIndex = 13;
            matricule_EmployerLabel.Text = "matricule Employer:";
            // 
            // id_DepartementLabel
            // 
            id_DepartementLabel.AutoSize = true;
            id_DepartementLabel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            id_DepartementLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_DepartementLabel.Location = new System.Drawing.Point(627, 85);
            id_DepartementLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            id_DepartementLabel.Name = "id_DepartementLabel";
            id_DepartementLabel.Size = new System.Drawing.Size(144, 20);
            id_DepartementLabel.TabIndex = 15;
            id_DepartementLabel.Text = "id Departement:";
            // 
            // id_intervenantLabel
            // 
            id_intervenantLabel.AutoSize = true;
            id_intervenantLabel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            id_intervenantLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_intervenantLabel.Location = new System.Drawing.Point(1035, 85);
            id_intervenantLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            id_intervenantLabel.Name = "id_intervenantLabel";
            id_intervenantLabel.Size = new System.Drawing.Size(129, 20);
            id_intervenantLabel.TabIndex = 17;
            id_intervenantLabel.Text = "id intervenant:";
            // 
            // nom_DepartementLabel
            // 
            nom_DepartementLabel.AutoSize = true;
            nom_DepartementLabel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            nom_DepartementLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nom_DepartementLabel.Location = new System.Drawing.Point(627, 152);
            nom_DepartementLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nom_DepartementLabel.Name = "nom_DepartementLabel";
            nom_DepartementLabel.Size = new System.Drawing.Size(167, 20);
            nom_DepartementLabel.TabIndex = 19;
            nom_DepartementLabel.Text = "Nom Departement:";
            // 
            // localisationLabel
            // 
            localisationLabel.AutoSize = true;
            localisationLabel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            localisationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            localisationLabel.Location = new System.Drawing.Point(660, 191);
            localisationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            localisationLabel.Name = "localisationLabel";
            localisationLabel.Size = new System.Drawing.Size(111, 20);
            localisationLabel.TabIndex = 21;
            localisationLabel.Text = "localisation:";
            // 
            // date_departLabel
            // 
            date_departLabel.AutoSize = true;
            date_departLabel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            date_departLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            date_departLabel.Location = new System.Drawing.Point(1065, 202);
            date_departLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            date_departLabel.Name = "date_departLabel";
            date_departLabel.Size = new System.Drawing.Size(116, 20);
            date_departLabel.TabIndex = 22;
            date_departLabel.Text = "date depart :";
            // 
            // date_arriverLabel
            // 
            date_arriverLabel.AutoSize = true;
            date_arriverLabel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            date_arriverLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            date_arriverLabel.Location = new System.Drawing.Point(1310, 202);
            date_arriverLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            date_arriverLabel.Name = "date_arriverLabel";
            date_arriverLabel.Size = new System.Drawing.Size(118, 20);
            date_arriverLabel.TabIndex = 23;
            date_arriverLabel.Text = "date arriver :";
            // 
            // lieu_deplacementLabel
            // 
            lieu_deplacementLabel.AutoSize = true;
            lieu_deplacementLabel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            lieu_deplacementLabel.Location = new System.Drawing.Point(1024, 140);
            lieu_deplacementLabel.Name = "lieu_deplacementLabel";
            lieu_deplacementLabel.Size = new System.Drawing.Size(157, 20);
            lieu_deplacementLabel.TabIndex = 25;
            lieu_deplacementLabel.Text = "lieu deplacement:";
            // 
            // date_departLabel2
            // 
            date_departLabel2.AutoSize = true;
            date_departLabel2.Location = new System.Drawing.Point(352, 338);
            date_departLabel2.Name = "date_departLabel2";
            date_departLabel2.Size = new System.Drawing.Size(110, 20);
            date_departLabel2.TabIndex = 26;
            date_departLabel2.Text = "date depart:";
            // 
            // date_arriverLabel2
            // 
            date_arriverLabel2.AutoSize = true;
            date_arriverLabel2.Location = new System.Drawing.Point(809, 338);
            date_arriverLabel2.Name = "date_arriverLabel2";
            date_arriverLabel2.Size = new System.Drawing.Size(112, 20);
            date_arriverLabel2.TabIndex = 28;
            date_arriverLabel2.Text = "date arriver:";
            // 
            // memoire_fraisBindingNavigator
            // 
            this.memoire_fraisBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.memoire_fraisBindingNavigator.BindingSource = this.memoire_fraisBindingSource;
            this.memoire_fraisBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.memoire_fraisBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.memoire_fraisBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.memoire_fraisBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.memoire_fraisBindingNavigatorSaveItem});
            this.memoire_fraisBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.memoire_fraisBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.memoire_fraisBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.memoire_fraisBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.memoire_fraisBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.memoire_fraisBindingNavigator.Name = "memoire_fraisBindingNavigator";
            this.memoire_fraisBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.memoire_fraisBindingNavigator.Size = new System.Drawing.Size(1688, 31);
            this.memoire_fraisBindingNavigator.TabIndex = 0;
            this.memoire_fraisBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Ajouter nouveau";
            // 
            // memoire_fraisBindingSource
            // 
            this.memoire_fraisBindingSource.DataMember = "Memoire_frais";
            this.memoire_fraisBindingSource.DataSource = this.notes_de_fraisDataSet;
            // 
            // notes_de_fraisDataSet
            // 
            this.notes_de_fraisDataSet.DataSetName = "notes_de_fraisDataSet";
            this.notes_de_fraisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 28);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Nombre total d\'éléments";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Supprimer";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Placer en premier";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Déplacer vers le haut";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(67, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Position actuelle";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Déplacer vers le bas";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Placer en dernier";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // memoire_fraisBindingNavigatorSaveItem
            // 
            this.memoire_fraisBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.memoire_fraisBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("memoire_fraisBindingNavigatorSaveItem.Image")));
            this.memoire_fraisBindingNavigatorSaveItem.Name = "memoire_fraisBindingNavigatorSaveItem";
            this.memoire_fraisBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.memoire_fraisBindingNavigatorSaveItem.Text = "Enregistrer les données";
            this.memoire_fraisBindingNavigatorSaveItem.Click += new System.EventHandler(this.memoire_fraisBindingNavigatorSaveItem_Click);
            // 
            // nom_EmployerLabel1
            // 
            this.nom_EmployerLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employersBindingSource, "Nom_Employer", true));
            this.nom_EmployerLabel1.Location = new System.Drawing.Point(414, 118);
            this.nom_EmployerLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nom_EmployerLabel1.Name = "nom_EmployerLabel1";
            this.nom_EmployerLabel1.Size = new System.Drawing.Size(107, 20);
            this.nom_EmployerLabel1.TabIndex = 6;
            this.nom_EmployerLabel1.Text = "label1";
            // 
            // employersBindingSource
            // 
            this.employersBindingSource.DataMember = "Employers";
            this.employersBindingSource.DataSource = this.notes_de_fraisDataSet;
            // 
            // prenom_EmployerLabel1
            // 
            this.prenom_EmployerLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employersBindingSource, "Prenom_Employer", true));
            this.prenom_EmployerLabel1.Location = new System.Drawing.Point(414, 160);
            this.prenom_EmployerLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.prenom_EmployerLabel1.Name = "prenom_EmployerLabel1";
            this.prenom_EmployerLabel1.Size = new System.Drawing.Size(107, 20);
            this.prenom_EmployerLabel1.TabIndex = 8;
            this.prenom_EmployerLabel1.Text = "label1";
            // 
            // adressLabel1
            // 
            this.adressLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employersBindingSource, "adress", true));
            this.adressLabel1.Location = new System.Drawing.Point(414, 244);
            this.adressLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.adressLabel1.Name = "adressLabel1";
            this.adressLabel1.Size = new System.Drawing.Size(107, 20);
            this.adressLabel1.TabIndex = 10;
            this.adressLabel1.Text = "label1";
            // 
            // descriptionLabel1
            // 
            this.descriptionLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statusBindingSource, "Description", true));
            this.descriptionLabel1.Location = new System.Drawing.Point(414, 202);
            this.descriptionLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descriptionLabel1.Name = "descriptionLabel1";
            this.descriptionLabel1.Size = new System.Drawing.Size(107, 20);
            this.descriptionLabel1.TabIndex = 12;
            this.descriptionLabel1.Text = "label1";
            // 
            // statusBindingSource
            // 
            this.statusBindingSource.DataMember = "status";
            this.statusBindingSource.DataSource = this.notes_de_fraisDataSet;
            // 
            // employersBindingSource1
            // 
            this.employersBindingSource1.DataMember = "FK_Employers_status";
            this.employersBindingSource1.DataSource = this.statusBindingSource;
            // 
            // matricule_EmployerComboBox
            // 
            this.matricule_EmployerComboBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.matricule_EmployerComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employersBindingSource1, "matricule_Employer", true));
            this.matricule_EmployerComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.memoire_fraisBindingSource, "matricule_employer", true));
            this.matricule_EmployerComboBox.DataSource = this.employersBindingSource1;
            this.matricule_EmployerComboBox.DisplayMember = "matricule_Employer";
            this.matricule_EmployerComboBox.FormattingEnabled = true;
            this.matricule_EmployerComboBox.Location = new System.Drawing.Point(372, 80);
            this.matricule_EmployerComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.matricule_EmployerComboBox.Name = "matricule_EmployerComboBox";
            this.matricule_EmployerComboBox.Size = new System.Drawing.Size(202, 28);
            this.matricule_EmployerComboBox.TabIndex = 14;
            this.matricule_EmployerComboBox.ValueMember = "matricule_Employer";
            // 
            // id_DepartementComboBox
            // 
            this.id_DepartementComboBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.id_DepartementComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.departementsBindingSource, "id_Departement", true));
            this.id_DepartementComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.departementsBindingSource, "id_Departement", true));
            this.id_DepartementComboBox.DataSource = this.departementsBindingSource;
            this.id_DepartementComboBox.DisplayMember = "id_Departement";
            this.id_DepartementComboBox.FormattingEnabled = true;
            this.id_DepartementComboBox.Location = new System.Drawing.Point(779, 80);
            this.id_DepartementComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.id_DepartementComboBox.Name = "id_DepartementComboBox";
            this.id_DepartementComboBox.Size = new System.Drawing.Size(201, 28);
            this.id_DepartementComboBox.TabIndex = 16;
            this.id_DepartementComboBox.ValueMember = "id_Departement";
            // 
            // departementsBindingSource
            // 
            this.departementsBindingSource.DataMember = "Departements";
            this.departementsBindingSource.DataSource = this.notes_de_fraisDataSet;
            // 
            // id_intervenantTextBox
            // 
            this.id_intervenantTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.id_intervenantTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memoire_fraisBindingSource, "id_intervenant", true));
            this.id_intervenantTextBox.Location = new System.Drawing.Point(1189, 81);
            this.id_intervenantTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.id_intervenantTextBox.Name = "id_intervenantTextBox";
            this.id_intervenantTextBox.Size = new System.Drawing.Size(195, 27);
            this.id_intervenantTextBox.TabIndex = 18;
            // 
            // nom_DepartementLabel1
            // 
            this.nom_DepartementLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.departementsBindingSource, "Nom_Departement", true));
            this.nom_DepartementLabel1.Location = new System.Drawing.Point(840, 152);
            this.nom_DepartementLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nom_DepartementLabel1.Name = "nom_DepartementLabel1";
            this.nom_DepartementLabel1.Size = new System.Drawing.Size(107, 20);
            this.nom_DepartementLabel1.TabIndex = 20;
            this.nom_DepartementLabel1.Text = "label1";
            // 
            // localisationLabel1
            // 
            this.localisationLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.departementsBindingSource, "localisation", true));
            this.localisationLabel1.Location = new System.Drawing.Point(840, 202);
            this.localisationLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.localisationLabel1.Name = "localisationLabel1";
            this.localisationLabel1.Size = new System.Drawing.Size(107, 20);
            this.localisationLabel1.TabIndex = 22;
            this.localisationLabel1.Text = "label1";
            // 
            // date_departLabel1
            // 
            this.date_departLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memoire_fraisBindingSource, "date_depart", true));
            this.date_departLabel1.Location = new System.Drawing.Point(1205, 202);
            this.date_departLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.date_departLabel1.Name = "date_departLabel1";
            this.date_departLabel1.Size = new System.Drawing.Size(107, 20);
            this.date_departLabel1.TabIndex = 23;
            this.date_departLabel1.Text = "label1";
            // 
            // date_arriverLabel1
            // 
            this.date_arriverLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memoire_fraisBindingSource, "date_arriver", true));
            this.date_arriverLabel1.Location = new System.Drawing.Point(1460, 202);
            this.date_arriverLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.date_arriverLabel1.Name = "date_arriverLabel1";
            this.date_arriverLabel1.Size = new System.Drawing.Size(107, 20);
            this.date_arriverLabel1.TabIndex = 24;
            this.date_arriverLabel1.Text = "label1";
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 31);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(1688, 31);
            this.fillByToolStrip.TabIndex = 25;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(48, 28);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // memoire_fraisTableAdapter
            // 
            this.memoire_fraisTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.authentificationTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DepartementsTableAdapter = this.departementsTableAdapter;
            this.tableAdapterManager.EmployersTableAdapter = this.employersTableAdapter;
            this.tableAdapterManager.Memoire_fraisTableAdapter = this.memoire_fraisTableAdapter;
            this.tableAdapterManager.objetsTableAdapter = null;
            this.tableAdapterManager.statusTableAdapter = this.statusTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp2.notes_de_fraisDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // departementsTableAdapter
            // 
            this.departementsTableAdapter.ClearBeforeFill = true;
            // 
            // employersTableAdapter
            // 
            this.employersTableAdapter.ClearBeforeFill = true;
            // 
            // statusTableAdapter
            // 
            this.statusTableAdapter.ClearBeforeFill = true;
            // 
            // memoire_fraisBindingSource1
            // 
            this.memoire_fraisBindingSource1.DataMember = "FK_Memoire_frais_Employers";
            this.memoire_fraisBindingSource1.DataSource = this.employersBindingSource;
            // 
            // lieu_deplacementLabel1
            // 
            this.lieu_deplacementLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memoire_fraisBindingSource1, "lieu_deplacement", true));
            this.lieu_deplacementLabel1.Location = new System.Drawing.Point(1205, 137);
            this.lieu_deplacementLabel1.Name = "lieu_deplacementLabel1";
            this.lieu_deplacementLabel1.Size = new System.Drawing.Size(100, 23);
            this.lieu_deplacementLabel1.TabIndex = 26;
            this.lieu_deplacementLabel1.Text = "label1";
            // 
            // date_departDateTimePicker
            // 
            this.date_departDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.memoire_fraisBindingSource, "date_depart", true));
            this.date_departDateTimePicker.Location = new System.Drawing.Point(484, 335);
            this.date_departDateTimePicker.Name = "date_departDateTimePicker";
            this.date_departDateTimePicker.Size = new System.Drawing.Size(303, 27);
            this.date_departDateTimePicker.TabIndex = 27;
            // 
            // date_arriverDateTimePicker
            // 
            this.date_arriverDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.memoire_fraisBindingSource, "date_arriver", true));
            this.date_arriverDateTimePicker.Location = new System.Drawing.Point(943, 335);
            this.date_arriverDateTimePicker.Name = "date_arriverDateTimePicker";
            this.date_arriverDateTimePicker.Size = new System.Drawing.Size(299, 27);
            this.date_arriverDateTimePicker.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1296, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 35);
            this.button1.TabIndex = 30;
            this.button1.Text = "Filtrer";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(170, 384);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1429, 269);
            this.dataGridView1.TabIndex = 31;
            // 
            // chercher_order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1688, 886);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(date_arriverLabel2);
            this.Controls.Add(this.date_arriverDateTimePicker);
            this.Controls.Add(date_departLabel2);
            this.Controls.Add(this.date_departDateTimePicker);
            this.Controls.Add(lieu_deplacementLabel);
            this.Controls.Add(this.lieu_deplacementLabel1);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(date_arriverLabel);
            this.Controls.Add(this.date_arriverLabel1);
            this.Controls.Add(date_departLabel);
            this.Controls.Add(this.date_departLabel1);
            this.Controls.Add(localisationLabel);
            this.Controls.Add(this.localisationLabel1);
            this.Controls.Add(nom_DepartementLabel);
            this.Controls.Add(this.nom_DepartementLabel1);
            this.Controls.Add(id_intervenantLabel);
            this.Controls.Add(id_DepartementLabel);
            this.Controls.Add(matricule_EmployerLabel);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionLabel1);
            this.Controls.Add(adressLabel);
            this.Controls.Add(this.adressLabel1);
            this.Controls.Add(prenom_EmployerLabel);
            this.Controls.Add(this.prenom_EmployerLabel1);
            this.Controls.Add(nom_EmployerLabel);
            this.Controls.Add(this.nom_EmployerLabel1);
            this.Controls.Add(this.memoire_fraisBindingNavigator);
            this.Controls.Add(this.id_intervenantTextBox);
            this.Controls.Add(this.id_DepartementComboBox);
            this.Controls.Add(this.matricule_EmployerComboBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "chercher_order";
            this.Text = "OrderMission";
            this.Load += new System.EventHandler(this.filtrer_rapport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.memoire_fraisBindingNavigator)).EndInit();
            this.memoire_fraisBindingNavigator.ResumeLayout(false);
            this.memoire_fraisBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoire_fraisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notes_de_fraisDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departementsBindingSource)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoire_fraisBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private notes_de_fraisDataSet notes_de_fraisDataSet;
        private System.Windows.Forms.BindingSource memoire_fraisBindingSource;
        private notes_de_fraisDataSetTableAdapters.Memoire_fraisTableAdapter memoire_fraisTableAdapter;
        private notes_de_fraisDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator memoire_fraisBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton memoire_fraisBindingNavigatorSaveItem;
        private notes_de_fraisDataSetTableAdapters.EmployersTableAdapter employersTableAdapter;
        private System.Windows.Forms.BindingSource employersBindingSource;
        private notes_de_fraisDataSetTableAdapters.statusTableAdapter statusTableAdapter;
        private System.Windows.Forms.Label nom_EmployerLabel1;
        private System.Windows.Forms.Label prenom_EmployerLabel1;
        private System.Windows.Forms.Label adressLabel1;
        private System.Windows.Forms.BindingSource statusBindingSource;
        private System.Windows.Forms.Label descriptionLabel1;
        private System.Windows.Forms.BindingSource employersBindingSource1;
        private notes_de_fraisDataSetTableAdapters.DepartementsTableAdapter departementsTableAdapter;
        private System.Windows.Forms.ComboBox matricule_EmployerComboBox;
        private System.Windows.Forms.BindingSource departementsBindingSource;
        private System.Windows.Forms.ComboBox id_DepartementComboBox;
        private System.Windows.Forms.TextBox id_intervenantTextBox;
        private System.Windows.Forms.Label nom_DepartementLabel1;
        private System.Windows.Forms.Label localisationLabel1;
        private System.Windows.Forms.Label date_departLabel1;
        private System.Windows.Forms.Label date_arriverLabel1;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.BindingSource memoire_fraisBindingSource1;
        private System.Windows.Forms.Label lieu_deplacementLabel1;
        private System.Windows.Forms.DateTimePicker date_departDateTimePicker;
        private System.Windows.Forms.DateTimePicker date_arriverDateTimePicker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}