// See https://aka.ms/new-console-template for more information

using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("-- Працюємо із матрицями та StreamReader --");

int n, m;

Console.WriteLine("Важіть розмір матриці:");
Console.Write("n = ");
n=int.Parse(Console.ReadLine());
Console.Write("m = ");
m=int.Parse(Console.ReadLine());

int[,] matrix = new int[n, m];

Random myRandom = new Random();
for (int i = 0; i < n; i++)
    for (int j = 0; j < m; j++)
        matrix[i, j] = myRandom.Next(18, 32);

Console.WriteLine("Вкажіть назву файлу:");
string fileName = Console.ReadLine() + ".txt";

using (StreamWriter sw = new StreamWriter(fileName))
{
    for(int i=0; i<n; i++)
    {
        for(int j=0; j<m; j++)
        {
            sw.Write(matrix[i,j]+"\t");
        }
        sw.WriteLine();
    }
}


