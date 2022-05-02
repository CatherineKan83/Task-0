//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.


Console.WriteLine("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());
if(num1 < num2)
{
    Console.Write(num2);
    Console.WriteLine("- максимальное число.");
    Console.Write(num1);
    Console.Write("- минимальное число.");
}
else
{
    Console.Write(num1);
    Console.WriteLine("- максимальное число.");
    Console.Write(num2);
    Console.Write("- минимальное число.");
}