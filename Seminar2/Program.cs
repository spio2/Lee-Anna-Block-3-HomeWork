// Задача 10. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

/*
Console.Write("Введите трехзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());

if(n >= 100 && n < 1000)
{
    Console.WriteLine("Last digit of " + n + " is " + n / 10 % 10);  
}
else
{
    Console.WriteLine("Немного ошиблись!");
}
*/



// Задача 13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

/*
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

string str = num.ToString();

if(num > 99)
{
    Console.WriteLine();
    Console.WriteLine("Третья цифра числа " + num + " - " + str[2]);
    Console.WriteLine();
}
else
{
    Console.WriteLine();
    Console.WriteLine("Тю! А здесь нет третьей цифры!");
    Console.WriteLine();
}
*/ 



// Задача 15. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

/*
Console.Write("Введите номер дня недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

string[] Days = { "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье" };
string result = "";

if (dayNumber > 5) 
{
    result = $". Ю-хууу! Выходной день!";
}
else 
{
    result = $", рабочий день.";
}
Console.WriteLine();
Console.WriteLine($"{dayNumber}-й день недели - это {Days[dayNumber - 1]}{result}");
Console.WriteLine();
*/