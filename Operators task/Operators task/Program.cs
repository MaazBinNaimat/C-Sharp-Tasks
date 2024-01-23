namespace Operators_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            char operators;
            int result;

            Console.WriteLine("Enter First Value");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Value");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter an operator (+, -, *, /):");
            operators = Console.ReadLine()[0];


            // Console.WriteLine(num1);
            // Console.WriteLine(num2);
            // Console.WriteLine($"You Operator: {operators}");

            if (operators == '+')
            {
                result = num1 + num2;
            }
            else if (operators == '-')
            {
                result = num1 - num2;
            }
            else if (operators == '*')
            {
                result = num1 * num2;
            }
            else if (operators == '/')
            {
                result = num1 / num2;
                
            }
            else
            {
                Console.WriteLine("Invalid operator!");
                return;
            }

            Console.WriteLine($"Result: {result}");

        }
    }
}
