using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GSB_FINAL
{
    public partial class FConsultermesinfos : Form
    {
        public FConsultermesinfos()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dgvconsultermesinfos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FConsultermesinfos_Load(object sender, EventArgs e)
        {
            textnom.Text = ModeleConnexion.LeVisiteurConnecte.nom.Trim().ToString();
            textprenom.Text = ModeleConnexion.LeVisiteurConnecte.prenom.Trim().ToString();
            textville.Text = ModeleConnexion.LeVisiteurConnecte.ville.Trim().ToString();
            textrue.Text = ModeleConnexion.LeVisiteurConnecte.rue.Trim().ToString();
            textcodepostale.Text = ModeleConnexion.LeVisiteurConnecte.cp.Trim().ToString();
        }

        private void bsConsultermesinfos_CurrentChanged(object sender, EventArgs e)
        {
           

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            /*Visiteur levisiteurchoisie = (Visiteur)bsVisiteur.Current;
            textBox1.Text = levisiteurchoisie.nom.ToString().Trim();
            dgvconsultermesinfos.DataSource = bsVisiteur;*/
        }

        private void Annuler_Click(object sender, EventArgs e)
        {
            if (ModeleM1.modifinfos(textnom.Text, textprenom.Text, textville.Text, textrue.Text, textcodepostale.Text))
            {
                labelinfos.Text = "informations mises a jour";
                MessageBox.Show("informations mises a jour avec succès");
            }
            else
            {
                labelinfos.Text = "une erreur est survenue";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
