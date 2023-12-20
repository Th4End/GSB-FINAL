using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Security.Cryptography.Pkcs;
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
            this.AcceptButton = button1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            infoconnection.Text = ModeleConnexion.connex(identifiant.Text, mdp.Text);
           if (ModeleConnexion.connexValid)
           {
               //MessageBox.Show("Bienvenue"+" "+ ModeleConnexion.LeVisiteurConnecte.prenom);
              System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));
              t.Start();
              this.Close();
           }
        }

        public static void ThreadProc()
        {
            SendKeys.SendWait("{ENTER}");
            Application.Run(new FMenu());
        }
    }
}

