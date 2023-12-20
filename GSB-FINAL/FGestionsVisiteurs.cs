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
    public partial class FMission1 : Form
    {
        public FMission1()
        {
            InitializeComponent();
        }

      

        

       

        private void perSecteurToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consulterMesInfosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FConsultermesinfos fenetreconsulterMesInfos = new FConsultermesinfos();
            fenetreconsulterMesInfos.Show();
        }

        private void bsGestionvisiteur_CurrentChanged(object sender, EventArgs e)
        {
           

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
