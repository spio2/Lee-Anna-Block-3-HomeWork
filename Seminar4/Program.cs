// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 1ый вариант:
/*
Console.Clear();
Console.Write("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());

double n = Math.Pow(a, b);

Console.WriteLine();
Console.WriteLine(n);
*/

// 2ой вариант:
/*
Console.Clear();

double ToDegree(double num, double degree) 
{
    double derivative = num;
    for (int i = 0; i < degree - 1; i++)
    {
        derivative = derivative * num;
    }
    return derivative;
}

Console.Write("Введите число А: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число В: ");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();
Console.WriteLine($"Число {a} в степени {b} равно: {ToDegree(a, b)}");
*/



// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

/*
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int sum = 0;

while (num > 0)
{
    int i = num % 10;
    num = num / 10;
    sum = sum + i;
}

Console.WriteLine();
Console.WriteLine("Сумма цифр в числе равна: " + sum);
*/




// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран, пользователь сам задает элементы массива.
// m = 5 -> [1, 2, 5, 7, 19]
// m = 3 -> [6, 1, 33]


/*
int[] CreateArray(int size)
{
    int[] array = new int[size];
    
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("");
    return array;
}

void ShowArray(int[] array) 
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
ShowArray(CreateArray(size));
*/