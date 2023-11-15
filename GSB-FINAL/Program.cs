using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSB_FINAL
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ModeleM1.init();
            ModeleM2.init();
            ModeleM3.init();
<<<<<<< HEAD
            Application.Run(new FMenu());
=======
            ModeleConnexion.init();


            Application.Run(new FConnexion());
>>>>>>> Connexion_Eliazid
        }
    }
}
