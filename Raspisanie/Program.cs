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
        public static List<Grade> grades;
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
            grades = new List<Grade>();
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new FormGradesAndTeachers());
            var testing = grades;
            //SchedlueMaker.CalculateSchedlue();
            //File.Delete("out.txt");
            //SchedlueMaker.SaveSchedlue("out.txt");
		}
	}
}
