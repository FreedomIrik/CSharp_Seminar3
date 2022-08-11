/* Задача 22: Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу квадратов чисел от 1 до N.*/

System.Console.WriteLine("Введите число N: ");
int numberN = Convert.ToInt32(System.Console.ReadLine());

int index = 1;

while (index <= numberN)
{
  int sqr = index * index;
    System.Console.Write(" " + sqr);
    index++;
}