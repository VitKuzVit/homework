int a = 1234;
string str = a.ToString();
//Использовали оператор преобразования в строку ToString
int[] b = new int[str.Length];
// создали массив длинной в строку
for( int i=0; i< str.Length; i++)
{
    b[i] = Convert.ToInt32(str[i].ToString());
}
// Наполнили массив "b" с помощью цикла For  преобразовывая строку в целочисленное число с помощью Convert.ToInt32
Array.Sort(b, (x, y) => y.CompareTo(x));

System.Console.WriteLine("[" + string.Join(", ", b) + "]");

