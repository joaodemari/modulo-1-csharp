using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratorio4
{
    public class ContaCorrente
    {
        private decimal saldo;
        public decimal Saldo
        {
            get { return saldo; }
        }

        private DateTime dataCriacao;
        public DateTime DataCriacao
        {
            get { return dataCriacao; }
        }
        private string nomeTitular;
        public string NomeTitular
        {
            get { return nomeTitular; }
        }

        private int NumeroDeOperacoes { get; set; }
        private decimal SaldoAcumulado { get; set; }

        public decimal SaldoMedio => SaldoAcumulado / NumeroDeOperacoes;

        public ContaCorrente(decimal val = 0m, string nome = "Não Informado")
        {
            saldo = val;
            dataCriacao = DateTime.Now;
            nomeTitular = nome;
            NumeroDeOperacoes = 1;
            SaldoAcumulado = val;
        }

        public void Depositar(decimal val)
        {
            saldo += val;
            SaldoAcumulado += saldo;
            NumeroDeOperacoes++;
        }

        public void Sacar(decimal val)
        {
            saldo -= val;
            SaldoAcumulado += saldo;
            NumeroDeOperacoes++;
        }
    }
}
