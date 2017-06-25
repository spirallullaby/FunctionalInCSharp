using System;
namespace FunctionalInCSharp
{
    public class AnonymousMethodCalculator
    {
        delegate decimal MathOperation(decimal left, decimal right);
        private MathOperation GetOperation(EOperations operation)
        {
            switch (operation)
            {
                case EOperations.Add:
                    return delegate (decimal left, decimal right) { return left + right; };
                case EOperations.Divide:
                    return delegate (decimal left, decimal right) { return left / right; };
                case EOperations.Multiply:
                    return delegate (decimal left, decimal right) { return left * right; };
                case EOperations.Subtract:
                    return delegate (decimal left, decimal right) { return left - right; };
            }
            return null;
        }
        public decimal Calculate(Tuple<char, decimal, decimal> input)
        { 
            return GetOperation(input.Item1.ConvertToEnum())(input.Item2, input.Item3);
        }
    }
}
