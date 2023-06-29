/*
//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
//Найдите сумму отрицательных и положительных элементов массива.


int [] CreateArray (int size, int minVal, int maxVal)
{
    int[] newArray = new int [size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minVal, maxVal + 1);
    }
    return newArray;
}

void ShowArray (int [] arrayToShow)
{
    for (int i = 0; i < arrayToShow.Length; i++)
        Console.Write (arrayToShow[i] + " ");
    Console.WriteLine();
}

void FindSumNegElem (int [] array)
{
    int sumNegElem = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] < 0)
            sumNegElem += array[i];
    Console.WriteLine($"Summ of negative elements of array is {sumNegElem}");
}

int FindSumPosElem (int [] arrayToAnalyse)
{
    int sumPosElem = 0;
    for (int i = 0; i < arrayToAnalyse.Length; i++)
        if (arrayToAnalyse[i] > 0)
            sumPosElem+= arrayToAnalyse[i];
    return sumPosElem;
}

int sizeArray = 12;
int minArrayVal = -9;
int maxArrayVal = 9;

int[] createdArray = CreateArray(sizeArray, minArrayVal, maxArrayVal);
ShowArray(createdArray);
FindSumNegElem (createdArray);
int positivSum = FindSumPosElem(createdArray);
Console.WriteLine($"Summ of positive elements of array is {positivSum}");

*/

/*
//Задача 2.
//Напишите программу замены элементов массива: положительные элементы замените на соответствующие 
//отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]

int [] RandomArray ()
{
    int size =new Random().Next(4,10);
    int [] randomArray = new int [size];
    for (int i = 0; i < size; i++)
    {
        randomArray[i] = new Random().Next(-10, 11);
    }
    return randomArray;
}

void PrintArray(int [] arrayPrint)
{
    for (int i = 0; i < arrayPrint.Length; i++)
    {
        Console.Write (arrayPrint[i] + " ");
    }
    Console.WriteLine();
}

int [] InvertArray(int [] invArray)
{
    for(int i = 0; i < invArray.Length; i++)
        invArray[i] = invArray[i] * (-1); // invArray[i] *= (-1);
    return invArray;    
}

int [] masiv = RandomArray();
PrintArray(masiv);
int [] invArray =  InvertArray(masiv);
PrintArray(invArray);
*/
/*

//Найдите произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
//Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21

int [] RandomArray ()
{
    int size =new Random().Next(4,10);
    int [] randomArray = new int [size];
    for (int i = 0; i < size; i++)
    {
        randomArray[i] = new Random().Next(-10, 11);
    }
    return randomArray;
}

void PrintArray(int [] arrayPrint)
{
    for (int i = 0; i < arrayPrint.Length; i++)
    {
        Console.Write (arrayPrint[i] + " ");
    }
    Console.WriteLine();
}

int [] startArray = RandomArray();

int size = startArray.Length;

int [] MultyArray(int [] startArray)
{
    int [] temp;
    if (startArray.Length % 2 == 0)
        temp = new int [size/2];
    else 
    {
        temp =  new int [size/2 + 1];
        temp [size/2] = startArray[size/2];
    }
    for (int i = 0; i < size/2; i++ ) //  7/2 -> 3
        temp[i] = startArray[i] * startArray[startArray.Length - 1 - i];
    return temp;
}
PrintArray(startArray);
int [] multy = MultyArray(startArray);
PrintArray(multy);


//Задайте одномерный массив из 123 случайных чисел. 
//Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
//Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
//[5, 18, 123, 6, 2] -> 1
//[1, 2, 3, 6, 2] -> 0
//[10, 11, 12, 13, 14] -> 5

int [] RandomArray ()
{
    int size = 123;
    int [] randomArray = new int [size];
    for (int i = 0; i < size; i++)
    {
        randomArray[i] = new Random().Next(0, 1000);
    }
    return randomArray;
}

void PrintArray(int [] arrayPrint)
{
    for (int i = 0; i < arrayPrint.Length; i++)
    {
        Console.Write (arrayPrint[i] + " ");
    }
    Console.WriteLine();
}

void CountOfElem (int [] countArry)
{
    int count = 0;
    for (int i = 0; i < countArry.Length; i++)
    {
        if (countArry[i] >= 10 && countArry[i] <=99)
            count++;
    }
    Console.Write($"->{count}");
}
int [] randomArray = RandomArray();
PrintArray(randomArray);
CountOfElem(randomArray);
*/


/*
//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

int [] RandomArray ()
{
    int size = new Random().Next(10,100);
    int [] randomArray = new int [size];
    for (int i = 0; i < size; i++)
    {
        randomArray[i] = new Random().Next(99, 1000);
    }
    return randomArray;
}


void PrintArray(int [] arrayPrint)
{
    for (int i = 0; i < arrayPrint.Length; i++)
    {
        Console.Write (arrayPrint[i] + " ");
    }
    Console.WriteLine();
}

void CountOfElem (int [] countArry)
{
    int count = 0;
    for (int i = 0; i < countArry.Length; i++)
    {
        if (countArry[i] % 2 == 0)
            count++;
    }
    Console.Write($"->{count}");
}

int[] massiv = RandomArray();
PrintArray(massiv);
CountOfElem(massiv);
*/


//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

/*

int [] RandomArray ()
{
    int size = new Random().Next(5,10);
    int [] randomArray = new int [size];
    for (int i = 0; i < size; i++)
    {
        randomArray[i] = new Random().Next(1, 100);
    }
    return randomArray;
}


void PrintArray(int [] arrayPrint)
{
    for (int i = 0; i < arrayPrint.Length; i++)
    {
        Console.Write (arrayPrint[i] + " ");
    }
    Console.WriteLine();
}

int SumOfOddIndex(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i+=2)
    {
        sum += arr[i];
    }
    return sum;
}

int[] createdArray = RandomArray();
PrintArray(createdArray);
Console.WriteLine($"Сумма чисел на нечётных позициях: {SumOfOddIndex(createdArray)}");
*/

//Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

double[] array3 = new double[10];

for (int i = 0; i < array3.Length; i++)
{
    array3[i] = Math.Round(new Random().NextDouble(), 2) + new Random().Next(-100, 100);
}

Console.WriteLine("Задан массив:");
for (int i = 0; i < array3.Length; i++)
{
    Console.Write(array3[i]);
    if (i != array3.Length - 1) Console.Write(", ");
    else Console.WriteLine(".");
}

double min = array3[0];
double max = array3[0];
for (int i = 1; i < array3.Length; i++)
{
    if (array3[i] > max) max = array3[i];
    else if (array3[i] < min) min = array3[i];
}
Console.WriteLine($"Разница между максимальным {max} и минимальным {min} элементами массива равна {max - min}");