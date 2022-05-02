//Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

Console.Write("Введите первое число -> ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число -> ");
int num2 = int.Parse(Console.ReadLine());
bool result = num2 * num2  == num1;
Console.WriteLine(result ? "Первое число является квадратом второго" : "Первое число не является квадратом второго");
Console.ReadKey();

