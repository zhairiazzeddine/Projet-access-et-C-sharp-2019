using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Projet_access_103
{
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;

        public MDIParent1()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Fenêtre " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

      
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void produitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fproduit f = new Fproduit();
            f.MdiParent = this;
            f.Show();
        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fclient f = new Fclient();
            f.MdiParent = this;
            f.Show();
        }

        private void venteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fvente f = new Fvente();
            f.MdiParent = this;
            f.Show();
        }

        private void produitVenduToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fproduit_Vendu f = new Fproduit_Vendu();
            f.MdiParent = this;
            f.Show();
        }

        private void situationDuStockToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Fsituation_Stock f = new Fsituation_Stock();
            f.MdiParent = this;
            f.Show();
        }

        private void ventesClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Fvente_client f = new Fvente_client();
            f.MdiParent = this;
            f.Show();
        }

        private void statistiqueDesVentesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Fstatistique_vente f = new Fstatistique_vente();
            f.MdiParent = this;
            f.Show();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
