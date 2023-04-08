// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

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

Console.WriteLine("Введите число 1 ");
int number_1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2 ");
int number_2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 3 ");
int number_3 = Convert.ToInt32(Console.ReadLine());

if(number_1 > number_2)
{   
    Console.Write("число " + number_1 + "является максимальным числом");
}
