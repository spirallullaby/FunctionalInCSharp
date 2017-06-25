using System;

namespace FunctionalInCSharp
{
    class DelegationCalculator
    {
        delegate decimal MathOperation(decimal left, decimal right);
        private static decimal Add(decimal left, decimal right)
        {
            return left + right;
        }
        private static decimal Subtract(decimal left, decimal right)
        {
            return left - right;
        }
        private static decimal Multiply(decimal left, decimal right)
        {
            return left * right;
        }
        private static decimal Divide(decimal left, decimal right)
        {
            return left / right;
        }
        private MathOperation GetOperation(EOperations operation)
        {
            switch (operation)
            {
                case EOperations.Add:
                    return Add;
                case EOperations.Divide:
                    return Divide;
                case EOperations.Multiply:
                    return Multiply;
                case EOperations.Subtract:
                    return Subtract;
                default:
                    return null;
            }
        }
        public decimal Calculate(Tuple<char, decimal, decimal> input)
        {
            var eoperation = input.Item1.ConvertToEnum();
            return GetOperation(eoperation)(input.Item2, input.Item3);
        }
    }
}
