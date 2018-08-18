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
			Application.Run(new FormGradesAndTeachers());
		}
	}
}
