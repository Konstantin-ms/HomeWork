// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6;

Console.WriteLine("Введите число:");
string inputstring = Console.ReadLine()!;
int numberA = int.Parse(inputstring);
Console.WriteLine("Ответ:");

//if(numberA/100 > 0)
//{
 //   Console.WriteLine(numberA % 10);
//}
//else
//{
   // Console.WriteLine("третьей цифры нет");
//}

if(numberA <= 999)
{
    Console.WriteLine("третьей цифры нет");
}

if(numberA >= 1000)
{
    int mid = numberA;
    while(mid > 999)
    {
        mid = mid / 10;
    }
    numberA = mid % 10;
Console.WriteLine(numberA);
}