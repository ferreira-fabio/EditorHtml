using System;
using System.IO;
using System.Threading;

namespace EditorHtml
{
    
    public class OpenFile{

        
        public static void Show(){
            Console.Clear();
            System.Console.WriteLine(" Entre com o local de destino e nome do arquivo: ");
            System.Console.WriteLine(@"Ex: C:\dev...");//usando @ para inserir caracteres especiais em um console.WriteLine
            System.Console.WriteLine("Pressione Esc para sair.");
            var path = Console.ReadLine();
            OpenFiles(path);
        }

        public static void OpenFiles(string path){

            using (var file = new StreamReader(path))
            {
                System.Console.WriteLine(file.ReadToEnd());
                
            }
            System.Console.WriteLine("Pressione 1 para voltar ao menu ou 0 para Sair");
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


    }
}