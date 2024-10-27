using System.Diagnostics;

namespace Calculadora
{
    class Calculos
    {
        static void Main(string[] argsdo)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Ola sou uma calculadora :) digite qual tipo de conta voce quer:");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtracao");
            Console.WriteLine("3 - Divisao");
            Console.WriteLine("4 - Multiplicacao");
            Console.WriteLine("5 - Sair");
            Console.WriteLine("-----------------");
            Console.WriteLine("");
            int decisao = int.Parse(Console.ReadLine());
            switch(decisao)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicao(); break;
                case 5: System.Environment.Exit(0); break;
                default : Menu(); break;
            }
            Console.ReadKey();
        }
        static void Soma()
        {
            Console.Clear();
            double valor1soma = double.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor:");
            double valor2soma = double.Parse(Console.ReadLine());
            var result = valor1soma + valor2soma;
            Console.WriteLine("O resultado da sua conta e: " + result);
            Console.ReadKey();
            Menu();

        }
        static void Subtracao()
        {
            Console.Clear();
             double valor1sub = double.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor:");
            double valor2sub = double.Parse(Console.ReadLine());
            var resultsub = valor1sub - valor2sub;
            Console.WriteLine("O resultado da sua conta e: " + resultsub);
            Console.ReadKey();
            Menu();
        }
        static void Divisao()
        {
            Console.Clear();
            double valor1div = double.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor:");
            double valor2div = double.Parse(Console.ReadLine());
            var resultadodiv = valor1div / valor2div;
            Console.WriteLine("O resultado da sua conta e: " + resultadodiv);
            Console.ReadKey();
            Menu();
        }
        static void Multiplicao()
        {
            Console.Clear();
            double valor1mul = double.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor:");
            double valor2mul = double.Parse(Console.ReadLine());
            Console.WriteLine("O resultado da sua conta e: " + (valor1mul * valor2mul));
            Console.ReadKey();
            Menu();
        }
    }
}