
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


Console.WriteLine("input number: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 2;
while(count <= number)
{
    Console.Write(count + ", ");
    count = count + 2;
}
