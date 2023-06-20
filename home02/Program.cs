
//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Input number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
if(99 < num1 && num1 < 1000)
{
    num1 = num1 / 10;
    num1 = num1 % 10;
    Console.WriteLine($"Second number is: {num1}");
}



//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int num = new Random().Next(10, 100000);
Console.WriteLine(num);
if (99 < num && num < 100000)
{
    num = num / 100;
    num = num % 10;
    Console.WriteLine($"Third digit: {num}");
}
else
{
    Console.WriteLine("Third digit: NIL");
}



//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num >= 1 && num <= 7)
{
    if(num >=1 && num <=5)
    {
        Console.WriteLine("Worker day");
    }
    else
    {
        Console.WriteLine("weekend");
    }
}