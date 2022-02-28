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
    public partial class Fproduit : Form
    {
        public Fproduit()
        {
            InitializeComponent();
        }
        Produit P;
        public void actualiser()
        {
            Tdesignation.Clear();
            Tpu.Clear();
            Tstock.Clear();
              P = new Produit(Form1.ma_con);
              dataGridView1.DataSource = P.lister(); 
            Lvaleur .Text ="La valeur du Stock est : "+P.Valeur_Stock_Globale().ToString ().Replace (",",".");
              
        }

        private void Fproduit_Load(object sender, EventArgs e)
        {
            actualiser();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Tdesignation.Text == "")
            {
                MessageBox.Show("Erreur de données ", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
             try
                {
                    P = new Produit(Form1.ma_con, Tdesignation.Text);
                    P.Supprimer_un_produit();
                    actualiser();
                    MessageBox.Show("Suppression effectuée ");
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  
                }
          
        }

        private void Bajout_Click(object sender, EventArgs e)
        {
            if (Tdesignation.Text == "" || Tpu.Text == "" || Tstock.Text == "")
            {
                MessageBox.Show("Erreur de données ", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {              
                try
                {
                    // il faut remplacer . par , pour la conversion
                    Double prix = Convert.ToDouble(Tpu.Text.Replace (".",","));
                  
                    int stock = Convert.ToInt16(Tstock.Text);
                   
                    P = new Produit(Form1.ma_con, Tdesignation.Text, prix , stock);
                    P.Ajouter_un_produit();
                    actualiser();
                    MessageBox.Show("Ajout effectué ");
                 
                }catch(Exception x)
                {
                    MessageBox.Show(x.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                          
                }
            }
            catch (FormatException f)
            {
                MessageBox.Show("Erreur de données \n" + f.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
             
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            actualiser();
        }

        private void Bmodifier_Click(object sender, EventArgs e)
        {
            if (Tdesignation.Text == "" || Tpu.Text == "" || Tstock.Text == "")
            {
                MessageBox.Show("Erreur de données ", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                
                try
                {
                    // il faut remplacer . par , pour la conversion
                    Double prix = Convert.ToDouble(Tpu.Text.Replace(".", ","));               
                    int stock = Convert.ToInt16(Tstock.Text);
                    P = new Produit(Form1.ma_con, Tdesignation.Text, prix, stock);
                    P.Modifier_un_produit();
                    MessageBox.Show("Modification effectuée ");
                 
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  
                }
            }
            catch (FormatException f)
            {
                MessageBox.Show("Erreur de données \n" + f.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
        }

        private void Rdésignation_TextChanged(object sender, EventArgs e)
        {
            P = new Produit(Form1.ma_con);
            dataGridView1.DataSource = P.Rechercher_par_désignation(Rdésignation.Text);
        }

        private void Rprix1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                Rprix2.Select();
        }

        private void Rprix2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                try
                {
                    Double prix1 = Convert.ToDouble(Rprix1.Text.Replace(".", ","));
                    Double prix2 = Convert.ToDouble(Rprix2.Text.Replace(".", ","));
                    P = new Produit(Form1.ma_con);
                    dataGridView1.DataSource = P.Rechercher_par_prix(prix1, prix2);
                }
                catch (FormatException  x)
                {
                    MessageBox.Show(x.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   
                }
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            Tdesignation.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            Tpu.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            Tstock.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void Tdesignation_Leave(object sender, EventArgs e)
        {
            Tdesignation.Text = Tdesignation.Text.Replace("'", "`");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Fetat_Produit f = new Fetat_Produit();
            f.MdiParent = this.MdiParent;
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
