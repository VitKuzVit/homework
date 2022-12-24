void FindMiddle(string num)
{
    int number;
    int.TryParse(num, out number);
    while (number < 100 || number > 999)
    {
        Console.WriteLine("Неверный ввод! Введите число от 100 до 999: ");
        num = Console.ReadLine() ?? "0";
        int.TryParse(num, out number);
    }
    int middle = number % 100 / 10;
    Console.WriteLine($"Вторая цифра числа {number} - {middle}");
}