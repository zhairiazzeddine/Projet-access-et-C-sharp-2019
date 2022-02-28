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
    public partial class Fstatistique_vente : Form
    {
        public Fstatistique_vente()
        {
            InitializeComponent();
        }
        public static String Année;
        private void Tannée_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Form1.ma_con.Executer_Liste("select libellé_mois,entrés,sorties,(entrés-sorties) as valeur from Requête_situation_vente where année=" + Tannée.Text + "");
                dataGridView1.DataSource = Form1.ma_con.Tb;
          
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Fstatistique_vente_Load(object sender, EventArgs e)
        {
            Tannée.Text = DateTime.Today.Year.ToString();
        }

        private void Tannée_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Année = Tannée.Text;
            Fgraphique f = new Fgraphique();
            f.MdiParent = this.MdiParent;
            f.Show();
        }
    }
}
