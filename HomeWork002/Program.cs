﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num>100){
    int n = (num % 10);
    Console.WriteLine("Третья цифра числа: " +n);
    if (num>1000){
        int s = ((num/100)% 10);
        Console.WriteLine("Третья цифра числа: " +s);
    }
    }
else
Console.WriteLine("Третьей цифры нет.");


