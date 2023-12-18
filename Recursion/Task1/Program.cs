int ReadInt(string str)
{
    System.Console.Write(str);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintNumber(int a, int b)
{
    if (b < a) return;
    System.Console.Write(a + " ");
    PrintNumber(a + 1, b);
    
}





int a = ReadInt("Введите число a: ");
int b = ReadInt("Введите число b: ");

PrintNumber(a, b);
