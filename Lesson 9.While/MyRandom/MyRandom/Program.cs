// See https://aka.ms/new-console-template for more information

using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;

Console.WriteLine("--Працюємо із Random--");

//межі для Random вводимо з клавіатури
int min, max;
Console.Write("Вкажіть мінімум: ->_");
min = int.Parse(Console.ReadLine());
Console.Write("Вкажіть максимум: ->_");
max = int.Parse(Console.ReadLine());

if (min > max)
{
    Console.WriteLine("Діапазон вказано не вірно :(");
    return; //перериває роботу програми :)
}
//Оголошуємо Random
Random myRandom = new Random(); //спеціальна змінна для myRandom
//Генеруємо випадково 10 чисел
int i = 0;
int count = 10;
while(i<count)
{
    int rand = myRandom.Next(min+1, max);
    Console.Write($"({i+1}/{count}) -> {rand}\n");
    Console.WriteLine("--Для продовження натисні будь-яку кнопку--");
    Console.ReadKey();
    i++;
}