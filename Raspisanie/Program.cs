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
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new formAddGrades());
		}
		public static string[] GetArrayOfClasses()
		{
			return File.ReadAllText("Classes.txt").Split(new char[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
		}
		public static Dictionary<string, int> GetDictionaryOfSubjects()
		{
			var text = File.ReadAllText("Subjects.txt").Split(new char[] { '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
			var dictionary = new Dictionary<string, int>();

			for (var i = 0; i < text.Length; i++)
			{
				var str = text[i];
				var index = str.LastIndexOf('-');
				var subject = str.Substring(0, index);
				var difficult = str.Substring(index + 1);
				dictionary.Add(subject, Int32.Parse(difficult));
			}

			return dictionary;
		}
		public static void ShowOnMessageBox(string[] checkedObj)
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
		public static string[] SaveList(CheckedListBox checkedList)
		{
			var arrOfChecked = checkedList.CheckedItems;
			var checkedObj = new string[arrOfChecked.Count];

			for (var i = 0; i < arrOfChecked.Count; i++)
				checkedObj[i] = arrOfChecked[i].ToString();

			return checkedObj;
		}
	}
}
