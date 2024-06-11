using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratorio7
{
    public class CarroEletrico : IEstadoBinario
    {
        private bool ligado;
        private string marca;
        private int bateria;

        public CarroEletrico(string m, int b)
        {
            marca = m;
            bateria = b;
            ligado = false;
        }

        public void Ligar()
        {
            if (bateria == 0)
            {
                Console.WriteLine("Bateria fraca, recarregue!");
                ligado = false;
            }
            else
            {
                bateria = 0;
                ligado = true;
            }
        }

        public void Desligar()
        {
            ligado = false;
        }

        public void Recarregar()
        {
            bateria = 100;
        }

        public EstadoBinario Estado
        {
            get
            {
                if (ligado)
                    return EstadoBinario.Ligado;
                else
                    return EstadoBinario.Desligado;
            }
        }
    }
}
