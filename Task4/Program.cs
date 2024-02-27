// Задача 4: Напишите программу, которая на вход принимает 
// натуральное число N, а на выходе показывает его цифры через запятую.

System.Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 10)
{
    System.Console.WriteLine(num);
}
else if (num == 0)
{
    System.Console.WriteLine("0 не является натуральным числом!");
}
else
{
    while (num > 0)
    {
        int part = num % 10;
        if (num > 9)
        {
            System.Console.Write($"{part}, ");
        }
        else
        {
            System.Console.Write($"{part}.");
        }
        num = num / 10;
    }
}