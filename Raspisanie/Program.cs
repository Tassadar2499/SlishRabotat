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
		///123
		/// <summary>
		/// Главная точка входа для приложения.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new formAddGrades());
		}
		public static string[] returnArrayOfClasses()
		{
			var text = File.ReadAllText("Classes.txt").Split(new char[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
			return text;
		}
		public static Dictionary<string, int> returnDictionaryOfSubjects()
		{
			var text = File.ReadAllText("Subjects.txt").Split(new char[] { '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
			var dictionary = new Dictionary<string, int>();
			for (int i = 0; i < text.Length; i++)
			{
				var str = text[i];
				var index = str.LastIndexOf('-');
				var subject = str.Substring(0, index);
				var difficult = str.Substring(index + 1);
				dictionary.Add(subject, Int32.Parse(difficult));
			}
			return dictionary;
		}
		public static void show(string[] checkedObj)
		{
			string output = "";
			if (checkedObj != null)
			{
				foreach (var element in checkedObj)
				{
					output += element;
					output += " ";
				}
				MessageBox.Show(output);
			}
			else
				MessageBox.Show("Нажми на кнопку сохранить");
		}
		public static string[] save(CheckedListBox checkedList)
		{
			var arrOfChecked = checkedList.CheckedItems;
			var checkedObj = new string[arrOfChecked.Count];
			var iterator = 0;
			foreach (var element in arrOfChecked)
			{
				checkedObj[iterator] = element.ToString();
				iterator++;
			}
			return checkedObj;
		}
	}
}
