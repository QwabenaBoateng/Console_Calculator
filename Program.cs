using System;

class function
{
    public void add(double x, double y)
    {
        double z = x + y;
        Console.WriteLine("Total is: " + z);
    }
    public void subtract(double x, double y)
    {
        double z = x - y;
        Console.WriteLine("Total is: " + z);
    }
    public void multiply(double x, double y)
    {
        double z = x * y;
        Console.WriteLine("Total is: " + z);
    }
    public void divide(double x, double y)
    {
        if (y != 0)
        {
            double z = x / y;
            Console.WriteLine("Total is: " + z);
        }
        else
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
        }
    }
}
class Program
{
    public static void Main(string[] args)
    {
        double a, b;
        int answer;
        char choice = 'Y';
        function objfunc = new function();
        while (choice == 'Y' || choice == 'y')
        {
            Console.WriteLine("Calculator");
            Console.WriteLine("...........");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("Enter your choice: ");
            answer = Convert.ToInt32(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    Console.WriteLine("Enter first number: ");
                    a = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter second number: ");
                    b = Convert.ToDouble(Console.ReadLine());
                    objfunc.add(a, b);
                    break;
                case 2:
                    Console.WriteLine("Enter first number: ");
                    a = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter second number: ");
                    b = Convert.ToDouble(Console.ReadLine());
                    objfunc.subtract(a, b);
                    break;
                case 3:
                    Console.WriteLine("Enter first number: ");
                    a = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter second number: ");
                    b = Convert.ToDouble(Console.ReadLine());
                    objfunc.multiply(a, b);
                    break;
                case 4:
                    Console.WriteLine("Enter first number: ");
                    a = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter second number: ");
                    b = Convert.ToDouble(Console.ReadLine());

                    objfunc.divide(a, b);
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;


            }
            Console.WriteLine("Do you want to continue? (Y/N)");
            choice = Convert.ToChar(Console.ReadLine());
        }
    }
}
