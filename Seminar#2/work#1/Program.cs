// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите любое трехзначное число");
string inputstring = Console.ReadLine()!;
int number = int.Parse(inputstring);
Console.WriteLine("Ответ:");

int secondnumber = number / 10;

Console.WriteLine(secondnumber % 10);

