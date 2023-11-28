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
            bindingSource1.DataSource = ModeleM2.listrapport();
            dataGridView1.DataSource = bindingSource1;
            bindingSource2.DataSource = ModeleM2.listMedecin();
            comboBox1.DataSource = bindingSource2;
            comboBox1.DisplayMember = "nom";
            dataGridView1.Columns[6].Visible = false;
            //dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            
        }
        
    }
}
