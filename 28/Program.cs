// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int sumury()
{
    Console.WriteLine("Введите число ");
    int A = Convert.ToInt32(Console.ReadLine());
    int sum = 1;
    for (int B = 1; B <= A; B++)
    {
        sum = sum * B;
    }
    return sum;
}

int sum = sumury();
Console.WriteLine(sum);