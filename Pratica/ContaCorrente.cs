using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pratica
{
    public abstract class ContaCorrente : Conta
    {
        protected double limite;
        public double Limite
        {
            get { return limite; }
        }

        protected ContaCorrente(int clientId, Cliente cliente, double limite)
            : base(clientId, cliente)
        {
            this.limite = limite;
        }

        public override void Sacar(double valor)
        {
            if (valor > saldo + limite)
            {
                Console.WriteLine("Saldo insuficiente");
            }
            saldo -= valor;
        }
    }
}
