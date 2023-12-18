int[] Array = { 1, 2, 5, 0, 10, 34 };
int i = 0;
void PrintNumber(int[] Array)
{

    if (i == Array.Length) return;
    else
    {
        System.Console.Write(Array[i] + " ");
        i++;
        PrintNumber(Array);
        i--;
        System.Console.Write(Array[i] + " ");
    }
}

PrintNumber(Array);