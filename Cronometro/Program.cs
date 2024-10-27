using System;
using System.Security.Cryptography.X509Certificates;

namespace Cronometro
{
    class Program
    {
        static void Main(string[] args)
        {
              Menu();
        }
        static void Start1(int tempo)
        {
            for(int tempoenquantoconta = 0; tempoenquantoconta != tempo;)
            {
                   tempoenquantoconta++;
                   Console.Clear();
                   Console.WriteLine(tempoenquantoconta);
                   Thread.Sleep(1000);
            }
            Console.WriteLine("O Cronometro parou... retornando ao menu");
            Thread.Sleep(3000);
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Ola este e um Cronometro, digite quanto quer cronometrar:");
            Console.WriteLine("S = segundos exp: 3s = 3 segundos");
            Console.WriteLine("M = minutos exp: 3m = 3 minutos");
            Console.WriteLine("0 = Sair do Cronometro");
            string tempo2 = Console.ReadLine().ToLower();
            char tipo = char.Parse(tempo2.Substring(tempo2.Length -1, 1));
            int time = int.Parse(tempo2.Substring(0, tempo2.Length -1));
            int multiplicador = 1;

            if(tipo == 'm')
            
                multiplicador = 60;
            
            if(time == 0)
            
                System.Environment.Exit(0);

            Start1(time * multiplicador);
        }
        
    }
}