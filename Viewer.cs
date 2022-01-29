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
            System.Console.WriteLine(strong.IsMatch("strong"));//continuar daqui

        }



    }

}