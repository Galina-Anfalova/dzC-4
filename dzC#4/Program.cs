//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//3, 5 -> 243 (3⁵)
//2, 4 -> 16

/*Console.WriteLine("Введите основание: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите показатель: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int Power(int num1, int num2)
{
  int count = 1;
  for(int i = 0; i < num2; i++)
  {
    count *= num1;
  }
  return count;
}

if (num2 > 0)
{
  Console.WriteLine($"Основание {num1}, показатель {num2}, равно - {Power(num1, num2)}");
}*/

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//452 -> 11
//82 -> 10
//9012 -> 12

/*Console.WriteLine("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

int Power(int num1)
{
  int count = 0;
  while (num1 > 0)
  {
    count += num1 % 10;
    num1 = num1 / 10;
  }
  return count;
}

Console.WriteLine($"Число {num1} - сумма его чисел = {Power(num1)}");*/


// Задача 29.  Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

/*void FillArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 100);
}

void PrintArray(int[] array)
{
  foreach (var el in array)
    Console.Write($"{el} ");
  Console.WriteLine();
}
int[] array = new int [8];
FillArray(array);
PrintArray(array);*/

