// See https://aka.ms/new-console-template for more information
//break - перериває роботу циклу
using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("- - Використання циклу while - -");

//int summ = 0;

//while(true) //вічний цикл
//{
//    Console.WriteLine("Вкажіть вік Вашої тваринки(-1 - вихід): ");
//    int temp = int.Parse(Console.ReadLine());
//    if (temp == -1)
//        break; //можна писати 1 рядок без { якщо 1 оператор }
//    summ += temp;
//}
//Console.WriteLine("Сумма = "+ summ);

int summ = 0;

for (; true;) //вічний цикл
{
    Console.WriteLine("Вкажіть вік Вашої тваринки(-1 - вихід): ");
    int temp = int.Parse(Console.ReadLine());
    if (temp == -1)
        break; //можна писати 1 рядок без { якщо 1 оператор }
    summ += temp;
}
Console.WriteLine("Сумма = " + summ);

