using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSB_FINAL
{
    public partial class FformulaireModif : Form
    {
        public FformulaireModif()
        {
            InitializeComponent();
            bindingSource1 = ModeleM2.ModifRaport().ToString();
            BilanList.DataBindings = bindingSource1;
        }

        private void FformulaireModif_Load(object sender, EventArgs e)
        {
            label5.Text = ModeleConnexion.LeVisiteurConnecte.nom + " " + ModeleConnexion.LeVisiteurConnecte.prenom;
        }


        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

