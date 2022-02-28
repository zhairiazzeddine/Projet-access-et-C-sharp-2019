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
    public partial class Fsituation_Stock : Form
    {
        public Fsituation_Stock()
        {
            InitializeComponent();
        }

        private void Tannée_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Ltotal_entré.Text = "0";
                Ltotal_sortie.Text = "0";
                Ltotal_Valeur.Text = "0.00";
                Form1.ma_con.Executer_Liste("select libellé_mois,produit,sorties,entrés,entrés-sorties as écart,(entrés-sorties)*pu as valeur from Requête_situation_stock, Produit where Requête_situation_stock.produit=produit.désignation and année=" + Tannée.Text + "");
                dataGridView1.DataSource = Form1.ma_con.Tb;
                Ltotal_entré.Text ="Total Entrés : "+ Form1.ma_con.Executer_valeur("select sum(entrés) from Requête_situation_stock where année=" + Tannée.Text + "");
                Ltotal_sortie.Text = "Total Sorties : " + Form1.ma_con.Executer_valeur("select sum(sorties) from Requête_situation_stock where année=" + Tannée.Text + "");
               Ltotal_Valeur.Text =Form1.ma_con.Executer_valeur("select sum((entrés-sorties)*pu) from Requête_situation_stock , Produit where Requête_situation_stock.produit=produit.désignation and année=" + Tannée.Text + "");
               Class_Conversio_monnaie C=new Class_Conversio_monnaie ();
               Ltotal_Valeur.Text = "Total Valeur : " + C.convertir_chiffre_en_lettre(Ltotal_Valeur.Text);
            
            }
        }

        private void Tannée_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Fsituation_Stock_Load(object sender, EventArgs e)
        {
            Tannée.Text = DateTime.Today.Year.ToString();
        }

        private void LAnnée_Click(object sender, EventArgs e)
        {

        }

        private void Ltotal_sortie_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
