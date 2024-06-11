using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratorio6
{
    public class ContaDebito : Conta
    {
        public ContaDebito(string t)
            : base(t) { }

        public override string Id
        {
            get { return Titular + "(CD)"; }
        }

        public override void Sacar(decimal valor)
        {
            if (Saldo >= valor)
            {
                Saldo -= valor;
            }
        }
    }
}
