using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
	 class Content
	{
		private string content;

		public Content(string content)
		{
			this.content = content;
		}

		public void Show()
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine($"Зміст книги:\n{content}");
			Console.ResetColor();
		}

	}
}
