// Задача 3: Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)
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
int[] myArray = GenerateArray(size, 1, 10);

PrintArray(myArray);

Array.Sort(myArray, (x, y) => y.CompareTo(x));

PrintArray(myArray);


