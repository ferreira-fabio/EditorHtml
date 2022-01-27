using System;
using System.IO;
using System.Text;
using System.Threading;

namespace EditorHtml
{

    public class Editor
    {

        public static void Show()
        {

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            System.Console.WriteLine("Você entrou no modo editor! Pressione ESC para Sair!");
            System.Console.WriteLine("--------------------");
            Thread.Sleep(1000);
            Start();


        }

        public static void Start()
        {

            var file = new StringBuilder(); //Criando objeto StringBuilder para armazenar a cadeia de characters.

            do
            {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);

            } while (Console.ReadKey().Key != ConsoleKey.Escape);//Ratreio de key através do método ReadKey()


            System.Console.WriteLine("  Deseja salvar o arquivo?");
            Thread.Sleep(500);
            System.Console.WriteLine("1 - Salvar Arquivo");
            System.Console.WriteLine("2 - Voltar ao menu");
            var option = char.Parse(Console.ReadLine());

            ChoiceSave(option, file);


        }


        public static void ChoiceSave(char option, StringBuilder file)
        {

            switch (option)
            {
                case '1': SaveFile(file); break;
                case '2':
                    {
                        System.Console.WriteLine("Retornando ao menu");
                        Thread.Sleep(1000);
                        Menu.Show();
                    }; break;

                default:
                    {
                        System.Console.WriteLine("Opção inválida!");
                        Thread.Sleep(500);
                        System.Console.WriteLine("Voltando para o menu principal.");
                        Thread.Sleep(500);
                        Menu.Show();
                    }; break;
            }

        }

        public static void SaveFile(StringBuilder file) 
        {


            Console.Clear();
            System.Console.WriteLine(" Entre com o local de destino e nome do arquivo: ");
            System.Console.WriteLine("Ex: C:\\dev...");
            var path = Console.ReadLine();


            using (var sw = new StreamWriter(path))
            {

                sw.WriteLine(file.ToString());     //Forçando o Stringbuilder file dentro do StreamWritter

            }
            System.Console.WriteLine("Salvo com sucesso!!!");
            Thread.Sleep(800);
            System.Console.WriteLine("Retornando para o menu.");
            Thread.Sleep(800);
            Menu.Show();

        }


    }





}
