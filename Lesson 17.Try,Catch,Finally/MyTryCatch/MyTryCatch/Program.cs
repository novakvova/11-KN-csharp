using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine("-- Робота із виключеннями --");

try
{
    Console.Write("Скільки Вам років ->_");
    int age = int.Parse(Console.ReadLine());
    Console.WriteLine("Ваш вік " + age);
}//У даному випадку ми будемо ловити довільні помилки - будь-які
catch(Exception ex)
{
    Console.WriteLine("Виникла помилка: " + ex.Message);
}
finally //не важливо, чи був chatch - finally - буде викликатися
{
    Console.WriteLine("Допобачення - позитивчику і смаколика :)");
}

Console.WriteLine("Як Вас звати:");
string name = Console.ReadLine(); //Вводимо Ім'я
try
{
    if(name.Equals("Сюзана"))
    {
        throw new Exception("Дане ім'я у бані");
    }
    else
    {
        Console.WriteLine("Вітаємо Вас у системі "+ name);
    }
}
catch(Exception ex)
{
    Console.WriteLine("Помилка "+ ex.Message);
}