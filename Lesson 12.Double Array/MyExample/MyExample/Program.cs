// See https://aka.ms/new-console-template for more information
using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("-- Робота із двовимірними масивами --");

// Створення двовимірного масиву
// Масив з 2 рядків
int[][] pavlo = new int[2][];
pavlo[0] = new int[2]; //У 1 рядку буде 2 елемента
pavlo[1] = new int[2]; //У 2 рядку буде 2 елемента

//Заповнення масиву значеннями
pavlo[0][0] = 1; //1 рядок, 1 елемент
pavlo[0][1] = 2; //1 рядок, 2 елемент
pavlo[1][0] = 3; //2 рядок, 1 елемент
pavlo[1][1] = 4; //2 рядок, 2 елемент

Console.WriteLine($"{pavlo[0][0]}\t{pavlo[0][1]}");
Console.WriteLine($"{pavlo[1][0]}\t{pavlo[1][1]}");
