class Task2
{
    /* Задание 2
Напишите программу, которая будет выполнять конвертирование валют. 
Пользователь вводит: сумму денег в определенной валюте, курс для конвертации в другую валюту. 
Организуйте вывод результата операции конвертирования валюты на экран. */

    static double USD (double amount, double rate)
    {
        return amount * rate;
    }
    static double EUR (double amount, double rate)
    {
       return amount * rate;
    }
    static double UAH (double amount, double rate)
    {
       return amount * rate;
    }
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.InputEncoding = System.Text.Encoding.Unicode;
        do
        {
                Console.WriteLine("Пожалуйста, введите сумму денег:");
                double amount = Convert.ToDouble(Console.ReadLine());
                do
                {
                    Console.WriteLine("Пожалуйста, укажите валюту из перечисленных USD, EUR, UAH:");
                    string currency1 = Console.ReadLine();
                    if (currency1 != "USD" && currency1 != "EUR" && currency1 != "UAH")
                    {
                                Console.WriteLine("Формат валюты неверный или не поддерживается");
                    }
                    else
                    {
                        break;
                    }
                }
                while (true);
                Console.WriteLine("Пожалуйста, введите курс для конвертации в другую валюту:");
                double rate = Convert.ToDouble(Console.ReadLine());
                do
                {
                    Console.WriteLine("Пожалуйста, выберите валюту для конвертации из перечисленных USD, EUR, UAH:");
                    string currency2 = Console.ReadLine();
                    if (currency2 != "USD" && currency2 != "EUR" && currency2 != "UAH")
                    {
                        Console.WriteLine("Формат валюты неверный или не поддерживается");
                    }
                    else
                    {
                        if (currency2 == "USD")
                        {
                            double usd = USD(amount, rate);
                            Console.WriteLine("Результат конвертации - " + usd + " USD");
                        }
                        else if (currency2 == "EUR")
                        {
                            double eur = EUR(amount, rate);
                            Console.WriteLine("Результат конвертации - " + eur + " EUR");
                        }
                        else if (currency2 == "UAH")
                        {
                            double uah = UAH(amount, rate);
                            Console.WriteLine("Результат конвертации - " + uah + " UAH");
                        }
                        break;
                    }                
                }
                while (true);
        }
        while (true);
    }
}
