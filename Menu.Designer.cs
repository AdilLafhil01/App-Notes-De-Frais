namespace WindowsFormsApp2
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.connexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deconnecterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statutsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memoireDeFraisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rapportDactivitéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notesDeFrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importPDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connexionToolStripMenuItem,
            this.memoireDeFraisToolStripMenuItem,
            this.rapportDactivitéToolStripMenuItem,
            this.notesDeFrToolStripMenuItem,
            this.importFileToolStripMenuItem,
            this.importPDFToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(13, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1924, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // connexionToolStripMenuItem
            // 
            this.connexionToolStripMenuItem.BackColor = System.Drawing.Color.MistyRose;
            this.connexionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deconnecterToolStripMenuItem,
            this.statutsToolStripMenuItem,
            this.employerToolStripMenuItem,
            this.departementToolStripMenuItem});
            this.connexionToolStripMenuItem.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connexionToolStripMenuItem.ForeColor = System.Drawing.SystemColors.InfoText;
            this.connexionToolStripMenuItem.Name = "connexionToolStripMenuItem";
            this.connexionToolStripMenuItem.Padding = new System.Windows.Forms.Padding(80, 0, 80, 0);
            this.connexionToolStripMenuItem.Size = new System.Drawing.Size(240, 30);
            this.connexionToolStripMenuItem.Text = "Fichier";
            this.connexionToolStripMenuItem.Click += new System.EventHandler(this.connexionToolStripMenuItem_Click);
            // 
            // deconnecterToolStripMenuItem
            // 
            this.deconnecterToolStripMenuItem.Name = "deconnecterToolStripMenuItem";
            this.deconnecterToolStripMenuItem.Size = new System.Drawing.Size(225, 30);
            this.deconnecterToolStripMenuItem.Text = "Deconnecter";
            this.deconnecterToolStripMenuItem.Click += new System.EventHandler(this.deconnecterToolStripMenuItem_Click);
            // 
            // statutsToolStripMenuItem
            // 
            this.statutsToolStripMenuItem.Name = "statutsToolStripMenuItem";
            this.statutsToolStripMenuItem.Size = new System.Drawing.Size(225, 30);
            this.statutsToolStripMenuItem.Text = "Statuts";
            this.statutsToolStripMenuItem.Click += new System.EventHandler(this.statutsToolStripMenuItem_Click);
            // 
            // employerToolStripMenuItem
            // 
            this.employerToolStripMenuItem.Name = "employerToolStripMenuItem";
            this.employerToolStripMenuItem.Size = new System.Drawing.Size(225, 30);
            this.employerToolStripMenuItem.Text = "Employer";
            this.employerToolStripMenuItem.Click += new System.EventHandler(this.employerToolStripMenuItem_Click);
            // 
            // departementToolStripMenuItem
            // 
            this.departementToolStripMenuItem.Name = "departementToolStripMenuItem";
            this.departementToolStripMenuItem.Size = new System.Drawing.Size(225, 30);
            this.departementToolStripMenuItem.Text = "Departement";
            this.departementToolStripMenuItem.Click += new System.EventHandler(this.departementToolStripMenuItem_Click);
            // 
            // memoireDeFraisToolStripMenuItem
            // 
            this.memoireDeFraisToolStripMenuItem.BackColor = System.Drawing.Color.MistyRose;
            this.memoireDeFraisToolStripMenuItem.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memoireDeFraisToolStripMenuItem.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.memoireDeFraisToolStripMenuItem.Name = "memoireDeFraisToolStripMenuItem";
            this.memoireDeFraisToolStripMenuItem.Padding = new System.Windows.Forms.Padding(80, 0, 80, 0);
            this.memoireDeFraisToolStripMenuItem.Size = new System.Drawing.Size(333, 30);
            this.memoireDeFraisToolStripMenuItem.Text = "Memoire de frais";
            this.memoireDeFraisToolStripMenuItem.Click += new System.EventHandler(this.memoireDeFraisToolStripMenuItem_Click);
            this.memoireDeFraisToolStripMenuItem.EnabledChanged += new System.EventHandler(this.memoireDeFraisToolStripMenuItem_Click);
            // 
            // rapportDactivitéToolStripMenuItem
            // 
            this.rapportDactivitéToolStripMenuItem.BackColor = System.Drawing.Color.MistyRose;
            this.rapportDactivitéToolStripMenuItem.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rapportDactivitéToolStripMenuItem.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.rapportDactivitéToolStripMenuItem.Name = "rapportDactivitéToolStripMenuItem";
            this.rapportDactivitéToolStripMenuItem.Padding = new System.Windows.Forms.Padding(80, 0, 80, 0);
            this.rapportDactivitéToolStripMenuItem.Size = new System.Drawing.Size(349, 30);
            this.rapportDactivitéToolStripMenuItem.Text = "Rapport d\'activité";
            this.rapportDactivitéToolStripMenuItem.Click += new System.EventHandler(this.rapportDactivitéToolStripMenuItem_Click);
            // 
            // notesDeFrToolStripMenuItem
            // 
            this.notesDeFrToolStripMenuItem.BackColor = System.Drawing.Color.MistyRose;
            this.notesDeFrToolStripMenuItem.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notesDeFrToolStripMenuItem.ForeColor = System.Drawing.SystemColors.MenuText;
            this.notesDeFrToolStripMenuItem.Name = "notesDeFrToolStripMenuItem";
            this.notesDeFrToolStripMenuItem.Padding = new System.Windows.Forms.Padding(60, 0, 60, 0);
            this.notesDeFrToolStripMenuItem.Size = new System.Drawing.Size(316, 30);
            this.notesDeFrToolStripMenuItem.Text = "MAJ Notes De Frais";
            this.notesDeFrToolStripMenuItem.Click += new System.EventHandler(this.notesDeFrToolStripMenuItem_Click);
            // 
            // importFileToolStripMenuItem
            // 
            this.importFileToolStripMenuItem.BackColor = System.Drawing.Color.MistyRose;
            this.importFileToolStripMenuItem.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importFileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.importFileToolStripMenuItem.Name = "importFileToolStripMenuItem";
            this.importFileToolStripMenuItem.Padding = new System.Windows.Forms.Padding(80, 0, 80, 0);
            this.importFileToolStripMenuItem.Size = new System.Drawing.Size(281, 30);
            this.importFileToolStripMenuItem.Text = "Import File";
            this.importFileToolStripMenuItem.Click += new System.EventHandler(this.importFileToolStripMenuItem_Click);
            // 
            // importPDFToolStripMenuItem
            // 
            this.importPDFToolStripMenuItem.BackColor = System.Drawing.Color.MistyRose;
            this.importPDFToolStripMenuItem.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importPDFToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.importPDFToolStripMenuItem.Name = "importPDFToolStripMenuItem";
            this.importPDFToolStripMenuItem.Size = new System.Drawing.Size(137, 30);
            this.importPDFToolStripMenuItem.Text = "Import PDF";
            this.importPDFToolStripMenuItem.Click += new System.EventHandler(this.importPDFToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(14, 30);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 866);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Menu";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ToolStripMenuItem connexionToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem memoireDeFraisToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem rapportDactivitéToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem notesDeFrToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem importFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deconnecterToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem importPDFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statutsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}