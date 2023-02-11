// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

                                // метод создает 2мер-массив
/*
Console.Clear();

double[,] CreateRandom2dArray()
{
    Console.Write("Введите количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите минимальное значение элемента: ");
    int minVal = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальное значение элемента: ");
    int maxVal = Convert.ToInt32(Console.ReadLine());
    
    double[,] array = new double[rows, columns];
    
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = Math.Round(new Random().Next(minVal, maxVal + 1) + new Random().NextDouble(), 1);
    
    return array;
}
                                // метод показывает 2мер-массив
void Show2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
}

Show2dArray(CreateRandom2dArray());
*/




// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> числа с такими индексами в массиве нет

//Console.Clear();
// void FindElementOf2DArray(double[,] array)
// {
//  Console.WriteLine("Now, lets find your element");
//  Console.WriteLine("Input the number of row:");
//  int row = Convert.ToInt32(Console.ReadLine());
//  Console.WriteLine("Input the number of column:");
//  int column = Convert.ToInt32(Console.ReadLine());
//  if(row < array.GetLength(0) && column < array.GetLength(1))
//  Console.WriteLine($"Element number {row} in {column} raw is {array[row - 1, column - 1]}");

//  else Console.WriteLine($"There is no such cell in the array");
// }








// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3


double[] AverageArithmNum(int[,] array)
{
    double[] averageNum = new double[array.GetLength(1)];

    for (int j = 0; j < array.GetLength(1); j++)
    {
        double result = 0;
        for (int i = 0; i < array.GetLength(0); i++)
            result += array[i, j];
        averageNum[j] = result / array.GetLength(0);
    }
    return averageNum;
}

int[,] CreateRandom2dArray() 
{
    Console.Write("Введите количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите минимальное значение элемента: ");
    int minVal = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальное значение элемента: ");
    int maxVal = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns]; 

    for(int i = 0; i < rows; i++)              
        for(int j = 0; j < columns; j++)                      
            array[i,j] = new Random().Next(minVal, maxVal + 1);
    
    return array;
}

void Show2dArray(int[,] array)                          
{
    for(int i = 0; i < array.GetLength(0); i++)   
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");   
        Console.WriteLine();
}

void ShowArray(double[] array) 
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}


int[,] array = CreateRandom2dArray();

Show2dArray(array);
ShowArray(AverageArithmNum(array));
