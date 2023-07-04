
int[,] Created2dArray(int rows, int coiiums, int minV, int maxV)
{
    int[,] createdArray = new int[rows, coiiums];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < coiiums; j++)
            createdArray[i, j] = new Random().Next(minV, maxV + 1);
    return createdArray;
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] ChangeRows(int[,] arrayChange, int row1, int row2)
{
    if (row1 >= 0 &&
        row1 < arrayChange.GetLength(0) &&
        row1 != row2 &&
        row2 >= 0 &&
        row2 < arrayChange.GetLength(0))
    {
        for (int j = 0; j < arrayChange.GetLength(1); j++)
        {
            int temp = arrayChange[row1, j];
            arrayChange[row1, j] = arrayChange[row2, j];
            arrayChange[row2, j] = temp;
        }
    }
    else Console.WriteLine("Error! Impossible value!");
    return arrayChange;
}

Console.Write("Input count of rows: ");
int userRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input count of collums: ");
int userColloums = Convert.ToInt32(Console.ReadLine());
Console.Write("Input count of min value: ");
int minUser = Convert.ToInt32(Console.ReadLine());
Console.Write("Input count of max value: ");
int maxUser = Convert.ToInt32(Console.ReadLine());

int [,] newArr = Created2dArray(userRows, userColloums, minUser, maxUser);
ShowArray(newArr);

Console.Write($"Input number of the first row to remove ftom 0 to {userRows-1}: ");
int userFirstRow = Convert.ToInt32(Console.ReadLine());
Console.Write($"Input number of the second row to remove ftom 0 to {userRows-1}: ");
int userSecondRow = Convert.ToInt32(Console.ReadLine());

ShowArray(ChangeRows(newArr, userFirstRow, userSecondRow));
*/

//Задача 2.
// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

/*
int[,] Created2dArray(int rows, int coiiums, int minV, int maxV)
{
    int[,] createdArray = new int[rows, coiiums];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < coiiums; j++)
            createdArray[i, j] = new Random().Next(minV, maxV + 1);
    return createdArray;
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] ExchRowsCols (int[,] arrToChange)
{
    int[,] tempArr = new int[arrToChange.GetLength(0), arrToChange.GetLength(1)];
    if (arrToChange.GetLength(0) == arrToChange.GetLength(1))
    {
        for (int i = 0; i < arrToChange.GetLength(0); i++)
        {
            for (int j = 0; j < arrToChange.GetLength(1); j++)
            {
                tempArr[j, i] = arrToChange[i, j];
            }
        }
        return tempArr;
    }
    else
    {
        Console.WriteLine("Impossible to exchange rows with columns. Array is not square.");
        return arrToChange;
    }
}

Console.Write("Input count of rows: ");
int userRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input count of collums: ");
int userColloums = Convert.ToInt32(Console.ReadLine());
Console.Write("Input count of min value: ");
int minUser = Convert.ToInt32(Console.ReadLine());
Console.Write("Input count of max value: ");
int maxUser = Convert.ToInt32(Console.ReadLine());

int [,] newArr = Created2dArray(userRows, userColloums, minUser, maxUser);
ShowArray(newArr);

ShowArray(ExchRowsCols(newArr));
*/


//Задача 3.
// Задайте двумерный массив из целых чисел. Напишите программу, которая обнулит строку и столбец, 
// на пересечении которых расположен первый наименьший элемент массива.
/*
int [,] Created2dArray (int rows, int columns)
{
    int [,] createdArray = new int [rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            createdArray[i,j] = new Random().Next(-9, 10);
    return createdArray;
}

void ShowArray (int [,] printedArray)
{
    for (int i = 0; i < printedArray.GetLength(0); i++)
    {    
        for (int j = 0; j < printedArray.GetLength(1); j++)
        {
            Console.Write(printedArray[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();    
}

int [] FindFirstMin (int [,] arrayToAnalyse)
{
    int min = arrayToAnalyse[0,0];
    int [] coord = new int[2];
    for (int i = 0; i < arrayToAnalyse.GetLength(0); i++)
        {    
            for (int j = 0; j < arrayToAnalyse.GetLength(1); j++)
                if (min > arrayToAnalyse[i,j])
                {
                    min = arrayToAnalyse[i,j];
                    coord[0] = i;
                    coord[1] = j;
                }
        }
    return coord;
}

int [,] arrayToDemonstrate (int [,] arrayToProcess, int [] coordArray)
{
    for (int i = 0; i < arrayToProcess.GetLength(0); i++)
        arrayToProcess[i, coordArray[1]] = 0;

    for (int j = 0; j < arrayToProcess.GetLength(1); j++)   
        arrayToProcess[coordArray[0], j] = 0;
    return arrayToProcess;
}

Console.Write("Input count of rows: ");
int userRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input count of columns: ");
int userColumns = Convert.ToInt32(Console.ReadLine());

int [,] arrayFromUser = Created2dArray(userRows, userColumns);
ShowArray(arrayFromUser);
int [] coordUser = FindFirstMin(arrayFromUser);
int [,] finalArray = arrayToDemonstrate(arrayFromUser, coordUser);
ShowArray(finalArray);
*/



