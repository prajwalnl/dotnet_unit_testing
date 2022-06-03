namespace Calculator_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basic Calculator!");
            Console.WriteLine("Enter first number");
            string temp1 = Console.ReadLine();
            double num1 = Convert.ToDouble(temp1);
            Console.WriteLine("Enter operation name (+,-,*,/)");
            string operation = Console.ReadLine();
            Console.WriteLine("Enter second number");
            string temp2 = Console.ReadLine();
            double num2 = Convert.ToDouble(temp2);

            Basic basic = new Basic();
            var answer = basic.basic_operations(operation, num1, num2);
            Console.WriteLine(answer);
        }
    }

    public class Basic
    {
        public double basic_operations(String operation, double a, double b)
        {
            var result = 3.14169;
            if (operation == "+")
            {
                result = a + b;
            }
            else if (operation == "-")
            {
                result = a - b;
            }
            else if (operation == "*")
            {
                result = a * b;
            }
            else if (operation == "/")
            {
                result = a / b;
            }

            return result;
        }
    }
}