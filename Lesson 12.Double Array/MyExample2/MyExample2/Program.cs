// See https://aka.ms/new-console-template for more information

using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;


Console.WriteLine("-- Створенння двохмірного масиву динамічно --");

int n = 0; // кількість рядків
int m = 0; // кількість стовпців

Console.WriteLine("Вкажіть кількість рядків:");
n = int.Parse(Console.ReadLine());

Console.WriteLine("Вкажіть кількість стовпців:");
m = int.Parse(Console.ReadLine());

//Так створити масив дуже просто,
//але він буде мати фіксовану кількість рядків і стовпців.
int[,] array = new int[n, m]; // створення двохмірного масиву

Random random = new Random();

for(int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        // заповнення масиву випадковими числами від 1 до 10
        array[i, j] = random.Next(1, 10); // заповнення масиву випадковими числами від 1 до 99
    }
}

Console.WriteLine("-- Наш масив --");
for (int i = 0; i < n; i++)
{
    for(int j = 0;j < m; j++)
    {
        Console.Write($"{array[i,j]}\t");
    }
    Console.WriteLine();
}
int summ = 0; //Зберігає суму елементів у рядку
Console.WriteLine("Сума значень у рядку:");
//Обчислити суму елементів у рядку
for (int i = 0; i < n; i++)
{
    summ = 0; //скидає лічильник
    for (int j = 0; j < m; j++)
    {
        summ += array[i, j]; // шукаємо суму елементів
    }
    Console.WriteLine($"{i+1} = {summ}");
}

//Вивести на екран суму елементів двомірного масиву по стовпчиках
Console.WriteLine("Сума значень у стовпчику:");
//Обчислити суму елементів у рядку
for (int i = 0; i < m; i++)
{
    summ = 0; //скидає лічильник
    for (int j = 0; j < n; j++)
    {
        summ += array[j, i]; // шукаємо суму елементів
    }
    Console.WriteLine($"{i + 1} = {summ}");
}


