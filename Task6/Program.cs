
// Задача 6: Напишите программу, которая на вход принимает число и выдает,
//  является ли число четным (делится ли оно на два без остатка).
Console.WriteLine("Введите  число ");
int a = Convert.ToInt32(Console.ReadLine());
if( a % 2 == 0)
System.Console.WriteLine("четное");
if( a % 2 == 1)
System.Console.WriteLine("нечетное");