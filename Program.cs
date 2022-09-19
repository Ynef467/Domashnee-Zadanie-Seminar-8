Console.Clear();

int rows = EnterPositiveIntNumber("Введите число строк массива по умолчанию");
int columns = EnterPositiveIntNumber("Введите число столбцов массива по умолчанию");
int minOfArray = EnterIntNumber("Введите минимальное число массива по умолчанию");
int maxOfArray = EnterIntNumber("Введите максимальное число массива по умолчанию");

/* int rows = 2;
int columns = 3;
int minOfArray = 1;
int maxOfArray = 9; */

/* Задача 54: Задайте двумерный массив. Напишите программу, которая
упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

Console.Clear();

System.Console.WriteLine($"\n<<<Задача 54: Упорядочение по убыванию элементов строк двумерного массива>>>");

int[,] array1 = GetArray(rows, columns, minOfArray, maxOfArray);

System.Console.WriteLine($"\nМассив №1:\n");
PrintArray(array1);

SortRowsOfArray(array1);

System.Console.WriteLine($"\nМассив №1 с отсортированными по убыванию строками:\n");
PrintArray(array1);

PressAKey();

/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет
находить строку с наименьшей суммой элементов. Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки
с наименьшей суммой элементов: 1 строка */

Console.Clear();

System.Console.WriteLine($"\n<<<Задача 56: Нахождение строки с минимальной суммой элементов массива>>>");

int[,] array2 = GetArray(rows, columns, minOfArray, maxOfArray);

System.Console.WriteLine($"\nМассив №2:\n");
PrintArray(array2);
Console.WriteLine();

FindMinSumOfArray(array2);

PressAKey();

/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

Console.Clear();

System.Console.WriteLine($"\n<<<Задача 58: Нахождение произведения двух матриц (двумерных массивов)>>>");

int[,] array3 = GetArray(rows, columns, minOfArray, maxOfArray);

System.Console.WriteLine($"\nМатрица 1:\n");
PrintArray(array3);

Console.WriteLine($"\nВнимание! Произведение двух матриц возможно только в том случае,");
Console.WriteLine($"когда число столбцов матрицы 1 (в данный момент равное {array3.GetLength(1)}) совпадает с числом строк матрицы 2!\n");
int rowsAnother = EnterPositiveIntNumber("Введите число строк второй матрицы");
int columnsAnother = EnterPositiveIntNumber("Введите число столбцов второй матрицы");

int[,] array4 = GetArray(rowsAnother, columnsAnother, minOfArray, maxOfArray);

Console.WriteLine($"\nМатрица 2:\n");
PrintArray(array4);

int[,] multArray = MultiplicationArray(array3, array4);
if (multArray != null)
{
    Console.WriteLine($"\nПроизведение матриц 1 и 2:\n");
    PrintArray(multArray);
}

else
{
    Console.WriteLine($"\nПроизведение этих матриц невозможно!\n");
}

PressAKey();

/* Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

Console.Clear();

Console.WriteLine($"\n<<<Задача 60: Вывод трёхмерного массива из неповторяющихся двузначных чисел>>>\n");

int sizeA = EnterPositiveIntNumber("Введите размер массива x");
int sizeB = EnterPositiveIntNumber("Введите размер массива y");
int sizec = EnterPositiveIntNumber("Введите размер массива z");

int[,,] arr3D = GetArray3D(x : sizeA, y : sizeB, z : sizec);
Console.WriteLine($"\nВаш массив:\n");
PrintArray3D(arr3D);

PressAKey();

/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

Console.WriteLine($"\n<<<Задача 62: Спиральное заполнение массива размером n x n>>>\n");

int sizeSpiral = EnterPositiveIntNumber("Введите размер квадратного массива");
int[,] arrSpiral = GetSpiralArray(sizeSpiral);

Console.WriteLine($"\nСпиральный массив:\n");
PrintArray(arrSpiral);

//_________________________________________________________________________________________________
//_________________________________________________________________________________________________

void PressAKey() // (запрос нажатия клавиши для продолжения)
{
    Console.WriteLine($"\nНажмите любую клавишу для продолжения...\n");
    Console.ReadKey();
}

int EnterIntNumber(string text) // (ввод и проверка целого числа)
{
    Console.Write($"{text}...\n");

    while (true)
    {
        try
        {
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }

        catch (FormatException)
        {
            Console.WriteLine($"Некорректный ввод. Введите целое число!\n");
        }
    }
}

int EnterPositiveIntNumber(string text) // (ввод и проверка целого положительного числа)
{
    Console.Write($"{text}...\n");

    while (true)
    {
        try
        {
            link: int number = Convert.ToInt32(Console.ReadLine());
            if (number > 0) return number;
            else
            {
                Console.WriteLine($"Вы ввели отрицательное число. Введите положительное!\n");
                goto link;
            }
        }

        catch (FormatException)
        {
            Console.WriteLine($"Некорректный ввод. Введите целое положительное число!\n");
        }
    }
}

int[,] GetArray(int rows = 5, int columns = 3, int numMin = 1, int numMax = 9) // (задание 2D массива)
{
    int[,] newArray = new int[rows, columns];
    var rand = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i, j] = rand.Next(numMin, numMax + 1);
        }
    }

    return newArray;
}

int[,,] GetArray3D(int x = 4, int y = 4, int z = 4) // 60 (задание 3D массива с неповторяющимися двузначными числами)
{
    int numMin = 10;
    int numMax = numMin + x * y * z - 1;
    int[,,] newArray3D = new int[x, y, z];
    int[] arrValues = new int[x * y * z];
    var rand = new Random();

    for (int i = 0; i < arrValues.Length; ++i)
    {
        bool isUnique;
        do
        {
            arrValues[i] = rand.Next(numMin, numMax + 1);
            isUnique = true;
            for (int j = 0; j < i; ++j)
                if (arrValues[i] == arrValues[j])
                {
                    isUnique = false;
                    break;
                }
        } while (!isUnique);
    }

    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                newArray3D[i, j, k] = arrValues[i * newArray3D.GetLength(1)*newArray3D.GetLength(2)
                                     + j *newArray3D.GetLength(2) + k];
            }
        }
    }

    return newArray3D;
}

int[,] GetSpiralArray(int size = 6) // 62 (решение лектора)
{
    int[,] result = new int[size, size];
    int i = 0;
    int j = 0;
    int rowE = size - 1;
    int columnE = size - 1;
    int rowS = 0;
    int columnS = 0;
    bool left = true;
    bool top = true;
    int count = 10;

    while (count - 10 < (size * size))
    {
        count++;
        result[i, j] = count;
        // идём вправо
        if (left && top)
        {
            if (j == columnE)
            {
                rowS++;
                top = true;
                left = false;
                i++;
                continue;
            }

            else
            {
                j++;
                continue;
            }
        }
        // идём вниз
        if (!left && top)
        {
            if (i == rowE)
            {
                columnE--;
                top = false;
                left = false;
                j--;
                continue;
            }

            else
            {
                i++;
                continue;
            }
        }
        // идём влево
        if (!left && !top)
        {
            if (j == columnS)
            {
                rowE--;
                top = false;
                left = true;
                i--;
                continue;
            }

            else
            {
                j--;
                continue;
            }
        }
        //идём вверх
        if (left && !top)
        {
            if (i == rowS)
            {
                columnS++;
                top = true;
                left = true;
                j++;
                continue;
            }

            else
            {
                i--;
                continue;
            }
        }
    }
    return result;
}

void PrintArray(int[,] array) // (печать массива)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void PrintArray3D(int[,,] array) // 60 (печать трёхмерного массива)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int[,] SortRowsOfArray(int[,] arr) // 54 (сортировка элементов в строках 2D массива)
{
    int temp;

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1) - 1; j++)
        {
            for (int k = j + 1; k < arr.GetLength(1); k++)
            {
                if (arr[i, j] < arr[i, k])
                {
                    temp = arr[i, k];

                    arr[i, k] = arr[i, j];

                    arr[i, j] = temp;
                }
            }
        }
    }

    return arr;
}

void FindMinSumOfArray(int[,] arr) // 56 (нахождение строки в 2D массиве с минимальной суммой)
{
    int[] arrSumOfRow = new int[arr.GetLength(0)];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arrSumOfRow[i] += arr[i, j];
        }

        Console.WriteLine($"Сумма элементов строки {i + 1} = {arrSumOfRow[i]}");
    }

    int minSum = arrSumOfRow[0];
    int indexOfMinRow = 0;

    for (int i = 1; i < arrSumOfRow.Length; i++)
    {
        if (arrSumOfRow[i] < minSum)
        {
            minSum = arrSumOfRow[i];
            indexOfMinRow = i;
        }
    }

    Console.WriteLine($"\nСтрока массива с наименьшей суммой элементов ({minSum}) - № {indexOfMinRow + 1}\n");
}

int[,] MultiplicationArray(int[,] arrFirst, int[,] arrSecond) // 58 (умножение матриц)
{
    int[,] arrResult = new int[arrFirst.GetLength(0), arrSecond.GetLength(1)];

    if (arrFirst.GetLength(1) == arrSecond.GetLength(0))
    {
        for (int i = 0; i < arrResult.GetLength(0); i++)
        {
            for (int j = 0; j < arrResult.GetLength(1); j++)
            {
                for (int k = 0; k < arrFirst.GetLength(1); k++)
                {
                    arrResult[i, j] += arrFirst[i, k] * arrSecond[k, j];
                }
            }
        }
        return arrResult;
    }

    else
    {
        return null!;
    }
}