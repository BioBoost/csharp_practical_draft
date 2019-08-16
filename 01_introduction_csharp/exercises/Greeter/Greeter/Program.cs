using System;

namespace Greeter
{
    class Program
    {
        static void Main(string[] args)
        {
            Greeter greeter = new Greeter();
            Console.WriteLine(greeter.greet());
        }
    }
}
