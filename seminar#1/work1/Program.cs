// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// c = 2; d = 10 -> max = 10
// e = -9; f = -3 -> max = -3


Console.WriteLine("Поиск большего числа между двумя числами");

Console.Write("Введите первое число:");
string inputstring1 = Console.ReadLine()!;
int numberA = int.Parse(inputstring1);

Console.Write("Введите второе число:");
string inputstring2 = Console.ReadLine()!;
int numberB = int.Parse(inputstring2);


Console.WriteLine("Ответ:");

if (numberA > numberB)
{
    Console.WriteLine(numberA);
}
else 
{
    Console.WriteLine(numberB);
}
