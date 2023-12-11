﻿/*
Задача 23
Напишите программу, которая принимает на входе число (N) и выдает таблицу кубов
чисел от 1 до N
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.Write("Введите число N: "); // Введите число N
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"таблица кубов чисел от 1 до {N}:  ");
for (int i = 1; i <= N; i++)
{
   Console.Write(Math.Pow(i, 3) + "\t"); // i*i*i
}
