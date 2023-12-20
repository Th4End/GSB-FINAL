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
    public partial class FMission2 : Form
    {
        public FMission2()
        {
            InitializeComponent();
        }
         
        private void FMission2_Load(object sender, EventArgs e)
        {
            
            bsrapport.DataSource = ModeleM2.listrapport();
            datarapport.DataSource = bsrapport;
            bsmedecin.DataSource = ModeleM2.listMedecinVisiteurConnect();
            comboBox1.DataSource = bsmedecin;
            comboBox1.DisplayMember = "nom";
            datarapport.Columns[6].Visible = false;
            //datarapport.Columns[7].Visible = false;
            datarapport.Columns[8].Visible = false;
        }

        private void bsrapport_CurrentChanged(object sender, EventArgs e)
        {
            bsmedecin.DataSource = ModeleM2.listMedecinVisiteurConnect();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            datarapport.DataSource = ModeleM2.rapportvisiteurco();
        }
    }
}
