using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {

        public static int Max(int[] tomb, out int hely)
        {

            int max = tomb[0];
            hely = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] > max)
                {
                    max = tomb[i];
                    hely = i;
                }
            }
            return max;
        }

        public static int Min(int[] tomb, out int hely) {

            int min = tomb[0];
            hely = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] < min) {
                    min = tomb[i];
                    hely = i;
                }
            }
            return min;   
        }


            static void Main(string[] args)
        {
            int[] szamok = new int[10];

            Console.WriteLine("Kérem adjon meg 10 db számot!");

            for (int i = 0; i < 10; i++)
            {
                string keres;
                do
                {
                    Console.WriteLine("Az {0} szám!",i+1);
                    keres = Console.ReadLine();

                } while (int.TryParse(keres, out szamok[i])==false);
            }

            for (int i = 0; i < szamok.Length; i++)
            {
                Console.WriteLine(szamok[i]);
            }
            int helye;
            int legnagyobb = Max(szamok, out helye);
            int legkisebb = Min(szamok, out helye);
            Console.WriteLine("A legnagyobb szám: {0} és a helye: {1}",legnagyobb,helye+1);
            Console.WriteLine("A legkisebb szám: {0} és a helye: {1}",legkisebb, helye + 1);

            Console.ReadKey();
        }
    }
}
