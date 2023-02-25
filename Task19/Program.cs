// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
System.Console.WriteLine("Введите пятизначное число:");
string ? strNum = Console.ReadLine();
if (strNum[0] == strNum[4] && strNum[1] == strNum[3])
{
    System.Console.WriteLine("Это число палиндром");
} 
else
{
    System.Console.WriteLine("Не является палиндромом");
}

