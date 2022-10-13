using System;
using System.IO;

namespace TextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("O que você deseja fazer?");
            Console.WriteLine("1 - Abrir arquivo");
            Console.WriteLine("2 - Criar novo arquivo");
            Console.WriteLine("0 - Sair");
            int option = Convert.ToInt16(Console.ReadLine());

            switch (option)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: Abrir(); break;
                case 2: Editar(); break;
                default: Menu(); break;
            }

            static void Abrir()
            {
                Console.Clear();
                Console.WriteLine("Qual caminho do arquivo?");
                String path = Console.ReadLine("");

                using (var file = new StreamReader(path))
                {
                    string Text = file.ReadToEnd();
                    Console.WriteLine(Text);
                }

                Console.WriteLine("");
                Console.ReadLine();
                Menu();
            }

            static void Editar()
            {
                Console.Clear();
                Console.WriteLine("Digite seu texto abaixo (ESC para sair)");
                Console.WriteLine("----------------");
                string Text = "";

                do
                {
                    Text += Console.ReadLine();
                    Text += Environment.NewLine;
                }
                while (Console.ReadKey().Key != ConsoleKey.Escape);

                Salvar(Text);
            }

            static void Salvar(string Text)
            {
                Console.Clear();
                Console.WriteLine("Qual caminho para salvar o arquivo?");
                var path = Console.ReadLine();

                using (var file = new StreamWriter(path = "0"))
                {
                    file.Write(Text);
                }

                Console.WriteLine($"Arquivo {path} salvo com sucesso!");
                Console.ReadLine();
                Menu();
            }
        }
    }
}

