// Generics
using System;
namespace generics
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enterthe 1st Element : ");
            var a = Console.ReadLine();
            Console.WriteLine("Enter the 2nd Element : ");
            var b = Console.ReadLine();
            swap(a, b);
            Console.WriteLine($"A: {a} and B: {b}");
        }
        static void swap<T>(T a, T b)
        {
            var temp = a;
            a = b;
            b = temp;
        }
    }
}