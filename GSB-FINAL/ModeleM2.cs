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
        private static int unID;
        public static int ActionMission2 = 0;
        private static MEDECIN practicienchoisi;
        private static RAPPORT rapportchoisi;

        public static RAPPORT Rapportchoisi { get => rapportchoisi; set => rapportchoisi = value; }
        public static MEDECIN Practicienchoisi { get => practicienchoisi; set => practicienchoisi = value; }

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
            return maConnexion.RAPPORT.Where(x => x.idVisiteur == ModeleConnexion.LeVisiteurConnecte.idVisiteur).ToList();
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
        public static RAPPORT rapportid(int ID)
        {
            RAPPORT vretour = maConnexion.RAPPORT.Where(x => x.idRapport == ID).ToList()[0];
            return vretour;
        }
        public static bool ModifRaport(int id, string bilan, string nom, string motif, DateTime date)
        
        {
            bool retour = false;
            try
            {
                rapportchoisi.bilan = bilan;
                rapportchoisi.idRapport = id;
                rapportchoisi.MEDECIN.nom = nom;
                rapportchoisi.MOTIF.libMotif = motif;
                rapportchoisi.dateRapport = date;
                maConnexion.SaveChanges();
                
            }catch(Exception ex)
            {
                retour = false;
            }
            return retour;

        }
        public static void Sauvegarde_modification()
        {
            maConnexion.SaveChanges();
        }
    }
}
