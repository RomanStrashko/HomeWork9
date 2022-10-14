/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

/*Console.WriteLine("Введите число N:");
int n = int.Parse(Console.ReadLine()!);

String Recurs(int n, int minValue)
{
    if(n == 1)
    {
        return n.ToString();
    }
    return (n + " " + Recurs(n-1,minValue));
}
Console.WriteLine(Recurs(n,1));*/


/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

/*Console.WriteLine("Введите число M:");
int m = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число N:");
int n = int.Parse(Console.ReadLine()!);

int SumNum(int m, int n)
{
    if(m == n) return m; 
    return m + SumNum(m +1, n);
}
    Console.WriteLine($"Сумма чисел от М до N = {SumNum(m,n)}");*/


/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

/*Console.WriteLine("Введите неотрицательное число M:");
int m = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите неотрицательное число N:");
int n = int.Parse(Console.ReadLine()!);

int AckermannFun (int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return AckermannFun(m - 1, 1);
    if (m > 0 && n > 0) return AckermannFun(m - 1, AckermannFun(m, n - 1));
return AckermannFun(m, n);
}
Console.WriteLine($"Функция Аккермана для чисел M и N = {AckermannFun(m, n)}");*/