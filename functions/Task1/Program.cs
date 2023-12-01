//Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
//Программа завершается при вводе символа ‘q’ 
//или при вводе числа, сумма цифр которого чётная.

int ReadInt()
{
System.Console.Write("Введите целые числа ");
return Convert.ToInt32(Console.ReadLine());
}
// int a = ReadInt();

int FindNumber()
{
    int a = ReadInt();
    int FirstNumber = a / 10;
    int SecondNumber = a % 10;
    int sum = FirstNumber + SecondNumber;
    return sum;
}
 //int b = FindNumber();

while(true)
{
    
    int c = FindNumber();
    
    if (c % 2 == 0) break;
}

// for(;;)
// {
//     System.Console.WriteLine("Введите число");
//     var a = (Console.ReadLine());
//     if(a == "q") break;
// }

