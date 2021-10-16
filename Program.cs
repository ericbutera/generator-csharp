// https://github.com/bchavez/Bogus

using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            var f = new Bogus.Faker("en");

            Console.WriteLine(f.Name.FullName());
        }
    }
}
