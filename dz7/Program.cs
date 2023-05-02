// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


Console.WriteLine("Введите число");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число");
int columns = Convert.ToInt32(Console.ReadLine());

double [,] array = new double [rows, columns];

for(int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
       array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
       Console.Write(array[i,j]+ " ");
    }

    Console.WriteLine();
}



// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("введите номер строки");
int s = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите номер столбца");
int c = Convert.ToInt32(Console.ReadLine());
int [,] numbers = new int [5,5];

for (int i = 0; i < numbers.GetLength(0); i++)
        {        
            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                numbers [i,j] = new Random().Next(0, 100);
                Console.Write(numbers[i,j] + " ");
                
            }   
            Console.WriteLine(""); 
         }  

if (s > numbers.GetLength(0) || c > numbers.GetLength(1))
{
    Console.WriteLine("такого элемента нет");
}
else
{
    Console.WriteLine($"значение элемента {s} строки и {c} столбца равно {numbers[s-1,c-1]}");
}
    


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.WriteLine("введите количество строк");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int m = Convert.ToInt32(Console.ReadLine());
double avarage = 0;

int[,] numbers1 = new int[n, m];

for (int i = 0; i < numbers1.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers1[i, j] = new Random().Next(0, 10);
             Console.Write(numbers1[i, j] + " ");
        }
        Console.WriteLine("");
    }

for (int j = 0; j < numbers1.GetLength(1); j++)
{
    
    for (int i = 0; i < numbers1.GetLength(0); i++)
    {
        avarage = (avarage + numbers1[i, j]);
    }
    avarage = avarage / n;
    double average = Math.Round(avarage, 1);
    Console.Write(average + "; ");
}

















