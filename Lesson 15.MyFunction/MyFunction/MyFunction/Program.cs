// See https://aka.ms/new-console-template for more information
using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("-- Привіт козаки і козачки - ми вчимо функції --");

///Фукнція дуже схожа до математичної функції, яка робить обчислення
///На С# може бути фукнція, яка нічого не приймає і нічого не повертає.
///Може бути функція, яка виводить привітання на екран.
///Протопит оголошення фукнції
/// void FunctionName() { }
///Функції потрібні, що один облок коду виконувався декілька разів.
///тобто функці назває блок коду, який можемо виконуватися декілька разів.
void DisplayText() //Назва нашої функції
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Привіт Оствиця - свиня Фрося форевер :)");
    Console.ForegroundColor = ConsoleColor.White;
}

//Виклик функції
//DisplayText(); //Виклик функції
//Operation(); //Виклик функції

Console.WriteLine("Вкажіть, яку операцію виконати:");
char ch = Console.ReadLine()[0]; //взяв із рядка 1 символ
OperationCase(ch);

//Хочу, що у Фукнцію передавався параметр, яку операцію виконати
void Operation() //Для виконання математичних операцій
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Введіть a");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введіть b");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("a + b = " + (a + b));
    Console.ForegroundColor = ConsoleColor.White;
}

void OperationCase(char ch) //Функція приймати параметри, яку операцію ми хочуемо виконати
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    int a, b, c=0;
    Console.Write("Вкажіть a ->_");
    a = int.Parse(Console.ReadLine());
    Console.Write("Вкажіть b ->_");
    b = int.Parse(Console.ReadLine());
    switch(ch)
    {
        case '+':
            {
                c = a + b;
                break;
            }
        case '-':
            {
                c = a - b;
                break;
            }
        case '*':
            {
                c = a * b;
                break;
            }
        case '/':
            {
                c = a / b;
                break;
            }
    }
    Console.WriteLine("c = " + c);

    Console.ForegroundColor = ConsoleColor.White;
}
