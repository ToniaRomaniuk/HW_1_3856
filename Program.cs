﻿// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Ведите первое число: ");

int number1_1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ведите второе число: ");

int number1_2 = Convert.ToInt32(Console.ReadLine());

if (number1_1 == number1_2)
 {
     Console.WriteLine("Числа равны");
 }

 else
 {
    
     if (number1_1 > number1_2)
   
     {
         Console.Write("max= ");
         Console.WriteLine(number1_1);
     }

     else

     {
         Console.Write("max= ");
         Console.WriteLine(number1_2);
     }
 }

// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


 Console.WriteLine("Ведите первое число: ");

 int number2_1 = Convert.ToInt32(Console.ReadLine());

 Console.WriteLine("Ведите второе число: ");

 int number2_2 = Convert.ToInt32(Console.ReadLine());

 Console.WriteLine("Ведите третье число: ");

 int number2_3 = Convert.ToInt32(Console.ReadLine());

 int maxNumber = number2_1;

 if (maxNumber < number2_2)
 {
     maxNumber = number2_2;
 }

 if (maxNumber < number2_3)
 {
     maxNumber = number2_3;
 }

 Console.Write("max= ");
 Console.WriteLine(maxNumber);

// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

 Console.WriteLine("Ведите число: ");

int number3_1 = Convert.ToInt32(Console.ReadLine());

int result = number3_1 % 2;

if (result == 0)
 {
     Console.WriteLine("Число является четным!");
 }

 else
 {
     Console.WriteLine("Число является нечетным!");
 }

//  Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8   

Console.WriteLine("Ведите число: ");

int number4_1 = Convert.ToInt32(Console.ReadLine());

int i = 2;

int result1 = i % 2;

if (i > number4_1)
{
    Console.WriteLine("Введите другое число");
}

else
{
    while (i <= number4_1)
    {
        if (result1 == 0)
        {
            Console.Write(i);
            Console.Write(", ");
            i++;
        }
        i++;
    }
}