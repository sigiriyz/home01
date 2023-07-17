﻿//Задайте значение N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.Write("Enter a number: ");
int userN = Convert.ToInt32(Console.ReadLine());
PrintNto1(userN);
Console.WriteLine("");



//Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Write("Enter the first natural number: ");
int userNumN = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the second natural number: ");
int userNumM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"The sum of all numbers between {Math.Min(userNumN, userNumM)} and {Math.Max(userNumN, userNumM)} is {SumRange(userNumN, userNumM)}");



//Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.

Console.Write("Enter the first natural number: ");
int userAckerM = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the second natural number: ");
int userAckerN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"A({userAckerM}, {userAckerN}) = {Ackermann(userAckerM, userAckerN)}");


void SumRangeLoop(int n, int m, ref int sum)
{
    if (n != m) SumRangeLoop(Math.Min(n, m), Math.Max(n, m) - 1, ref sum);
    sum = sum + m;
}

int SumRange(int n, int m)
{
    int sum = 0;
    SumRangeLoop(n, m, ref sum);
    return sum;
}

void PrintNto1(int n)
{
    if (n != 0)
    {
        Console.Write(n + " ");
        PrintNto1(n - 1);
    }
}

int Ackermann(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return Ackermann(m - 1, 1);
    else if (m > 0 && n > 0) return Ackermann(m - 1, Ackermann(m, n - 1));
    else return 0;
}