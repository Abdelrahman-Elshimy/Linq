using System;

namespace CADelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            M2(M1);
        }

        static void M1()
        {
            Console.WriteLine("M 1");
        }
        static void M2(Action md)
        {
            md();
            Console.WriteLine("M 2");
        }
    }
}
