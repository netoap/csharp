using System;
using MulticastDelegates.Services;

namespace MulticastDelegates
{
    class Program
    {
        // É uma referência (com type safety) para um ou mais métodos
        // É um tipo referência
        delegate void BinaryNumericOperation(double n1, double n2);
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationService.ShowSum;
            op += CalculationService.ShowMax;
            op.(a,b); // vai mostrar 22 e depois 12
        }
    }
}
