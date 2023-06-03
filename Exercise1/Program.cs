/*Задача 54: Задайте двумерный массив. 
Напишите программу, которая упорядочит по 
убыванию элементы каждой строки двумерного
 массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

Console.Clear();
int col = 6;
int row = 5;
int[,] myArray = GetArray(row, col, 0, 10);
PrintArray(myArray);
Console.WriteLine();
int[] arrSort = new int[col];
for (int i = 0; i < row; i++)
{
    for (int j = 0; j < col; j++)
        arrSort[j] = myArray[i, j];
    SortingArray(arrSort);
    Insert(i, arrSort, myArray);
}
PrintArray(myArray);



int[,] GetArray(int row, int col, int valueMin, int valueMax)
{
    int[,] array = new int[row, col];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(valueMin, valueMax);
        }
    }

    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void SortingArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        for (int j = 0; j < array.Length - i - 1; j++)
        {
            if (array[j] < array[j + 1])
            {
                int temp = array[j + 1];
                array[j + 1] = array[j];
                array[j] = temp;
            }
        }
}

void Insert(int i, int[] arr1, int[,] matrixArray)
{
    for (int k = 0; k < arr1.Length; k++)
    {
        matrixArray[i, k] = arr1[k];
    }
}
