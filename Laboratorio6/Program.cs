namespace Laboratorio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercicio1();
            Exercicio2();
        }

        private static void Exercicio2()
        {
            ContaPoupanca cp = new ContaPoupanca(0.01m, new DateTime(2019, 1, 1), "Maria");
            cp.Depositar(1000);
            cp.Sacar(100);
            cp.AdicionarRendimento();
            Console.WriteLine("Saldo da conta poupança: " + cp.Saldo);
            ContaDebito cd = new ContaDebito("João");
            cd.Depositar(1000);
            cd.Sacar(100);
            Console.WriteLine("Saldo da conta débito: " + cd.Saldo);
            List<Conta> contas = new List<Conta> { cp, cd };
            foreach (Conta c in contas)
            {
                // c.adicionarrendimento não pode ser
                //chamado por causa do polimorfismo
                //só se
                if (c is ContaPoupanca poupanca)
                {
                    Console.WriteLine("Adicionando rendimento para a conta poupança");
                    poupanca.AdicionarRendimento();
                }
            }
        }

        static void Exercicio1()
        {
            ContaPoupanca cp = new ContaPoupanca(0.01m, new DateTime(2019, 1, 1), "Maria");
            cp.Depositar(1000);
            cp.Sacar(100);
            cp.AdicionarRendimento();
            Console.WriteLine("Saldo da conta poupança: " + cp.Saldo);
            ContaDebito cd = new ContaDebito("João");
            cd.Depositar(1000);
            cd.Sacar(100);
            Console.WriteLine("Saldo da conta débito: " + cd.Saldo);
            List<Conta> contas = new List<Conta> { cp, cd };
            foreach (Conta c in contas)
            {
                Console.WriteLine(c.Id);
            }
        }
    }
}
