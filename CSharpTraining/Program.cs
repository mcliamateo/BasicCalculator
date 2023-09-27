using System;

namespace CSharpTraining
{
    class Program
    {
        public int Addition(int a, int b)
        {
            int sum = 0;
            sum = a + b;
            return sum;
        }
        public int Subtraction(int a, int b)
        {
            int difference = 0;
            difference = a - b;
            return difference;
        }

        public int Multiplication(int a, int b)
        {
            int product = 0;
            product = a * b;
            return product;
        }

        public double Division(int a, int b)
        {
            double qoutient = 0;
            qoutient = (double)a / b;
            return qoutient;
        }

        public void Exeption(string numberString) 
        {
            bool success = int.TryParse(numberString, out int number);

            if (success)
            {
                Console.WriteLine("Valid Number");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }

        public void Operation(int operationNumber, int a, int b)
        {
            switch (operationNumber)
            {
                case 1:
                    int sum = Addition(a, b);
                    Console.WriteLine($"{a} + {b} = {sum}");
                    break;
                case 2:
                    int difference = Subtraction(a, b);
                    Console.WriteLine($"{b} - {a} = {difference}");
                    break;
                case 3:
                    int product = Multiplication(a, b);
                    Console.WriteLine($"{b} x {a} = {product}");
                    break;
                case 4:
                    double qoutient = Math.Round(Division(a, b), 2);
                    Console.WriteLine($"{b} / {a} = {qoutient}");
                    break;
                default:
                    Console.WriteLine("WRONG INPUT");
                    break;
            }
        }

        public int StringToInteger(string toConvert) 
        {
            int convertedStringToInteger = int.Parse(toConvert);
            return convertedStringToInteger;
        }

        public int OperationSelector(string choiceOfOperation)
        {
            if (choiceOfOperation == "A")
            {
                return 1;
            }
            else if (choiceOfOperation == "S")
            {
                return 2;
            }
            else if (choiceOfOperation == "M")
            {
                return 3;
            }
            else if (choiceOfOperation == "D")
            {
                return 4;
            }
            else
            {
                return 0;
            }
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine("M - for Multiplication");
            Console.WriteLine("D - for Division");
            Console.WriteLine("A - for Addition");
            Console.WriteLine("S - for Subtraction");
            Console.Write("ENTER MODE OF BASIC CALCULATOR: ");

            string choiceOfOperation = Console.ReadLine();

            Console.Write("Enter first Number Input: ");
            string input1 = Console.ReadLine();
            program.Exeption(input1);
            Console.Write("Enter second Number Input: ");
            string input2 = Console.ReadLine();
            program.Exeption(input2);

            int choiceNumber = program.OperationSelector(choiceOfOperation);

            int a = program.StringToInteger(input1);
            int b = program.StringToInteger(input2);

            program.Operation(choiceNumber, a, b);

        }

        
    }
}
