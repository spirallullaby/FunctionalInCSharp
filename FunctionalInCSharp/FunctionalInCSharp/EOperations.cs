using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalInCSharp
{
    public enum EOperations
    {
       Add, Divide, Multiply, Subtract
    }
    public static class OperationsConverter
    {
        public static EOperations ConvertToEnum(this char operation)
        {
            switch (operation)
            {
                case '+': return EOperations.Add;
                case '-': return EOperations.Subtract;
                case '*': return EOperations.Multiply;
                case '/': return EOperations.Divide;
                default:
                    throw new ArgumentException("not supported operation");
            }
        }
    }
}
