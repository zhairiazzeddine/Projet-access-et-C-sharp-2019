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
    public partial class Fetat_vente_client : Form
    {
        public Fetat_vente_client()
        {
            InitializeComponent();
        }

        private void Fetat_vente_client_Load(object sender, EventArgs e)
        {
            crystalReportViewer1.SelectionFormula = "{Client.Code}='"+Fvente_client.Code_Client+"'";
            crystalReportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.PrintReport();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
