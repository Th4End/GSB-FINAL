﻿using System;
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
    }
}
