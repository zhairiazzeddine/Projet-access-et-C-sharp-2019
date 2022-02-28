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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static Connexion ma_con; 
        private void button1_Click(object sender, EventArgs e)
        {
            ma_con = new Connexion(Tpasse.Text);
            if (ma_con.Connecter() == true)
                {
                          new MDIParent1().Show();       
                            this .Hide ();
             }
                 else
                MessageBox.Show("Erreur de connexion");
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
        }
    }
}
