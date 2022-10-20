// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.



Console.Clear();
                                // Метод для создания массива из случайных чисел
int[] AskRandomArray(int size, int start, int end)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(start, end + 1);

    return array;
}
                                // Метод для вывода массива на экрана
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}
                                // Проверка количества чётных чисел
int CountOfEven(int[] myArray)
{
    int Count = 0;

    for (int i = 0; i < myArray.Length; i++)
        if (myArray[i] % 2 == 0)
            Count = Count + 1;

    return Count;
}
                                // ВЫЗОВ РАНЕЕ ОБЪЯВЛЕННЫХ МЕТОДОВ
Console.Write("Задайте размер массива: ");
int num = Convert.ToInt32(Console.ReadLine());

int[] myArray = new int[num];
Console.WriteLine();
myArray = AskRandomArray(num, 100, 999);
ShowArray(myArray);
Console.WriteLine();

Console.WriteLine($"Массив состоит из {myArray.Length} чисел, из них чётных - {CountOfEven(myArray)}.");
Console.WriteLine();




// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

/*
Console.Clear();
                                 // Метод для создания рандомного массива
int[] AskRandomArray(int size, int minVal, int maxVal)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(minVal, maxVal + 1);

    return array;
}

                                // Метод для вывода элементов на экрана
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}
                               // Сумма нечетных элементов
int SumOddNum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
        if (i % 2 != 0)
        sum += array[i];
    return sum;
}

Console.Write("Задайте размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное число массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = AskRandomArray(size, min, max);
ShowArray(myArray);
Console.WriteLine();

Console.WriteLine($"Сумма элементов нечетных позиций = {SumOddNum(myArray)}");
Console.WriteLine();
*/



// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

/*
Console.Clear();
                                 // Метод для создания рандомного массива
int[] AskRandomArray(int size, int minVal, int maxVal)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(minVal, maxVal + 1);

    return array;
}
                                // Метод для вывода элементов на экрана
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}
                               // Сумма нечетных элементов
int DifferMinMax(int[] array)
{
    int min = array[0];
    int max = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i])
            min = array[i];

        if (max < array[i])
            max = array[i];
    }
    return max - min;
}

Console.Write("Задайте размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное число массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = AskRandomArray(size, min, max);
ShowArray(myArray);
Console.WriteLine();

Console.WriteLine($"Разница между максимальным и минимальным элементом массива равна - {DifferMinMax(myArray)}.");
Console.WriteLine();
*/