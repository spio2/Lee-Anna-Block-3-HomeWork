// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


/*
Console.Write("Введите пятизначное число: ");
string number = Console.ReadLine();

int len = number.Length;
{
    if (len == 5)
    {
        if (number[0] == number[4] && number[1] == number[3])
        {
            Console.Write($"{number} - палиндром");
        }
        else
        {
            Console.Write($"{number} - НЕ палиндром");
        }
    }
    else
    {
        Console.WriteLine("Некорректное число! Попробуйте снова.");
    }
}
*/



// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

/*
Console.Clear();

double FindDistance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double num = 0;
    num = (x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1);
    num = Math.Sqrt(num);
    num = Math.Round(num, 2);
    return num;
}

Console.WriteLine("Введите координату первой точки А (x1, y1, z1): ");
double x1 = Convert.ToDouble(Console.ReadLine());
double y1 = Convert.ToDouble(Console.ReadLine());
double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату второй точки В (x2, y2, z2): ");
double x2 = Convert.ToDouble(Console.ReadLine());
double y2 = Convert.ToDouble(Console.ReadLine());
double z2 = Convert.ToDouble(Console.ReadLine());


double findDistance = FindDistance(x1, y1, z1, x2, y2, z2);
Console.WriteLine();
Console.Write($"Расстояние между точкой А и В: {findDistance} единицы измерения.");
Console.WriteLine();
*/

// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

/*
Console.Clear();

void ShowCub(int num)
{
    int count = 1;
    while(count <= num)
    {
        double n = Math.Pow(count, 3);
        Console.Write(n + " ");
        count++;
    }
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
ShowCub(number);
*/

