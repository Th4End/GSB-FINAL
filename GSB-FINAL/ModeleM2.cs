using System;
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
            chargeTestVisiteurConnecte();
        }
        public static List<RAPPORT> listrapport()
        {
            return maConnexion.RAPPORT.ToList();
        }
        public static List<MEDECIN>listMedecin()
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
        public static List<Region>listregion()
        {
            return maConnexion.Region.ToList();
        }
        public static List<Secteur>listsecteur()
        {
            return maConnexion.Secteur.ToList();
        }
        public static List<MOTIF> lesmotifs()
        {
            return maConnexion.MOTIF.ToList();
        }
        public static List<OFFRIR> lesoffres()
        {
            return maConnexion.OFFRIR.ToList();
        }

    }
}
