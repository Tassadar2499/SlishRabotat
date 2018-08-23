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
		public static IEnumerable<string> ListBoxToStrings(ListBox checkedList)
		{
			for (var i = 0; i < checkedList.Items.Count; i++)
				yield return checkedList.Items[i].ToString();
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
