//  Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Clear ();

Console.Write("Введите число : ");
int numberN = int.Parse(Console.ReadLine());
int numberI = 1;

Console.Write("Набор четных чисел: "); 

while (numberN>numberI)
{
    if (numberI % 2 ==0)
    {
              Console.Write(numberI + ","); 
    }
    numberI = numberI +1;
}


