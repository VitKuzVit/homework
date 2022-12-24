Console.Write("Введите число a: ");
        int a = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("Введите число b: ");
        int b = int.Parse(Console.ReadLine() ?? "0");

        if (a == b)
        {
            Console.WriteLine("Числа равны.");
        }

        else if (a > b)
        {
            Console.WriteLine("Максимальное число: " + a);
        }

        else
        {
            Console.WriteLine("Максимальное число: " + b);
        }