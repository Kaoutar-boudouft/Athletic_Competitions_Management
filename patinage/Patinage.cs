using Microsoft.OData.Edm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patinage
{
    class Patinage:Copetition
    {
        string categorie;

        public string Categorie { get => categorie; set => categorie = value; }

        public Patinage(int code,string nom,Date anne,string effectif,string categorie):base(code, nom, anne, effectif)
        {
            this.categorie = categorie;
        }
        public override string Afficher()
        {
            return base.Afficher() + ",la categorie de cette compition est :" + categorie;
        }
    }
    
   
}
