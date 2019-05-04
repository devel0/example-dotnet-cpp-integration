using System;
using System.Runtime.InteropServices;

namespace dotnet_app
{
    class Program
    {
        [DllImport("./lib.so")]
        public static extern int sum(int a, int b);

        static void Main(string[] args)
        {
            Console.WriteLine($"1+2={sum(1, 2)}");
        }
    }
}
