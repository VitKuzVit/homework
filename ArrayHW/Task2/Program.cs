// Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[] GenerateArray(int size, int LeftRange, int rightRenge)
{
    int[] tempArray = new int[size];
    Random rend = new Random();

    for (int i = 0; i < size; i++)
    {
        tempArray[i] = rend.Next(LeftRange, rightRenge + 1);
    }
    return tempArray;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

int size = ReadInt("Введите размер массива ");
int[] myArray = GenerateArray(size, 1, 100);

int count = 0;
for (int i = 0; i < myArray.Length; i++)
{
    
    if (myArray[i] % 2 == 0)
    {
        count++;
    }
}

PrintArray(myArray);

System.Console.WriteLine($"количество чётных чисел в массиве = {count}");


