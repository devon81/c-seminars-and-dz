// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите любое число:");
int number = Convert.ToInt32(Console.ReadLine());

while(number > 999)
    {
        number = number / 10;
    }
   if (number > 100)
   {
    number = (number % 100) / 10;
    Console.WriteLine(number);
    }
else
{
   Console.WriteLine("число меньше сотни"); 
}

    // Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
    //что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int number1 = new Random().Next(0, 10000);
Console.WriteLine(number1);

    while(number1 > 999)
    {
        number1 = number1 / 10;
    }
   if (number1 > 100)
   {
    number1 = number1 % 10;
    Console.WriteLine(number1);
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
