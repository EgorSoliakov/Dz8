/*Задача 56: Задайте прямоугольный двумерный 
массив. Напишите программу, которая будет 
находить строку с наименьшей суммой элементов.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой 
строке и выдаёт номер строки с наименьшей 
суммой элементов: 1 строка */



Console.Clear();
int col = 4;
int row = 4;
int[,] myArray = GetArray(row, col, 0, 10);
PrintArray(myArray);
Console.WriteLine();
int[] arrSort = new int[col];
for (int i = 0; i < row; i++)
{
    for (int j = 0; j < col; j++)
        arrSort[i] = arrSort[i] + myArray[i, j];


}
PrintArray1(arrSort);
int minj = MinSearch(arrSort);
Console.WriteLine();
Console.WriteLine($"Наименьшая сумма элементов в {minj} строке");



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


int MinSearch(int[] array)
{
    int min = array[0];
    int temp = -1;

    for (int j = 0; j < array.Length; j++)
    {
        if (min > array[j])
        {
            min = array[j];
            temp = j + 1;
        }

    }

    return temp;
}

void Insert(int i, int[] arr1, int[,] matrixArray)
{
    for (int k = 0; k < arr1.Length; k++)
    {
        matrixArray[i, k] = arr1[k];
    }
}

void PrintArray1(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {

        Console.Write($" {array[i]} ");


    }
}