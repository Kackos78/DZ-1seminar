﻿

// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, 
//а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

System.Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if(numberA > numberB)
{
    System.Console.WriteLine($"Число {numberA} больше числа {numberB}.");
    
}
if(numberA < numberB)
{
    System.Console.WriteLine($"Число {numberB} больше числа {numberA}.");
    
}
if(numberA == numberB)
{
    System.Console.WriteLine("Числа равны друг другу.");
}
