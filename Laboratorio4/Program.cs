using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratorio4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Exemplo1();
            // Exemplo2();
            // Exemplo3();

            //Exercícios
            // Exercício1();
            // Exercício2();
            Exercicio3();
        }

        static void Exercicio3(){
            ContaCorrente minhaConta = new(100, "João da Silva");
            Console.WriteLine(minhaConta.Saldo);
            minhaConta.Depositar(100);
            Console.WriteLine(minhaConta.Saldo);
            minhaConta.Depositar(100);
            Console.WriteLine(minhaConta.Saldo);
            minhaConta.Depositar(100);
            Console.WriteLine(minhaConta.Saldo);
            //Ganhei na Loteria...
            minhaConta.Depositar(1000000);
            Console.WriteLine(minhaConta.Saldo);
            Console.WriteLine(minhaConta.SaldoMedio);
        }

        static void Exercício2()
        {
            ContaCorrente minhaConta = new(100, "João da Silva");
            Console.WriteLine(minhaConta.Saldo);
            minhaConta.Depositar(100);
            Console.WriteLine(minhaConta.Saldo);
            Console.WriteLine(minhaConta.NomeTitular);
            Console.WriteLine(minhaConta.DataCriacao);
            Console.WriteLine(minhaConta.SaldoMedio);
        }

        static void Exercício1()
        {
            ContaCorrente minhaConta = new(340, "João da Silva");
            Console.WriteLine(minhaConta.Saldo);
            minhaConta.Depositar(100);
            Console.WriteLine(minhaConta.Saldo);
            minhaConta.Sacar(50);
            Console.WriteLine(minhaConta.Saldo);
            Console.WriteLine(minhaConta.NomeTitular);
            Console.WriteLine(minhaConta.DataCriacao);
        }

        static void Exemplo3()
        {
            ContaCorrente minhaConta = new(340);
            Console.WriteLine(minhaConta.Saldo);
            minhaConta.Depositar(100);
            Console.WriteLine(minhaConta.Saldo);
            minhaConta.Sacar(50);
            Console.WriteLine(minhaConta.Saldo);
        }

        static void Exemplo2()
        {
            ContaCorrente minhaConta = new(0);
            Console.WriteLine(minhaConta.Saldo);
            minhaConta.Depositar(100);
            Console.WriteLine(minhaConta.Saldo);
            minhaConta.Sacar(50);
            Console.WriteLine(minhaConta.Saldo);
        }

        static void Exemplo1()
        {
            ContaCorrente minhaConta = new(0);
            minhaConta.Depositar(100);
            minhaConta.Sacar(50);
        }
    }
}
