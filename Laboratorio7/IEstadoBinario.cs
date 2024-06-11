using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratorio7
{
    public enum EstadoBinario
    {
        Ligado,
        Desligado
    };

    interface IEstadoBinario
    {
        void Ligar();
        void Desligar();
        EstadoBinario Estado { get; }
    }
}
