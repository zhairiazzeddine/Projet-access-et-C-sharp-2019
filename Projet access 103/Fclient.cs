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
    public partial class Fclient : Form
    {
        public Fclient()
        {
            InitializeComponent();
        }

        private void Fclient_Load(object sender, EventArgs e)
        {
            actualiser();
        }
          Client C;
        public void actualiser()
        {
            Tcode.Clear();
            Tnom.Clear();
            Tprénom.Clear();
              C = new Client(Form1.ma_con);
              dataGridView1.DataSource = C.lister(); 
          
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (Tcode.Text == "")
            {
                MessageBox.Show("Erreur de données ", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
             try
                {
                    C = new Client(Form1.ma_con, Tcode.Text);
                    C.Supprimer_un_client();
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
            if (Tcode.Text == "" || Tnom.Text == "" || Tprénom.Text == "")
            {
                MessageBox.Show("Erreur de données ", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
               
                try
                {
                C = new Client(Form1.ma_con, Tcode.Text, Tnom .Text  , Tprénom .Text );
                    C.Ajouter_un_client();
                    actualiser();
                    MessageBox.Show("Ajout effectué ");
                  
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
            if (Tcode.Text == "" || Tnom.Text == "" || Tprénom.Text == "")
            {
                MessageBox.Show("Erreur de données ", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                    C = new Client(Form1.ma_con, Tcode.Text, Tnom .Text , Tprénom .Text );
                    C.Modifier_un_client();
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
            Tcode.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            Tnom.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            Tprénom.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void Rnom_TextChanged(object sender, EventArgs e)
        {
             C = new Client(Form1.ma_con);
             dataGridView1.DataSource = C.Rechercher_par_nom(Rnom.Text);

     
    }

        private void Tprénom_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
