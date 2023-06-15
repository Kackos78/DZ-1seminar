// Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    System.Console.WriteLine($"Число {number} четное");
}
else{
    System.Console.WriteLine($"Число {number} нечетное");
}