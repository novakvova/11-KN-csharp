using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

//& - амерсенд - і
// | - або
Console.WriteLine("Оператор && та ||");

//&& - Для запису умови коли ми хочемо об'єднати
//(умова) && (умова) - коли даний вираз буде істини true
//Коли умова зліва та з права буде true
int age = 12;
Console.Write("Вкажіть Ваш вік: ");
age = int.Parse(Console.ReadLine());//Вводимо дані з клавіатуи
//Давайте перевіримо умові від 18  і до 60
if(age>18 && age<60)
{
    Console.WriteLine("Ви призовного віку :)");
}
else if(age>6 && age<=18)
{
    Console.WriteLine("Ви шкільного віку. Чудово :)");
}
else if(age<6 && age>=3)
{
    Console.WriteLine("Ви із дитячого садочка :)");
}
else if((age>0 && age<3) ||age>=60)
{
    Console.WriteLine("Мабуть ви хатня дитина або пенсіонер");
}
else
{
    Console.WriteLine("Ми не можемо Вас ідентифікувати 🙌");
}

