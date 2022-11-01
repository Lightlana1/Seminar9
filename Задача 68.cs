void Zadacha68()
{
    // Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. 
    Console.WriteLine("Введите число M: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число N: ");
    int n = Convert.ToInt32(Console.ReadLine());
    
    if (n >= 0 && m >= 0)
    {
        int funAkkerman = Ack(m, n);
        Console.Write($"Функция Аккермана = {funAkkerman} ");
    }
    else
    {
        Console.Write("Введите значения > 0");
    }
    
    int Ack(int m, int n)
    {
    if (m == 0) return n + 1;
    else if (n == 0) return Ack(m - 1, 1);
    else return Ack(m - 1, Ack(m, n - 1));
    }
}
Zadacha68();
