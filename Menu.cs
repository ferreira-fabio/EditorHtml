using System;
using System.Threading;

namespace EditorHtml
{

    public static class Menu {

        public static void Show(){

            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;

            DrawScreen();
            WriteOptions();
            

            var options = short.Parse(Console.ReadLine());
            HandleMenuOption(options);

            }

            public static void DrawScreen(){

                CollumBorder();
                CollumSide();
                CollumBorder();

                       }

            public static void WriteOptions(){

                Console.SetCursorPosition(4, 3);// usado para escrever dentro de um determinado campo,como dentro do método DrawScreen.
                System.Console.WriteLine("Bem Vindo Ao Editor HTML!");
                Console.SetCursorPosition(4, 4);
                System.Console.WriteLine("==========================");
                Console.SetCursorPosition(4, 5);
                System.Console.WriteLine("Selecione uma opção abaixo:");
                Console.SetCursorPosition(4, 7);
                System.Console.WriteLine("1 - Novo arquivo");
                Console.SetCursorPosition(4, 8);
                System.Console.WriteLine("2 - Abrir");
                Console.SetCursorPosition(4, 10);
                System.Console.WriteLine("0 - Sair");
                Console.SetCursorPosition(4, 11);
                System.Console.Write("Opção: ");

            }

            public static void HandleMenuOption(short options){

                switch (options)
                {
                    case 1 : Editor.Show();break;
                    case 2 : System.Console.WriteLine("teste 2");break;
                    case 0 : {
                        Console.Clear();
                        System.Console.WriteLine("GoodBye!");
                        Thread.Sleep(1000);
                        Environment.Exit(0);break;
                    }
                    default: {
                            System.Console.WriteLine("Opção inválida: ");
                            Thread.Sleep(800);
                            System.Console.WriteLine("Retornando ao menu principal.");
                            Thread.Sleep(1000);
                            Show();break;

                    }
                }


            }

            //FUNCTIONS
             static void CollumBorder(){

                System.Console.Write("+");

                for (int i = 0; i <= 40; i++)
                {
                    System.Console.Write("-");
                    
                }System.Console.Write("+");

        }

            static void CollumSide(){
            System.Console.Write(Environment.NewLine);
            for (int newLine = 0; newLine <= 12; newLine++)
            {
                
            
            System.Console.Write("|");
            for (int line = 0; line <=40; line++)
            {
                System.Console.Write(" ");
                
            }System.Console.Write("|");
             System.Console.Write(Environment.NewLine);
            }
        }

    }
    
}