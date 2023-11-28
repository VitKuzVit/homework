System.Console.WriteLine("Введите x ");
int x = Convert.ToInt32( Console.ReadLine() );

System.Console.WriteLine("Введите y ");
int y = Convert.ToInt32( Console.ReadLine() );

if ( x == 0 || y == 0 ) Console.WriteLine( "Ошибка!" );
else {
    if(x > 0 && y > 0) System.Console.WriteLine(1);
    if(x < 0 && y > 0) System.Console.WriteLine(2);
    if(x > 0 && y < 0) System.Console.WriteLine(3);
    if(x < 0 && y < 0) System.Console.WriteLine(4);
}