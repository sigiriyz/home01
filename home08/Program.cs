//Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.
int[,] userArr = Create2DArr(4, 4);
Console.WriteLine("Array:");
ShowArray(userArr);
Console.WriteLine("\nSorted array:");
ShowArray(SortLine(userArr));

 //Задайте прямоугольный двумерный массив. 
 //Напишите программу, которая будет находить строку с наименьшей суммой элементов.
int[,] userArr2 = Create2DArr(4, 4);
Console.WriteLine("Array:");
ShowArray(userArr2);
LeastLine(userArr2);

//Задайте две матрицы. Напишите программу, 
//которая будет находить произведение двух матриц.

int[,] matrix1 = Create2DArr(3, 5);
int[,] matrix2 = Create2DArr(5, 2);
Console.WriteLine("Matrix 1:");
ShowArray(matrix1);
Console.WriteLine("\nMatrix 2:");
ShowArray(matrix2);

Console.WriteLine("\nResult of multiplication:");
ShowArray(MatrixMult(matrix1, matrix2));


//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
//которая будет построчно выводить массив, добавляя индексы каждого элемента.

Show3dArray(Create3DArr(2, 2, 2));

//Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
ShowArrayPadZero(Spiral(12, 6));
Console.WriteLine("");
ShowArrayPadZero(Spiral(5, 5));
Console.WriteLine("");
ShowArrayPadZero(Spiral(4, 4));
Console.WriteLine("");
ShowArrayPadZero(Spiral(9, 3));



int[,] MatrixMult(int[,] mat1, int[,] mat2)
{
    int[,] result = new int[mat1.GetLength(0), mat2.GetLength(1)];
    if (mat1.GetLength(1) != mat2.GetLength(0))
    {
        Console.WriteLine("These matrixes cannot be multiplied!");
        return result;
    }
    int currentsum = 0;
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int k = 0; k < mat1.GetLength(1); k++)
            {
                currentsum += (mat1[i, k] * mat2[k, j]);
            }
            result[i, j] = currentsum;
            currentsum = 0;
        }
    }
    return result;
}

void LeastLine(int[,] arrToProcess)
{
    int[] sumLine = new int[arrToProcess.GetLength(0)];
    for (int i = 0; i < arrToProcess.GetLength(0); i++)
        for (int j = 0; j < arrToProcess.GetLength(1); j++)
            sumLine[i] += arrToProcess[i, j];
    int leastline = 0;
    for (int i = 1; i < sumLine.Length; i++)
        if (sumLine[i] < sumLine[i - 1]) leastline = i;
    Console.WriteLine($"The line with the least sum of elements is {leastline + 1}");
}

int[,] SortLine(int[,] arrToSort)
{
    int pass = 0;
    for (int i = 0; i < arrToSort.GetLength(0); i++)
    {
        for (int j = 1; j < arrToSort.GetLength(1); j++)
        {
            if (arrToSort[i, j] > arrToSort[i, j - 1])
            {
                (arrToSort[i, j], arrToSort[i, j - 1]) = (arrToSort[i, j - 1], arrToSort[i, j]);
                pass += 1;
            }
            if (j == (arrToSort.GetLength(1) - 1) && pass != 0)
            {
                j = 0;
                pass = 0;
            }
        }
        pass = 0;
    }
    return arrToSort;
}

int[,] Create2DArr(int rows, int columns, int minV = 1, int maxV = 9)
{
    int[,] createdArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            createdArray[i, j] = new Random().Next(minV, maxV + 1);
        }
    }
    return createdArray;
}

int[,,] Create3DArr(int rows, int columns, int depth)
{
    int[,,] createdArray = new int[rows, columns, depth];
    int[] rndNum = RandomUnique(rows * columns * depth, 100);
    int count = 0;
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            for (int k = 0; k < depth; k++)
            {
                createdArray[i, j, k] = rndNum[count];
                count++;
            }
    return createdArray;
}

int[] RandomUnique(int length, int digits)
{
    int[] numbers = new int[length];
    for (int i = 0; i < length; i++)
    {
        numbers[i] = new Random().Next(digits / 10, digits);
        for (int j = i; j > 0; j--)
            if (numbers[i] == numbers[j - 1])
            {
                i -= 1;
                break;
            }
    }
    return numbers;
}

void Show3dArray(int[,,] arrToShow)
{
    for (int k = 0; k < arrToShow.GetLength(2); k++)
    {
        for (int i = 0; i < arrToShow.GetLength(0); i++)
        {
            for (int j = 0; j < arrToShow.GetLength(1); j++)
            {
                Console.Write($"{arrToShow[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine("");
        }
    }
}

void ShowArray(int[,] arrToShow)
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

void ShowArrayPadZero(int[,] arrToShow)
{
    for (int i = 0; i < arrToShow.GetLength(0); i++)
    {
        for (int j = 0; j < arrToShow.GetLength(1); j++)
        {
            if (arrToShow[i, j] / 10 == 0)
                Console.Write("0" + arrToShow[i, j] + " ");
            else
                Console.Write(arrToShow[i, j] + " ");
        }
        Console.WriteLine("");
    }
}

int[,] Spiral(int rows, int cols)
{
    int[,] result = new int[rows, cols];
    int colMin = 0;
    int colMax = result.GetLength(1) - 1;
    int rowMin = 0;
    int rowMax = result.GetLength(0) - 1;
    int count = 1;

    while (count <= rows * cols)
    {
        for (int i = colMin; i < colMax + 1; i++){
            result[colMin, i] = count;
            count++;
        }
        for (int i = rowMin + 1; i < rowMax; i++){
            result[i, colMax] = count;
            count++;
        }
        for (int i = colMax; i > colMin; i--){
            result[rowMax, i] = count;
            count++;
        }
        for (int i = rowMax; i > rowMin; i--){
            result[i, colMin] = count;
            count++;
        }

        colMin++;
        colMax--;
        rowMin++;
        rowMax--;
    }
    return result;
}
