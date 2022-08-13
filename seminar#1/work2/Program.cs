// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Поиск максимального числа среди 3-x значений");

Console.Write("Введите первое число:");
string inputstring1 = Console.ReadLine()!;
int numberA = int.Parse(inputstring1);

Console.Write("Введите второе число:");
string inputstring2 = Console.ReadLine()!;
int numberB = int.Parse(inputstring2);

Console.Write("Введите третье число:");
string inputstring3 = Console.ReadLine()!;
int numberC = int.Parse(inputstring3);

int MaxNumber = numberA;

if(MaxNumber < numberB)
{
    MaxNumber = numberB;
}
if(MaxNumber < numberC)
{
    MaxNumber = numberC;
}
Console.WriteLine("Ответ:");
Console.WriteLine(MaxNumber);


