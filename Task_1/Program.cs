// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

while (true)
{
    Console.Write("Введите пятизначное число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int mir1 = number; int mir2 = number;
    if (number < 0)
    {
        number *= -1;
    }
    if (number < 100000 && number > 9999)
    {
        {
            mir1 = number / 1000;
            mir2 = number % 10 * 10 + number / 10 % 10;
        }
        if (mir1 == mir2)
        {
            Console.WriteLine("Число является палиндромом");
        }
        else
        {
            Console.WriteLine("Число НЕ является палиндромом");
        }
    }
    else
    {
        Console.WriteLine("Не верное число, введите пятизначно!");
        continue;
    }
    break;
}
