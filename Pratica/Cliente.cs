using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pratica
{
    public class Cliente
    {
        private int bancoId;
        public int BancoId
        {
            get { return bancoId; }
            set { bancoId = value; }
        }
        private Banco banco;
        public Banco Banco
        {
            get { return banco; }
            set { banco = value; }
        }
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        private double pontuacaoSerasa;
        public double PontuacaoSerasa
        {
            get { return pontuacaoSerasa; }
            set { pontuacaoSerasa = value; }
        }
        private DateOnly dataDeNascimento;
        public DateOnly DataDeNascimento
        {
            get { return dataDeNascimento; }
            set { dataDeNascimento = value; }
        }

        public readonly Dictionary<int, Conta> contas = new();

        public Cliente(string nome, double pontuacaoSerasa, DateOnly dataDeNascimento, Banco banco)
        {
            this.nome = nome;
            this.pontuacaoSerasa = pontuacaoSerasa;
            this.dataDeNascimento = dataDeNascimento;
            this.banco = banco;
            this.bancoId = banco.Id;
        }

        public bool AdicionarConta(Conta conta)
        {
            if (contas.ContainsKey(conta.Id))
            {
                return false;
            }
            contas.Add(conta.Id, conta);
            return true;
        }

        public bool RemoverConta(int contaId)
        {
            contas.TryGetValue(contaId, out Conta? conta);
            if (conta != null)
            {
                contas.Remove(contaId);
                return true;
            }
            return false;
        }
    }
}
