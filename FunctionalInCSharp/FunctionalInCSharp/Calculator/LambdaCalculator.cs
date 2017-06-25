using System;
namespace FunctionalInCSharp
{
    class LambdaCalculator
    {
        private Func<decimal, decimal, decimal> GetOperation(EOperations operation)
        {
            switch (operation)
            {
                case EOperations.Add:
                    return (left, right) => left + right;
                case EOperations.Divide:
                    return (left, right) => left / right;
                case EOperations.Multiply:
                    return (left, right) => left * right;
                case EOperations.Subtract:
                    return (left, right) => left - right;
            }
            return null;
        }
        public decimal Calculate(Tuple<char, decimal, decimal> input)
        {
            return GetOperation(input.Item1.ConvertToEnum())(input.Item2, input.Item3);
        }
    }
}
