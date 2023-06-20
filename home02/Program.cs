/*
int Line()
{
    int num = new Random().Next(10, 100);
    Console.WriteLine("You num is " + num);
    int dec = num / 10;
    int ed = num % 10;
    if(dec > ed)
    {
        return dec;
    }
    else
    {
        return ed;
    }
}
Console.WriteLine("Result is - " + Line());



//Напишите программу,которая выводит случайное число трехзначное и удалят вторую цифру этого числа

    int num = new Random().Next(100, 1000);
    Console.WriteLine("Yon number is " + num);
    int b = num / 100;
    int c = num % 10;

    Console.WriteLine($"Your result {b}{c}");



Console.WriteLine("Input number1 ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number2 ");
int num2 = Convert.ToInt32(Console.ReadLine());
if(num2 != 0 && num1 != 0)
{
    if(num2 % num1 == 0)
    {
        Console.WriteLine("Число кратное");
    }
    else
    {
        Console.WriteLine("Число некратное");
    }
}
else
{
    Console.WriteLine("ERROR");
}



Console.WriteLine("Input number ");// кратно 7 и 23
int num = Convert.ToInt32(Console.ReadLine());

if(num != 0)
{
    if (num % 7 == 0 && num % 23 == 0)
    {
        Console.WriteLine("Number multiple 7 and 23");
    }
    else
    {
        Console.WriteLine("Number not multiple 7 and 23");
    }
}
else
{
    Console.WriteLine("Don't enter 0");
}



Console.WriteLine("Input number ");// кратно 7 и 23
int num = Convert.ToInt32(Console.ReadLine());
void GetNumberDiv()
{
    if(num != 0)
{
    if (num % 7 == 0 && num % 23 == 0)
    {
        Console.WriteLine("Number multiple 7 and 23");
    }
    else
    {
        Console.WriteLine("Number not multiple 7 and 23");
    }
}
else
{
    Console.WriteLine("Don't enter 0");
}
}
GetNumberDiv();



Console.WriteLine("Input number1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number2: ");
int num2 = Convert.ToInt32(Console.ReadLine());
void GetSqrt()
{
    if (num1 == num2 * num2 || num2 == num1 * num1)
    {
        Console.WriteLine("is square");
    }
    else
    {
        Console.WriteLine("not square");
    }
}
GetSqrt();
*/

