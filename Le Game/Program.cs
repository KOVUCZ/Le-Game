using System;

namespace Le_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Le Game");
            Random random = new Random();
            bool neuhodl = true;
            int nahodneCislo;
            int hadaneCislo;

            nahodneCislo = random.Next(1, 101);

            Console.WriteLine("Hádací hra");
            Console.WriteLine("-------------------------");
            Console.WriteLine("Myslím si číslo od 1 do 100");

            while (neuhodl)
            {
                Console.WriteLine("Vymysli si náhodné číslo od 1 do 100");
                hadaneCislo = int.Parse(Console.ReadLine());
                if(hadaneCislo > nahodneCislo)
                {
                    Console.WriteLine("To je moc");
                }
                else if (hadaneCislo < nahodneCislo)
                {
                    Console.WriteLine("To je málo");
                }
                else
                {
                    Console.WriteLine("YAYYY UHÁDL JSI! :D");
                    neuhodl = false;
                }
            }
            
            
            Console.ReadLine();

            
        }
    }
}
