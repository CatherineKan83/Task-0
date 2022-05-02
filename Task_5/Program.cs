//Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

Console.WriteLine("Введите целое число -> ");
int N = int.Parse(Console.ReadLine());
int Y = -N;
while(Y <= N);
{
    Console.Write(Y+",");
    Y++;
}
