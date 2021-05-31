using System;
using System.Collections.Generic;

namespace SuccessionOfFibonacci
{
    class Program
    {
        // Var
        static List<int> succession = new List<int>() { 0, 1 };
        static int quantity = 11; //<= Put quantity of number
        static int total = 0;
        static int sumOne = 0;
        static int sumTwo = 1;
        static void Main(string[] args)
        {
            Console.WriteLine(" --------------- SUCCESSION OF FIBONACCI ---------------\n\n");
            Operations();
            Print();
            Console.WriteLine("\n\n\n ------------------------- END -------------------------");
            Console.WriteLine("\n\n Press any Key....");
            Console.ReadKey();
        }
        static private void Operations()
        {
            for (int i = 2; i < quantity; i++)
            {
                Calculate();
                AddItemNumberAndIncrementVarSum();
            }
        }
        static private void AddItemNumberAndIncrementVarSum()
        {
            succession.Add(total);
            sumOne++;
            sumTwo++;
        }
        static private void Calculate() => total = succession[sumOne] + succession[sumTwo];
        static private void Print() => Console.Write(" " + string.Join("+", succession));
    }
}
