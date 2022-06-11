// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Clear ();

Console.Write("Введите первое число : ");
string numberString1 = Console.ReadLine();
int numberA = int.Parse(numberString1);
Console.Write("Введите второе число : ");
string numberString2 = Console.ReadLine();
int numberB = int.Parse(numberString2);

if (numberA == numberB)
{
    Console.WriteLine ($"Число {numberA} равно числу {numberB} .");
    
}
else if (numberA > numberB)
{
    Console.WriteLine ($"Число {numberA} является большее, а число {numberB} является меньшее.");
}
else 
{
    Console.WriteLine ($"Число {numberB} является большее, а число {numberA} является меньшее.");
}


