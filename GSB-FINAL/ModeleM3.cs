using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSB_FINAL
{
    internal class ModeleM3
    {
        public static ALaSmeneProEntities maConnexion;
        public static void init()
        {
            maConnexion = new ALaSmeneProEntities();
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
