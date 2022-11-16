﻿//                        Задача 66

//   Задайте значения M и N. 
//  Напишите программу, которая найдёт сумму натуральных элементов 
//  в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

void NaturalElem(int num1, int num2, int sum)
{
    if (num1 > num2)
    {
        Console.WriteLine(sum);
        return;
    }
    sum = sum + (num1++);
    NaturalElem(num1, num2, sum);
}
NaturalElem(num1, num2, 0);