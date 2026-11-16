// See https://aka.ms/new-console-template for more information

using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("-- Робота з потоками файлів --");

Console.WriteLine("Вкажіть назву файлу");

string fileName = Console.ReadLine();
fileName += ".txt"; //Додаємо до файлу розширення
/*
//Клас для запису тексту у файл
StreamWriter myWriter = new StreamWriter(fileName);
//Працює аналогічно, як Console.WriteLine але у файл
myWriter.WriteLine("Сьогодні класна погода.");
myWriter.WriteLine("Назара вкусила собака біля.");
myWriter.WriteLine("Вона лежала. Втала вкусилі і втіла.");

myWriter.Close();

Console.WriteLine("Запис у файл успішний :)");
*/
//Чи існує файл - true - якщо існує
if(File.Exists(fileName))
{
    StreamReader myReader = new StreamReader(fileName);
    string line1 = myReader.ReadLine();
    string line2 = myReader.ReadLine();
    Console.WriteLine("line1 = "+line1);
    Console.WriteLine("line2 = "+line2);
    myReader.Close();
}
else
{
    Console.WriteLine("Даний файл не існує :(");
}


