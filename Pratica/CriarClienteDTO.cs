using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pratica
{
    public class CriarClienteDTO
    {
        public CriarClienteDTO(string nome, double pontuacaoSerasa, DateOnly dataDeNascimento)
        {
            this.nome = nome;
            this.pontuacaoSerasa = pontuacaoSerasa;
            this.dataDeNascimento = dataDeNascimento;
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
    }
}
