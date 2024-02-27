// Задача 3: Напишите программу, которая принимает на вход 
// целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

System.Console.WriteLine("Введите число от 10 до 99:");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 10 || num > 99)
{
    System.Console.WriteLine("Данное число не входит в отрезок [10, 99]!");
}
else 
{
    int x1 = num / 10;
    int x2 = num % 10;
    if (x1 > x2)
    {
        System.Console.WriteLine($"Наибольшая цифра числа: {x1}");
    }
    else
    {
        System.Console.WriteLine($"Наибольшая цифра числа: {x2}");
    }
}