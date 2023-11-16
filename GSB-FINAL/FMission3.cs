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
    public partial class FMission3 : Form
    {
        public FMission3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mission3_Renseigner Mission3_R = new Mission3_Renseigner();
            Mission3_R.Show();
        }

           
        private void FMission3_Load(object sender, EventArgs e)
        {
            bsFiches.DataSource = ModeleM3.listfiche();
            dgvfiches.DataSource = bsFiches;
            dgvfiches.Columns[0].Visible = false;
            dgvfiches.Columns[4].Visible = false;
            dgvfiches.Columns[2].Visible = false;
            dgvfiches.Columns[6].Visible = false;
            dgvfiches.Columns[4].Visible = false;
            dgvfiches.Columns[7].Visible = false;
            dgvfiches.Columns[8].Visible = false;
            dgvfiches.Columns[9].Visible = false;
            dgvfiches.Columns[1].HeaderText = "Mois/Année";
            dgvfiches.Columns[3].HeaderText = "Montant De la Fiche";
            dgvfiches.Columns[5].HeaderText = "Id de l'État";
        }
        public void bgMois_CurrentChanged(object sender, EventArgs e)

        {
      
        }

        private void CheckFiltre_CheckedChanged(object sender, EventArgs e)
        {
            PanelFiltre.Visible = CheckFiltre.Checked;
        }
    }
   /* public void bsNation_CurrentChanged(object sender, EventArgs e)

    {
     
    }*/
}
