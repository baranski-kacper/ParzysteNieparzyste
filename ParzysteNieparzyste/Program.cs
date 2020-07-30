using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParzysteNieparzyste
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Podaj liczbe:");
                if (Liczba() % 2 == 0)
                {
                    Console.WriteLine("To liczba parzysta");
                }
                else Console.WriteLine("To liczba nieparzysta");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //Waiting for something 
                Console.ReadKey();
            }

        }

        private static int Liczba()
        {
            if (!int.TryParse(Console.ReadLine(), out int value)) throw new Exception("Podana Wartosć jest nie prawidłowa!");
            return value;
        }
    }
}
