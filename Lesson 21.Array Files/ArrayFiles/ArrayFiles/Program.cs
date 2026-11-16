// See https://aka.ms/new-console-template for more information

using System.Security.Cryptography;
using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;


Console.WriteLine("Працюєммо із масивом файлів");

string url = "https://i.pravatar.cc/1200";

int count = 0;
Console.WriteLine("Вкажіть кількість фото:");
count = int.Parse(Console.ReadLine());
string dir; //ім'я папки, куди будемо кидати фото
Console.WriteLine("Вкажіть назву папки:");
dir = Console.ReadLine();
//створимо папку у поточні папці
Directory.CreateDirectory(dir);
for (int i = 0; i < count; i++) //качаю певну кількість фото
{
    try
    {
        HttpClient myClient = new HttpClient();
        byte[] bytes = myClient.GetByteArrayAsync(url).Result;
        //Guid --унікальна назва файлу
        string fileName = Guid.NewGuid().ToString()+".jpg";
        //Path - для роботи із гляхами у файловій системі
        string fileSavePath = Path.Combine(dir, fileName);
        //string fileSavePath = dir + "\\" + fileName;
        File.WriteAllBytes(fileSavePath, bytes); //зберігаємо у папку
        Console.WriteLine($"Збережено {i+1} файл успішно :)");
    }
    catch(Exception ex)
    {
        Console.WriteLine("Сталася помилка "+ex.Message);
    }
}

//Хочу провести аналіз папки
//Використаю файл Directory
string [] files = Directory.GetFiles(dir);
Console.WriteLine("Список файлів, які ви скачали:");
//Отримав список усіх файлів у папці
foreach(var file in files)
{
    FileInfo fileInfo = new FileInfo(file);
    int size = File.ReadAllBytes(file).Length; //розмір файлу
    string fileName = Path.GetFileName(file);
    DateTime fileCreated = fileInfo.CreationTime;
    string strDateCreate = fileCreated.ToString("dd.MM.yyyy HH:mm:ss");
    Console.WriteLine($"{fileName}\t{size/1024} Кб.\t{strDateCreate}");
}




