namespace Laboratorio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Exemplo1();
            Exemplo2();

            Exercicio1();
            Exercicio2();
            Exercicio3();
        }

        static void Exercicio3()
        {
            List<Circulo> circulos = new List<Circulo>()
            {
                new(1, 2, 3),
                new CirculoColorido(4, 5, 6, "azul"),
                new CirculoColoridoPreenchido(7, 8, 9, "verde", "Red"),
                new(10, 11, 12)
            };

            foreach (Circulo circulo in circulos)
            {
                Console.WriteLine(circulo);
            }
        }

        static void Exercicio2()
        {
            CirculoColorido circ3 = new CirculoColoridoPreenchido();
            Console.WriteLine(circ3);
        }

        static void Exercicio1()
        {
            CirculoColorido circ3 = new CirculoColorido();
            Console.WriteLine(circ3.CentroX);
            Console.WriteLine(circ3.CentroY);
            CirculoColorido circ4 = new CirculoColorido(1.5, 3.1, 1, "vermelho");
            Console.WriteLine(circ4.CentroX);
            Console.WriteLine(circ4.CentroY);
            Console.WriteLine(circ4);
        }

        static void Exemplo1()
        {
            Circulo circ1 = new Circulo();
            Console.WriteLine(circ1);
            Circulo circ2 = new Circulo(2.4, 5, 3);
            Console.WriteLine(circ2);
        }

        static void Exemplo2()
        {
            Circulo circ1 = new Circulo();
            Console.WriteLine(circ1);
            Circulo circ2 = new Circulo(2.4, 5, 3);
            Console.WriteLine(circ2);
            CirculoColorido circ3 = new CirculoColorido();
            Console.WriteLine(circ3);
            CirculoColorido circ4 = new CirculoColorido(1.5, 3.1, 1, "vermelho");
            Console.WriteLine(circ4);
        }
    }
}
