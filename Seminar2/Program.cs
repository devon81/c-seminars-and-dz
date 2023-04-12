// int t = 6;

// //Канкатинация
// Console.WriteLine("Наше число " + t);

// //Интерполяция
// Console.WriteLine($"Наше число: {t}" );

// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

// int num = new Random().Next(10,100);
// Console.WriteLine(num);

// int a = num / 10;
// int b = num % 10;

// if (a > b)
// {
//     Console.WriteLine(a);
// }
// else if(a < b)
// {
//     Console.WriteLine(b);
// }
// else
// {
//    Console.WriteLine ("Числа равны");
// }

// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

// int num = new Random().Next(100, 1000);
// Console.WriteLine(num);

// int a = num / 100;
// int b = num % 10;
// int c = (num % 100) / 10;

// Console.WriteLine("Итоговое число " + a + b);
// Console.WriteLine($"Итоговое число {a}{b}");
// Console.WriteLine($"Итоговое число {c}");

// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

// Console.WriteLine ("Введите число 1");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Введите число 2");
// int number2 = Convert.ToInt32(Console.ReadLine());

// int result = number1 % number2;

// if( result == 0)
// {
//     Console.WriteLine ("Число 2 кратно числу 1");
// }
// else
// {
//     Console.WriteLine ("Число 2 не кратно числу 1 отстаток " + result);
// }

// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
// 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да

// int num = new Random().Next(100, 1000);
// Console.WriteLine(num);

// //&& и
// if((num%7==0)&&(num&23==0))
// {
//     Console.WriteLine("да");
// }
// else
// {
//     Console.WriteLine("нет");
// }
// if ((num%7=0) || (num&23=0)) || или

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num % 7 == 0 && num % 23 == 0)
// {
//     Console.WriteLine("ДА");    
// }
// else
// {
// Console.WriteLine("НЕТ");
// }

// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

Console.WriteLine("Введите 1 число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num2 == num1*num1)
{
    Console.WriteLine("Число 2 является квадратом числа 1");
}
else if(num1 == num2*num2)
{
    Console.WriteLine("Число 1 является квадратом числа 2");
}
else
{
    Console.WriteLine("Числа не совместимы");
}

// double i = Math.Pow(a,2); фун-ия позволяющая возводить в степень Math (в этой ф-ии есть и другие пар-мы )