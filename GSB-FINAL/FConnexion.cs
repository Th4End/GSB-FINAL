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
    public partial class FConnexion : Form
    {
        public FConnexion()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FConnexion_Load(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;


                if (IsValidUser(username, password))
                {
                    MessageBox.Show("Connexion réussie !");

                }
                else
                {
                    MessageBox.Show("Échec de la connexion. Veuillez vérifier vos informations.");
                }
            }

             bool IsValidUser(string username, string password)
            {

                return username == "utilisateur" && password == "motdepasse";
            }
        }
    }
}
