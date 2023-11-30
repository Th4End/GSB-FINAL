﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSB_FINAL
{
    internal class ModeleM2
    {
        private static ALaSmeneProEntities maConnexion;
        private static Visiteur leVisiteurConnecte;
        private static void chargeTestVisiteurConnecte()
        {
            leVisiteurConnecte = maConnexion.Visiteur.Where(x => x.idVisiteur == "??????").ToList()[0];
        }
        public static void init()
        {
            maConnexion = new ALaSmeneProEntities();
        }
        public static List<RAPPORT> listrapport()
        {
            return maConnexion.RAPPORT.ToList();
        }
        public static List<MEDECIN> listMedecin()
        {
            return maConnexion.MEDECIN.ToList();
        }
        public static List<MEDICAMENT> listmedicamnt()
        {
            return maConnexion.MEDICAMENT.ToList();
        }
        public static List<Visiteur> listvisiteur()
        {
            return maConnexion.Visiteur.ToList();
        }
        public static List<Region> listregion()
        {
            return maConnexion.Region.ToList();
        }
        public static List<Secteur> listsecteur()
        {
            return maConnexion.Secteur.ToList();
        }
        public static List<RAPPORT> rapportvisiteurco()
        {
            return maConnexion.RAPPORT.Where(x => x.idVisiteur == leVisiteurConnecte.idVisiteur).ToList();
        }
        public static List<MEDECIN> listMedecinVisiteurConnect()
        {
            List<MEDECIN> vretour = new List<MEDECIN>();
            foreach (RAPPORT r in rapportvisiteurco())
            {
                if (!vretour.Contains(r.MEDECIN))
                {
                    vretour.Add(r.MEDECIN);
                }

            }
            return vretour;
        }

    }
}
