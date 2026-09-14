// See https://aka.ms/new-console-template for more information

using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("Оператор switch :)");

//Оператор switch - може допомогти змінити if та else
//використовується для вибору однієї із декілької умов
//Синтаксис запису
//switch(змінна)
//{
//case Умова-Відповідність:
//{
//блоку коду для виконання
//}
//}

int day = -5; //нам по номеру тижня, видати,який це є день
switch(day) //передаємо змінну, яка буде перевірятися
{
    case 4:
        {
            Console.WriteLine("--Четвер--");
            break;
        }
    case 5: //перевірка на відповідність
        { //блок коду, якщо day == 5
            Console.WriteLine("--П'ятниця--");
            //Якщо його не вказати буде помилка або полетить інший case
            break; //Переває роботу даного блоку виходить із switch
        }
    default:
        {
            Console.WriteLine("Дані вказано не вірно :(");
            break;
        }
}
