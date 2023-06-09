Random rnd = new Random();
Console.WriteLine("===Программа для замены нулями ниже побочной диагонали===\n");
Console.Write("Введите размер матрицы: ");
int M = Convert.ToInt32(Console.ReadLine()); // переменная для определения размера матрицы
int[,] matrix = new int[M, M];
Console.WriteLine($"Исходная матрица: {M}x{M}");

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = rnd.Next(1, 9);
        Console.Write(" " + matrix[i, j]);
    }
    Console.WriteLine();
}
int count = 0; //счетчик нулей решил оставить(помогал во время написания)
int k = matrix.GetLength(0) - 1; //переменная определения побочной диагонали

for (int i = 1; i < matrix.GetLength(0); i++)
{
    for (int j = matrix.GetLength(1) - 1; j > k - i; j--)
    {
        if (matrix[i, j] != 0)
        {
            count++;
            matrix[i, j] = 0;
        }
    }
}
Console.WriteLine("Модифицированная матрица:");
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write(" " + matrix[i, j]);
    }
    Console.WriteLine();
}
if (count != 0)
    Console.WriteLine("К-во нулей = " + count);
else
    Console.WriteLine("Error");   
        
