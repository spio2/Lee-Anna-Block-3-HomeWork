﻿// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.(без массива)
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

/*
Console.Clear();

void PositiveNumbers()
{
    Console.Write("Введите количество чисел: ");

    int size = Convert.ToInt32(Console.ReadLine());
    int count = 0;
    
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите число номер {i + 1} - ");
        int num = Convert.ToInt32(Console.ReadLine());
            
        if (num > 0)
            count++;
    }
    Console.WriteLine($"Количество чисел > 0 = {count}.");
    Console.WriteLine();
}

PositiveNumbers();
*/




// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

/*
Console.Clear();

void CrossPoint(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;

        if(k1==k2) 
            Console.Write("Заданные прямые не пересекаются.");
    
        else
            Console.WriteLine($"Точка пересечения заданных прямых: ({x}; {y})");
            Console.WriteLine();
}

Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();

CrossPoint(b1, k1, b2, k2);
Console.WriteLine();
*/