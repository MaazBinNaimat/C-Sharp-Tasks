namespace swap_values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initial values
            int a = 10;
            int b = 20;

            Console.WriteLine($"Before swapping: a = {a}, b = {b}");

            // Swapping values
            int c = a;
            a = b;
            b = c;

            Console.WriteLine($"After swapping: a = {a}, b = {b}");
        }
    }
}
