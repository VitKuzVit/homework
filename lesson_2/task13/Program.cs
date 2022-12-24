void FindThird(string num1)
{
    int number;
    int.TryParse(num1, out number);
    while (number == 0)
    {
        Console.WriteLine("Неверный ввод! Введите число, не равное нулю: ");
        num1 = Console.ReadLine() ?? "0";
        int.TryParse(num1, out number);
    }
    int length = num1.Length;
    if (number < 0)
    {
        length -= 1;
    }

    if (length < 3)
    {
        Console.WriteLine($"У числа {number} нет третьей цифры");
    }
    else
    {
        if (number < 0)
        {
            Console.WriteLine($"Третья цифра числа {number} - {num1[3]}");
        }
        else
        {
            Console.WriteLine($"Третья цифра числа {number} - {num1[2]}");
        }
    }
    
}
