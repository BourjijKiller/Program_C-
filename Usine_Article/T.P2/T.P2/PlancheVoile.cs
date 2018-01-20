using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T.P2
{
    class PlancheVoile : Article
    {
        private Matiere matiereSupp1;
        private Matiere matiereSupp2;
        private Matiere matiereSupp3;

        public PlancheVoile(int id, string nom, string forme, Matiere matiere, Matiere matiereSupp1, Matiere matiereSupp2) : base(id, nom, forme, matiere)
        {
            this.matiereSupp1 = matiere;
            this.matiereSupp2 = matiereSupp1;
            this.matiereSupp3 = matiereSupp2;
        }

        public override string action()
        {
            return "Glisse";
        }

        public override List<Matiere> recupMatiere()
        {
            List<Matiere> list = new List<Matiere>();
            list.Add(matiereSupp1);
            list.Add(matiereSupp2);
            list.Add(matiereSupp3);

            return list;
        }
    }
}
