Console.Write("Введите базовое Число: ");
int baseVal = int.Parse(Console.ReadLine()!);
Console.Write("Введите степень Число: ");
int exp = int.Parse(Console.ReadLine()!);
 int power(int baseValue, int exp) {
     if (exp == 0) {
         return 1;
     } else {
         return  baseValue * power(baseValue, exp -1);
     }
 }
 Console.Write("В степен: " + power(baseVal, exp));
