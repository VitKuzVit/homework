System.Console.WriteLine("Введите число ");
int number = Convert.ToInt32( Console.ReadLine() );

if(number % 7 == 0 && number % 23 == 0)
{
    System.Console.WriteLine($"{number} => да");
}
else
{
    System.Console.WriteLine($"{number} => нет");
}