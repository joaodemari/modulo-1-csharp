using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pratica
{
    public abstract class Conta
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        protected DateOnly dataDeCriacao;
        public DateOnly DataDeCriacao
        {
            get { return dataDeCriacao; }
        }
        protected double saldo;
        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        protected Conta(int clientId, Cliente cliente)
        {
            this.clientId = clientId;
            donoDaConta = cliente;
            dataDeCriacao = DateOnly.FromDateTime(DateTime.Now);
            saldo = 0;
        }

        public virtual void Depositar(double valor)
        {
            saldo += valor;
        }

        public virtual void Sacar(double valor)
        {
            saldo -= valor;
        }

        private int clientId;
        public int ClientId
        {
            get { return clientId; }
            set { clientId = value; }
        }
        private Cliente donoDaConta;
        public Cliente DonoDaConta
        {
            get { return donoDaConta; }
            set { donoDaConta = value; }
        }
    }
}
