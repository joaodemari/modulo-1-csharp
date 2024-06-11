using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pratica
{
    public abstract class ContaPoupanca : Conta
    {
        public ContaPoupanca(int clientId, Cliente cliente)
            : base(clientId, cliente) { }

        public override void Sacar(double valor)
        {
            if (valor > saldo)
            {
                Console.WriteLine("Saldo insuficiente");
            }
            saldo -= valor;
        }

        public void AdicionarRendimentoMensal()
        {
            saldo += saldo * 0.01;
        }

        public void ProjetarSaldo(DateOnly data)
        {
            int meses = data.Month - dataDeCriacao.Month;
            int anos = data.Year - dataDeCriacao.Year;
            meses += anos * 12;
            double saldoProjetado = saldo;
            for (int i = 0; i < meses; i++)
            {
                saldoProjetado += saldoProjetado * 0.01;
            }
            Console.WriteLine($"Saldo projetado para {data} é de {saldoProjetado}");
        }
    }
}
