using System;

namespace helloworld.app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.ToString("hh:mm:ss"));

            Console.ReadKey();
        }
    }
}
