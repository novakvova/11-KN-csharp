// See https://aka.ms/new-console-template for more information
using System.Text; //Підключення простору імен System.Text

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("-- Умовні оператори у C# --");

//Які оператори умови є у C# 
// >, <, ==, !=, >=, <=
//Кожен вираз повертає значення true або false
Console.WriteLine(3==2);//Даний вираз повертає False
Console.WriteLine(4 > 2); //Повертає True

//У С# icнує оператор if - синтаксис запису
//  if(УМОВА) 
//  { //Початок блоку оператора умови
//      //Блок вашого коду, який буде працювати у днаій умові
//  } //Кінець блоку оператора умови

//Зберігає вік людини
int age; //Зберігає цілі числа - вік
//cw -> Tab
Console.Write("Вкажіть Ваш вік: ->_");
string text = Console.ReadLine(); //вводимо текст із клавіатури
age = int.Parse(text); //Перетворили текст у число

Console.WriteLine("age = " + age);

if(age<18) //щоб зробити умову в протилежному випадку
{
    Console.WriteLine("Вам не дадуть права на авто :(");
}
//Ми можемо використати else - спрацьовує кли if хибний
else
{
    Console.WriteLine("Вітаємо :). Ви можете навчатися на права.");
}

if(age < 0)
{
    Console.WriteLine("Ви точне не отримаєте права. Не допустимий вік.");
}




