using System;
using System.Collections.Generic;
namespace random_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<int> numbers = new List<int>();
            for (int i = 0; i < 21; i++)
            {
                numbers.Add(random.Next(1, 51));
            }
            List<int> squaredNumbers = new List<int>();
            foreach(int item in numbers)
            {
                squaredNumbers.Add(item * item);
            }
            squaredNumbers.RemoveAll(i => i % 2 != 0);
            foreach(int item in squaredNumbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
