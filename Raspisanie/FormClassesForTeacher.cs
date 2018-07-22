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
	public partial class FormClassesForTeacher : Form
	{
		public FormClassesForTeacher(string nameOfTeacher, string[] classes)
		{
			InitializeComponent();
			listOfClasses.Items.AddRange(classes);
			labelTeacher.Text += nameOfTeacher;
		}

		private void CheckedListOfSubjectsSelect(object sender, EventArgs e)
		{
			listOfClasses.DoubleClick -= DoubleClicking;
			listOfClasses.DoubleClick += DoubleClicking;
		}

		private static void DoubleClicking(object sender, EventArgs e)
		{
			CheckedListBox kek = (CheckedListBox)sender;
			var nameOfClass = kek.SelectedItem;
			FormSubjectsForTeacher formSubjectsForTeacher = new FormSubjectsForTeacher(nameOfClass.ToString());
		}

		private void LabelTeacherClick(object sender, EventArgs e)
		{

		}

		private void DeleteClick(object sender, EventArgs e)
		{
			for (var i = listOfClasses.Items.Count - 1; i >= 0; i--)
			{
				if (!listOfClasses.GetItemChecked(i))
				{
					listOfClasses.Items.RemoveAt(i);
				}
			}
		}
	}
}
