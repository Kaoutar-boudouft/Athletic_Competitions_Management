using Microsoft.OData.Edm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patinage
{
    class Natation:Copetition
    {
        string type;

        public string Type { get => type; set => type = value; }

        public Natation(int code,string nom,Date anne,string effectif,string type) : base(code, nom, anne, effectif)
        {
            this.type = type;
        }
        public override string Afficher()
        {
            return base.Afficher() + ",le type de competition est :" + type;
        }
    }
}
