using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1st input: ");
            int input1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2nd Input: ");
            int input2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Select 1-AND, 2-OR, 3-XOR: ");

            int gate = Convert.ToInt32(Console.ReadLine());

            switch (gate)
            {
                case 1:
                    Console.WriteLine("This is an AND gate operation.");
                    var orResult = input1 | input2;
                    Console.WriteLine("OR Operation - {0} & {1} = {2}", input1, input2, orResult);
                    break;
                case 2:
                    Console.WriteLine("This is an OR gate operation.");
                    var andResult = input1 & input2;
                    Console.WriteLine("AND Operation - {0} & {1} = {2}", input1, input2, andResult);
                    break;
                case 3:
                    Console.WriteLine("This is an XOR gate operation.");
                    var xorResult = input1 ^ input2;
                    Console.WriteLine("XOR Operation - {0} ^ {1} = {2}", input1, input2, xorResult);
                    break;
            }
        }
    }
}
