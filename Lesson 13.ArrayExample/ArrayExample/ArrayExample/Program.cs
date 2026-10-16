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

Console.WriteLine("--- Task 1 ---");
//1.В масиві з 10 елементів заповненого 
//випадковими числами в межах [-10;10]
//знайти добуток та суму елементів.
int n = 10;
int[] array = new int[n];
Random r = new Random();
//Заповняємо масив даними
for (int i = 0; i < n; i++)
{
    array[i] = r.Next(-10, 11);
}
Console.WriteLine("Наш масив");
foreach(var t in array)
    Console.Write($"{t}\t");
Console.WriteLine();

//Щоб знайти суму елементів, треба мати змінну куди
//суму зберігати
int sum = 0; //Коли шукаємо суму починає з 0
for(int i = 0; i < n;i++)
{
    //sum += array[i];
    sum = sum + array[i];
}
Console.WriteLine($"Суму елементів {sum}");

int dob = array[0];
for (int i = 1; i < n; i++)
{
    dob *= array[i];
}
Console.WriteLine($"Добуток елементів {dob}");


