namespace Pratica
{
    class Program
    {
        static void Main(string[] args)
        {
            Banco banco = new("NuBank");
            CriarClienteDTO cliente = new("João", 700, new DateOnly(2000, 1, 1));
            Cliente cliente1 = banco.AdicionarCliente(cliente);
            ContaCorrenteSimples conta = new(1, cliente1);
            cliente1.AdicionarConta(conta);
            // cant set
            double limite = conta.Limite;
            ContaCorrenteEspecial conta2 = new(2, cliente1, 1000);
            conta2.Limite = 2000;
            cliente1.AdicionarConta(conta2);
            conta2.Depositar(500);
            conta2.Sacar(200);
            CriarClienteDTO cliente2 = new("Maria", 800, new DateOnly(2000, 1, 1));
            Cliente cliente2Obj = banco.AdicionarCliente(cliente2);
            ContaCorrenteSimples conta3 = new(3, cliente2Obj);
            cliente2Obj.AdicionarConta(conta3);
            ContaCorrenteEspecial conta4 = new(4, cliente2Obj, 1000);
            cliente2Obj.AdicionarConta(conta4);
            Cliente? clienteComMaisDinheiro = banco.QuemTemMaisDinheiro();
            Console.WriteLine(clienteComMaisDinheiro?.Nome);
        }
    }
}
