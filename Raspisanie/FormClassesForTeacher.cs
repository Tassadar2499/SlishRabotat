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
		public static string teacherName;
		public FormClassesForTeacher(string nameOfTeacher, string[] classes)
		{
			InitializeComponent();
			listOfClasses.Items.AddRange(classes);
			labelTeacher.Text += nameOfTeacher;
			teacherName = nameOfTeacher;

			listOfClasses.DoubleClick += DoubleClicking;
		}

		private void CheckedListOfClassesSelect(object sender, EventArgs e)
		{
			
		}

		private static void DoubleClicking(object sender, EventArgs e)
		{
			var nameOfClass = (sender as CheckedListBox).SelectedItem;

			var grade = SchedlueMaker.Grades.Where(a => a.Name == nameOfClass.ToString());
			var subjects = grade.Single().Subjects.Keys;
			var teacherSubjects = subjects.Select(a => a.Name).ToArray();

			FormSubjectsForTeacher formSubjectsForTeacher
				= new FormSubjectsForTeacher(nameOfClass.ToString(), teacherSubjects, teacherName);
			formSubjectsForTeacher.Show();
		}

		private void LabelTeacherClick(object sender, EventArgs e)
		{

		}

		private void DeleteClick(object sender, EventArgs e)
		{
			for (var i = listOfClasses.Items.Count - 1; i >= 0; i--)
				if (!listOfClasses.GetItemChecked(i))
					listOfClasses.Items.RemoveAt(i);
		}

		private void Label1_Click(object sender, EventArgs e)
		{

		}
	}
}
