using System;

namespace Greeter.Solution
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
