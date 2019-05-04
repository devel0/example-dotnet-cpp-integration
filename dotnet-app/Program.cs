using System;
using System.Runtime.InteropServices;

namespace dotnet_app
{
    class Program
    {
        [DllImport("./lib.so")]
        public static extern int sum(int a, int b);
                
        public delegate void MyFunctionDelegate(string frame);

        [DllImport("./lib.so")]
        public static extern void follower(int q, MyFunctionDelegate fn);

        static void Main(string[] args)
        {
            Console.WriteLine($"1+2={sum(1, 2)}");

            follower(10, (str) =>
            {
                System.Console.WriteLine(str);
            });
        }
    }
}
