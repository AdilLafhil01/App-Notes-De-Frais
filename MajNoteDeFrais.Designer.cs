namespace WindowsFormsApp2
{
    partial class MajNoteDeFrais
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
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label discriptionLabel;
            System.Windows.Forms.Label transportLabel;
            System.Windows.Forms.Label carburantLabel;
            System.Windows.Forms.Label repasLabel;
            System.Windows.Forms.Label autresLabel;
            System.Windows.Forms.Label contrôleLabel;
            System.Windows.Forms.Label matricule_employerLabel;
            System.Windows.Forms.Label date_departLabel;
            System.Windows.Forms.Label date_arriverLabel;
            System.Windows.Forms.Label lieu_deplacementLabel;
            System.Windows.Forms.Label nom_EmployerLabel;
            System.Windows.Forms.Label telLabel;
            System.Windows.Forms.Label id_departementLabel;
            System.Windows.Forms.Label id_statutLabel;
            System.Windows.Forms.Label objetLabel1;
            System.Windows.Forms.Label totalLabel;
            System.Windows.Forms.Label id_intervenantLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MajNoteDeFrais));
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.discriptionTextBox = new System.Windows.Forms.TextBox();
            this.hotelTextBox = new System.Windows.Forms.TextBox();
            this.transportTextBox = new System.Windows.Forms.TextBox();
            this.carburantTextBox = new System.Windows.Forms.TextBox();
            this.repasTextBox = new System.Windows.Forms.TextBox();
            this.autresTextBox = new System.Windows.Forms.TextBox();
            this.contrôleTextBox = new System.Windows.Forms.TextBox();
            this.date_departDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.date_arriverDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lieu_deplacementTextBox = new System.Windows.Forms.TextBox();
            this.matricule_employerComboBox = new System.Windows.Forms.ComboBox();
            this.nom_EmployerLabel1 = new System.Windows.Forms.Label();
            this.prenom_EmployerLabel1 = new System.Windows.Forms.Label();
            this.id_departementLabel1 = new System.Windows.Forms.Label();
            this.id_statutLabel1 = new System.Windows.Forms.Label();
            this.telLabel2 = new System.Windows.Forms.Label();
            this.objetComboBox = new System.Windows.Forms.ComboBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.id_intervenantTextBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.notes_de_fraisDataSet = new WindowsFormsApp2.notes_de_fraisDataSet();
            this.memoire_fraisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.memoire_fraisTableAdapter = new WindowsFormsApp2.notes_de_fraisDataSetTableAdapters.Memoire_fraisTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp2.notes_de_fraisDataSetTableAdapters.TableAdapterManager();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            dateLabel = new System.Windows.Forms.Label();
            discriptionLabel = new System.Windows.Forms.Label();
            transportLabel = new System.Windows.Forms.Label();
            carburantLabel = new System.Windows.Forms.Label();
            repasLabel = new System.Windows.Forms.Label();
            autresLabel = new System.Windows.Forms.Label();
            contrôleLabel = new System.Windows.Forms.Label();
            matricule_employerLabel = new System.Windows.Forms.Label();
            date_departLabel = new System.Windows.Forms.Label();
            date_arriverLabel = new System.Windows.Forms.Label();
            lieu_deplacementLabel = new System.Windows.Forms.Label();
            nom_EmployerLabel = new System.Windows.Forms.Label();
            telLabel = new System.Windows.Forms.Label();
            id_departementLabel = new System.Windows.Forms.Label();
            id_statutLabel = new System.Windows.Forms.Label();
            objetLabel1 = new System.Windows.Forms.Label();
            totalLabel = new System.Windows.Forms.Label();
            id_intervenantLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notes_de_fraisDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoire_fraisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dateLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dateLabel.Location = new System.Drawing.Point(32, 50);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(55, 20);
            dateLabel.TabIndex = 1;
            dateLabel.Text = "Date:";
            // 
            // discriptionLabel
            // 
            discriptionLabel.AutoSize = true;
            discriptionLabel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            discriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            discriptionLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            discriptionLabel.Location = new System.Drawing.Point(32, 78);
            discriptionLabel.Name = "discriptionLabel";
            discriptionLabel.Size = new System.Drawing.Size(107, 20);
            discriptionLabel.TabIndex = 3;
            discriptionLabel.Text = "Discription:";
            // 
            // transportLabel
            // 
            transportLabel.AutoSize = true;
            transportLabel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            transportLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            transportLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            transportLabel.Location = new System.Drawing.Point(32, 134);
            transportLabel.Name = "transportLabel";
            transportLabel.Size = new System.Drawing.Size(96, 20);
            transportLabel.TabIndex = 7;
            transportLabel.Text = "Transport:";
            // 
            // carburantLabel
            // 
            carburantLabel.AutoSize = true;
            carburantLabel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            carburantLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            carburantLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            carburantLabel.Location = new System.Drawing.Point(32, 162);
            carburantLabel.Name = "carburantLabel";
            carburantLabel.Size = new System.Drawing.Size(98, 20);
            carburantLabel.TabIndex = 9;
            carburantLabel.Text = "Carburant:";
            // 
            // repasLabel
            // 
            repasLabel.AutoSize = true;
            repasLabel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            repasLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            repasLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            repasLabel.Location = new System.Drawing.Point(32, 190);
            repasLabel.Name = "repasLabel";
            repasLabel.Size = new System.Drawing.Size(68, 20);
            repasLabel.TabIndex = 11;
            repasLabel.Text = "Repas:";
            // 
            // autresLabel
            // 
            autresLabel.AutoSize = true;
            autresLabel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            autresLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            autresLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            autresLabel.Location = new System.Drawing.Point(32, 218);
            autresLabel.Name = "autresLabel";
            autresLabel.Size = new System.Drawing.Size(70, 20);
            autresLabel.TabIndex = 13;
            autresLabel.Text = "Autres:";
            // 
            // contrôleLabel
            // 
            contrôleLabel.AutoSize = true;
            contrôleLabel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            contrôleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contrôleLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            contrôleLabel.Location = new System.Drawing.Point(32, 274);
            contrôleLabel.Name = "contrôleLabel";
            contrôleLabel.Size = new System.Drawing.Size(86, 20);
            contrôleLabel.TabIndex = 17;
            contrôleLabel.Text = "Contrôle:";
            // 
            // matricule_employerLabel
            // 
            matricule_employerLabel.AutoSize = true;
            matricule_employerLabel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            matricule_employerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            matricule_employerLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            matricule_employerLabel.Location = new System.Drawing.Point(369, 49);
            matricule_employerLabel.Name = "matricule_employerLabel";
            matricule_employerLabel.Size = new System.Drawing.Size(175, 20);
            matricule_employerLabel.TabIndex = 19;
            matricule_employerLabel.Text = "matricule employer:";
            // 
            // date_departLabel
            // 
            date_departLabel.AutoSize = true;
            date_departLabel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            date_departLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            date_departLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            date_departLabel.Location = new System.Drawing.Point(388, 206);
            date_departLabel.Name = "date_departLabel";
            date_departLabel.Size = new System.Drawing.Size(110, 20);
            date_departLabel.TabIndex = 21;
            date_departLabel.Text = "date depart:";
            // 
            // date_arriverLabel
            // 
            date_arriverLabel.AutoSize = true;
            date_arriverLabel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            date_arriverLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            date_arriverLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            date_arriverLabel.Location = new System.Drawing.Point(388, 233);
            date_arriverLabel.Name = "date_arriverLabel";
            date_arriverLabel.Size = new System.Drawing.Size(112, 20);
            date_arriverLabel.TabIndex = 23;
            date_arriverLabel.Text = "date arriver:";
            // 
            // lieu_deplacementLabel
            // 
            lieu_deplacementLabel.AutoSize = true;
            lieu_deplacementLabel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            lieu_deplacementLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lieu_deplacementLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lieu_deplacementLabel.Location = new System.Drawing.Point(388, 263);
            lieu_deplacementLabel.Name = "lieu_deplacementLabel";
            lieu_deplacementLabel.Size = new System.Drawing.Size(157, 20);
            lieu_deplacementLabel.TabIndex = 25;
            lieu_deplacementLabel.Text = "lieu deplacement:";
            // 
            // nom_EmployerLabel
            // 
            nom_EmployerLabel.AutoSize = true;
            nom_EmployerLabel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            nom_EmployerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nom_EmployerLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            nom_EmployerLabel.Location = new System.Drawing.Point(396, 78);
            nom_EmployerLabel.Name = "nom_EmployerLabel";
            nom_EmployerLabel.Size = new System.Drawing.Size(137, 20);
            nom_EmployerLabel.TabIndex = 32;
            nom_EmployerLabel.Text = "Nom Employer:";
            // 
            // telLabel
            // 
            telLabel.AutoSize = true;
            telLabel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            telLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            telLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            telLabel.Location = new System.Drawing.Point(396, 158);
            telLabel.Name = "telLabel";
            telLabel.Size = new System.Drawing.Size(41, 20);
            telLabel.TabIndex = 38;
            telLabel.Text = "Tel:";
            // 
            // id_departementLabel
            // 
            id_departementLabel.AutoSize = true;
            id_departementLabel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            id_departementLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_departementLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            id_departementLabel.Location = new System.Drawing.Point(397, 102);
            id_departementLabel.Name = "id_departementLabel";
            id_departementLabel.Size = new System.Drawing.Size(140, 20);
            id_departementLabel.TabIndex = 40;
            id_departementLabel.Text = "id departement:";
            // 
            // id_statutLabel
            // 
            id_statutLabel.AutoSize = true;
            id_statutLabel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            id_statutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_statutLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            id_statutLabel.Location = new System.Drawing.Point(397, 128);
            id_statutLabel.Name = "id_statutLabel";
            id_statutLabel.Size = new System.Drawing.Size(84, 20);
            id_statutLabel.TabIndex = 42;
            id_statutLabel.Text = "id statut:";
            // 
            // objetLabel1
            // 
            objetLabel1.AutoSize = true;
            objetLabel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            objetLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            objetLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            objetLabel1.Location = new System.Drawing.Point(388, 297);
            objetLabel1.Name = "objetLabel1";
            objetLabel1.Size = new System.Drawing.Size(56, 20);
            objetLabel1.TabIndex = 46;
            objetLabel1.Text = "objet:";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            totalLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            totalLabel.Location = new System.Drawing.Point(32, 246);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new System.Drawing.Size(57, 20);
            totalLabel.TabIndex = 15;
            totalLabel.Text = "Total:";
            // 
            // id_intervenantLabel
            // 
            id_intervenantLabel.AutoSize = true;
            id_intervenantLabel.Location = new System.Drawing.Point(544, 187);
            id_intervenantLabel.Name = "id_intervenantLabel";
            id_intervenantLabel.Size = new System.Drawing.Size(89, 16);
            id_intervenantLabel.TabIndex = 54;
            id_intervenantLabel.Text = "id intervenant:";
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.Location = new System.Drawing.Point(163, 47);
            this.dateDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dateDateTimePicker.TabIndex = 2;
            // 
            // discriptionTextBox
            // 
            this.discriptionTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.discriptionTextBox.Location = new System.Drawing.Point(163, 75);
            this.discriptionTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.discriptionTextBox.Name = "discriptionTextBox";
            this.discriptionTextBox.Size = new System.Drawing.Size(200, 22);
            this.discriptionTextBox.TabIndex = 4;
            // 
            // hotelTextBox
            // 
            this.hotelTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.hotelTextBox.Location = new System.Drawing.Point(163, 103);
            this.hotelTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hotelTextBox.Name = "hotelTextBox";
            this.hotelTextBox.Size = new System.Drawing.Size(200, 22);
            this.hotelTextBox.TabIndex = 6;
            // 
            // transportTextBox
            // 
            this.transportTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.transportTextBox.Location = new System.Drawing.Point(163, 130);
            this.transportTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.transportTextBox.Name = "transportTextBox";
            this.transportTextBox.Size = new System.Drawing.Size(200, 22);
            this.transportTextBox.TabIndex = 8;
            this.transportTextBox.TextChanged += new System.EventHandler(this.transportTextBox_TextChanged);
            // 
            // carburantTextBox
            // 
            this.carburantTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.carburantTextBox.Location = new System.Drawing.Point(163, 159);
            this.carburantTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.carburantTextBox.Name = "carburantTextBox";
            this.carburantTextBox.Size = new System.Drawing.Size(200, 22);
            this.carburantTextBox.TabIndex = 10;
            // 
            // repasTextBox
            // 
            this.repasTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.repasTextBox.Location = new System.Drawing.Point(163, 187);
            this.repasTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.repasTextBox.Name = "repasTextBox";
            this.repasTextBox.Size = new System.Drawing.Size(200, 22);
            this.repasTextBox.TabIndex = 12;
            // 
            // autresTextBox
            // 
            this.autresTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.autresTextBox.Location = new System.Drawing.Point(163, 215);
            this.autresTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.autresTextBox.Name = "autresTextBox";
            this.autresTextBox.Size = new System.Drawing.Size(200, 22);
            this.autresTextBox.TabIndex = 14;
            // 
            // contrôleTextBox
            // 
            this.contrôleTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.contrôleTextBox.Location = new System.Drawing.Point(163, 271);
            this.contrôleTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.contrôleTextBox.Name = "contrôleTextBox";
            this.contrôleTextBox.Size = new System.Drawing.Size(200, 22);
            this.contrôleTextBox.TabIndex = 18;
            // 
            // date_departDateTimePicker
            // 
            this.date_departDateTimePicker.CalendarMonthBackground = System.Drawing.SystemColors.InactiveBorder;
            this.date_departDateTimePicker.Location = new System.Drawing.Point(557, 213);
            this.date_departDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.date_departDateTimePicker.Name = "date_departDateTimePicker";
            this.date_departDateTimePicker.Size = new System.Drawing.Size(177, 22);
            this.date_departDateTimePicker.TabIndex = 22;
            // 
            // date_arriverDateTimePicker
            // 
            this.date_arriverDateTimePicker.CalendarMonthBackground = System.Drawing.SystemColors.InactiveBorder;
            this.date_arriverDateTimePicker.Location = new System.Drawing.Point(557, 233);
            this.date_arriverDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.date_arriverDateTimePicker.Name = "date_arriverDateTimePicker";
            this.date_arriverDateTimePicker.Size = new System.Drawing.Size(177, 22);
            this.date_arriverDateTimePicker.TabIndex = 24;
            this.date_arriverDateTimePicker.ValueChanged += new System.EventHandler(this.date_arriverDateTimePicker_ValueChanged);
            // 
            // lieu_deplacementTextBox
            // 
            this.lieu_deplacementTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lieu_deplacementTextBox.Location = new System.Drawing.Point(557, 260);
            this.lieu_deplacementTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lieu_deplacementTextBox.Name = "lieu_deplacementTextBox";
            this.lieu_deplacementTextBox.Size = new System.Drawing.Size(177, 22);
            this.lieu_deplacementTextBox.TabIndex = 26;
            // 
            // matricule_employerComboBox
            // 
            this.matricule_employerComboBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.matricule_employerComboBox.FormattingEnabled = true;
            this.matricule_employerComboBox.Location = new System.Drawing.Point(561, 45);
            this.matricule_employerComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.matricule_employerComboBox.Name = "matricule_employerComboBox";
            this.matricule_employerComboBox.Size = new System.Drawing.Size(172, 24);
            this.matricule_employerComboBox.TabIndex = 29;
            this.matricule_employerComboBox.ValueMember = "matricule_Employer";
            this.matricule_employerComboBox.SelectedIndexChanged += new System.EventHandler(this.matricule_employerComboBox_SelectedIndexChanged);
            // 
            // nom_EmployerLabel1
            // 
            this.nom_EmployerLabel1.Location = new System.Drawing.Point(559, 77);
            this.nom_EmployerLabel1.Name = "nom_EmployerLabel1";
            this.nom_EmployerLabel1.Size = new System.Drawing.Size(97, 23);
            this.nom_EmployerLabel1.TabIndex = 33;
            this.nom_EmployerLabel1.Text = "label1";
            // 
            // prenom_EmployerLabel1
            // 
            this.prenom_EmployerLabel1.Location = new System.Drawing.Point(661, 77);
            this.prenom_EmployerLabel1.Name = "prenom_EmployerLabel1";
            this.prenom_EmployerLabel1.Size = new System.Drawing.Size(200, 23);
            this.prenom_EmployerLabel1.TabIndex = 35;
            this.prenom_EmployerLabel1.Text = "label1";
            this.prenom_EmployerLabel1.Click += new System.EventHandler(this.prenom_EmployerLabel1_Click);
            // 
            // id_departementLabel1
            // 
            this.id_departementLabel1.Location = new System.Drawing.Point(559, 100);
            this.id_departementLabel1.Name = "id_departementLabel1";
            this.id_departementLabel1.Size = new System.Drawing.Size(200, 23);
            this.id_departementLabel1.TabIndex = 41;
            this.id_departementLabel1.Text = "label1";
            this.id_departementLabel1.Click += new System.EventHandler(this.id_departementLabel1_Click);
            // 
            // id_statutLabel1
            // 
            this.id_statutLabel1.Location = new System.Drawing.Point(559, 126);
            this.id_statutLabel1.Name = "id_statutLabel1";
            this.id_statutLabel1.Size = new System.Drawing.Size(200, 23);
            this.id_statutLabel1.TabIndex = 43;
            this.id_statutLabel1.Text = "label1";
            // 
            // telLabel2
            // 
            this.telLabel2.Location = new System.Drawing.Point(559, 157);
            this.telLabel2.Name = "telLabel2";
            this.telLabel2.Size = new System.Drawing.Size(100, 23);
            this.telLabel2.TabIndex = 44;
            this.telLabel2.Text = "label1";
            // 
            // objetComboBox
            // 
            this.objetComboBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.objetComboBox.FormattingEnabled = true;
            this.objetComboBox.Location = new System.Drawing.Point(557, 292);
            this.objetComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.objetComboBox.Name = "objetComboBox";
            this.objetComboBox.Size = new System.Drawing.Size(177, 24);
            this.objetComboBox.TabIndex = 47;
            this.objetComboBox.ValueMember = "id_objet";
            this.objetComboBox.SelectedIndexChanged += new System.EventHandler(this.objetComboBox_SelectedIndexChanged);
            // 
            // totalTextBox
            // 
            this.totalTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.totalTextBox.Location = new System.Drawing.Point(163, 242);
            this.totalTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(200, 22);
            this.totalTextBox.TabIndex = 16;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.InactiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(12, 408);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1912, 264);
            this.dataGridView1.TabIndex = 49;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(163, 340);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 48);
            this.button1.TabIndex = 51;
            this.button1.Text = "generer order_mission";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(12, 340);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 48);
            this.button2.TabIndex = 52;
            this.button2.Text = "gernerer activité";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(36, 102);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(88, 24);
            this.checkBox1.TabIndex = 54;
            this.checkBox1.Text = "Hotel :";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // id_intervenantTextBox
            // 
            this.id_intervenantTextBox.Location = new System.Drawing.Point(648, 182);
            this.id_intervenantTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.id_intervenantTextBox.Name = "id_intervenantTextBox";
            this.id_intervenantTextBox.Size = new System.Drawing.Size(100, 22);
            this.id_intervenantTextBox.TabIndex = 55;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Crimson;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(322, 340);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 48);
            this.button3.TabIndex = 57;
            this.button3.Text = "chercher_fichier";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Crimson;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(482, 340);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(151, 48);
            this.button4.TabIndex = 58;
            this.button4.Text = "Afficher_fichier";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // notes_de_fraisDataSet
            // 
            this.notes_de_fraisDataSet.DataSetName = "notes_de_fraisDataSet";
            this.notes_de_fraisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // memoire_fraisBindingSource
            // 
            this.memoire_fraisBindingSource.DataMember = "Memoire_frais";
            this.memoire_fraisBindingSource.DataSource = this.notes_de_fraisDataSet;
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
            this.tableAdapterManager.Rapport_activitéTableAdapter = null;
            this.tableAdapterManager.statusTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp2.notes_de_fraisDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.memoire_fraisBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1924, 29);
            this.bindingNavigator1.TabIndex = 59;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Placer en premier";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Déplacer vers le haut";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Position actuelle";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 20);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Nombre total d\'éléments";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Déplacer vers le bas";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Placer en dernier";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Ajouter nouveau";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Supprimer";
            // 
            // MajNoteDeFrais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1924, 809);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(id_intervenantLabel);
            this.Controls.Add(this.id_intervenantTextBox);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(objetLabel1);
            this.Controls.Add(this.objetComboBox);
            this.Controls.Add(this.telLabel2);
            this.Controls.Add(nom_EmployerLabel);
            this.Controls.Add(this.nom_EmployerLabel1);
            this.Controls.Add(this.prenom_EmployerLabel1);
            this.Controls.Add(telLabel);
            this.Controls.Add(id_departementLabel);
            this.Controls.Add(this.id_departementLabel1);
            this.Controls.Add(id_statutLabel);
            this.Controls.Add(this.id_statutLabel1);
            this.Controls.Add(this.matricule_employerComboBox);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateDateTimePicker);
            this.Controls.Add(discriptionLabel);
            this.Controls.Add(this.discriptionTextBox);
            this.Controls.Add(this.hotelTextBox);
            this.Controls.Add(transportLabel);
            this.Controls.Add(this.transportTextBox);
            this.Controls.Add(carburantLabel);
            this.Controls.Add(this.carburantTextBox);
            this.Controls.Add(repasLabel);
            this.Controls.Add(this.repasTextBox);
            this.Controls.Add(autresLabel);
            this.Controls.Add(this.autresTextBox);
            this.Controls.Add(totalLabel);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(contrôleLabel);
            this.Controls.Add(this.contrôleTextBox);
            this.Controls.Add(matricule_employerLabel);
            this.Controls.Add(date_departLabel);
            this.Controls.Add(this.date_departDateTimePicker);
            this.Controls.Add(date_arriverLabel);
            this.Controls.Add(this.date_arriverDateTimePicker);
            this.Controls.Add(lieu_deplacementLabel);
            this.Controls.Add(this.lieu_deplacementTextBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MajNoteDeFrais";
            this.Text = "MajNoteDeFrais";
            this.Load += new System.EventHandler(this.MajNoteDeFrais_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notes_de_fraisDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoire_fraisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.TextBox discriptionTextBox;
        private System.Windows.Forms.TextBox hotelTextBox;
        private System.Windows.Forms.TextBox transportTextBox;
        private System.Windows.Forms.TextBox carburantTextBox;
        private System.Windows.Forms.TextBox repasTextBox;
        private System.Windows.Forms.TextBox autresTextBox;
        private System.Windows.Forms.TextBox contrôleTextBox;
        private System.Windows.Forms.DateTimePicker date_departDateTimePicker;
        private System.Windows.Forms.DateTimePicker date_arriverDateTimePicker;
        private System.Windows.Forms.TextBox lieu_deplacementTextBox;
        private System.Windows.Forms.ComboBox matricule_employerComboBox;
        private System.Windows.Forms.Label nom_EmployerLabel1;
        private System.Windows.Forms.Label prenom_EmployerLabel1;
        private System.Windows.Forms.Label id_departementLabel1;
        private System.Windows.Forms.Label id_statutLabel1;
        private System.Windows.Forms.Label telLabel2;
        private System.Windows.Forms.ComboBox objetComboBox;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        //private System.Windows.Forms.Label hotel;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox id_intervenantTextBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private notes_de_fraisDataSet notes_de_fraisDataSet;
        private System.Windows.Forms.BindingSource memoire_fraisBindingSource;
        private notes_de_fraisDataSetTableAdapters.Memoire_fraisTableAdapter memoire_fraisTableAdapter;
        private notes_de_fraisDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
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
    }
}