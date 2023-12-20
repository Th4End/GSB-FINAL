using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GSB_FINAL
{
    internal class ModeleConnexion
    {
        public static ALaSmeneProEntities maConnexion;
        private static Visiteur leVisiteurConnecte;
        public static bool connexValid;

        public static Visiteur LeVisiteurConnecte { get => leVisiteurConnecte; set => leVisiteurConnecte = value; }
        public bool ConnexValid { get => connexValid; set => connexValid = value; }

        public static void init()
        {
            maConnexion = new ALaSmeneProEntities();
            chargeTestVisiteurConnecte();
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
        public static string connex(string id, string mdp)
        {
            string msg = "";
            List<Visiteur> user = maConnexion.Visiteur.Where(x => x.identifiant == id).ToList();
            if(user.Count == 0)
            {
                msg = "Utilisateur innexistant";
                connexValid = false;
            }
            else
            {
                if (user.Count > 1)
                {
                    msg = "erreur dans la base de données, contactez l'administrateur de la base de données";
                    connexValid = false;
                }
                else
                {
                    leVisiteurConnecte = user[0];
                    string mdph = GetMd5Hash(mdp);
                    string md = LeVisiteurConnecte.password.Substring(2).ToString();
                    
                    if (String.Equals(mdph, LeVisiteurConnecte.password.Substring(2).ToString(),StringComparison.CurrentCultureIgnoreCase))
                    {
                        msg = "Bienvenue"+" "+leVisiteurConnecte.prenom;
                        connexValid = true;
                    }
                    else
                    {
                        msg = "identifiant ou Mot de passe incorect ";
                        connexValid = false;
                    }

                }
            }
            return msg;
        }
       
    }
}
