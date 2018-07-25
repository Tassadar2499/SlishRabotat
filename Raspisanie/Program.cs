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
		public static SchoolClass[] grades; //не удаляй плез, мне чисто потестить
		public static Teacher[] teachers;

		public static void ShowOnMessageBox(string[] checkedObj)
		{
			if (checkedObj == null)
				MessageBox.Show("Нажми на кнопку сохранить");

			else if (checkedObj.Length == 0)
				MessageBox.Show("Выбери хотя бы 1 предмет");

			else
				MessageBox.Show(string.Join(" ", checkedObj));				
		}

		public static IEnumerable<string> ListBoxToStrings(CheckedListBox checkedList)
		{
			var arrOfChecked = checkedList.Items;

			for (var i = 0; i < arrOfChecked.Count; i++)
				yield return arrOfChecked[i].ToString();
		}

		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			FormAddSubjects formAddSubjects = new FormAddSubjects();
			Application.Run(formAddSubjects);

			var testing = grades;
			File.Delete("Input.txt");
			var strInput = "";

			if (testing != null)
			{
				foreach (var grade in testing)
				{
					strInput += grade.Name;
					foreach (var dict in grade.Subjects)
					{
						strInput += "\r\nПредмет - ";
						strInput += dict.Key.Name;
						strInput += "; Сложность - ";
						strInput += dict.Key.Difficult.ToString();
						strInput += "; Количество часов в неделю - ";
						strInput += dict.Key.CountAtWeek.ToString();
						strInput += "\r\nУчитель ";
						strInput += dict.Value.Name;
						strInput += "\r\n";
					}
				}
			}
			File.AppendAllText("Input.txt", strInput);
		}
	}
}
