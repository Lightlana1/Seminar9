
void Zadacha64()
//Задайте значения M и N. Напишите рекурсивный метод, который выведет все натуральные числа кратные 3-ём в промежутке от M до N.
{
    Console.WriteLine("Введите число M: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число N: ");
    int n = Convert.ToInt32(Console.ReadLine());

    FindNatural(m, n);
    void FindNatural(int m, int n)
    {
        if (m % 3 == 0)
        {
            Console.Write(m + " ");
        }
        m++;
        if(m >= n+1)
        {
            return;
        }
        FindNatural(m, n);
    } 
}
Zadacha64();
