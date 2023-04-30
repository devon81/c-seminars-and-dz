// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// int Quality()
// {
// Console.WriteLine("Введите размер массива:");
// int size = Convert.ToInt32(Console.ReadLine());
// int [] array = new int [size];
// Console.WriteLine("Размер массива = " + size);
// int i = 0;
// int col = 0;

//     for(i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-100, 101);
//         Console.WriteLine(array[i]);

//         if(array[i]> 0)
//         {
//             int count = 0;
//             count++;
//             col = col + count;
//         }
//     }
//     return col;
// } 
//   Console.WriteLine("Чисел больше 0 = " + Quality());

    
// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("введите значение b1");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k1");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение b2");
int  b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k2");
int  k2 = Convert.ToInt32(Console.ReadLine());

int  x = (-b2 + b1)/(-k1 + k2);
int  y = k2 * x + b2;

Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");