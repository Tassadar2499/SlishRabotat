using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Raspisanie
{
	public partial class FormFillingTheClasses : Form
	{
		public FormFillingTheClasses(string[] schoolClasses)
		{
			InitializeComponent();
			foreach (var grade in schoolClasses)
			{
				TabPage newClass = new TabPage();
				newClass.Text = grade;
				tabControlClasses.TabPages.Add(newClass);
			}
			tabControlClasses.Multiline = true;
		}

		private void TabControlClasses_SelectedIndexChanged(object sender, EventArgs e)
		{
			tabControlClasses.Selected -= TabSelected;
			tabControlClasses.Selected += TabSelected;
		}

		private static void TabSelected(object sender, TabControlEventArgs e)
		{
			FormHelpAdding formHelpAdding = new FormHelpAdding(e.TabPage.Text, FormAddSubjects.checkedSubjects);
			formHelpAdding.Show();
			var index = 0;
			for (int i = 0; i < Program.grades.Length; i++)
			{
				if (Program.grades[i].Name == e.TabPage.Text)
				{
					index = i;
					break;
				}
			}
			foreach (var subj in FormHelpAdding.subjOfCurrentClass)
			{
				Program.grades[index].AddSubject(subj,new Teacher("gg"));
			}
		}

		private void FormFillingTheClasses_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}
	}
}
