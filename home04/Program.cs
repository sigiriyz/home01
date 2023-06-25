
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