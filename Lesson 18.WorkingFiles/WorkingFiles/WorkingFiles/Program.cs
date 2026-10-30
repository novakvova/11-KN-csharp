// See https://aka.ms/new-console-template for more information

using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("-- Робота з файлами --");

///Найпростіше працювати із файлами, які
///збірігаються у поточній папці. Поточна - це де 
///запускається вак код програми, ваш exe файл.

/*
Console.WriteLine("Вкажіть назву файла:");
string file = Console.ReadLine();
//Як перевірити чи існує файл
if(File.Exists(file)) //Exists - true - файл існує
{
    Console.WriteLine($"Даний файл існує {file}");
    string text = File.ReadAllText(file); //читаємо вміст файлу
    Console.WriteLine(text);
}
else
{
    Console.WriteLine("Вкажіть текст, який записати у файл:");
    string text = Console.ReadLine();
    File.WriteAllText(file, text); //записуємо у файл
}
*/


Console.WriteLine("Клас --- Enviroment ---");
//Ім'я мого ПК
Console.WriteLine("MachineName: " + Environment.MachineName);
Console.WriteLine("Поточна папка: "+ Environment.CurrentDirectory);
string [] drivers = Environment.GetLogicalDrives();
Console.WriteLine("Список Ваших дисків:");
foreach (string driver in drivers)
{
    Console.WriteLine($"\t{driver}");
}

Console.WriteLine("Що знаходиться в папці:");
DirectoryInfo dInfo = new DirectoryInfo("C:\\");
var filesAndDirs = dInfo.GetDirectories();

foreach (var dir in filesAndDirs)
    Console.WriteLine(dir);