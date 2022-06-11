//  Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Clear ();

Console.Write("Введите первое число : ");
string numberString1 = Console.ReadLine();
int numberA = int.Parse(numberString1);
Console.Write("Введите второе число : ");
string numberString2 = Console.ReadLine();
int numberB = int.Parse(numberString2);
Console.Write("Введите третье число : ");
string numberString3 = Console.ReadLine();
int numberC = int.Parse(numberString3);

int max = numberA;

if (numberA > max) max = numberA;
if (numberB > max) max = numberB;
if (numberC > max) max = numberC;

Console.Write($"Число {max} является большее среди введенных числ {numberA},{numberB},{numberC} ");
