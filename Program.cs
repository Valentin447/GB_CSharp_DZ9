void Task64()
{
    // Задача 64: Задайте значения M и N. Напишите рекурсивный метод, который выведет все натуральные числа кратные 3-ём в промежутке от M до N.

    Console.WriteLine("Введите значение M: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите значение N: ");
    int n = Convert.ToInt32(Console.ReadLine());


    if (m < n)
    {
        Console.Write($"Числа кратные 3 от {m} до {n}: ");
        PrintNumbers(m, n);
    }
    else
    {
        Console.Write($"Числа кратные 3 от {n} до {m}: ");
        PrintNumbers(n, m);
    }
}
void Task66()
{
    // Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

    Console.WriteLine("Введите значение M: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите значение N: ");
    int n = Convert.ToInt32(Console.ReadLine());

    if (m < n)
    {
        Console.Write($"Сумма натуральных элементов от {m} до {n}: {GetSum(m, n)}");
    }
    else
    {
        Console.Write($"Сумма натуральных элементов от {n} до {m}: {GetSum(n, m)}");
    }
}
void Task68()
{
    // Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

    Console.WriteLine("Введите значение M: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите значение N: ");
    int n = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"A({m},{n}) = {Akkerman(m, n)}");
}

void PrintNumbers(int min, int max)
{
    if (min > max) return;
    if (min % 3 == 0)
    {
        Console.Write(min + ", ");
    }
    min++;
    PrintNumbers(min, max);
}
int GetSum(int min, int max, int sum = 0)
{

    if (min > max)
    {
        return sum;
    }
    sum += min;
    min++;
    return GetSum(min, max, sum);
}
int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }
}

//Task64();
//Task66();
Task68();