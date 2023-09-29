using System;

class Program
{
    static void Main()
    {
        // 1 
        Console.WriteLine("Завдання 1: Парні числа від 1 до 20:");
        for (int i = 2; i <= 20; i += 2)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine("\n");

        // 2
        Console.WriteLine("Завдання 2: Сума чисел від 1 до 100:");
        int sum = 0;
        for (int i = 1; i <= 100; i++)
        {
            sum += i;
        }
        Console.WriteLine("Сума: " + sum + "\n");

        // 3
        Console.Write("Завдання 3: Введіть число для таблиці множення: ");
        int multiplicationNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Таблиця множення для " + multiplicationNumber + ":");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{multiplicationNumber} * {i} = {multiplicationNumber * i}");
        }
        Console.WriteLine();

        //4
        Console.Write("Завдання 4: Введіть число для обчислення факторіала: ");
        int n = int.Parse(Console.ReadLine());
        int factorial = 1;
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }
        Console.WriteLine($"Факторіал {n} = {factorial}\n");

        // 5
        Console.WriteLine("Завдання 5: Сума простих чисел від 1 до 50:");
        int primeSum = 0;
        for (int i = 1; i <= 50; i++)
        {
            if (IsPrime(i))
            {
                primeSum += i;
            }
        }
        Console.WriteLine("Сума простих чисел: " + primeSum + "\n");

        // 6 
        Console.Write("Завдання 6: Введіть десяткове число для переводу в двійкову систему: ");
        int decimalNumber = int.Parse(Console.ReadLine());
        string binary = Convert.ToString(decimalNumber, 2);
        Console.WriteLine($"Двійкове представлення: {binary}\n");

        // 7
        Console.Write("Завдання 7: Введіть максимальне число для суми чисел Фібоначчі: ");
        int maxFibonacciNumber = int.Parse(Console.ReadLine());
        int a = 0, b = 1, fibonacciSum = 0, fibonacciCount = 0;
        while (a + b <= maxFibonacciNumber)
        {
            int next = a + b;
            fibonacciSum += next;
            a = b;
            b = next;
            fibonacciCount++;
        }
        Console.WriteLine($"Сума {fibonacciCount} чисел Фібоначчі менше {maxFibonacciNumber}: {fibonacciSum}\n");

        //8
        Console.Write("Завдання 8: Введіть перше число: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Введіть друге число: ");
        int num2 = int.Parse(Console.ReadLine());
        int gcd = FindGCD(num1, num2);
        Console.WriteLine($"Найбільший спільний дільник: {gcd}");
    }

    // Допоміжна функція для перевірки числа на простоту
    static bool IsPrime(int number)
    {
        if (number <= 1)
            return false;
        for (int i = 2; i * i <= number; i++)
        {
            if (number % i == 0)
                return false;
        }
        return true;
    }

    // Допоміжна функція для знаходження НСД
    static int FindGCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}
