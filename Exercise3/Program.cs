/*Задача 58: Задайте две матрицы. Напишите 
программу, которая будет находить произведение 
двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */


Console.Clear();

int[,] myArray = GetArray(2, 2, 1, 5);
PrintArray(myArray);
Console.WriteLine();
int[,] newArray = GetArray(2, 2, 1, 5);
PrintArray(newArray);
Console.WriteLine();
Console.WriteLine("Результирующая матрица будет: ");
PrintArray(Matrix(myArray, newArray));



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

int[,] Matrix(int[,] arr, int[,] nextArr)
{
    int[,] matrArr = new int[arr.GetLength(0), arr.GetLength(1)];

    for (int i = 0; i < matrArr.GetLength(0); i++)
    {
        for (int j = 0; j < matrArr.GetLength(1); j++)
        {
            matrArr[0, 0] = arr[0, 0] * nextArr[0, 0] + arr[0, 1] * nextArr[1, 0];
            matrArr[0, 1] = arr[0, 0] * nextArr[0, 1] + arr[0, 1] * nextArr[1, 1];
            matrArr[1, 0] = arr[1, 0] * nextArr[0, 0] + arr[1, 1] * nextArr[1, 0];
            matrArr[1, 1] = arr[1, 0] * nextArr[0, 1] + arr[1, 1] * nextArr[1, 1];
        }

    }
    return matrArr;

}