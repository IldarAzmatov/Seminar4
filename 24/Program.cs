// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int sumury()
{
    Console.WriteLine("Введите число ");
    int A = Convert.ToInt32(Console.ReadLine());
    int sum = 0;
    for (int B = 1; B <= A; B++)
    {
        sum = sum + B;
    }
    return sum;
}

int sum = sumury();
Console.WriteLine(sum);

