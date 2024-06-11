using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratorio7
{
    public class Program
    {
        static void Main(string[] args)
        {
            Exemplo();

            Exercicio();
        }

        static void Exercicio()
        {
            List<IEstadoBinario> lista = new();
            lista.Add(new Lampada(110, 60));
            lista[0].Ligar();
            lista.Add(new TermometroEletrico());
            lista.Add(new CarroEletrico("Mercedes", 100));
            lista[2].Ligar();
            lista[2].Desligar();
            lista[2].Ligar();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(lista[i].Estado);
            }
        }

        static void Exemplo()
        {
            IEstadoBinario[] lista = new IEstadoBinario[2];
            lista[0] = new Lampada(110, 60);
            lista[0].Ligar();
            lista[1] = new TermometroEletrico();
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(lista[i].Estado);
            }
        }
    }
}
