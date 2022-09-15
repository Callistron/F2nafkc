using System;

namespace f2nafk12ora
{
    class szamol {
        static int darab = 0;
        public static int maxdarab = 0;
        public szamol()
        {
            darab++;
            Console.WriteLine(darab);
            
        }
        ~szamol()
        {
            darab = darab - 1;
        }
    }

    class Program

    {
            static void Main(string[] args)
        {
            for(int i=0;i<550000;i++)
            {
                new szamol();
            }
        }
    }
}
