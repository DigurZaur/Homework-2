// Задача 1: Напишите программу, которая принимает на 
// вход число и проверяет, кратно ли оно одновременно 7 и 23.

System.Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 7 == 0 && num % 23 == 0)
{
    System.Console.WriteLine($"Число {num} кратно одновременно 7 и 23");
}
else
{
    System.Console.WriteLine($"Число {num} НЕ кратно одновременно 7 и 23");
}