
using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine(
    "Написати програму, яка обчислює суму \n" +
    "перших n цілих позитивних цілих чисел. \n" +
    "Кількість сумованих чисел має вводитися \n " +
    "під час роботи програми.");

int n = 0; //Кількість чисел, суму яких потрібно обчислити
Console.Write("n = ->_");
n = int.Parse(Console.ReadLine());
int summ = 0; //Данна змінна буде зберігати суму чисел
for(int i = 1; i<=n; i = i+1)
{
    summ = summ + i;
    Console.WriteLine("i = " + i);
}
Console.WriteLine("Суму чисел = " + summ);
//
