﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GSB_FINAL
{
    static class ModeleM1
    {
        private static ALaSmeneProEntities maConnexion;
        private static Visiteur leVisiteurConnecte;
        private static int Action;//1 ajout et 2 modif
       
        public static void init()
        { 
            maConnexion = new ALaSmeneProEntities();
        }
        public static List<FAMILLE> listfamille()
        {
            return maConnexion.FAMILLE.ToList();
        }
        public static List<MOTIF> listmotif()
        {
            return maConnexion.MOTIF.ToList();
        }
        public static List<Visiteur> listvisiteur()
        {
            return maConnexion.Visiteur.ToList();
        }
    }
}
