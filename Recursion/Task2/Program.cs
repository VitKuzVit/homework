
int Akk(int n, int m)
{
    if (n == 0)
        return m + 1;
    else
      if ((n != 0) && (m == 0))
        return Akk(n - 1, 1);
    else
        return Akk(n - 1, Akk(n, m - 1));
}
 
Console.WriteLine(Akk(1, 2)); // 4
Console.WriteLine(Akk(0, 0)); // 1
Console.WriteLine(Akk(2, 3)); // 9
 
Console.ReadKey();