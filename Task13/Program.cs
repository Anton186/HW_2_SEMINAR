// Задача 13: Напишите программу, которая выводит третью цифру
//  заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.WriteLine("Напишите трёхначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100 & number > -99)
{
    Console.WriteLine("Тут нету третьей цифры");
}
else
{if (number < -99)
    {
        number *= -1;
    }
    while (number > 999)
    {
        number /= 10;
    }
    number %= 10;
    Console.WriteLine($"Наше число: {number}");
}