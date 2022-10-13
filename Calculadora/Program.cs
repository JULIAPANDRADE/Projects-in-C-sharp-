using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
            Soma();
            Subtracao();
            Multiplicacao();
            Divisao();
        }

        static void Menu()
        {
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("---------");
            Console.WriteLine("Selecione uma opção: ");

            float res = Convert.ToSingle(Console.ReadLine());

            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                case 5: System.Environment.Exit(0); break;

                default: Menu(); break;
            }
        }

        static void Soma()
        {
            Console.WriteLine("Primeiro valor: ");
            float v1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = Convert.ToSingle(Console.ReadLine());

            float resultado = v1 + v2;
            Console.WriteLine("O resultado da soma é: " + resultado);
            Console.ReadKey();
            Menu();
        }


        static void Subtracao()
        {
            Console.WriteLine("Primeiro valor: ");
            float v1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 - v2;
            Console.WriteLine($"O resultado da subtração é: {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.WriteLine("Primeiro valor: ");
            float v1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 * v2;
            Console.WriteLine($"O resultado da multiplicação é: " + (v1 * v2));
            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.WriteLine("Primeiro valor: ");
            float v1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 / v2;
            Console.WriteLine($"O resultado da divisão é: {resultado}");
            Console.ReadKey();
            Menu();
        }
    }
}


