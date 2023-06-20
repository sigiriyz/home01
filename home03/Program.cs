/*
x > 0, y > 0 I quater
x > 0, y < 0 IV quater
x < 0, y < 0 III quater
x < 0, y > 0 II quater

void NameFunk() //невозвратный метод (аргумент)
{

}

NameFunk();

int FunktName (int arg1, int arg2)
{      // arg1 = number
        //arg2 = 9
        int del = arg1 % arg2;

return del;   
}

Console.WriteLine("Input ");
int number = Convert.ToInt32(Console.ReadLine());

int resul = FunktName(number, 9);
Console.WriteLine("1 " + resul);
int result1 = FunktName(1000, 78);
Console.WriteLine("2 " + result1);
*/
/*
void FunktName1 ()
{      
        Console.WriteLine("Input ");
        int number = Convert.ToInt32(Console.ReadLine());

        int del = number % 9;
        Console.WriteLine("1 " + del);
}
FunktName1();



int Koord (int x, int y)
{
    int numberQuater;
    if(x > 0 && y > 0)
        numberQuater = 1;
    else if(x > 0 && y < 0)
        numberQuater = 4;
    else if (x < 0 && y > 0)
        numberQuater = 2;
    else 
        numberQuater = 3;
    return numberQuater;
}
Console.WriteLLine("Enter X coord: ");
int xCoord = Convert.ToInt32(Console.ReadLine());
Console.WriteLLine("Enter Y coord: ");
int yCoord = Convert.ToInt32(Console.ReadLine());
int numberQuater;

if (xCoord == 0 || yCoord == 0)
{
    Console.WriteLine("ERROR!");
}
else
{
    numberQuater = koord (xCoord, yCoord);
    Console.WriteLLine($"Number is quater is {numbQuater} ");
}



//Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти (x и y).

int Diapason (int quadro)
{
    if (quadro == 1)
        return 1;
    else if (quadro == 2)
        return 2;
    else if (quadro == 3)
        return 3;
    else
        return 4;
}
System.Console.WriteLine("Введите четверть: ");
int a = Convert.ToInt32(Console.ReadLine());
int result;
if (a <= 0 || a > 4) System.Console.WriteLine("Айяйяй");
else {
    result = Diapason(a);

if (result == 1)
{
    System.Console.WriteLine("Ваш диапазон x > 0 и y > 0");
}
else if (result == 2)
{
    System.Console.WriteLine("Ваш диапазон x < 0 и y > 0");
}
else if (result == 3)
{
    System.Console.WriteLine("Ваш диапазон x < 0 и y < 0");
}
else
{
    System.Console.WriteLine("Ваш диапазон x > 0 и y < 0");
}
}



void PossibleValue (int quadro)
{
    if (quadro == 1)
        Console.WriteLine ("1st quater x > 0, y > 0");
    else if (quadro == 2)
        Console.WriteLine ("2nd quater x < 0, y > 0");
    else if (quadro == 3)
        Console.WriteLine ("3rd quater x < 0, y < 0");
    else 
        Console.WriteLine ("4st quater x > 0, y < 0");
}

Console.WriteLine("Input number of quater: ")     ;
int numQater = Convert.ToInt32(Console.ReadLine());

if(numQater >= 1 && numQater <= 4)
    PossibleValue(numQater);
else Console.WriteLine("its not number of quater!");



double LongLineAB (int xA, int xB, int yA, int yB)
{
    double LongLine = Math.Sqrt((xB - xA)*(xB - xA) + (yB - yA)*(yB - yA));
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

double dist = LongLineAB(xCoordA, xCoordB, yCoordA, yCoordB);
Console.WriteLine($"Distance between A and B " + dist); //f3- чисел после запятой в выводе.


void SqurePrint(int number)
{
    int current = 1;
    while (current <= number)
    {
        double res = Math.Pow(current, 2);
        Console.Write($"{res:f0}, ");
        current++;
    }
    Console.WriteLine("\b\b.");
}
void SqurePrintNeg(int numberN)
{
    int current = 1;
    while (current >= numberN)
    {
        double res = Math.Pow(current, 2);
        Console.Write($"{res:f0}, ");
        current--;
    }
    Console.WriteLine("\b\b.");
}

Console.Write("number: "); 
int userNumber = Convert.ToInt32(Console.ReadLine());

if(userNumber > 0)
    SqurePrint(userNumber);
else
    SqurePrintNeg(userNumber);
    */






//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.


//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("number: ");
int number = Convert.ToInt32(Console.ReadLine());
int current = 1;
while (current <= number)
{
    double res = Math.Pow(current, 3);
    Console.Write($"{res:f0}, ");
    current++;
}
