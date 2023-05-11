using System;
using System.Text;

namespace Fundamentos.String
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Menu();

        }
    
        public static void Menu()
        {
            Console.Clear();
            Cabecario("  M  e  n  u  ");
            Console.WriteLine("0 - Sair");
            Console.WriteLine(" ");
            Console.WriteLine("1 - Guid - Aula 01");
            Console.WriteLine(" ");
            Console.WriteLine("2 - Interpolação - Aula 02");
            Console.WriteLine(" ");
            Console.WriteLine("3 - Comparação de Strings - Aula 03");
            Console.WriteLine(" ");
            Console.WriteLine("4 - StartsWith e EndsWith -  Aula 04");
            Console.WriteLine(" ");
            Console.WriteLine("5 - Equals - Aula 05");
            Console.WriteLine(" ");
            Console.WriteLine("6 - Índices - Aula 06");
            Console.WriteLine(" ");
            Console.WriteLine("7 - Métodos Adicionais - Aula 07");
            Console.WriteLine(" ");
            Console.WriteLine("8 - Manipulando String - Aula 08");
            Console.WriteLine(" ");
            Console.WriteLine("9 - StringBuilder - Aula 09");

            Cabecario("              ");
            Console.WriteLine("");
            Console.WriteLine("Escolha sua Opção :");
            short option = short.Parse(Console.ReadLine());
            switch (option)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: Contador(); break;
                case 2: Interpolacao(); break;
                case 3: Compara();break;
                case 4: StarEnd(); break;
                case 5: Igual(); break;
                case 6: Indices(); break;
                case 7: Adicional(); break;
                case 8: Manipula(); break;
                case 9: SBuilder(); break;

            }
        }

        // Guid - Aula 01
        public static void Contador()
        {

            var id = Guid.NewGuid(); // criar um sequencia aleatória
            id.ToString(); // transformar em uma string

            id = new Guid("02040c34-4ec1-4617-a7a6-e0019774deff"); // informar o id

        var idCompacto = id.ToString().Substring(0, 8); // pega os 8 primeiros caracteres

            Console.WriteLine("GRID gerado");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(id);
            Console.WriteLine(" ");
            Console.WriteLine(idCompacto);
            Console.WriteLine("");

            Retorno();
        }




        // Interpolação - Aula 02
        public static void Interpolacao()
        {
            Cabecario("Interpolação");

            var price = 10.2 + 9;
            var texto = "O preço é " + price + " somente na promoção"; // 1. interpolação = concatenação
            Console.WriteLine(texto);

            var texto1 = string.Format("O preço de {0}, somente na promoção", price); // 2. interpolação usando Format
            Console.WriteLine(texto1);

            Retorno();


        }
        // Aula 03
        public static void Compara()
        {
            Cabecario("Comparação de String");

            var texto = "Testando para melhor crescer ...";
            Console.WriteLine(texto.CompareTo("test"));// 0 - true; 1- false

            Console.WriteLine(texto.Contains("para")); // retorna true 
            Console.WriteLine(texto.Contains("Para")); // retorna false 
            Console.WriteLine(texto.Contains("Para", StringComparison.OrdinalIgnoreCase)); // retorna true, ignora se maiscula ou minusculo


            Retorno();
        }

        //Aula 04
        public static void StarEnd()
        {
            Cabecario("StartsWith e EndsWith usando");

            var texto = "Testando para melhor crescer";
            Console.WriteLine(texto.StartsWith("Test"));// Começa com ... retorna True

            Console.WriteLine(texto.StartsWith("test")); // retorna false
            Console.WriteLine(texto.EndsWith("cer")); // retorna false 
            Console.WriteLine(texto.EndsWith("Cer", StringComparison.OrdinalIgnoreCase)); // retorna true, ignora se maiscula ou minusculo


            Retorno();
        }

      
        //Aula 05
        public static void Igual()
        {
            Cabecario("Equals - compara e retorna true ou false");

            var texto = "Testando para melhor crescer";

            Console.WriteLine(texto.Equals("e")); // true ou false
            Console.WriteLine(texto.Equals("melhor")); 



            Retorno();
        }

        //Aula 06
        public static void Indices()
        {
            Cabecario("Indices");

            var texto = "Testando para melhor crescer";

            Console.WriteLine(texto.IndexOf("e")); // retorna a 1. posição
            Console.WriteLine(texto.LastIndexOf("r")); // retorna a ultima. posição



            Retorno();
        }

        //Aula 07
        public static void Adicional()
        {
            Cabecario("Métodos Adicionais");

            var texto = "Testando para melhor crescer";

            Console.WriteLine(texto.ToLower());
            Console.WriteLine("");
            Console.WriteLine(texto.ToUpper());
            Console.WriteLine("");
            Console.WriteLine(texto.Insert(5," Paralelepipedo "));
            Console.WriteLine("");
            Console.WriteLine(texto.Remove(5, 5));
            Console.WriteLine("");
            Console.WriteLine(texto.Length);

            Retorno();
        }


        // Aula 08
        public static void Manipula()
        {
            Cabecario("Manipulando Strings");

            var texto = "Testando para melhor crescer";
            Console.WriteLine(texto);
            Console.WriteLine("");
            Console.WriteLine(texto.Replace("e", "W"));

            var divisao = texto.Split(' ');// separa as palavras
            Console.WriteLine("");

            for(int i = 0; i < divisao.Length; i++) Console.WriteLine(divisao[i]);

            var resultado = texto.Substring(5, 10);
            Console.WriteLine(resultado);

            Retorno();
        }


        // Aula 09
        public static void SBuilder()
        {
            Cabecario("StringBuilder trabalhando com string grandes");

            var texto = new StringBuilder();

            texto.Append("Começo do texto");
            texto.Append("Na segunda linha aparece outro paragrafo");
            texto.AppendLine("Testando para ver como vai ficar ...");
 
            Console.WriteLine(texto.ToString());

            Retorno();
        }

        public static void Cabecario(string texto)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.BackgroundColor = ConsoleColor.Red;
            for (int i = 0; i < texto.Length; i++)
            {
                Console.Write(texto.Substring(i, 1).ToUpper() + "  ");
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("");
            Console.WriteLine("");

            

        }

        public static void Rodape(string texto)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.BackgroundColor = ConsoleColor.Red;
            for (int i = 0; i < 30; i++)
            {
                Console.Write(" ");
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("");
            Console.WriteLine("");

        }

        public static void Retorno()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.BackgroundColor = ConsoleColor.Red;
            for (int i = 0; i < 30; i++)
            {
                Console.Write(" ");
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Digite ao para voltar ...");
            Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("");

            Menu();
        }
    }
}
