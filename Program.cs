using System;

namespace Task12
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Добро пожаловать в обменник валют вы можете обьменять валюту");
            Console.WriteLine("Сегодня usd = 0.94 euro , euro = 1.06 usd, usd = 67 rub, euro = 72 rub");
            Console.WriteLine("1 - Вы моежете конвертировать доллар в рубли или евро");
            Console.WriteLine("2 - Вы моежете конвертировать рубли  в евро или доллары");
            Console.WriteLine("3 - Вы можете конвертировать евро в рубли или доллары");


            string userInput = Console.ReadLine();
          
            switch (userInput)
            {

                case "1":
                    
                    Console.Write("Введите количество долларов:");
                    float usdCount = Convert.ToSingle(Console.ReadLine());                   
                    Console.Write("В какую валюту конвертировать? Введите валюту 'euro' или 'rub': ");
                    string euroOrRub = Console.ReadLine();
                   
                    if (euroOrRub == "euro")
                    {
                        Console.Write($"У Вас " + usdCount * 0.94 + " euro");
                       
                    }
                    else if (euroOrRub == "rub")
                    {
                        Console.Write("У Вас " + usdCount * 67 + "rub");
                    }
                    else
                    {
                        Console.WriteLine("Ошибка");
                    }
                    break;

                case "2":
                    Console.Write("Введите количество рублей: ");
                    float rubCount = Convert.ToSingle(Console.ReadLine());
                    Console.Write("В какую валюту конвертировать? Введите валюту 'euro' или 'usd': ");
                    string euroOrUsd = Console.ReadLine();

                    if (euroOrUsd == "euro")
                    {
                        Console.Write("У вас  " + rubCount / 72 + "euro");
                    }
                    else if (euroOrUsd == "usd") 
                    {
                        Console.Write("У вас  " + rubCount / 67 + "usd");
                    }
                    else
                    {
                        Console.WriteLine("Ошибка");
                    }
                    break;

                case "3":
                    Console.Write("Введите количество евро ");
                    float euroCount = Convert.ToSingle(Console.ReadLine());
                    Console.Write("В какую валюту вы хотите конвертировать? Введите валюту 'rub' или 'usd': ");
                    string rubOrUsd = Console.ReadLine();

                    if (rubOrUsd == "rub")
                    {
                        Console.Write("У вас " + euroCount * 72 + "rub");
                    }
                    else if (rubOrUsd == "usd") 
                    {
                        Console.Write("у вас " + euroCount * 1.06 + "usd");
                    }
                    else
                    {
                        Console.WriteLine("Ошибка");
                    }
                    
                    break;


            }

            
        }  
    }
}
