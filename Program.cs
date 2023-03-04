Console.Clear();
Console.WriteLine("Введите размеры массива ");
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
double[,] arr = GetArray(m, n);
PrintArray(arr);
double[,] GetArray(int m, int n) 
{
     double[,] result = new double[m, n];
     for (int i = 0; i < m; i++)     
     {
        for(int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(-10, 10) + new Random().NextDouble();  
        }              
     }
     return result;
}

void PrintArray(double[,] inArray)
{
    for(int i = 0; i < inArray.GetLength(0); i++)
    {
        for(int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write("{0,6:F1}", inArray[i, j]);
        }
        Console.WriteLine();
    }
}