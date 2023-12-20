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
    public partial class Fcreationvisiteur : Form
    {
        public Fcreationvisiteur()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fcreationvisiteur_Load(object sender, EventArgs e)
        {
            cboregions.DisplayMember = "libRegion";
            bsregions.DataSource = ModeleM1.listregion();
            cboregions.DataSource = bsregions;

        }

        private void cboregions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
