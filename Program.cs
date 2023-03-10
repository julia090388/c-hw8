// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void FillArray(int [,] matr) // Заполнение массива рандомными данными
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            matr [i,j] = new Random().Next(1,100);
        }
    }
}

void PrintArray(int[,] matr) // Распечатывание массива
{
    for (int i = 0; i  < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i,j]} ");
        }
    Console.WriteLine();
    }
}


void SortingElements(int[,] array)  // Функция сортировки элементов в строке двумерного массива, по убыванию
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}


void PrintArraySorting(int[,] array) // Распечатывание массива
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

int [,] massiv = new int [4, 4];
FillArray(massiv);
// PrintArray(massiv);
PrintArray(massiv);

Console.WriteLine();
Console.WriteLine();

SortingElements(massiv);
PrintArraySorting(massiv);

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void FillArray(int [,] matr) // Заполнение массива рандомными данными
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            matr [i,j] = new Random().Next(1,10);
        }
    }
}

void PrintArray(int[,] matr) // Распечатывание массива
{
    for (int i = 0; i  < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i,j]} ");
        }
    Console.WriteLine();
    }
}


void RowSmallElement(int[,] array) // Функция вывода номера строки (не индекса) с наименьшей суммой элементов 
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minRow += array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) sumRow += array[i, j];
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0;
    }
    Console.Write($"наименьшая сумма элементов в {minSumRow + 1} строке ");
}



int [,] massiv = new int [3, 4];
FillArray(massiv);
PrintArray(massiv);

Console.WriteLine();
Console.WriteLine();

RowSmallElement(massiv);

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void FirstMatrix(int [,] one, int [,] two) 
{
    for(int i = 0; i < one.GetLength(0); i++) 
    {
        for(int j = 0; j < one.GetLength(1); j++) 
        {
            one [i,j] = new Random().Next(1,10);

        }
    }
    for(int y = 0; y < two.GetLength(0); y++)
    {
        for(int x = 0; x < two.GetLength(1); x++)
        {
            two [y,x] = new Random().Next(1,10);
        }
    }

}

void PrintArrayFirst(int[,] one) 
    for (int i = 0; i  < one.GetLength(0); i++) 
    {
        for (int j = 0; j < one.GetLength(1); j++) 
        {
            Console.Write($"{one[i,j]} ");
        }
    Console.WriteLine();
    }

}

void PrintArraySecond(int [,] two) 
        for(int y = 0; y < two.GetLength(0); y++)
    {
        for(int x = 0; x < two.GetLength(1); x++)
        {
            Console.Write($"{two[y,x]} ");
        }
    Console.WriteLine();
    }

}

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)     //Функция перемножения матриц
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;

    }
    }
}

void WriteArray (int[,] array)     
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}

Random rnd = new Random();
int i = rnd.Next(1, 4);
int t = rnd.Next(1, 4);
int p = rnd.Next(1, 4);

int [,] First = new int [i, t];
int [,] Second= new int [t, p];

FirstMatrix(First, Second);
Console.WriteLine($"Первая матрица:");
PrintArrayFirst(First);
Console.WriteLine();
Console.WriteLine($"Вторая матрица:");
PrintArraySecond(Second);

Console.WriteLine();

int[,] resultMatrix = new int[i,p];
MultiplyMatrix(First, Second, resultMatrix);
Console.WriteLine($"Произведение первой и второй матриц:");
WriteArray(resultMatrix);

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)



void PrintIndex(int[,,] arr)        // Функция вывода индекса элементов 3D массива
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write($"{arr[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}


void FillArray(int[,,] arr)     // Функция заполнения 3D массива не повторяющимеся числами
{
    int count = 10;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[k, i, j] += count;
                count += 3;
            }
        }
    }
}


int[,,] array3D = new int[2, 2, 2];
FillArray(array3D);
PrintIndex(array3D);

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int len = 4;
int[,] table = new int[len, len];
FillArraySpiral(table, len);
PrintArray(table);



void FillArraySpiral(int[,] array, int n)       //  Функция заполнения массива по спирали начиная с 1
{
    int i = 0, j = 0;
    int value = 1;
    for (int e = 0; e < n * n; e++)
    {
        int k = 0;
        do { array[i, j++] = value++; } while (++k < n - 1);
        for (k = 0; k < n - 1; k++) array[i++, j] = value++;
        for (k = 0; k < n - 1; k++) array[i, j--] = value++;
        for (k = 0; k < n - 1; k++) array[i--, j] = value++;
        ++i; ++j;
        n = n < 2 ? 0 : n - 2;
    }
}


void PrintArray(int[,] array)       //  Функция вывода двумерного массива в терминал
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("0" + array[i, j]);
                Console.Write(" ");
            }
            else Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}