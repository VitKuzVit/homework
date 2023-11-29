// Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементов массива.

double[] array = new double[5];
Random rend = new Random();
for (int i = 0; i <  array.Length; i++)
{
    array[i] = Math.Round(rend.Next(0, 10) + rend.NextDouble(), 2);
}
System.Console.WriteLine(string.Join(" ", array));

double min = array[0];
for(int i = 1; i < array.Length; i++)
{
   if(array[i] < min)
      min = array[i];
}
Console.WriteLine(min); 

double max = array[0];
for(int i = 1; i < array.Length; i++)
{
   if(array[i] > max)
      max = array[i];
}
Console.WriteLine(max);

double diff = Math.Round(max - min, 2);

System.Console.WriteLine(diff);