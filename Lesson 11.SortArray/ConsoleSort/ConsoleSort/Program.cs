// See https://aka.ms/new-console-template for more information
using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("-- Сортування масивів --");

Console.WriteLine("Вкажіть кількість елементів у масиві:");
Console.Write("->_");
int n = int.Parse(Console.ReadLine());

Console.WriteLine("n = " + n);

int[] items = new int[n]; //створили масив вказного розміру
Random myRandom = new Random();

for(int i = 0; i < n; i++)
    items[i] = myRandom.Next(16,55);

//Давайте виведемо масив через foreach(var item in items)
Console.WriteLine("Вхідний масив:");
foreach(int item in items)
    Console.Write($"{item}\t"); //якщо без {} виконується 1 рядок
Console.WriteLine();

//Переставити значення двох змінних між собою
//int a = 12;
//int b = 18;
//int temp = a;
//a = b;
//b = temp;
//Console.WriteLine($"Перестановка a = {a} b = {b}");

for(int i=0;i<n-1;i++) // i на 1 позицію не доходить до кінця
{
    //На початку роботи ми фіксуємо items[0]
    //і проходимо по циклу, щоб на початку було найменши число
    //Сортуємо від найменшого до найбільшого
    for(int j = i+1; j<n; j++) //починається з i+1
    {
        if (items[i] > items[j])
        {
            //переставимо їх місцями
            int temp = items[i]; items[i] = items[j]; items[j] = temp; 
        }
    }
}

Console.WriteLine("Вісортований масив");
foreach(int item in items)
    Console.Write($"{item}\t");
Console.WriteLine();

//Опишемо алгортм сортування по етапно
// нехай у нас є масив mas[5] = {12 7 23 1 9}
// Цикл for для i = 0;
// Цикл for для j = i+1; ... j<5
// j = 1 - 12 > 7 - mas[0] > mas[1] //міняємо місцями {7 12 23 1 9}
// j = 2 - 7 > 23 - mas[0] > mas[2] //нічого не робимо
// j = 3 - 7 > 1 - mas[0] > mas[3] // міняємо місцями {1 12 23 7 9}
// j = 4 - 1 > 9 - mas[0] > mas[4] // нічого не робимо
// Тепер на 1 місці у нас наймешний елемент
// i = 1 - змінився цикл for
// j = 2, бо j = i+1 - 12 > 23 - нічого не робимо
// j = 3 - 12 > 7, mas[1]>mas[3] // міняємо місцями {1 7 23 12 9}
// j = 4 - 7 > 9, mas[1]>mas[4] // нічогон не робимо
// Тепер на 2 міця стоїть найменший елемент
// і так далі.

string[] names = { "Василь", "Ярослав", "Ігор", "Вулкан" };
int size = names.Length;
Console.WriteLine("Мої друзі:");
foreach(var item in names)
    Console.Write($"{item}\t");


for (int i = 0; i < size - 1; i++) // i на 1 позицію не доходить до кінця
{
    //На початку роботи ми фіксуємо items[0]
    //і проходимо по циклу, щоб на початку було найменши число
    //Сортуємо від найменшого до найбільшого
    for (int j = i + 1; j < size; j++) //починається з i+1
    {
        if (names[i].CompareTo(names[j]) > 0)
        {
            //переставимо їх місцями
            string temp = names[i]; names[i] = names[j]; names[j] = temp;
        }
    }
}

Console.WriteLine("\n\nВідсортовані козаки і козачки:");
foreach (var item in names)
    Console.Write($"{item}\t");

