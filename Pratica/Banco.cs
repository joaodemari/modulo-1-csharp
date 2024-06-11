using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pratica
{
    public class Banco
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string nome;
        public Dictionary<int, Cliente> clientes = new();

        public Banco(string _nome)
        {
            nome = _nome;
        }

        public Cliente AdicionarCliente(CriarClienteDTO cliente)
        {
            Cliente novoCliente =
                new(cliente.Nome, cliente.PontuacaoSerasa, cliente.DataDeNascimento, this);
            clientes.Add(clientes.Count + 1, novoCliente);
            return novoCliente;
        }

        public Cliente? QuemTemMaisDinheiro()
        {
            Cliente? clienteComMaisDinheiro = null;
            double maiorSaldo = double.MinValue;
            Console.WriteLine(clientes.Count);
            foreach (KeyValuePair<int, Cliente> cliente in clientes)
            {
                double saldo = 0;
                foreach (KeyValuePair<int, Conta> conta in cliente.Value.contas)
                {
                    saldo += conta.Value.Saldo;
                }
                if (saldo > maiorSaldo)
                {
                    maiorSaldo = saldo;
                    clienteComMaisDinheiro = cliente.Value;
                }
            }
            return clienteComMaisDinheiro;
        }
    }
}
