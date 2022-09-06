// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на 
// выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Напишите трёхзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if ((number > 99 & number < 1000) ^ (number < -100 & number > -1000))
{
    if (number < -100 & number > -1000)
    {
        number *= -1;
    }
    number /= 10;
    number %= 10;
    Console.WriteLine($"Ваше второе число {number}");
}
else
{
    Console.WriteLine("Число не трёхзначное");
}