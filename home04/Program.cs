
/*//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
void SquadNum(int numA, int numB)
{
    int current = numA;
    while(current <= numA)
    {
        double res = Math.Pow(current, numB);
        Console.Write($"{res}");
        current++;
    }
}
Console.Write("input number ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("input stepen ");
int numB = Convert.ToInt32(Console.ReadLine());
SquadNum(numA, numB);

//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

void SumNum(int num)
{
    
    if(num > 99 && num < 1000)
    {
        
        num = (num%10) + ((num/10)%10) + (num/100);
        Console.Write(num);
    }
    else
    {
        Console.Write("input correct number");
    }
}
Console.WriteLine("input three - digit");
int num = Convert.ToInt32(Console.ReadLine());
SumNum(num);
*/

//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
/*
int[] CreateNewArray(int sizeArray)
{
    int[] random1array = new int[sizeArray];
    for (int i = 0; i < sizeArray; i++)
    {
        random1array[i] = new Random().Next(0, 2);
    }
    return random1array;
}

void PrintArray(int[] arrayToPrint)
{
    Console.WriteLine("Your array is: ");
    for (int i = 0; i < arrayToPrint.Length; i++)
        Console.Write(arrayToPrint[i] + " ");
}

int size = 8;
int[] firstArray = CreateNewArray(size);
PrintArray(firstArray);

*/

int[] CreateNewArray(int sizeArray)
{
    int[] randomArray = new int[sizeArray];
    for(int i = 0; i < sizeArray; i++)
    {
        randomArray[i] = new Random().Next(-20, 20);
    }
    return randomArray;
}

void PrintArray(int[] arrayToPrint)
{
    Console.WriteLine("Your array is: ");
    for(int i = 0; i < arrayToPrint.Length; i++)
        Console.Write($"{arrayToPrint[i]} ");
}

int size = 8;
int[] firstArray = CreateNewArray(size);
PrintArray(firstArray);
