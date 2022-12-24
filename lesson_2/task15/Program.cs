void Weekend(string dayNum)
{
    int checkNum;
    int.TryParse(dayNum, out checkNum);
    while (checkNum < 1 || checkNum > 7)
    {
        Console.WriteLine("Ошибка! Введите номер дня от 1 до 7: ");
        dayNum = Console.ReadLine()?? "0";
        int.TryParse(dayNum, out checkNum);
    }

    if (checkNum == 6 || checkNum == 7)
    {
        Console.WriteLine($"День номер {checkNum} является выходным.");
    }
    else
    {
        Console.WriteLine($"День номер {checkNum} не является выходным.");
    }
}