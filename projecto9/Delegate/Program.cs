using System;
using Delegate.Services;

namespace Delegate
{
    // É uma referência (com type safety) para um ou mais métodos
    // É um tipo referência
    delegate double BinaryNumericOperation(double n1, double n2);
    class Program
    {
        
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            //BinaryNumericOperation op = CalculationService.Sum;
            //double result = CalculationService.Square(a);
            BinaryNumericOperation op = CalculationService.Max;
            double result = op(a,b);
            Console.WriteLine(result);
        }
    }
}
