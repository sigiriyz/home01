// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("input number: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input number: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if(numberA > numberB)
{
    Console.Write(numberA + " > " + numberB);
}
else
{
    Console.Write(numberB + " > " + numberA);
}

// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("input number: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input number: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input number: ");
int numberC = Convert.ToInt32(Console.ReadLine());
int max = numberA;
if(numberB > max) max = numberB;
if(numberC > max) max = numberC;
Console.Write("max number: " + max);

//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("input number: ");
int numberA = Convert.ToInt32(Console.ReadLine());
if(numberA % 2 == 0)
{
    Console.WriteLine("even number: " + numberA);
}
else
{
    Console.WriteLine("try again: ");
}

//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("input number: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 2;
while(count <= number)
{
    Console.Write(count + ", ");
    count = count + 2;
}
