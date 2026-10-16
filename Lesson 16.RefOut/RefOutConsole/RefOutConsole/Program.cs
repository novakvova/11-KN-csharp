// See https://aka.ms/new-console-template for more information

using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;

Console.WriteLine("--Ref Out, як воно працює--");

//Console.WriteLine("Скільки Вам років: ");
//string str = Console.ReadLine(); //Ми вводимо текст
//Я хочу текст перетворити у число
//int age = int.Parse(str); //Якщо str - не число, я отримаю помилку
int age;
//Якщо пишемо out, то змінна має змінюватися у середині функції
//При цьому важливо знати, що age - точно зміниться
//int.TryParse(str, out age); //По іншому петворюємо рядок у цифру
//Console.WriteLine("Ваш вік: " + age);
Console.WriteLine("Введіть число:");
string str = Console.ReadLine();
MyTryParse(str, out age);
Console.WriteLine($"Робота функції 23щ9 = {age}");
//Давайте тепер напишемо свою функцію TryParse, яка буде
//Рядок перетворювати у число
void MyTryParse(string text, out int result) //void - фукнія нічого не вертає
{
    //out - посилається на змінну result і будемо її змінювати
    string str = "";
    foreach(char ch in text) //перебирає рядок по символах
    {
        int code = (int)ch; //код символа
        if(code >=48 && code <=57)
        {
            str += ch; //тут зберігаю цифри
        }
        Console.WriteLine($"code = {code}");
    }
    result = int.Parse(str); //перетворю в число
}

