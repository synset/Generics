using System;

namespace GenericScale
{
    class Program
    {
        static void Main(string[] args)
        {
            Scale<string> scale = new Scale<string>("5", "10");
            Console.WriteLine(scale.GetHeavier());
        }
    }
}
