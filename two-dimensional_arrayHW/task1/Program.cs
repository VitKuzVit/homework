// Задача 1: 
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateMatrix(int row, int col, int LeftRange, int RightRange)// Задали функцию дву мерного массива с четырьмя переменными int
{
    int[,] tempMatrix = new int[row, col];// инициализируем временный массив
    Random rand = new Random();// Выделяем память
    for (int i = 0; i < tempMatrix.GetLength(0); i++)// проход по строкам
        for (int j = 0; j < tempMatrix.GetLength(1); j++)// проход по столбцам
            tempMatrix[i, j] = rand.Next(LeftRange, RightRange + 1); //наполнение ячейки случайнм числом
    return tempMatrix;
}

int rows = ReadInt("Введите колличество строк в массиве");
int cols = ReadInt("Введите колличество столбцов в массиве");
int[,] matrix = GenerateMatrix(rows, cols, -9, 9);
int a = ReadInt("Введите номер строки массива");
int b = ReadInt("Введите номер столбца массива");
if (a < matrix.GetLength(0) || b < matrix.GetLength(1))
{
    System.Console.WriteLine(matrix[a, b]);
}
else System.Console.WriteLine("Нет такого элемента");