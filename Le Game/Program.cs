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

            while (true)
            {

                nahodneCislo = random.Next(1, 5);
                Console.WriteLine(nahodneCislo);
                Console.ReadLine();
            }
            

            
        }
    }
}
