//Встановили кодування
Console.InputEncoding = System.Text.Encoding.UTF8;
Console.OutputEncoding = System.Text.Encoding.UTF8;

//Виводимо повідомлення на екран
Console.WriteLine("Як Вас звати?");
Console.Write("->_"); //Рядок на екран без переносу на новий рядок
//Це текстова змінна, яка називається name і може зберігати текст
string name;
//Щоб, щось ввести з клавіатури потрібно використати
//Console.ReadLine(); - це спеціальна фукнція, яка може прочитати текст
//-Console.ReadLine() - зупиняє програму і чекає текст
name = Console.ReadLine(); // текст з клавіатури після <Enter> запишеться в name

Console.WriteLine("Привіт друже "+ name+"! Гарного дня і позитивчику :)");

//для зберігання дробових значень нам потрібно double,float або decimal
float weight; //Дана змінна буде зберігати вагу
weight = 85.23F; //Це означає, що ми надали значення змінні 85.25
Console.WriteLine("weight = " + weight);

double weight2;
weight2 = 65.35;
Console.WriteLine("weight2 = " + weight2);

decimal weight3;
weight3 = 73.67M;
Console.WriteLine("weight4 = " + weight3);

double a, b, c; //створити 3 змінних
string text; //Для зберігання тексту - текст, який вводить користувач

Console.Write("Введіть число a = ");
text = Console.ReadLine(); //З клавіатури вводимо число - але це текст
//a = text; //Так роботи не можна бо змінні зберігаються різні значення
a = double.Parse(text); //Перетворюємо текст у дробове значення double
Console.WriteLine("a = " + a);


