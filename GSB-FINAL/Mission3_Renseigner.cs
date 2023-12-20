using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSB_FINAL
{
    public partial class Mission3_Renseigner : Form
    {
        public Mission3_Renseigner()
        {
            InitializeComponent();
           
        }
        private string Nuitées = "", Déjeuner = "", PetitDéj = "", ForfairSoi = "", Diner = "", qttNuitées = "", qttDéjeuner = "", qttPetitDéj = "", qttForfairSoi = "", qttDiner = "", finNuitées = "", finDéjeuner = "", finPetitDéj = "", finForfairSoi = "", finDiner = "";

        private void bsTypeLoco_CurrentChanged(object sender, EventArgs e)
        {
            FraisForfait lefraischoisis = (FraisForfait)bsTypeLoco.Current;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void Mission3_Renseigner_Load(object sender, EventArgs e)
        {
            bsVisiteurInfos.DataSource = ModeleM3.listvisiteur();
            bsTypeLoco.DataSource = ModeleM3.listfrais();

        }
        private void bsVisiteurInfos_CurrentChanged(object sender, EventArgs e)
        {
            Visiteur levisiteurchoisis = (Visiteur)bsVisiteurInfos.Current;
            Numvis.Text = levisiteurchoisis.idVisiteur.ToString();
            
        }
        /*/////////////////////////////////////////////////////////////////////////////////////////////////*/

        private void textBox32_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                Nuitées = textBox32.Text;
                e.Handled = true; // Bloquer la saisie du caractère
            }
        }
        /*/////////////////////////////////////////////////////////////////////////////////////////////////*/


        private void textBox23_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                qttNuitées = textBox23.Text;
                e.Handled = true; // Bloquer la saisie du caractère
            }
        }

        private void textBox30_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                qttDiner = textBox30.Text;
                e.Handled = true; // Bloquer la saisie du caractère
            }
        }

        private void textBox26_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                qttDéjeuner = textBox26.Text;
                e.Handled = true; // Bloquer la saisie du caractère
            }
        }

        private void textBox27_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                qttPetitDéj = textBox27.Text;
                e.Handled = true; // Bloquer la saisie du caractère
            }
        }

        private void textBox28_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                qttForfairSoi = textBox28.Text;
                e.Handled = true; // Bloquer la saisie du caractère
            }
        }
        /*/////////////////////////////////////////////////////////////////////////////////////////////////*/
        private void textBox31_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                Diner = textBox31.Text;
                e.Handled = true; // Bloquer la saisie du caractère
            }
        }

        private void textBox38_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                Déjeuner = textBox38.Text;
                e.Handled = true; // Bloquer la saisie du caractère
            }
        }

        private void textBox37_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                PetitDéj = textBox37.Text;
                e.Handled = true; // Bloquer la saisie du caractère
            }
        }

        private void textBox36_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                ForfairSoi = textBox36.Text;
                e.Handled = true; // Bloquer la saisie du caractère
            }
        }
        /*/////////////////////////////////////////////////////////////////////////////////////////////////*/

        















    }
}
