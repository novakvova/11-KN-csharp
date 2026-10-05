// See https://aka.ms/new-console-template for more information
using System.Collections.Concurrent;
using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

//Console.WriteLine("--Привіт козаки і козачки--");
/*
int i = 0; //Початкове значення для циклу
int n = 10; //Цикл буде працювати 10 разів
for(;i<n;i++)
{
    Console.WriteLine($"{i+1}.Добре їсти добре спати");
}
*/

//Парні і не парні числа
// Парні числа 0,2,4,6, ..., 
//Вивести на екран парні числа в певному діапазоні
//діапазон вводить з клавіатури.
/*
int min, max; //Для зберігання діапазону
Console.Write("Вкажіть мінімум ->_");
min = int.Parse(Console.ReadLine());
Console.Write("Вкажіть максимум ->_");
max = int.Parse(Console.ReadLine());
for(int i = min; i<=max; i++)
{
    if(i%2==0)
    {
        Console.Write($"{i}\t");
    }
}
Console.WriteLine("\n--Кінець зроботи програми--");

*/

//Зробити програму, у якій користувач вводить числа
//вік домашніх твари
//якщо користувач вводить відємний вік, то програма
//виходить
//Потрібно числити Загальну суму віку ваших тварин
//Тобто у нас має бути вічний цикл
//int age = 0; //вік тварини
//int summ = 0; //На початку роботи циклу сума = 0
//for (; 1 == 1;) //== порівнння, = - присвоїти
//{
//    Console.Write("Вкажіть вік вашої тварин ->_");
//    age = int.Parse(Console.ReadLine());
//    //Задаємо умову переривання циклу
//    if (age < 0)
//    {
//        break; //перериває роботу даного циклу for
//    }
//    summ = summ + age; //збільшуємо суму
//}

//Console.WriteLine("Загальний вік ваших тварин: " + summ);


//Задача 
//Написати програму, яка обчислює суму перших n
//членів ряду: 1, 3, 5, 7... Кількість сумованих членів ряду
//задається під час роботи програми.
Console.Write("Вкажіть кільсть чисел рядку: ->_");
int n = int.Parse(Console.ReadLine());
//сума має бути така - 1+3+5+7+9
int temp = 1;
int suma = 0; //Почнаємо з 0 обчислення суми
for(int i=0;i<n;i++)
{
    suma = suma + temp;
    //Console.WriteLine($"{i}.{temp}");
    temp = temp + 2; //temp пригає через 1
}
Console.WriteLine("Сума число рядку: "+suma);
