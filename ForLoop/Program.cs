using System;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {

           Console.WriteLine("Example 1"); 
           for (int i =0; i<5; i++)
            {
                Console.WriteLine($"{i}");
                
            }
            Console.WriteLine();


            Console.WriteLine("Example 2");
            for (int j = 5; j<10; j++)
            {
                Console.WriteLine(j);
            }
            Console.WriteLine();


            Console.WriteLine("Example 3");
            for(int k=5; k > 0; k--)
            {
                Console.WriteLine(k);
            }
            Console.WriteLine();


            Console.WriteLine("Example 4");
            for(int a=5; a>=0; a--)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine();

            Console.WriteLine("Example 5");
            for (int q=8; q==8; q++)
            {
                Console.WriteLine("Done Learning FOR Loop");
            }
        }
    }
}
