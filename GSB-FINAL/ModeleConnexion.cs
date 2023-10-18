using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSB_FINAL
{
    internal class ModeleConnexion
    {
        public static ALaSmeneProEntities maConnexion;
        private static Visiteur leVisiteurConnecte;
        private static void chargeTestVisiteurConnecte()//pour gérer tant que la connexion est pas faite 
        {
            leVisiteurConnecte = maConnexion.Visiteur.Where(x => x.idVisiteur == "??????").ToList()[0];
        }
        public static void init()
        {
            maConnexion = new ALaSmeneProEntities();
            chargeTestVisiteurConnecte();
        }
        public static List<Visiteur> lesvisiteurs()
        {
            return maConnexion.Visiteur.ToList();
        }
    }
}
