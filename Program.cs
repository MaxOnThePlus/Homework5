// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// int[] CreateArray(int size)
// {
//   int[] myArray = new int [size];
//   for(int i = 0;i < size; i++)
//   {
//    myArray[i] = new Random().Next(100, 1000);
//   }
//   return myArray;
// }

// void ShowArray(int[] array)
// {
//   Console.WriteLine("Полученный массив:");
//   for(int i = 0; i < array.Length; i++)
//   {
//     Console.Write(array[i]+" ");
//   }
//   Console.WriteLine();
// }

// int Kratnie(int[] array)
// {
//     int count = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//        if(array[i]%2 == 0)
//        count++;
//     }
//     return count;
// }


// Console.WriteLine("Введите размер массива:");
// int Length = Convert.ToInt32(Console.ReadLine());
// int[] newArray = CreateArray(Length);
// ShowArray(newArray);
// Console.WriteLine($"Количество четных чисел в массиве равно {Kratnie(newArray)}");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19

// int[] CreateArray(int size)
// {
//   int[] myArray = new int [size];
//   for(int i = 0;i < size; i++)
//   {
//    myArray[i] = new Random().Next(-100, 100);
//   }
//   return myArray;
// }

// void ShowArray(int[] array)
// {
//   Console.WriteLine("Полученный массив:");
//   for(int i = 0; i < array.Length; i++)
//   {
//     Console.Write(array[i]+" ");
//   }
//   Console.WriteLine();
// }

// int Sum(int[] array)
// {
//     int sum = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//        if(i % 2 > 0)
//        sum = array[i]+sum;
//     }
//     return sum;
// }

// Console.WriteLine("Введите размер массива:");
// int Length = Convert.ToInt32(Console.ReadLine());
// int[] newArray = CreateArray(Length);
// ShowArray(newArray);
// Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях {Sum(newArray)}");

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// double[] CreateArray(int size)
// {
//   double[] myArray = new double [size];
//   for(int i = 0;i < size; i++)
//   {
//    myArray[i] = new Random().Next(0, 100);
//   }
//   return myArray;
// }

// void ShowArray(double[] array)
// {
//   Console.WriteLine("Полученный массив:");
//   for(int i = 0; i < array.Length; i++)
//   {
//     Console.Write(array[i]+" ");
//   }
//   Console.WriteLine();
// }

// double Sum(double[] array)
// {
//   double min = array[0];
//   double max = array[0];
//   double sum = 0;
//   for (int i = 0; i < array.Length; i++)
//    if (array[i] > max)
//     max = array[i];
//   for (int i = 0; i < array.Length; i++)
//   if (array[i] < min)
//     min = array[i];
//   sum = min + max; 
//   return sum;
// }

// Console.WriteLine("Введите размер массива:");
// int Length = Convert.ToInt32(Console.ReadLine());
// double[] newArray = CreateArray(Length);
// ShowArray(newArray);
// Console.WriteLine($"Cумма минимума и максимума массива {Sum(newArray)}");