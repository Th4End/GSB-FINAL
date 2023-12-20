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
    public partial class FMenu : Form
    {
        public FMenu()
        {
            InitializeComponent();
        }
        private void mission1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FMission1 fmission1 = new FMission1();
            fmission1.Show();
        }

        private void mission2ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FMission2 mission2 = new FMission2();
            mission2.Show();
        }

        private void mission3ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FMission3 mission3 = new FMission3();
            mission3.Show();
        }
    }
}
