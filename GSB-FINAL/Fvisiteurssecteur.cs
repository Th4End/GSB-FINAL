using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSB_FINAL
{
    public partial class Fvisiteurssecteur : Form
    {
        public Fvisiteurssecteur()
        {
            InitializeComponent();
        }

        private void Fvisiteurssecteur_Load(object sender, EventArgs e)
        {
            cbosecteurs.DisplayMember = "libSecteur";
            bssecteur.DataSource = ModeleM1.listsecteur();
            cbosecteurs.DataSource = bssecteur;


          
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bssecteur_CurrentChanged(object sender, EventArgs e)
        {
            bsregion.DataSource = ((Secteur)bssecteur.Current).Region.ToList();
            cboregions.DisplayMember = "libRegion";
            cboregions.DataSource = bsregion;
            txtSecteur.Text = ((Secteur)bssecteur.Current).Visiteur.nom.Trim().ToString() + " " + ((Secteur)bssecteur.Current).Visiteur.prenom.Trim().ToString();
        }

        private void bsregion_CurrentChanged(object sender, EventArgs e)
        {
            bsvisiteur.DataSource = ((Region)bsregion.Current).Visiteur1.ToList();
            dgvvisiteursecteur.DataSource = bsvisiteur;

            if (((Region)bsregion.Current).Visiteur1.ToList().Count> 0)
            {
                for (int i = 0; i < dgvvisiteursecteur.Columns.Count; i++)
                {
                    dgvvisiteursecteur.Columns[i].Visible = false;
                }
                dgvvisiteursecteur.Columns[8].Visible = true;
                dgvvisiteursecteur.Columns[9].Visible = true;
            }
        }
    }
}
