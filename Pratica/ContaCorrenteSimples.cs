using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pratica
{
    public class ContaCorrenteSimples : ContaCorrente
    {
        public ContaCorrenteSimples(int clientId, Cliente cliente)
            : base(clientId, cliente, 0) { }
    }
}
