using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
	 class Author
	{

		private string author;

		public Author(string author)
		{
			this.author = author;
		}

		public void Show()
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine($"Автор: {author}");
			Console.ResetColor();
		}
	}
}
