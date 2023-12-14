// Задача 2: Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.

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
void PrintMatrix(int[,] matrixForPrint)
{
    for (int i = 0; i < matrixForPrint.GetLength(0); i++)
    {
        for (int j = 0; j < matrixForPrint.GetLength(1); j++)
        {
            System.Console.Write(matrixForPrint[i, j] + "\t");
        }
        System.Console.WriteLine();
    }

}
int rows = ReadInt("Введите колличество строк в массиве");
int cols = ReadInt("Введите колличество столбцов в массиве");
int[,] matrix = GenerateMatrix(rows, cols, -9, 9);
PrintMatrix(matrix);

for (int i = 0; i < matrix.GetLength(1); i++)
{
    var tmp = matrix[3, i];
    matrix[3, i] = matrix[0, i];
    matrix[0, i] = tmp;
}
PrintMatrix(matrix);



