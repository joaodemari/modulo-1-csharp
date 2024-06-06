namespace Laboratorio1
{
    class Exemplos
    {
        static void Main(string[] args)
        {
            Exemplo1();
            Exemplo2();
            Exemplo3();

            //Exercícios
            Exercicio1();
            Exercicio2();
            Exercicio3();
            Exercicio4();
            Exercicio5();
            Exercicio6();
            Exercicio7();
            Exercicio8();
        }

        static void Exercicio8()
        {
            int x = 10;
            double y = 3.4;
            // aqui no primeiro console temos o 0 e 1 como referência para os argumentos que vem após a string
            Console.WriteLine("{0} {1}", x, y);
            // aqui colocamos o cifrão para especificar que podemos utilizar as
            // chaves para colocar variáveis dentro do console.writeline
            Console.WriteLine($"{x} {y}");
        }

        static void Exercicio7()
        {
            double valorFracionado = 4.7;
            int valorInteiro1 = (int)valorFracionado;
            int valorInteiro2 = Convert.ToInt32(valorFracionado);
            Console.WriteLine("Conversao explicita = " + valorInteiro1);
            Console.WriteLine("Conversao metodo Convert = " + valorInteiro2);
        }

        static void Exercicio6()
        {
            string stringInteiroGrande = "999999999999999999999999999999999999999999999";
            bool conversao2 = Int32.TryParse(stringInteiroGrande, out int valorStringInteiroGrande);
            Console.WriteLine(
                "Conversão efetuada:" + conversao2 + " Valor: " + valorStringInteiroGrande
            );
        }

        static void Exercicio5()
        {
            string stringInteiro = "123456789";
            int valorStringInteiro = Convert.ToInt32(stringInteiro);
            Console.WriteLine(valorStringInteiro);
            Int64 valorInt64 = 123456789;
            int valorInt = Convert.ToInt32(valorInt64);
            Console.WriteLine(valorInt);
        }

        static void Exercicio4()
        {
            int i = 10;
            float f = 0;
            f = i; //conversão implícita, sem perda de dados.
            System.Console.WriteLine(f);
            f = 0.6F;
            i = (int)f; //conversão explícita, com perda de dados.
            System.Console.WriteLine(i);
        }

        //Novas operações com DateTimes
        static void Exercicio3()
        {
            var today = DateTime.Now;
            Console.WriteLine("today.DayOfWeek >>" + today.DayOfWeek);
            Console.WriteLine("today.Kind >>" + today.Kind);
            Console.WriteLine("today.Ticks >>" + today.Ticks);

            //most different method
            DateTime.IsLeapYear(2016);
        }

        // Novas operações com Strings
        static void Exercicio2()
        {
            // o \t é um tab
            string columns = "Column 1\tColumn 2\tColumn 3";
            // o \n é uma quebra de linha
            string row1 = "Row 1\nRow 1\nRow 1";

            string alien = "\U0001F47D";

            var jh = (firstName: "Jupiter", lastName: "Hammon", born: 1711, published: 1761);
            Console.WriteLine(
                $"{jh.firstName} {jh.lastName} was an African American poet born in {jh.born}."
            );

            string s3 = "Visual C# Express";
            Console.WriteLine(s3.Replace("C#", "Basic"));
        }

        static void Exercicio1()
        {
            // Decimal printa todas as casas decimais, mesmo que sejam zeros
            float f = 1.00f;
            double d = 1.00;
            decimal dec = 1.00m;

            Console.WriteLine("Valor maximo de float: " + f);
            Console.WriteLine("Valor maximo de double: " + d);
            Console.WriteLine("Valor maximo de decimal: " + dec);
        }

        static void Exemplo3()
        {
            DateTime dt = new DateTime(2015, 04, 23);
            string strQuinta = dt.ToString();
            Console.WriteLine(dt);
        }

        static void Exemplo2()
        {
            string strPrimeira = "Alo ";
            string strSegunda = "Mundo";
            string strTerceira = strPrimeira + strSegunda;
            Console.WriteLine(strTerceira);
            int cchTamanho = strTerceira.Length;
            string strQuarta = "Tamanho = " + cchTamanho.ToString();
            Console.WriteLine(strQuarta);
            Console.WriteLine(strTerceira.Substring(0, 5));
        }

        static void Exemplo1()
        {
            byte b;
            b = byte.MaxValue;
            Console.WriteLine("Valor maximo de byte: " + b);
            int i;
            i = int.MaxValue;
            Console.WriteLine("Valor maximo de int: " + i);
            long l;
            l = long.MaxValue;
            Console.WriteLine("Valor maximo de long: " + l);
        }
    }
}
