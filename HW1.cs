// Задача 2. Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее:

/*Console.Write("Введите первое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int m = Convert.ToInt32(Console.ReadLine());
if (n > m)
{
    Console.WriteLine("Минимальное число: " + m);
    Console.WriteLine("Максимальное число: " + n);
}
else{
    Console.WriteLine("Минимальное число: " + n);
    Console.WriteLine("Максимальное число: " + m);
}*/

// Задача 4. Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел:

/*Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());
if(a > b && a>c)
    Console.WriteLine("Максимальное число: " + a);
if(b > a && b>c)
    Console.WriteLine("Максимальное число: " + b);
else
    Console.WriteLine("Максимальное число: " + c);*/

// Задача 6. Напишите программу, которая на вход принимает число и выдает, является ли число четным:

/*Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if(a % 2 ==0)
    Console.WriteLine("Да");
else
    Console.WriteLine("Нет");*/

// Задача 8. Напишите программу, которая на вход принимает число N, а на выходе показывает все четные числа от 1 до N:

// 1. вариант с циклом while

/*Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

int i =2;
while(i<=a)
{
    Console.Write(i + " ");
    i = i + 2;
}*/

// 2. вариант с циклом for

/*Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

for(int i = 1; i <= a; i++)
    if(i % 2 == 0)
        Console.Write(i + " ");*/

