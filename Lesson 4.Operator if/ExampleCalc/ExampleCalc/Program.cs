// See https://aka.ms/new-console-template for more information

using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine("-- Калькулятор --");
int a, b, c;
Console.Write("Вкажіть a = ");
a = int.Parse(Console.ReadLine());
Console.Write("Вкажіть b = ");
b = int.Parse(Console.ReadLine());

if(b == 0)
{
    Console.WriteLine("Ділити на 0 не можна :(");
    //return  - завершує роботу програми
    return; //Далі код виконуватися не буде
}
c = a / b;
Console.WriteLine($"{a}/{b}={c}");


