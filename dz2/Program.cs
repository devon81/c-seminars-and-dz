﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите 3-х значное число:");
int number = Convert.ToInt32(Console.ReadLine());

int a1 = (number % 100) / 10;

Console.WriteLine(a1);

    // Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
    //что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int number1 = new Random().Next(0, 1000);
Console.WriteLine(number1);

int a = number1 % 10;

if(number1 > 100)
{
     Console.WriteLine(a);
}
else
{
     Console.WriteLine("третьей цифры нет");
}




// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите любое число: ");
int number12 = Convert.ToInt32(Console.ReadLine());

if(number12 == 6 || number12 == 7)
{
    Console.WriteLine("Выходной день");
}
else if(number12 >= 1 && number12 <= 5)
{
    Console.WriteLine("Рабочий день");
}
else
{
    Console.WriteLine("Это не день недели");
}
