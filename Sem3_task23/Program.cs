// Задача 23: Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27. 
//5 -> 1, 8, 27, 64, 125
Console.WriteLine("Введите число:");
int num1 = Convert.ToInt32(Console.ReadLine());
GetDashbord(num1);
void GetDashbord(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine($"квадрат числа{count} = {count*count*count}");
        count++;
    }
}