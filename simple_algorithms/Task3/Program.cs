// Задать переменную
System.Console.WriteLine("Введите двухзначное число ");
int number = Convert.ToInt32( Console.ReadLine() );
if ( number < 10 || number > 99 ) Console.WriteLine( "Ошибка!" );
else {


// int number = new Random().Next(10, 100);
// Вычислить(узнать) левое и правое число и засунуть их в переменные
int LeftDigit = number / 10;
int rightDigit = number % 10;
// далее создать сравнение и ветвление IF ELSE (Если левое больше чем правое число то пишем левое в противном случае пиши правое)
if(LeftDigit > rightDigit)
{
    System.Console.WriteLine($"{number} -> {LeftDigit}");
}
else
{
    System.Console.WriteLine($"{number} -> {rightDigit}");
}
}