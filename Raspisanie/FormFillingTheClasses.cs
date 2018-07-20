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
		public static string x;
		public FormFillingTheClasses()
		{
			InitializeComponent();
			var schoolClasses = FormAddGrades.schoolClasses;
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
			//tabControlClasses.Click += (sende, args) =>
			//{
			//	Program.ShowOnMessageBox(FormAddSubjects.checkedSubjects);
			//};
			tabControlClasses.Selected -= TabSelected;
			tabControlClasses.Selected += TabSelected;
			//tabPage1.BackColor = Color.Red;
		}

		private static void TabSelected(object sender, TabControlEventArgs e)
		{
			MessageBox.Show(e.TabPage.Text);
		}

		private void FormFillingTheClasses_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}
	}
}
