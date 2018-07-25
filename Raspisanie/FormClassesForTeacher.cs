using System;
using System.Collections;
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

		private void CheckedListOfClassesSelect(object sender, EventArgs e)
		{
			listOfClasses.DoubleClick -= DoubleClicking;
			listOfClasses.DoubleClick += DoubleClicking;
		}

		private static void DoubleClicking(object sender, EventArgs e)
		{
			CheckedListBox kek = (CheckedListBox)sender;
			var nameOfClass = kek.SelectedItem;
			var grades = Program.grades;
			var iterator = 0;
			foreach (var grade in grades)
			{
				if (grade.Name == nameOfClass.ToString())
					break;
				iterator++;
			}
			var subjects = grades[iterator].Subjects.Keys;
			string[] lol = new string[subjects.Count];
			int pop = 0;
			foreach (var elem in subjects)
			{
				lol[pop] = elem.Name;
				pop++;
			}
			FormSubjectsForTeacher formSubjectsForTeacher = new FormSubjectsForTeacher(nameOfClass.ToString(), lol, teacherName);
			formSubjectsForTeacher.Show();
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

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
}
