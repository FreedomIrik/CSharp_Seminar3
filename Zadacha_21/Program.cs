/*Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 2D пространстве.*/

System.Console.WriteLine("Введите координаты точки А по оси x: ");
int Ax = Convert.ToInt32(System.Console.ReadLine());

System.Console.WriteLine("Введите координаты точки А по оси y: ");
int Ay = Convert.ToInt32(System.Console.ReadLine());

System.Console.WriteLine("Введите координаты точки B по оси x: ");
int Bx = Convert.ToInt32(System.Console.ReadLine());

System.Console.WriteLine("Введите координаты точки B по оси y: ");
int By = Convert.ToInt32(System.Console.ReadLine());

double distanceAB = Math.Sqrt((Bx-Ax)*(Bx-Ax)+(By-Ay)*(By-Ay));

System.Console.WriteLine("Длина отрезка АВ: " + distanceAB);
