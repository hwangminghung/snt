using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Nhập số cần kiểm tra:");
        int number = int.Parse(Console.ReadLine());

        bool isPrime = IsPrime(number);

        if (isPrime)
        {
            Console.WriteLine("Số " + number + " là số nguyên tố");
        }
        else
        {
            Console.WriteLine("Số " + number + " không là số nguyên tố");
        }
    }

    static bool IsPrime(int number)
    {
        if (number <= 1)
        {
            return false;
        }

        for (int i = 2; i * i <= number; i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}