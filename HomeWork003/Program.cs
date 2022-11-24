// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите цифру, обозначающую день недели: ");
int nDay = Convert.ToInt32(Console.ReadLine());
void day (int nDay){
    if (nDay>7 || nDay<1){
        Console.WriteLine("Это не цифра дня недели.");
    }
    else if (nDay==6 || nDay==7){
        Console.WriteLine("Да.");
    }
    else
    Console.WriteLine("Нет.");
}
day(nDay);
