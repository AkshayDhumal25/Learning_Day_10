// Generics
//using System;
//namespace generics
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("Enterthe 1st Element : ");
//            var a = Console.ReadLine();
//            Console.WriteLine("Enter the 2nd Element : ");
//            var b = Console.ReadLine();
//            swap(a, b);
//            Console.WriteLine($"A: {a} and B: {b}");
//        }
//        static void swap<T>(T a, T b)
//        {
//            var temp = a;
//            a = b;
//            b = temp;
//        }
//    }
//}

// Encapsulation
using System;
namespace encapsulation
{
    class rectangleArea
    {
        private double length;
        private double width;

        public double Length
        {
            get { return length; }
            set { length = value; }
        }

        public double Width
        {
            get { return width; }
            set { width = value; }
        }
        public double getArea()
        {
            return length * width;
        }

        public void Display()
        {
            Console.WriteLine($"Length : {length} and Width : {width}");
            Console.WriteLine($"Area :" + getArea());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            rectangleArea r = new rectangleArea();
            r.Length = 9.0;
            r.Width = 9.0;
            r.Display();
        }
    }
}