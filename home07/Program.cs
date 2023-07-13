//Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.

Console.WriteLine("Задача 47------------------------------");
Console.Write("Enter number of rows: ");
int userRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number of columns: ");
int userCols = Convert.ToInt32(Console.ReadLine());

ShowArrayReal(Create2DArrReal(userRows, userCols));



//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] userArr = Create2DArr(new Random().Next(3, 9), new Random().Next(3, 9));
Console.WriteLine("Array:");
ShowArray(userArr);
IndexPrint(userArr);



//Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

userArr = Create2DArr(4, 4);
Console.WriteLine("Array:");
ShowArray(userArr);
ColumnMean(userArr);

double[,] Create2DArrReal(int rows, int columns, int minV = -9, int maxV = 9)
{
    double[,] createdArray = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            createdArray[i,j] = Math.Round(
                                new Random().Next(minV, maxV + 1)
                              + new Random().NextDouble(),
                                1);
        }
    }
    return createdArray;
}

void ShowArrayReal (double [,] arrToShow)
{
    for (int i = 0; i < arrToShow.GetLength(0); i++)
    {
        for (int j = 0; j < arrToShow.GetLength(1); j++)
        {
            if (arrToShow[i, j] < 0)
            {
                if (arrToShow[i, j] % 1 == 0) Console.Write(arrToShow[i, j] + "   ");
                else Console.Write(arrToShow[i, j] + " ");
            }
            else
            {
                if (arrToShow[i, j] % 1 == 0) Console.Write(" " + arrToShow[i, j] + "   ");
                else Console.Write(" " + arrToShow[i, j] + " ");
            }
        }
        Console.WriteLine("");
    }
}

int[,] Create2DArr(int rows, int columns, int minV = 1, int maxV = 9)
{
    int[,] createdArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            createdArray[i,j] = new Random().Next(minV, maxV + 1);
        }
    }
    return createdArray;
}

void ShowArray (int [,] arrToShow)
{
    for (int i = 0; i < arrToShow.GetLength(0); i++)
    {
        for (int j = 0; j < arrToShow.GetLength(1); j++)
        {
            Console.Write(arrToShow[i, j] + " ");
        }
        Console.WriteLine("");
    }
}

void IndexPrint (int[,] arrToParse)
{
    Console.Write("Enter row position: ");
    int row = Convert.ToInt32(Console.ReadLine()) - 1;
    Console.Write("Enter column position: ");
    int col = Convert.ToInt32(Console.ReadLine()) - 1;

    if (row+1 > arrToParse.GetLength(0) || col+1 > arrToParse.GetLength(1))
        Console.WriteLine("Element with this index does not exist.");
    else
        Console.WriteLine("The value of the provided index is: " + arrToParse[row, col]);
}

void ColumnMean (int[,] arrToMean)
{
    double mean = 0;
    Console.WriteLine("Mean for each column:");
    for (int j = 0; j < arrToMean.GetLength(1); j++)
    {
        mean = 0;
        for (int i = 0; i < arrToMean.GetLength(0); i++)
        {
            mean += arrToMean[i, j];
        }
        if (j == arrToMean.GetLength(1)-1) Console.WriteLine(Math.Round(mean/arrToMean.GetLength(0), 1) + ".");
        else Console.Write(Math.Round(mean/arrToMean.GetLength(0), 1) + "; ");
    }
}