// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.WriteLine("Введите первое число");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num1 > num2)
// {
//     Console.WriteLine("Первое число больше второго");
// }
// else if (num1 < num2)
// {
//     Console.WriteLine("Первое число меньше второго");
// }
// else
// {
//     Console.WriteLine("Числа равны");
// }
// Console.ReadKey();

﻿//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

// Console.Write("Ведите первое число: ");
// int a = int.Parse(Console.ReadLine());
// Console.Write("Ведите второе число: ");
// int b = int.Parse(Console.ReadLine());
// Console.Write("Ведите третье число: ");
// int c = int.Parse(Console.ReadLine());

// if (a > b && a > c)
// {
//     Console.Write($"a = {a}, b = {b}, c = {c} > max = {a}");
// }
// else if (b > c)
// {
//     Console.Write($"a = {a}, b = {b} > max = {b}");
// }
// else 
// {
//     Console.Write($"a = {a}, b = {b} > max = {c}");
// }
﻿//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

// Console.Write("Введите число, a ");
// int a = int.Parse(Console.ReadLine());
// if (a % 2 == 0)
// {
//     Console.Write($"a = {a} > да");
// }
// else 
// {
//     Console.Write($"a = {a} > нет");
// }
﻿//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.Write("Введите число, а ");
int a = int.Parse(Console.ReadLine());

for (int i =2; i <= a; i = i + 2)
{
    Console.Write($"{i}, ");
}