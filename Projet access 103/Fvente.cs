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
    public partial class Fvente : Form
    {
        public Fvente()
        {
            InitializeComponent();
        }
        public static String Numéro_vente;
        Vente V;
        Client C;
        public void actualiser()
        {
            // incrementer le compteur
            V = new Vente(Form1.ma_con);
            Lnvente.Text = V.Numvente().ToString();
            //afficher la date 
            Tdate.Text = DateTime.Today.ToShortDateString();
            //remplir le combo box
              C = new Client(Form1.ma_con);                
             Tclient .DataSource =  C.lister();
             Tclient.DisplayMember = "Code";//definir la colonne à afficher

            //remplir datagrid
            V=new Vente (Form1 .ma_con );
            dataGridView1.DataSource = V.lister();

        }


        private void button2_Click(object sender, EventArgs e)
        {
            //supprimer
           
            try
            {
                V = new Vente(Form1.ma_con,Convert .ToInt16 ( Lnvente.Text));
                V.Supprimer_une_vente();
            
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
            if (Tdate.Text == "  /  /" || Tclient.Text == "")
            {
                MessageBox.Show("Erreur de données ", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                C=new Client (Form1 .ma_con ,  Tclient.Text );
                V = new Vente(Form1.ma_con, Convert.ToInt16(Lnvente.Text), Convert.ToDateTime(Tdate.Text), C);
                V.Ajouter_une_vente();
          
            actualiser();
            MessageBox.Show("Ajout effectué ");
            if (MessageBox.Show("Voulez vous ajouter les produits à la vente maintenant", "Vente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Numéro_vente = Lnvente.Text;
                Fproduit_Vendu f = new Fproduit_Vendu();
                f.MdiParent = this.MdiParent;
                f.Show();
            }

            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
              
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            actualiser();
        }

        private void Bmodifier_Click(object sender, EventArgs e)
        {
            if (Tdate.Text == "  /  /")
            {
                MessageBox.Show("Erreur de données ", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
               
                V = new Vente(Form1.ma_con, Convert.ToInt16(Lnvente.Text), Convert.ToDateTime(Tdate.Text));
                V.Modifier_une_vente();

                actualiser();
                MessageBox.Show("Modification effectuée ");

            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }



        private void dataGridView1_Click(object sender, EventArgs e)
        {
         Lnvente.Text   = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            Tdate.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            Tclient.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void Fvente_Load(object sender, EventArgs e)
        {
            actualiser();
        }

        private void Tdate1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                Tdate2.Select();
        }

        private void Tdate2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                try{
                        V = new Vente(Form1.ma_con);
                        dataGridView1 .DataSource= V.Rechercher_par_dates(Convert.ToDateTime(Tdate1.Text), Convert.ToDateTime(Tdate2.Text));
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void Tclient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Tclient.Text != "")
            {
                Tdate1.Clear();
                Tdate2.Clear();
                checkBox1.Checked = false;
                V = new Vente(Form1.ma_con);
                dataGridView1.DataSource = V.Rechercher_par_code_client(Tclient .Text );
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Tdate1.Clear();
                Tdate2.Clear();
                V = new Vente(Form1.ma_con);
                dataGridView1.DataSource = V.lister();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Numéro_vente = Lnvente.Text;
            Fproduit_Vendu f = new Fproduit_Vendu();
            f.MdiParent = this.MdiParent;
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
