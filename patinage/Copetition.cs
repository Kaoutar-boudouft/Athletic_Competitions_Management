using Microsoft.OData.Edm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace patinage
{
    class Copetition
    {
        int code;
        string nom;
        Date anne;
        string effectif;

        public Copetition() { }
        public Copetition(int code, string nom, Date anne, string effectif)
        {
            if (code > 0) { this.code = code; }
            else
            {
                throw new Exception("le code doit etre positif!!");
            }
            
            Regex r = new Regex(@"[individuel|collectif]");
            if (r.IsMatch(effectif)) {
                this.effectif = effectif;
            }
            else
            {
                throw new Exception("l'effectif doit etre soit 'individuel' ou bien 'collectif'!!");
            }
            this.nom = nom;
            this.anne = anne;
        }

        public int Code { get => code; set => code = value; }
        public string Nom { get => nom; set => nom = value; }
        public Date Anne { get => anne; set => anne = value; }
        public string Effectif { get => effectif; set => effectif = value; }

        public virtual string Afficher()
        {
            return "Le code de la competition est : " + code + ",le nom est: " + nom + ",l'annee d'integration au jeux aulampique: " + anne + ",et l'effectif est :" + effectif;
        }


    }
}
