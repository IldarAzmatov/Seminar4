// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5


// int sumury()
// {
// Console.WriteLine("Введите число ");
// string number = Console.ReadLine();
// int count = 0;
// char[] array = new char[number.Length];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = number[i];
//     count++;
// }
// return count;
// }
// int sum = sumury();
// Console.WriteLine(sum);


// альтернативный способ решения через подсчет 


Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int count =0;
while(num>0)
{
    num = num/10;
    count++;
}
Console.WriteLine(count);