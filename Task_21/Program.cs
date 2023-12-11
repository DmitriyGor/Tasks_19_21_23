﻿/*
Задача 21
Напишите программу, которая на входе принимает координаты двух точек и
находит расстояние между ними в 3D пространстве.
A(3,6,8) B(2,1,-7) -> 15,84
A(7,-5,0) B(1,-1,9) -> 11,53
AB = √(x2 - x1)^2 + (y2 - y1)^2 +(z2 - z1)^2
6 координаты A(x1,y1,z1) B(x2,y2,z2)
*/
Console.Write("Введите координату x1:  ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y1:  ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z1:  ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату x2:  ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y2:  ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z2:  ");
int z2 = Convert.ToInt32(Console.ReadLine());
// Math.Sqrt (число) = > Math.Sqrt (25) = 5
// (x2 - x1) * (x2 - x1) => Math.Pow(число, степень) => Math.Pow(x2-x1, 2)
double d = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2-z1, 2));
// Math.Round(число, количество знаков)
Console.WriteLine($"Расстояние между точками А({x1},{y1},{z1}) и В({x2},{y2},{z2}) равно {Math.Round(d,2)}"); 
// Интерполяция
// $"Текст {переменная} что-то еще {переменная}"

