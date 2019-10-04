using System;

namespace Array_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tal = new int[5];
            for (int i = 0; i < tal.Length; i++)
            {
                Console.WriteLine("skriv tal");
                tal[i]=int.Parse (Console.ReadLine());
            }
            for (int i=tal.Length-1;i>=0; i--)
            Console.WriteLine(tal[i]);




        }
    }
}
