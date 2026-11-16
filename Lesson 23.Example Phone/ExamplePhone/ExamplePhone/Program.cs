// See https://aka.ms/new-console-template for more information

using System.Reflection.PortableExecutable;
using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("-- Телефоний довідничок --");

int action = 0; //Дія яку робить користувач
string fileName = "phones.txt"; //назва нашого файлу із телефонами
do
{
    Console.WriteLine("0.Вихід");
    Console.WriteLine("1.Додати абонента");
    Console.WriteLine("2.Показати усіх абонентів");
    Console.WriteLine("3.Пошук по name");
    Console.Write("->_");
    action = int.Parse(Console.ReadLine());

    switch (action)
    {
        case 1:
            {
                Console.Write("Як звати людину ->_");
                string name = Console.ReadLine();
                Console.Write("Вкажіть адресу ->_");
                string address = Console.ReadLine();
                Console.Write("Вкажіть телефон ->_");
                string phone = Console.ReadLine();
                StreamWriter writer = new StreamWriter(fileName, true);
                writer.WriteLine(name);
                writer.WriteLine(address);
                writer.WriteLine(phone);
                writer.Close();
                break;
            }
        case 2:
            {
                StreamReader reader = new StreamReader(fileName);
                Console.WriteLine("--Список наших козаків і козачок--");
                while(true)
                {
                    string line = reader.ReadLine();
                    if (string.IsNullOrEmpty(line))
                        break; //Не буде путий рядок - це кінець файлу
                    Console.WriteLine(line);
                }
                reader.Close();
                break;
            }
        case 3:
            {
                Console.Write("Вкажіь ім'я -> ");
                string name = Console.ReadLine();
                StreamReader reader = new StreamReader(fileName);
                Console.WriteLine("-- Результат пошуку --");
                while (true)
                {
                    // ім'я яке я прочитав із файлу
                    string nameRead = reader.ReadLine();
                    if (string.IsNullOrEmpty(nameRead))
                        break; //Не буде путий рядок - це кінець файлу
                    string addressRead = reader.ReadLine();
                    string phoneRead = reader.ReadLine();
                    //порівняння на входження в рядок
                    if(name.Contains(nameRead))
                    {
                        Console.WriteLine(nameRead);
                        Console.WriteLine(addressRead);
                        Console.WriteLine(phoneRead);
                    }
                }
                reader.Close();
                break;
            }

    }


} while (action != 0);
