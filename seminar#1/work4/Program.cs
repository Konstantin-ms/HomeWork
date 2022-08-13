// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


Console.WriteLine("Введите число N для поиска всех четных чисел от 1 до N");

string inputstring = Console.ReadLine()!;
int numberN = int.Parse(inputstring);
int numberI = 0;
Console.WriteLine("Ответ:");
while(numberI+1 < numberN)
{
    numberI += 2;
    Console.Write(numberI);
}



