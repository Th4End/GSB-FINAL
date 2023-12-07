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
    public partial class Fconsultermesresponsabilités : Form
    {
        public Fconsultermesresponsabilités()
        {
            InitializeComponent();
        }

        private void Fconsultermesresponsabilités_Load(object sender, EventArgs e)
        {

            /*bsregionsres.DataSource = ModeleConnexion.LeVisiteurConnecte;
            dgvregionsresp.DataSource = bsregionsres;
            dgvregionsresp.Columns[0].Visible = false;
            dgvregionsresp.Columns[1].Visible = false;
            dgvregionsresp.Columns[2].Visible = false;
            dgvregionsresp.Columns[4].Visible = false;
            dgvregionsresp.Columns[5].Visible = false;
            dgvregionsresp.Columns[6].Visible = false;
            dgvregionsresp.Columns[7].Visible = false;
            dgvregionsresp.Columns[8].Visible = false;
            dgvregionsresp.Columns[9].Visible = false;
            dgvregionsresp.Columns[10].Visible = false;
            dgvregionsresp.Columns[11].Visible = false;
            dgvregionsresp.Columns[12].Visible = false;
            dgvregionsresp.Columns[13].Visible = false;
            dgvregionsresp.Columns[14].Visible = false;
            dgvregionsresp.Columns[15].Visible = false;
            bsregionstravai.DataSource = ModeleConnexion.LeVisiteurConnecte;
            dgvregionstrav.DataSource = bsregionstravai;*/
            bsregionsres.DataSource = ModeleConnexion.LeVisiteurConnecte.Region.ToList();//regions pour lesquelles il est responsable
            dgvregionsresp.DataSource = bsregionsres.DataSource;
            for(int i= 0; i < dgvregionsresp.Columns.Count; i++)
            {
                dgvregionsresp.Columns[i].Visible = false;
            }
            dgvregionsresp.Columns[1].Visible = true;

            bsregionstravai.DataSource = ModeleConnexion.LeVisiteurConnecte.Region1.ToList();//regions ou il travaille
            dgvregionstrav.DataSource = bsregionstravai.DataSource;
            for (int i = 0; i < dgvregionstrav.Columns.Count; i++)
            {
                dgvregionstrav.Columns[i].Visible = false;
            }
            dgvregionstrav.Columns[1].Visible = true;
        }

        private void Fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
