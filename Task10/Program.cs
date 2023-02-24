// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8 
// 918 -> 1

System.Console.WriteLine("Введите трехзначное число ");
int num1 = Convert.ToInt32(Console.ReadLine());
int second  = num1 / 10 % 10;
System.Console.WriteLine("вторая цифра числа " +second);