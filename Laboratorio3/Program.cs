namespace Laboratorio3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exemplo1();
            // Exemplo2();
            // Exemplo2o1();
            // Exemplo3();

            // Exercicio1();
            Exercicio2();
        }

        private static void Exercicio2()
        {
            List<int> golsDoPelé = new() { 10, 400, 20, 40, 1000, 20, 2983 };
            int totalAcimaDaMedia = TotalAcimaMedia(golsDoPelé);
            List<int> golsAcimaDaMedia = GolsAcimaDaMedia(golsDoPelé);
        }

        static List<int> GolsAcimaDaMedia(List<int> lista)
        {
            double mediaDeGolsDoPele = lista.Average();
            Console.WriteLine("Média de gols do Pelé: {0}", mediaDeGolsDoPele);
            List<int> golsAcimaDaMedia = lista.Where(g => g > mediaDeGolsDoPele).ToList();
            Console.WriteLine("Gols acima da média: {0}", string.Join(", ", golsAcimaDaMedia));

            return golsAcimaDaMedia;
        }

        static int TotalAcimaMedia(List<int> lista)
        {
            double mediaDeGolsDoPele = lista.Average();
            Console.WriteLine("Média de gols do Pelé: {0}", mediaDeGolsDoPele);
            int numeroDeGolsAcimaDaMedia = lista.Count(g => g > mediaDeGolsDoPele);
            Console.WriteLine("Número de gols acima da média: {0}", numeroDeGolsAcimaDaMedia);

            return numeroDeGolsAcimaDaMedia;
        }

        private static void Exercicio1()
        {
            Dictionary<int, string> paises = new Dictionary<int, string>();
            paises[44] = "Reino Unido";
            paises[33] = "França";
            paises[55] = "Brasil";
            paises[1] = "Brasuca";
            string ASerProcurado = "Bra";
            Console.WriteLine("Países encontrados com a palavra {0}:", ASerProcurado);
            paises
                .Where(p => p.Value.Contains(ASerProcurado))
                .ToList()
                .ForEach(p => Console.WriteLine("Código {0} = {1}", p.Key, p.Value));
        }

        static void Exemplo3()
        {
            Dictionary<int, string> paises = new Dictionary<int, string>();
            paises[44] = "Reino Unido";
            paises[33] = "França";
            paises[55] = "Brasil";
            Console.WriteLine("O código 55 é: {0}", paises[55]);
            foreach (var item in paises)
            {
                int codigo = item.Key;
                string pais = item.Value;
                Console.WriteLine("Código {0} = {1}", codigo, pais);
            }
        }

        static void Exemplo2o1()
        {
            Queue<int> minhaFila = new Queue<int>();
            minhaFila.Enqueue(10);
            minhaFila.Enqueue(200);
            minhaFila.Enqueue(1000);
            Console.WriteLine(minhaFila.Dequeue());
            Console.WriteLine(minhaFila.Dequeue());
            Console.WriteLine(minhaFila.Dequeue());
        }

        static void Exemplo2()
        {
            Queue<Object> q = new Queue<Object>();
            q.Enqueue(".Net Framework");
            q.Enqueue(new Decimal(123.456));
            q.Enqueue(654.321);
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());
        }

        static void Exemplo1()
        {
            List<string> listaStrings = new List<string>();
            listaStrings.Add("Um");
            listaStrings.Add("Hello");
            listaStrings.Add("World");
            Console.WriteLine(listaStrings[0]);
            Console.WriteLine(listaStrings[1]);
            Console.WriteLine(listaStrings[2]);
            //Erro de compilação
            //listaStrings.Add(10);
        }
    }
}
