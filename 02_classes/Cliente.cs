using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _02_classes
{
    public class Cliente
    {
        private string? Nome { get; set; }
        private decimal LimiteCredito { get; set; }
        private uint ClienteID { get; set; }

        public Cliente(string nome, decimal limiteCredito, uint clienteID)
        {
            Nome = nome;
            LimiteCredito = limiteCredito;
            ClienteID = clienteID;
        }

        public void Metodo01(string entrada, out string saida)
        {
            saida = Nome + "->" + entrada;
        }
    }
}
