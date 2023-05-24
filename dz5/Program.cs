// // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// // Напишите программу, которая покажет количество чётных чисел в массиве.
// // [345, 897, 568, 234] -> 2

int GetChetArray()
{
int[] array = new int [10];
int sum = 0;

for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);

    Console.WriteLine(array[i]);
    if(array[i] % 2 == 0)
    {
         sum++;
    }
}
    return sum;
}
Console.WriteLine("");
Console.WriteLine("Количество четных чисел в массиве:" + GetChetArray());



// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int GetSummNechet()
{
int[] array = new int [10];
int sum = 0;

for(int i=0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 5);

    Console.WriteLine(array[i]); 
 }    
   for(int count = 1; count < array.Length; count+=2)
    { 
        sum = sum + array[count];
    }
    return sum;
}
Console.WriteLine("");
Console.WriteLine("Сумма элементов в нечетных позициях:" + GetSummNechet());

// // Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// // [3 7 22 2 78] -> 76

Console.WriteLine("Введите размер массива:");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
Console.WriteLine("");
Console.WriteLine("Размер массива = " + size);

for(int i=0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 100);
    Console.WriteLine(array[i]);
}
    int max = array[0];
    int min = array [0];

for(int j =0; j < array.Length; j++)
{
    if(array[j] > max)
    {
        max = array[j];
    }

    if(array[j] < min)
    {
        min = array[j];
    }    
}
    int diff = max - min; 
    Console.WriteLine("");
    Console.WriteLine("Максимальный элемент: " + max);
    Console.WriteLine("");
    Console.WriteLine("Минимальный элемент: " + min);
    Console.WriteLine("");
    Console.WriteLine("Разница элементов: " + diff);
