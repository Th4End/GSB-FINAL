﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace GSB_FINAL
{
    public partial class FMission3 : Form
    {
        public FMission3()
        {
            InitializeComponent();
        }

        /* Ci dessous c'est pour avoir accèes au filtrage pour les feuilles */


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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        /* Ci dessous c'est pour avoir accèes au bouton de filtrage pour les feuilles */


        private void checkBoxMois_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (checkBoxMois.Checked)
                {
                    checkBoxPeriode.Checked = false;
                    checkBoxEtat.Checked = false;
                }
            }
        }

        private void checkBoxPeriode_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (checkBoxPeriode.Checked)
                {
                    checkBoxMois.Checked = false;
                    checkBoxEtat.Checked = false;
                }
            }
        }

        private void checkBoxEtat_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (checkBoxEtat.Checked)
                {
                    checkBoxPeriode.Checked = false;
                    checkBoxMois.Checked = false;
                }
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

            if (dateTimePickerDebut.Value >= dateTimePickerFin.Value)
            {
                MessageBox.Show("Impossible que la première date soit inférieur !");
            }
        }



        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            string selectedText = comboBoxEtat.Text;
            MessageBox.Show(comboBoxEtat.Text);
        }

        private void FiltreButton_Click(object sender, EventArgs e)
        {

        }
        /* Ci dessus c'est pour avoir accèes au bouton de filtrage pour les feuilles */








    }
}
  

