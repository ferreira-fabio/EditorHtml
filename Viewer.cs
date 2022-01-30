using System;
using System.Text.RegularExpressions;
using System.Threading;

namespace EditorHtml
{
    public class Viewer
    {

        public static void Show()
        {

            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            System.Console.WriteLine("Você entrou no modo visualizador! Pressione ESC para Sair!");
            System.Console.WriteLine("--------------------");
            var text = " ";
            do
            {
                text = Console.ReadLine();
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Replace(text);
            System.Console.WriteLine(" ");            
            Thread.Sleep(1000);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            System.Console.WriteLine("--------------------");
            System.Console.WriteLine("Pressione 1 para voltar ao menu ou 0 para sair:");
            var choice = char.Parse(Console.ReadLine());
            if (choice == '1')
            {
                Menu.Show();
            }
            else
            {
                System.Console.WriteLine("GoodBye!");
                Thread.Sleep(1000);
                System.Environment.Exit(0);
            }

        }

        public static void Replace(string text)
        {
            var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>"); //Criado o regex para a palavra strong
           
            var words = text.Split(' ');

            for (int i = 0; i < words.Length; i++)//Criando um for para pegar o Array gerado por Split()
            {

                if (strong.IsMatch(words[i]))//buscando IsMatch com o Regex
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(
                        words[i].Substring(
                            words[i].IndexOf('>') + 1,
                            ((words[i].LastIndexOf('<') - 1) -
                            words[i].IndexOf('>'))
                        )
                    );
                    Console.Write(" ");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(words[i]);
                    Console.Write(" ");
                }

            }

        }



    }

}