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
    public partial class FConnexion : Form
    {
        public FConnexion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            infoconnection.Text = ModeleConnexion.connex(identifiant.Text, mdp.Text);
            if (ModeleConnexion.connexValid)
            {
               MessageBox.Show("Bienvenue"+" "+ ModeleConnexion.LeVisiteurConnecte.prenom);
            }
        }
    }
}
