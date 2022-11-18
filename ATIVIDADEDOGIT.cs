using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batutinhas_astrais
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ponto = new int[5];
            string[] nome = new string[5];
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("qual o nome do {0}° time", i+1);
                nome[i] = Console.ReadLine();
                Console.WriteLine("qual a pontuação do {0}° time?",i+1);
                ponto[i] = int.Parse(Console.ReadLine());
            }
            Console.ReadKey();
            Console.WriteLine("Time\t\tPontos");
            for (int i = 0; i < 5; i++)
            {
                
                Console.WriteLine("{0}\t\t{1}", nome[i], ponto[i]);
            }
            Console.ReadKey();

        }
    }
}
