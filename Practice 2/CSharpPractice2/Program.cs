using System;
using System.Collections.Generic;

namespace CSharp
{
    class Program
    {
        // Generic class
        class MyClass<T> where T : struct // reference, new(), Monster...
        {
            T[] arr = new T[10];

            public T GetItem(int i)
            {
                return arr[i];
            }
        }

        static void TestFunc<T>(T input)
        {

        }

        static void Main(string[] args)
        {
            object obj = 3;     // object is reference type
            int num = (int)obj; // int already inherits from object

            MyClass<int> class_a = new MyClass<int>();
            MyClass<string> class_b = new MyClass<string>();

            TestFunc<int>(3);
        }
    }
}