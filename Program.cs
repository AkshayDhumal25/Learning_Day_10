﻿// Generics
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
//using System;
//namespace encapsulation
//{
//    class rectangleArea
//    {
//        private double length;
//        private double width;

//        public double Length
//        {
//            get { return length; }
//            set { length = value; }
//        }

//        public double Width
//        {
//            get { return width; }
//            set { width = value; }
//        }
//        public double getArea()
//        {
//            return length * width;
//        }

//        public void Display()
//        {
//            Console.WriteLine($"Length : {length} and Width : {width}");
//            Console.WriteLine($"Area :" + getArea());
//        }
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            rectangleArea r = new rectangleArea();
//            r.Length = 9.0;
//            r.Width = 9.0;
//            r.Display();
//        }
//    }
//}


// 14. [80, 60, 10, 50, 30, 100, 0, 50]
// Find pairs whose sum = 100;
// Logic for above problem?
// What will be the complexity for it?
// Any better solution for the above problem?

//using System;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            int[] arr = { 80, 60, 10, 50, 30, 100, 0, 50 };
//            Array.Sort(arr);
//            int left = 0;
//            int right = arr.Length - 1;
//            int targetSum = 100;
//            while (left < right)
//            {
//                int sum = (arr[left] + arr[right]);
//                if (sum == targetSum)
//                {
//                    Console.WriteLine(arr[left] + " " + arr[right]);
//                    left++;
//                    right--;
//                }
//                else if (sum < targetSum)
//                {
//                    left++;
//                }
//                else
//                {
//                    right--;
//                }

//            }
//        }
//    }
//}


//Enum
//using System;
//namespace Enum
//{
//    class Program
//    {

//        public enum ShippingMethod
//        {
//            RegularAirMail = 1,
//            RegisteredAirMail = 2,
//            Express = 3
//        }
//        public static void Main(string[] args)
//        {
//            var method = ShippingMethod.Express;
//            Console.WriteLine((int)method);
//        }
//    }
//}



//Constructors
// It's a special method present under a class responsible for initializing the variables of that class 
//using System;
//namespace constructors
//{
//    class Person
//    {
//        public Person(string name)
//        {
//            Console.WriteLine($"Hello my name is {name}");
//        }
//    }
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            Person p = new Person("Akshay");
//        }
//    }
//}

// ref and out parameters
using System;
namespace refandout
{
    class Program
    {

        public static void increment(out int a)
        {
            a = 10;
            a++;
            Console.WriteLine(a);
        }

        public static void Main(string[] args)
        {
            int a;
            Program.increment(out a);
        }
    }
}