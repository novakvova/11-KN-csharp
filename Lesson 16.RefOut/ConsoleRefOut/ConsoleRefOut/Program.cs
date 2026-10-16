// See https://aka.ms/new-console-template for more information

using System.Collections.Specialized;
using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("Фукнції. Повернення значення. Ref Out.");

int a = MyPow(2,8); //підношу число 2 до 8 ступення
Console.WriteLine($"2 у степені 8 = {a}");

//Математичні фукнції у C#
double b = Math.Pow(2, 8);
Console.WriteLine($"Використання pow у С# = {b}");

double cos = Math.Cos(4);
Console.WriteLine($"cos(4) = {cos}");

//Якщо функція повертає значення, то тип значення, яке повертається
//пишемо перед назвою функції
//Приймає число і степінь
int MyPow(int digital, int step)
{
    //Щоб піднести число до степення використаю цикл
    int count = 1;
    int результат = digital; //1 - це 1 степінь
    while(count<step)
    {
        результат *= digital; //
        count++;
    }
    return результат;
}
