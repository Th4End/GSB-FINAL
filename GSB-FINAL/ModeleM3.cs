﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSB_FINAL
{
    internal class ModeleM3
    {
        public static ALaSmeneProEntities maConnexion;
        private static Visiteur leVisiteurConnecte;
        private static void chargeTestVisiteurConnecte()
        {
            leVisiteurConnecte = maConnexion.Visiteur.Where(x => x.idVisiteur == "??????").ToList()[0];
        }
        public static void init()
        {
            maConnexion = new ALaSmeneProEntities();
            chargeTestVisiteurConnecte();
        }
        public static List<FraisForfait> listfrais()
        {
            return maConnexion.FraisForfait.ToList();
        }
        public static List<fichefrais> listfiche()
        {
           return maConnexion.fichefrais.ToList();
        }
        public static List<Visiteur> listvisiteur()
        {
            return maConnexion.Visiteur.ToList();
        }
        
    }
}
