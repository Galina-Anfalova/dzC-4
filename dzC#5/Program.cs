/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/

/*Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
FillArray(array);
Console.WriteLine("Вот наш массив: ");
PrintArray(array);
int count = 0;

for (int i = 0; i < array.Length; i++)
{
  if (array[i] % 2 == 0)
    count++;
}

Console.WriteLine($"всего чисел: {array.Length}, из них чётных {count}");

void FillArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(100, 999);
  }
}

void PrintArray(int[] array)
{
    Console.Write("[ ");
    for(int i = 0; i < array.Length; i++)
    {
      Console.Write(array[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}
*/

/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

/*Console.WriteLine("Введите размер массива:");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
FillArray(array);
Console.WriteLine("Вот наш массив:");
PrintArray(array);
int sum = 0;
int count = 0;

for (int i = 0; i < array.Length; i++)
{
  if(array[i] % 2 != 0)
  {  
    sum += array[i];
    count++;
  }
}
Console.WriteLine($"всего {array.Length} чисел, сумма элементов на нечётных позициях = {sum}");
Console.WriteLine($"");

void FillArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(1, 100);
  }
}

void PrintArray(int[] array)
{
    Console.Write("[ ");
    for(int i = 0; i < array.Length; i++)
    {
      Console.Write(array[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}*/

/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

/*Console.WriteLine("Введите размер массива:");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double[size];
FillArray(array);
Console.WriteLine("Вот наш массив:");
PrintArray(array);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int i = 0; i < array.Length; i++)
{
  if (array[i] > max)
  {
    max = array[i];
  }
  if (array[i] < min)
  {
    min = array[i];
  }
}
Console.WriteLine($"всего {array.Length} чисел, минимальный элемент = {min}, максимальный элемент = {max}");
Console.WriteLine($"Разница между максимальным и минимальным элементов массива = {max - min}");

void FillArray(double[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
  }
}

void PrintArray(double[] array)
{
  Console.Write("[ ");
  for(int i = 0; i < array.Length; i++)
  {
    Console.Write(array[i] + " ");
  }
  Console.Write("]");
  Console.WriteLine();
}*/

