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
        MethodForTask64(m, n);
    }
    else
    {
        Console.Write($"Числа кратные 3 от {n} до {m}: ");
        MethodForTask64(n, m);
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

}

void MethodForTask64(int min, int max)
{
    if(min >= max) return;
    if (min % 3 == 0)
    {
        Console.Write(min + ", ");
    }
    min++;
    MethodForTask64(min, max);
}
int GetSum(int min, int max, int sum = 0)
{
    
    if (min > max)
    {
        return sum;
    }
    sum+= min;
    min++;
    //Console.WriteLine(sum);
    return GetSum(min, max, sum);
}

//Task64();
Task66();
//Task68();