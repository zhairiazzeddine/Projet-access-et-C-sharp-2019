namespace Projet_access_103
{
    partial class MDIParent1
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
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opérationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.venteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produitVenduToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.situationDuStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statistiqueDesVentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventesClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.opérationsToolStripMenuItem,
            this.editionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1306, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produitToolStripMenuItem,
            this.clientToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // produitToolStripMenuItem
            // 
            this.produitToolStripMenuItem.Name = "produitToolStripMenuItem";
            this.produitToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.produitToolStripMenuItem.Text = "Produit";
            this.produitToolStripMenuItem.Click += new System.EventHandler(this.produitToolStripMenuItem_Click);
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.clientToolStripMenuItem.Text = "Client";
            this.clientToolStripMenuItem.Click += new System.EventHandler(this.clientToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // opérationsToolStripMenuItem
            // 
            this.opérationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.venteToolStripMenuItem,
            this.produitVenduToolStripMenuItem});
            this.opérationsToolStripMenuItem.Name = "opérationsToolStripMenuItem";
            this.opérationsToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.opérationsToolStripMenuItem.Text = "Opérations";
            // 
            // venteToolStripMenuItem
            // 
            this.venteToolStripMenuItem.Name = "venteToolStripMenuItem";
            this.venteToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.venteToolStripMenuItem.Text = "Vente";
            this.venteToolStripMenuItem.Click += new System.EventHandler(this.venteToolStripMenuItem_Click);
            // 
            // produitVenduToolStripMenuItem
            // 
            this.produitVenduToolStripMenuItem.Name = "produitVenduToolStripMenuItem";
            this.produitVenduToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.produitVenduToolStripMenuItem.Text = "Produit vendu";
            this.produitVenduToolStripMenuItem.Click += new System.EventHandler(this.produitVenduToolStripMenuItem_Click);
            // 
            // editionsToolStripMenuItem
            // 
            this.editionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.situationDuStockToolStripMenuItem,
            this.statistiqueDesVentesToolStripMenuItem,
            this.ventesClientsToolStripMenuItem});
            this.editionsToolStripMenuItem.Name = "editionsToolStripMenuItem";
            this.editionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.editionsToolStripMenuItem.Text = "Editions";
            // 
            // situationDuStockToolStripMenuItem
            // 
            this.situationDuStockToolStripMenuItem.Name = "situationDuStockToolStripMenuItem";
            this.situationDuStockToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.situationDuStockToolStripMenuItem.Text = "Situation du Stock";
            this.situationDuStockToolStripMenuItem.Click += new System.EventHandler(this.situationDuStockToolStripMenuItem_Click);
            // 
            // statistiqueDesVentesToolStripMenuItem
            // 
            this.statistiqueDesVentesToolStripMenuItem.Name = "statistiqueDesVentesToolStripMenuItem";
            this.statistiqueDesVentesToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.statistiqueDesVentesToolStripMenuItem.Text = "Statistique des ventes";
            this.statistiqueDesVentesToolStripMenuItem.Click += new System.EventHandler(this.statistiqueDesVentesToolStripMenuItem_Click);
            // 
            // ventesClientsToolStripMenuItem
            // 
            this.ventesClientsToolStripMenuItem.Name = "ventesClientsToolStripMenuItem";
            this.ventesClientsToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.ventesClientsToolStripMenuItem.Text = "Ventes/Clients";
            this.ventesClientsToolStripMenuItem.Click += new System.EventHandler(this.ventesClientsToolStripMenuItem_Click);
            // 
            // MDIParent1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 453);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "MDIParent1";
            this.Text = "MDIParent1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opérationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem venteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produitVenduToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem situationDuStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statistiqueDesVentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventesClientsToolStripMenuItem;

    }
}



