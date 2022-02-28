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
    public partial class Fgraphique : Form
    {
        public Fgraphique()
        {
            InitializeComponent();
        }

        private void Fgraphique_Load(object sender, EventArgs e)
        {
            crystalReportViewer1.SelectionFormula = "{Requête_situation_stock_graphique.année}=" + Fstatistique_vente.Année + "";
            crystalReportViewer1.RefreshReport();
        }
    }
}
