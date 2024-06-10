using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratorio5
{
    public class CirculoColoridoPreenchido : CirculoColorido
    {
        private Color preenchimento;
        public Color Preenchimento
        {
            get { return preenchimento; }
            set { preenchimento = value; }
        }

        public CirculoColoridoPreenchido(double x, double y, double r, string c, string p)
            : base(x, y, r, c)
        {
            preenchimento = Color.FromName(p);
        }

        public CirculoColoridoPreenchido()
        {
            preenchimento = Color.FromName("Black");
        }

        public override string ToString()
        {
            return base.ToString() + " Preenchimento=" + Preenchimento.ToKnownColor();
        }
    }
}
