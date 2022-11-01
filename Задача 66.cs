void Zadacha66()
{
    // Задайте значения M и N. Напишите рекурсивный метод, который найдёт сумму натуральных элементов в промежутке от M до N.
    Console.WriteLine("Введите число M: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число N: ");
    int n = Convert.ToInt32(Console.ReadLine());

    SumNum(m, n);

    void SumNum(int m, int n, int sum = 0)
    {
        if (m >= n+1)
        {
            Console.WriteLine($"{sum}");
            return;
        }
        sum = sum + m;
        m++;
        SumNum(m, n, sum);
    }
}
Zadacha66();