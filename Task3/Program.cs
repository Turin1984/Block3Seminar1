//  Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Clear ();

Console.Write("Введите первое число : ");
string numberString1 = Console.ReadLine();
int numberA = int.Parse(numberString1);

if (numberA % 2 == 0)
Console.Write($"Число {numberA} является четным");
else
Console.Write($"Число {numberA} является нечетным");
