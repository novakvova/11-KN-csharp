// See https://aka.ms/new-console-template for more information

using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("-- Робота з масивами --");
/* Example 1
//Масив - це набір однотипних даних.
//однотипні - одного типу - int, string, ...
//При створені масиву ми маємо вказати тип даних
// і кількість елементів у масиві.
//Це масив, який берігає 5 рядків - бо тип даних string
string[] names = new string[5];
//names - це назва масиву - як змінна, але масив
//Для збереження даних у масиві потрібно, звертатися
//по індексу до елементів масиву - тобто по його номеру
names[0] = "Мальвіна"; //на позиції 1 - це Мальвіна
//Ідексація масиву починається з 0
names[1] = "Віктор"; //на 2 позиції буде Віктор - індекс 1
names[2] = "Василь";
names[3] = "Петро";
names[4] = "Вулкан";

Console.WriteLine("index 0 = " + names[0]);
Console.WriteLine("index 1 = " + names[1]);
Console.WriteLine("index 2 = " + names[2]);
Console.WriteLine("index 3 = " + names[3]);
Console.WriteLine("index 4 = " + names[4]);

*/

/* Example 2
int n = 10; //Зберігає кількість елементів у масиві

int[] numbers = new int[n]; //зберігає цілі числа розміром n
Random myRandom = new Random();
int i = 0; //Змінна яка буде відповідає за ітерації циклу
for (i = 0; i < n; i++) //Цикл буде працювати від 0 до 9
{
    //Цикл працювати у межах ваших індексів масиву 
    //Записую числа у масив
    numbers[i] = myRandom.Next(18, 60);//Генерую випадкові числа 
}

//Відображаємо елементи масиву
i = 0; //Скидає лічильник циклу
while(i<n)
{
    Console.Write($"{numbers[i]}\t");
    i++; //i = i+1;
}
Console.WriteLine();

*/
/*
// Ініціалізація мисиву при створені
// Ми створили масив із 4 елементів і відразу записали значення у масив
int[] list = new int[] { 12, 45, 78, 31 };

//Як отримати кількість елементів масиву
int len = list.Length; //Масив має властивість Length - кількість елементів
Console.WriteLine($"Len = {len}");

int j = 0;
while(j<len)
{
    Console.WriteLine($"{j} -> {list[j]}");
    j++;
}
*/

//Хочу зробити масив, який зберіга страви
//Інший масив, який зберігає кількість калорій
string[] dishes = { 
    "Пампушка 1 штука", 
    "Чебурек - 200 грам",
    "Котлета - 100 грам",
    "Кумис - 300 грам"
};
//кількість калорій
int[] weight = { 130, 500, 250, 150 };

Console.WriteLine("Беріть страви, які ви хочете поїсти: :)");

int i = 0;
for(i=0; i < dishes.Length; i++)
{
    Console.WriteLine($"{i + 1}.{dishes[i]} -- {weight[i]} калорій");
}

int answer = 0; //Відповідь користувача
Console.Write("->_");
answer = int.Parse(Console.ReadLine());

Console.WriteLine("--Ваш вибір впав на--");
Console.WriteLine($"{answer} -- {dishes[answer-1]} - {weight[answer-1]} калорій");
