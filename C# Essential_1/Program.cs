
using C__Essential_1;

Console.WriteLine("Сторна 1") ;
double side1 = double.Parse(Console.ReadLine());
Console.WriteLine("Сторна 2");
double side2 = double.Parse(Console.ReadLine());

Rectangle myRectangle = new Rectangle(side1, side2);
Console.WriteLine(myRectangle.Area);
Console.WriteLine(myRectangle.Perimeter);