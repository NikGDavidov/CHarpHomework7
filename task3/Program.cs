//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int [,] Get2DimentionArray(int xSize, int ySize, int from, int to)
{
    int[,] result = new int[xSize, ySize];
    for (int j = 0; j < ySize; j++)
    {
        for (int i = 0; i < xSize; i++)
        {
            result[i, j] =new Random().Next(from,to);
        }
    }
    return result;
}
void Print2DimentionArray(int [,]array)
{
    int xSize = array.GetLength(0);
    int ySize = array.GetLength(1);
   
for (int j = 0; j < ySize; j++)
    {
        Console.WriteLine();
        for (int i = 0; i < xSize; i++)
        {
           Console.Write(array[i,j] + " ");
        }
    }
    Console.WriteLine();
   
}
double [] GetAriphMean (int [,] array)
{
    int columns = array.GetLength(0);
    int rows = array.GetLength(1);
    double [] result = new double[columns];
    for (int i=0; i<columns; i++)
    {
        double sumRow = 0;
        for (int j = 0; j < rows; j++)  sumRow += array[i,j];
        result [i]=sumRow/rows;
    }
    return result;
}

int m = 6;
int n = 4;
int from  = 1;
int to = 9;
int[,]array = Get2DimentionArray(m,n, from, to);
Print2DimentionArray(array);
double [] ariphMean = GetAriphMean(array);
for (int i=0 ;i<ariphMean.Length; i++) Console.WriteLine($"Среднее арифметическое колонки {i} = {ariphMean[i]}");


