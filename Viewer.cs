using System;
using System.Text.RegularExpressions;
using System.Threading;

namespace EditorHtml
{
    public class Viewer
    {

        public static void Show(String text)
        {

            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            System.Console.WriteLine("Você entrou no modo visualizador! Pressione ESC para Sair!");
            System.Console.WriteLine("--------------------");
            Replace(text);
            System.Console.WriteLine("--------------------");
            Thread.Sleep(1000);
            Console.ReadKey();
            Menu.Show();

        }

        public static void Replace(string text)
        {
            var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
            System.Console.WriteLine(strong.IsMatch("strong"));
            var words = text.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                
                if (strong.IsMatch(words[i]))
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
                }else{
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(words[i]);
                    Console.Write(" ");
                }

            }

        }



    }

}