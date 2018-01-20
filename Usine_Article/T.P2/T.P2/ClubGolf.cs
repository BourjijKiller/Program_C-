using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T.P2
{
    class ClubGolf : Article
    {
        private int numero;

        public ClubGolf(int id, string nom, string forme, Matiere matiere, int numero) : base(id, nom, forme, matiere)
        {
            this.numero = numero;
        }

        public override string action()
        {
            return "Tape";
        }

        public int getNumero
        {
            get
            {
                return this.numero;
            }
        }
    }
}
