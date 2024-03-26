using System.Drawing;
using Task3;
using Point = Task3.Point;

Point A = new Point(0, 0, "A");
Point B = new Point(5, 0, "B");
Point C = new Point(3, 4, "C");
Point D = new Point(0, 4, "D");

Figure square = new Figure(A, B, C, D);


square.PerimeterCalculator();
Console.WriteLine($"Периметр квадрата: {square.Perimeter}");