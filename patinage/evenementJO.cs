using Microsoft.OData.Edm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace patinage
{
    class evenementJO
    {
        string nom;
        List<Copetition> lc;

        public evenementJO(string nom)
        {
            this.nom = nom;
            this.lc =new List<Copetition>();
        }

        public string Nom { get => nom; set => nom = value; }
        internal List<Copetition> Lc { get => lc; set => lc = value; }

        public int Rechercher(int code)
        {
            for(int i = 0; i < lc.Count; i++)
            {
                if (lc[i].Code == code)
                {
                    return i;
                }
            }
            return -1;
        }

        public bool Ajouter(Copetition c)
        {
            int r = Rechercher(c.Code);
            if (r == -1)
            {
                lc.Add(c);
                return true;
            }
            return false;
        }

        public string Supprimer(int code)
        {
            int r = Rechercher(code);
            if (r != -1)
            {
                lc.RemoveAt(r);
                return "la competition a ete supprimer!!";
            }
          return "la competition n'existe pas!!";
        }

        public string Modifier(int code,string nom,Date anne,string effectif)
        {
            int r = Rechercher(code);
            if (r != -1)
            {
                lc[r].Nom = nom;
                lc[r].Anne = anne;
                lc[r].Effectif = effectif;
                return "la competition a ete modifier!";
            }
            return "la competition n'existe pas!!";
        }



    }
}
