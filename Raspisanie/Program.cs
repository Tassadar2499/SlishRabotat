using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Raspisanie
{
	static class Program
	{
		/// <summary>
		/// Главная точка входа для приложения.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new formOfClasses());
		}
		public static string[] returnArrayOfClasses()
		{
			var text = File.ReadAllText("Classes.txt").Split(new char[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
			return text;
		}
	}
	public class Grades{
		private static string[] names;

		public Grades(string[] arrOfClasses) {
			names = arrOfClasses;
		}

		public string[] getNames() {return names;}
	}
}
