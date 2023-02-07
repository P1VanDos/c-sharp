using System;

namespace DemoSplitFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 zadanie
            /*int[] omas = new int[12] { 5, -2, 3, -6, 7, 9, -4, 8, 1, 2, 7, -3 };
            foreach (int elem in omas)
            {
                Console.Write($"{elem}\t");
            }*/

            //2 zadanie


            /*int[] omas = new int[12] { 5, -2, 3, -6, 7, 9, -4, 8, 1, 2, 7, -3 };
            foreach (int elem in omas)
            {
                if (elem > 0)
                    Console.Write($"{elem}\t");
            }*/

            // 3 zadanie

            /*int[] omas = new int[] { 18,-4,16,5,10,-7 };
            foreach (int elem in omas)
            {
                Console.Write($"{elem}\t");
            }
*/

            // 4 zadanie
            Random rnd = new Random();
            int n = rnd.Next(163,180);
            int[] myArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                myArray[i] = rnd.Next(180);
            }
            foreach (int elem in myArray)
            {
                Console.WriteLine("{0} ", elem);

            }
        }
    }
}
