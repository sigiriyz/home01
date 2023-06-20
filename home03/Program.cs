//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double LongLineAB (int xA, int xB, int yA, int yB, int zA, int zB)
{
    double LongLine = Math.Sqrt((xB - xA)*(xB - xA) + (yB - yA)*(yB - yA) + (zB - zA) * (zB - zA));
    LongLine = Math.Round(LongLine, 2);
    return LongLine;
}
Console.WriteLine("Input X of A: "); 
int xCoordA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Y of A: "); 
int yCoordA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input X of B: "); 
int xCoordB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Y of B: "); 
int yCoordB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Z of A: "); 
int zCoordA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Z of B: "); 
int zCoordB = Convert.ToInt32(Console.ReadLine());
double dist = LongLineAB(xCoordA, xCoordB, zCoordA, zCoordB, yCoordA, yCoordB);
Console.WriteLine($"Distance between A and B " + dist);



//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("number: ");
int number = Convert.ToInt32(Console.ReadLine());
int current = 1;
while (current <= number)
{
    double res = Math.Pow(current, 3);
    current++;
    Console.Write(res + " ");
}



//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введт пятизначное число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
if (numberA % 10 == numberA / 10000 && (numberA % 100) / 10== (numberA / 1000) % 10)
{
    Console.Write("является палиндромом ");
}
else
{
     Console.Write("неявляется палиндромом ");
}


