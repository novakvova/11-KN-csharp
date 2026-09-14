
//Встановли кодування для консолі
//Щоб працювали українські літери
Console.InputEncoding = System.Text.Encoding.UTF8;
Console.OutputEncoding = System.Text.Encoding.UTF8;

//cw натиснути Tab
Console.WriteLine("---Арифметичні операції---");

//+, -, *, /, %
//Створимо цілі змінні - по default - 0
int a; //Дана змінна зветься a - 4 байти при цьому - і + 
int b; //Аналогічно, як a але зветься b

//Операція = - присвоїти - надати значення
a = 12; //У змінну a ми присвоїли значення 12
b = 25; //Надали значення 25

int c;
c = a + b; //Значення 12 + 25 і те, що вийте буде записано у с
//Коли ми додаємо до "" + "" - це називається конкатонація
//Обєднання двох слів
Console.WriteLine("c = " + c);

int plus = a + b; //Ми створили змінну plus і її присвоїли a+b
int minus = a - b;
int div = a / b;
int mul = a * b;
int vid = b % a; //Відсоток від діленя  25/12 - 2, а остача 1

Console.WriteLine("a + b = " + plus);
Console.WriteLine("a - b = " + minus);
Console.WriteLine("a * b = " + mul);
Console.WriteLine("a / b = " + div);
Console.WriteLine("b % a = " + vid);

