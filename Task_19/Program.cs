/*
Задача 19
Напишите программу, которая принимает на входе пятизначное число и проверяет, 
является ли оно палиндромом
Например:
14212 -> нет
23432 -> да
12821 -> да
*/
Console.Write ("Enter a five-digit number:  "); // Введите пятизначное число
int Number = Convert.ToInt32(Console.ReadLine());
if (Number > 9999 && Number <= 99999) // Число от 10000 до 99999
{
    int a = Number / 10000; // 45678 -> 4
    int b = Number % 10;    // 45678 -> 8
    int c = Number / 1000 % 10; // 45678 -> 5
    int d = Number % 100 /10;    // 45678 -> 7
    if (a == b && c == d)
    {
        Console.WriteLine($"the number {Number} is a PALINDROME"); 
    }
    else
    {
        Console.WriteLine($"the number {Number} is NOT a palindrome");
    }
        
}
else
{
    Console.WriteLine($"Error! the number {Number} is NOT FIVE DIGITS");
}