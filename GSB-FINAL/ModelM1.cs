using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public static List<Region>listregion()
        {
            return maConnexion.Region.ToList();
        }
        public static List<Secteur> listsecteur()
        {
            return maConnexion.Secteur.ToList();
        }
        private static string GetMd5Hash(string PasswdSaisi)
        {
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(PasswdSaisi);
            byte[] hash = (MD5.Create()).ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            return sb.ToString();
        }
        public static bool modifinfos(string nom, string prenom, string ville, string rue, string cp)
        {
            bool vretour = true;
            try
            {
                ModeleConnexion.LeVisiteurConnecte.nom = nom;
                ModeleConnexion.LeVisiteurConnecte.prenom = prenom;
                ModeleConnexion.LeVisiteurConnecte.ville = ville;
                ModeleConnexion.LeVisiteurConnecte.rue = rue;
                ModeleConnexion.LeVisiteurConnecte.cp = cp;
                ModeleConnexion.maConnexion.SaveChanges();

            }
            catch (Exception ex)
            {
                vretour = false;
            }
            return vretour;



        }
        public static string modifpasssword(string password, string nouveaupassword, string confipassword)
        {
            string message = "";
            string mdph = GetMd5Hash(password);
            if (string.Equals(mdph,ModeleConnexion.LeVisiteurConnecte.password.Substring(2).ToString(),StringComparison.CurrentCultureIgnoreCase ) && string.Equals(nouveaupassword, confipassword))
            {
                try
                {
                    string newmdph = string.Concat("0x", GetMd5Hash(nouveaupassword));
                    ModeleConnexion.LeVisiteurConnecte.password = newmdph;
                    ModeleConnexion.maConnexion.SaveChanges();
                    message = "mot de passe modifié";
                }
                catch (Exception ex)
                {
                    message = "le mot de passe n'est pas modifié";
                }

            }
            else
            {
                message = "informations incorrect";
            }
            return message;
        }
       

    }
}
