// See https://aka.ms/new-console-template for more information
using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("-- Робота із циклом while --");

// Задача 1: Вивести числа від 1 до 10
// ініціалізація циклу while 
int i = 1; //починаємо з 1
while(i<=10)
{ //початок блоку коду циклу
    Console.WriteLine($"{i} ітерація");
    i = i + 1; //Працює лічильник циклу - без нього вічний цикл
} //кінцеь блоку цикл
