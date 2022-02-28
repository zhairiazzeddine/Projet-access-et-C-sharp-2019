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
    public partial class Fvente_client : Form
    {
        public Fvente_client()
        {
            InitializeComponent();
        }
        public static String Code_Client;
        Client C;
        private void Fvente_client_Load(object sender, EventArgs e)
        {
            //remplir le combo box
             C= new Client(Form1.ma_con);
             listBox1.DataSource = C.Information_client();
             listBox1.DisplayMember = "identif";//definir la colonne à afficher
        }

        private void Tclient_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            Form1.ma_con.Executer_Liste("select date_vente,désignation,qté,pu,total  from Requête_vente_client where client='" +listBox1.Text + "'");
                dataGridView1.DataSource = Form1.ma_con.Tb;
            Ltotal .Text =Form1 .ma_con .Executer_valeur("select sum(total)  from Requête_vente_client where client='" +listBox1.Text + "'");
            if (Ltotal.Text == "")
                Ltotal.Text = "00.00";
            else
            {
                Class_Conversio_monnaie CC = new Class_Conversio_monnaie();
                Ltotal.Text = CC.arrondie(Ltotal.Text);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            C=new Client (Form1 .ma_con );
            Code_Client = C.Renvoyer_Code_client(listBox1.Text);
            Fetat_vente_client f = new Fetat_vente_client();
            f.MdiParent = this.MdiParent;
            f.Show();
        }
    }
}
