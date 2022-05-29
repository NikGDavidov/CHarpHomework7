// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double [,] Get2DimentionArray(int xSize, int ySize, double from, double to)
{
    double[,] result = new double[xSize, ySize];
    for (int j = 0; j < ySize; j++)
    {
        for (int i = 0; i < xSize; i++)
        {
            result[i, j] = Math.Round(new Random().NextDouble()*(to-from) + from,2);
        }
    }
    return result;
}
void Print2DimentionArray(double[,]array)
{
    int ySize = array.GetLength(1);
    int xSize = array.GetLength(0);
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
int m = 6;
int n = 4;
double from  = 1;
double to = 9;
double[,]array = Get2DimentionArray(m,n, from, to);

Print2DimentionArray(array);