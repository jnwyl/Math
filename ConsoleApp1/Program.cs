using System;

public class Activity1
{
    public int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    public int Subtract(int num1, int num2)
    {
        return num1 - num2;
    }

    public int Multiply(int num1, int num2)
    {
        return num1 * num2;
    }

    public double Divide(int num1, int num2)
    {
        if (num2 != 0)
        {
            return (double)num1 / num2;
        }
        else
        {
            Console.WriteLine("Cannot divide by zero");
            return 0;
        }
    }

    public static void Main()
    {
        Activity1 mathOps = new Activity1();

        Console.Write("Enter the first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Results:\nAddition: {mathOps.Add(num1, num2)}");
        Console.WriteLine($"Subtraction: {mathOps.Subtract(num1, num2)}");
        Console.WriteLine($"Multiplication: {mathOps.Multiply(num1, num2)}");
        Console.WriteLine($"Division: {mathOps.Divide(num1, num2)}");
    }
}