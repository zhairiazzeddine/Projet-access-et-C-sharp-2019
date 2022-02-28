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
    public partial class Fproduit_Vendu : Form
    {
        public Fproduit_Vendu()
        {
            InitializeComponent();
        }

        Vente V;
        Produit  P;
        Produit_Vendu PV;
        public void actualiser()
        {
            Tproduit.Clear();
            Tqté.Clear();
            Lpu.Text = "";
       
            if (Fvente.Numéro_vente != null)
                   Lnvente.Text = Fvente.Numéro_vente;
             else
                Lnvente.Text = listBox1.Text;
        
            V = new Vente(Form1.ma_con, Convert.ToInt16(Lnvente.Text));
            Ldate.Text = V.Rechercher_Date_Vente().ToShortDateString();
            Lclient.Text = V.Rechercher_Client_Vente();
            PV = new Produit_Vendu(Form1.ma_con, V);
            dataGridView1.DataSource = PV.Liste_produits_vendu_pour_une_vente();
            Lnet.Text = PV.Net_une_vente().ToString();
        }


        private void Fproduit_Vendu_Load(object sender, EventArgs e)
        {
            // remplir listbox
            V = new Vente(Form1.ma_con);
            listBox1.DataSource = V.lister();
            listBox1.DisplayMember = "Nvente";

            //remplir le combo box
            P = new Produit(Form1.ma_con);
            listBox2.DataSource = P.lister();
            listBox2.DisplayMember = "Désignation";//definir la colonne à afficher

            
                actualiser();
            
        }

     

        private void Tproduit_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            try
            {
                actualiser();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void Tproduit_Click(object sender, EventArgs e)
        {
          
        }

        

        private void listBox2_Click(object sender, EventArgs e)
        {   
                    Tproduit.Text = listBox2.Text;
                    P = new Produit(Form1.ma_con, Tproduit.Text);
                   Lpu.Text = P.Rechercher_Prix_par_désignation().ToString();
                   Lstock.Text = P.Rechercher_Stock_par_désignation().ToString();
                   Tqté.Focus();
            }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Bajout_Click(object sender, EventArgs e)
        {
            if (Tproduit.Text == "" || Tqté.Text == "")
            {
                MessageBox.Show("Erreur de données ");
                return;
            }
            try
            {
                try
                {
                    int qté=Convert .ToInt16 (Tqté.Text );
                    Double prix=Convert.ToDouble (Lpu .Text );
                    int stock =Convert .ToInt16 (Lstock .Text );
                    P = new Produit(Form1.ma_con, Tproduit.Text,prix,stock);
                    V = new Vente(Form1.ma_con, Convert.ToInt16(Lnvente.Text),Convert .ToDateTime (Ldate.Text ));
                    PV = new Produit_Vendu(Form1.ma_con, P, V, qté);
                    PV.Ajouter_un_produit_a_une_vente();
                    actualiser();
                    MessageBox.Show("Ajout effectuéé");
                }
                catch (FormatException f)
                {
                    MessageBox.Show(f.Message);
                }

            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //supprimer un produit d'une vente
            if (Tproduit.Text == "" || Tqté.Text == "")
            {
                MessageBox.Show("Erreur de données ");
                return;
            }
            try
            {
                 try
                {
                    int qté=Convert .ToInt16 (Tqté.Text );
                     
                    P = new Produit(Form1.ma_con, Tproduit.Text);
                    V = new Vente(Form1.ma_con, Convert.ToInt16(Lnvente.Text));
                    PV = new Produit_Vendu(Form1.ma_con, P, V, qté);
                    PV.Supprimer_un_produit_d_une_vente();
                    actualiser();
                    MessageBox.Show("Le produit a été supprimé de la venteé");
                }
                 catch (FormatException f)
                 {
                     MessageBox.Show(f.Message);
                 }

            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            Tproduit.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            Tqté.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
             Lpu.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        }
        
    
}
