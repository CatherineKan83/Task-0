//Напишите программу, которая на вход принимает три числа и выдаёт максимальное из трёх чисел.


Console.WriteLine("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int num3 = int.Parse(Console.ReadLine());
if(num1>num2)
{
    Console.Write(num1);
    Console.Write("- максимальное число.");
}
else if(num3>num2)
{
    Console.Write(num3);
    Console.Write("- максимальное число.");
}