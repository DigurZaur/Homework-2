// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

System.Console.WriteLine("Введите X:");
int X = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите Y:");
int Y = Convert.ToInt32(Console.ReadLine());

if (X == 0 || Y == 0)
{
    System.Console.WriteLine("Введите X и Y не равные 0!");
}
else if (X > 0 && Y > 0)
{
    System.Console.WriteLine($"Точка с координатами ({X}:{Y}) находится в I координатной четверти плоскости.");
}
else if (X < 0 && Y > 0)
{
    System.Console.WriteLine($"Точка с координатами ({X}:{Y}) находится во II координатной четверти плоскости.");
}
else if (X < 0 && Y < 0)
{
    System.Console.WriteLine($"Точка с координатами ({X}:{Y}) находится в III координатной четверти плоскости.");
}
else if (X > 0 && Y < 0)
{
    System.Console.WriteLine($"Точка с координатами ({X}:{Y}) находится в IV координатной четверти плоскости.");
}