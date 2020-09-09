using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ismetles01
{
    class Program
    {
        static void Main(string[] args)
        {

            Random vel = new Random();
            string[] lehetoseg = new string[] { "Kő", "Papír", "Olló" };

            int jatekosValasz;

            Console.WriteLine("Kő (0), Papír (1), Olló (2)");
            Console.Write("Válasz: ");
            jatekosValasz = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Játékos választása: {0}", lehetoseg[jatekosValasz]);

            int gepValasz = vel.Next(0, 3);
            
            Console.WriteLine("Gép választása: {0}", lehetoseg[gepValasz]);

            if (gepValasz==0 && jatekosValasz==1 || gepValasz==1 && jatekosValasz==2 || gepValasz==2 && jatekosValasz==0)
            {
                Console.WriteLine("Győztél!");
            }
            else if (gepValasz == jatekosValasz)
            {
                Console.WriteLine("Döntetlen");
            }
            else if (gepValasz==0 && jatekosValasz==2 || gepValasz == 1 && jatekosValasz == 0 || gepValasz == 2 && jatekosValasz == 1)
            {
                Console.WriteLine("Vesztettél...");
            }

            Console.ReadKey();
        }
    }
}
