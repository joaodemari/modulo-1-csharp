using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratorio5
{
    public class CirculoColorido : Circulo
    {
        public CirculoColorido()
        {
            minhaCor = "preto";
        }

        public CirculoColorido(double x, double y, double r, string c)
            : base(x, y, r)
        {
            minhaCor = c;
        }

        private string minhaCor;
        public string Cor
        {
            get { return minhaCor; }
            set { minhaCor = value; }
        }

        public override string ToString()
        {
            return base.ToString() + " cor=" + Cor;
        }
    }
}
