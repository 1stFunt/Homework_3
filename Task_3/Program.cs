// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

while (true)
{
    Console.Write("Введите натуральное число (N): ");
    int number = Convert.ToInt32(Console.ReadLine());
    int a = 1;
    if (number <= 0)
    {
        Console.WriteLine("Ошибка! Введено НЕ натуральное число (N), попробуйте ещё раз.");
        continue;
    }
    while (a <= number)
    {
        Console.Write(a * a * a++ + " ");
    }
    break;
}