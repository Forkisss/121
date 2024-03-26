using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
	class Figure
	{
		private Point[] points;
		private double perimeter;

		
		public Figure(Point A, Point B, Point C)
		{
			points = new Point[] { A, B, C };
		}

		public Figure(Point A, Point B, Point C, Point D)
		{
			points = new Point[] { A, B, C, D };
		}

		
		private double LengthSide(Point A, Point B)
		{
			return Math.Sqrt(Math.Pow((B.X - A.X), 2) + Math.Pow((B.Y - A.Y), 2));
		}

	
		public void PerimeterCalculator()
		{
			perimeter = 0;
			for (int i = 0; i < points.Length - 1; i++)
			{
				perimeter += LengthSide(points[i], points[i + 1]);
			}
			perimeter += LengthSide(points[points.Length - 1], points[0]);
		}

		
		public double Perimeter { get { return perimeter; } }




	}
}
