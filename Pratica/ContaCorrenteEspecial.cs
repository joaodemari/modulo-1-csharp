using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pratica
{
    public class ContaCorrenteEspecial : ContaCorrente
    {
        public ContaCorrenteEspecial(int clientId, Cliente cliente, double limite)
            : base(clientId, cliente, limite) { }

        public new double Limite
        {
            get { return limite; }
            set { limite = value; }
        }
    }
}
