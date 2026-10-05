// See https://aka.ms/new-console-template for more information

using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("Робота із масивами :)");

int[] list = { 23, 8, 12, 90 };
foreach (int i in list)
    Console.Write($"{i}\t");
Console.WriteLine(); // У кінці робимо перехід на новий
                     // рядок
int[,] myCats =
{
    { 2, 3, 4 },
    { 5, 6, 7 },
};
//myCats.GetLength(0) - перший вимір - кількість рядків
//myCats.GetLength(1) - кількість стовпчиків
Console.WriteLine("Двох мірний масив");
for (int i = 0; i < myCats.GetLength(0); i++)
{
    for (int j = 0; j < myCats.GetLength(1); j++)
    {
        Console.Write($"{myCats[i,j]}\t");
    }
    Console.WriteLine();
}


