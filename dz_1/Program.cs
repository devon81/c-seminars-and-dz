﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.WriteLine("Введите число 1 ");
// int number_1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число 2 ");
// int number_2 = Convert.ToInt32(Console.ReadLine());

// if(number_1 > number_2)
// {
//     Console.Write(number_1 + " больше чем " + number_2);
// }
// else
// {   
//     Console.Write(number_1 + " меньше чем " + number_2);
// }


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.WriteLine("Введите число 1 ");
// int number_1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число 2 ");
// int number_2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число 3 ");
// int number_3 = Convert.ToInt32(Console.ReadLine());

// int max = number_1;

// if(number_2 > max)
// {   
//     max = number_2;
// }
// if(number_3 > max)
// {
//     max = number_3;
// }
// Console.Write("число " + max + " является максимальным числом");


// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.WriteLine("Введите число ");
// int number = Convert.ToInt32(Console.ReadLine());
// if(number % 2 == 0)
// {
//     Console.WriteLine(number + " является четным числом ");
// }
// else
// {
//     Console.WriteLine(number + " является нечетным числом ");    
// }

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
int result = 0;

while(count < number-1)
{
        if(number % 2 == 0)
            {
                result = result + 2;
                Console.WriteLine(result);
            }
        else
             {
                Console.WriteLine("не является четным числом");
            }
    count = count + 1;
}
