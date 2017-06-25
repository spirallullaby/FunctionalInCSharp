using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var delCalculator = new DelegationCalculator();
            Console.WriteLine(delCalculator.Calculate("5+6".ParseInput()));
            Console.WriteLine(delCalculator.Calculate("6-4".ParseInput()));
            Console.WriteLine(delCalculator.Calculate("6/2".ParseInput()));
            Console.WriteLine(delCalculator.Calculate("6*3".ParseInput()));
            Console.ReadLine();
            var anonCaclculator = new AnonymousMethodCalculator();
            Console.WriteLine(anonCaclculator.Calculate("5+6".ParseInput()));
            Console.WriteLine(anonCaclculator.Calculate("6-4".ParseInput()));
            Console.WriteLine(anonCaclculator.Calculate("6/2".ParseInput()));
            Console.WriteLine(anonCaclculator.Calculate("6*3".ParseInput()));
            Console.ReadLine();
            var lambdaCalculator = new LambdaCalculator();
            Console.WriteLine(lambdaCalculator.Calculate("5+6".ParseInput()));
            Console.WriteLine(lambdaCalculator.Calculate("6-4".ParseInput()));
            Console.WriteLine(lambdaCalculator.Calculate("6/2".ParseInput()));
            Console.WriteLine(lambdaCalculator.Calculate("6*3".ParseInput()));
            Console.ReadLine();
        }
    }
}
