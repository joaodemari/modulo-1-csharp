namespace Laboratorio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Exemplo1();
            Exemplo2();
            Exemplo3();

            Exemplo1ForEach();
            Exemplo2ForEach();
            Exemplo3ForEach();

            //Exercícios
            Exercicio1();
            Exercicio2Multidimensional();
            Exercicio2Jambed();
        }

        static void Exercicio2Jambed()
        {
            const int size = 5;
            int[][] codigos = new int[size][];
            for (int i = 0; i < codigos.Length; i++)
            {
                codigos[i] = new int[size];
            }
            Random rnd = new();
            for (int j = 0; j < size; j++)
            {
                int columnSum = 0;
                Console.WriteLine("---------- COLUNA " + j + "---------------");
                for (int i = 0; i < size; i++)
                {
                    int randomValue = rnd.Next(1, 70); // creates a number between 1 and 12
                    codigos[i][j] = randomValue;
                    columnSum += randomValue;
                    Console.WriteLine(
                        "Coluna = " + j + "| Linha = " + i + " | Valor = " + randomValue
                    );
                }
                Console.WriteLine("Soma final da coluna " + j + " = " + columnSum);
            }
        }

        static void Exercicio2Multidimensional()
        {
            const int size = 5;
            int[,] codigos = new int[size, size];
            Random rnd = new();
            for (int j = 0; j < size; j++)
            {
                int columnSum = 0;
                Console.WriteLine("---------- COLUNA " + j + "---------------");
                for (int i = 0; i < size; i++)
                {
                    int randomValue = rnd.Next(1, 70); // creates a number between 1 and 12
                    codigos[i, j] = randomValue;
                    columnSum += randomValue;
                    Console.WriteLine(
                        "Coluna = " + j + "| Linha = " + i + " | Valor = " + randomValue
                    );
                }
                Console.WriteLine("Soma final da coluna " + j + " = " + columnSum);
            }
            codigos[0, 0] = 11;
        }

        static void Exercicio1()
        {
            const int size = 5;
            int[] arrayOg = new int[size] { 10, 20, 30, 40, 50 };
            int[] arrayClone = new int[size];

            Array.Copy(arrayOg, arrayClone, size);

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Indice = " + i + " & Valor = " + arrayClone[i]);
            }
        }

        static void Exemplo3ForEach()
        {
            DateTime[] dt = new DateTime[2];
            dt[0] = new DateTime(2002, 5, 1);
            dt[1] = new DateTime(2002, 6, 1);
            foreach (var item in dt.Select((value, i) => new { i, value }))
            {
                Console.WriteLine(
                    "Indice = " + item.i + " & Data = " + item.value.ToShortDateString()
                );
            }
        }

        static void Exemplo2ForEach()
        {
            string[] str = new string[3];
            str[0] = "Um";
            str[1] = "Dois";
            str[2] = "Tres";
            foreach (var item in str.Select((value, i) => new { i, value }))
            {
                Console.WriteLine("Indice = " + item.i + " & Valor = " + item.value);
            }
        }

        static void Exemplo1ForEach()
        {
            int[] array = new int[5] { 10, 20, 30, 40, 50 };
            foreach (var item in array.Select((value, i) => new { i, value }))
            {
                Console.WriteLine("Indice = " + item.i + " & Valor = " + item.value);
            }
        }

        static void Exemplo3()
        {
            DateTime[] dt = new DateTime[2];
            int iDate;
            dt[0] = new DateTime(2002, 5, 1);
            dt[1] = new DateTime(2002, 6, 1);
            for (iDate = 0; iDate < 2; iDate++)
            {
                Console.WriteLine(
                    "Indice = " + iDate + " & Data = " + dt[iDate].ToShortDateString()
                );
            }
        }

        static void Exemplo2()
        {
            string[] str = new string[3];
            int iStr;
            str[0] = "Um";
            str[1] = "Dois";
            str[2] = "Tres";
            for (iStr = 0; iStr < 3; iStr++)
            {
                Console.WriteLine("Indice = " + iStr + " & Valor = " + str[iStr]);
            }
        }

        static void Exemplo1()
        {
            int[] array = new int[5] { 10, 20, 30, 40, 50 };
            int i;
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Indice = " + i + " & Valor = " + array[i]);
            }
        }
    }
}
