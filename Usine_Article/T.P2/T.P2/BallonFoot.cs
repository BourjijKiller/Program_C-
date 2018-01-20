using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T.P2
{
    class BallonFoot : Article
    {
        private Matiere matiereSupp1;
        private Matiere matiereSupp2;

        public BallonFoot(int id, string nom, string forme, Matiere matiere, Matiere matiereSupp1) : base(id, nom, forme, matiere)
        {
            this.matiereSupp1 = matiere;
            this.matiereSupp2 = matiereSupp1;
        }

        public override string action()
        {
            return "Roule";
        }

        public override List<Matiere> recupMatiere()
        {
            List<Matiere> list = new List<Matiere>();
            list.Add(matiereSupp1);
            list.Add(matiereSupp2);

            return list;
        }
    }
}
