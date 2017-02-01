namespace DatabaseManager
{
    partial class frmDatabaseManager
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.tsOuvrirBdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSep = new System.Windows.Forms.ToolStripSeparator();
            this.tsQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsLblBddEnCours = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlContenu = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbTable = new System.Windows.Forms.ComboBox();
            this.lblTable = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.pnlContenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsFichier});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(805, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsFichier
            // 
            this.tsFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsOuvrirBdd,
            this.tsSep,
            this.tsQuitter});
            this.tsFichier.Name = "tsFichier";
            this.tsFichier.Size = new System.Drawing.Size(54, 22);
            this.tsFichier.Text = "&Fichier";
            // 
            // tsOuvrirBdd
            // 
            this.tsOuvrirBdd.Name = "tsOuvrirBdd";
            this.tsOuvrirBdd.Size = new System.Drawing.Size(163, 22);
            this.tsOuvrirBdd.Text = "&Ouvrir une bdd...";
            this.tsOuvrirBdd.Click += new System.EventHandler(this.tsOuvrirBdd_Click);
            // 
            // tsSep
            // 
            this.tsSep.Name = "tsSep";
            this.tsSep.Size = new System.Drawing.Size(160, 6);
            // 
            // tsQuitter
            // 
            this.tsQuitter.Name = "tsQuitter";
            this.tsQuitter.Size = new System.Drawing.Size(163, 22);
            this.tsQuitter.Text = "&Quitter";
            this.tsQuitter.Click += new System.EventHandler(this.tsQuitter_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLblBddEnCours});
            this.statusStrip1.Location = new System.Drawing.Point(0, 521);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 7, 0);
            this.statusStrip1.Size = new System.Drawing.Size(805, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsLblBddEnCours
            // 
            this.tsLblBddEnCours.Name = "tsLblBddEnCours";
            this.tsLblBddEnCours.Size = new System.Drawing.Size(213, 17);
            this.tsLblBddEnCours.Text = "Aucune base de données n\'est ouverte.";
            // 
            // pnlContenu
            // 
            this.pnlContenu.Controls.Add(this.dataGridView1);
            this.pnlContenu.Controls.Add(this.cbTable);
            this.pnlContenu.Controls.Add(this.lblTable);
            this.pnlContenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenu.Enabled = false;
            this.pnlContenu.Location = new System.Drawing.Point(0, 24);
            this.pnlContenu.Margin = new System.Windows.Forms.Padding(2);
            this.pnlContenu.Name = "pnlContenu";
            this.pnlContenu.Size = new System.Drawing.Size(805, 497);
            this.pnlContenu.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(798, 453);
            this.dataGridView1.TabIndex = 3;
            // 
            // cbTable
            // 
            this.cbTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTable.FormattingEnabled = true;
            this.cbTable.Location = new System.Drawing.Point(168, 15);
            this.cbTable.Margin = new System.Windows.Forms.Padding(2);
            this.cbTable.Name = "cbTable";
            this.cbTable.Size = new System.Drawing.Size(633, 21);
            this.cbTable.TabIndex = 0;
            this.cbTable.SelectedIndexChanged += new System.EventHandler(this.cbTable_SelectedIndexChanged);
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Location = new System.Drawing.Point(6, 16);
            this.lblTable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(156, 13);
            this.lblTable.TabIndex = 2;
            this.lblTable.Text = "Veuillez sélectionner une table :";
            // 
            // frmDatabaseManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 543);
            this.Controls.Add(this.pnlContenu);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDatabaseManager";
            this.ShowIcon = false;
            this.Text = "Database manager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.pnlContenu.ResumeLayout(false);
            this.pnlContenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsFichier;
        private System.Windows.Forms.ToolStripMenuItem tsOuvrirBdd;
        private System.Windows.Forms.ToolStripSeparator tsSep;
        private System.Windows.Forms.ToolStripMenuItem tsQuitter;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsLblBddEnCours;
        private System.Windows.Forms.Panel pnlContenu;
        private System.Windows.Forms.ComboBox cbTable;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

