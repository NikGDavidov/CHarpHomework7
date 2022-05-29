//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
string flag = "exists";
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
int ValueIfContains(int[,]array,int x, int y)
{
    
    if (x>0 && x<=array.GetLength(0)
                                 && y>0 && y<=array.GetLength(1)) return array[x-1,y-1];
    
    flag = "no";
    return -1;
}
int m = 6;
int n = 4;
int from  = 1;
int to = 9;
int[,]array = Get2DimentionArray(m,n, from, to);
Print2DimentionArray(array);

int x = 2;
int y = 4;
int value = ValueIfContains(array, x,y);
if (flag == "exists") Console.WriteLine($"Значение по позиции {x},{y} = {value}");
else Console.WriteLine($"Позиции {x},{y} в массиве нет");