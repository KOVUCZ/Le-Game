using System;

namespace Le_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Le Game");
            Random random = new Random();
            int nahodneCislo;

            nahodneCislo = random.Next(1, 101);

            Console.WriteLine("Hádací hra");
            Console.WriteLine("-------------------------");
            Console.WriteLine("Myslím si číslo od 1 do 100");

            Console.ReadLine();

            
        }
    }
}
