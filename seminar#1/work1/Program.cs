// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// c = 2; d = 10 -> max = 10
// e = -9; f = -3 -> max = -3


int numberA = 5;
int numberB = 7;

Console.WriteLine("Поиск большего числа между 5 и 7");
Console.WriteLine("Ответ:");

if (numberA > numberB)
{
    Console.WriteLine(numberA);
}
else 
{
    Console.WriteLine(numberB);
}
int numberC = 2;
int numberD = 10;

Console.WriteLine("Поиск большего числа между 2 и 10");
Console.WriteLine("Ответ:");

if (numberC > numberD)
{
    Console.WriteLine(numberC);
}
else 
{
    Console.WriteLine(numberD);
}

int numberE = -9;
int numberF = -3;

Console.WriteLine("Поиск большего числа между -9 и -3");
Console.WriteLine("Ответ:");

if (numberE > numberF)
{
    Console.WriteLine(numberE);
}
else 
{
    Console.WriteLine(numberF);
}