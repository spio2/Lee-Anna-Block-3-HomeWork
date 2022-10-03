// Задача2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.


Console.WriteLine("Введите два числа: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
 
if (a > b)
    Console.WriteLine("max = {0}", a);
else
    Console.WriteLine("max = {0}", b);



// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.


Console.WriteLine("Введите три числа: ");
int a, b, c;
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
c = Convert.ToInt32(Console.ReadLine());

if (a > b)
    
    if (a > c)
        Console.WriteLine("Максимальное число: " + a);
    else
        Console.WriteLine("Максимальное число: " + c);

else 
    
    if (b > c)
        Console.WriteLine("Максимальное число: " + b);
    else
        Console.WriteLine("Максимальное число: " + c);
*/



// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).


Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.Read());

if (num % 2 == 0)
    Console.WriteLine("Чётное");
else 
    Console.WriteLine("Нечётное");
*/



// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.


Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= num; i++)

    if (i % 2 == 0) 
        Console.Write(i + " ");