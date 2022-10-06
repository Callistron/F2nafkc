using System;

namespace f2nafkokt10


{
    


    class Program
    {
        static void Main(string[] args)
        {
            int[] array= new int[3];
            array[0] = 2;
            array[1] = 5;
            array[2] = 7;
            
            for (int i=array.Length-1;i>=0;i--) {
                Console.WriteLine(array[i]);
            }

            int[] sarray = new int[3];
            sarray[0] = 2;
            sarray[1] = 5;
            sarray[2] = 8;
            int sum = 0;
            foreach (int item in sarray) {
                sum += item;
            }
            Console.WriteLine("Tomb osszeg: "+sum);

            int[] tarray = new int[3];
            tarray[0] = 15;
            tarray[1] = 10;
            tarray[2] = 12;

            int[] copray = new int[3];
            System.Array.Copy(tarray, copray, 3);
            Console.WriteLine("Masolt tomb: ");
            foreach (int item in copray)
            {
                Console.WriteLine(item);
            }

            int[] splitray = new int[5];
            splitray[0] = 25;
            splitray[1] = 47;
            splitray[2] = 42;
            splitray[3] = 56;
            splitray[4] = 32;

            Console.Write("The Even elements Are: ");
            foreach (int item in splitray)
            {
                if (item % 2 == 0)
                {
                    Console.Write(" "+item);
                }
           
            }
            Console.WriteLine();

            Console.Write("The Odd elements Are: ");
            foreach (int item in splitray)
            {
                if (item % 2 != 0)
                {
                    Console.Write(" "+item);
                }

            }
            Console.WriteLine();
        }
    }
}
