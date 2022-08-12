/* Задача 23 Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.*/

Console.WriteLine("Введите число N: ");

int numberN = Convert.ToInt32(Console.ReadLine());

for (int index = 1; index <= numberN; index++)
{
    double sqr = Math.Pow(index, 3);
    Console.Write(" " + sqr);
}
