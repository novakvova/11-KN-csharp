// See https://aka.ms/new-console-template for more information

using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("-- Робота з матрицями --");

int n, m; // Розмірність матриці
Console.WriteLine("Вкажіть кількість рядків:");
n = int.Parse(Console.ReadLine()); // Введення кількості рядків
Console.WriteLine("Вкажіть кількість стовпців:");
m = int.Parse(Console.ReadLine()); // Введення кількості стовпців
///У Console.WriteLine можна вказути параметри після коми,
///які будуть підставлені у відповідні місця в рядку формату.
Console.WriteLine("Розмір нашої матриці: {0}x{1}", n, m);

///Я хочу вводи матрицю ось так
/// 34 45 21
/// 56 23 1
/// 3 1 5
int[,] a = new int[n, m]; // Створення матриці розміром n x m
Console.WriteLine("Введіть матрицю A ");
for (int i = 0; i < n; i++)
{
    string str = Console.ReadLine(); // Введення рядка матриці
    string[] ints = str.Split(' '); // Розділення рядка на числа
    if (ints.Length < m)
    {
        Console.WriteLine("Не достатня кількість чисел :(");
        return;
    }
    //Console.WriteLine($"Кількість чисел: {ints.Length}");
    for(int j=0;j<m;j++)
    {
        a[i, j] = int.Parse(ints[j]);
    }
}

int[,] b = new int[n, m]; // Створення матриці розміром n x m
Console.WriteLine("Введіть матрицю B ");
for (int i = 0; i < n; i++)
{
    string str = Console.ReadLine(); // Введення рядка матриці
    string[] ints = str.Split(' '); // Розділення рядка на числа
    if (ints.Length < m)
    {
        Console.WriteLine("Не достатня кількість чисел :(");
        return;
    }
    //Console.WriteLine($"Кількість чисел: {ints.Length}");
    for (int j = 0; j < m; j++)
    {
        b[i, j] = int.Parse(ints[j]);
    }
}

//Виведемо суму двох матриць
int[,] c = new int[n, m];
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        c[i, j] = a[i, j] + b[i, j]; //Сума елементів матриць A і B
    }
}

Console.WriteLine("Сума двох матриць A і B:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(c[i, j] + "\t");
    }
    Console.WriteLine();
}

//Над матрицями можна виконувати операції
//додавання, віднімання, множення, транспонування