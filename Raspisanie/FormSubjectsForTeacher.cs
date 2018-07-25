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
	public partial class FormSubjectsForTeacher : Form
	{
		public static string teacherName;
		public static string currentClass;

		public FormSubjectsForTeacher(string nameOfClass, string[] subjects, string teacher)
		{
			InitializeComponent();
			labelClass.Text += nameOfClass;
			checkedListBoxOfSubjects.Items.AddRange(subjects);
			teacherName = teacher;
			currentClass = nameOfClass;
		}

		private void CheckedListBoxOfSubjectsSelect(object sender, EventArgs e)
		{

		}

		private void LabelClassClick(object sender, EventArgs e)
		{

		}

		private void SaveClick(object sender, EventArgs e)
		{
			for (var i = checkedListBoxOfSubjects.Items.Count - 1; i >= 0; i--)
				if (!checkedListBoxOfSubjects.GetItemChecked(i))
					checkedListBoxOfSubjects.Items.RemoveAt(i);
		}

		private void FormSubjectsForTeacher_FormClosing(object sender, FormClosingEventArgs e)
		{
						
		}

		private void FormSubjectsForTeacher_Load(object sender, EventArgs e)
		{
			var grade = SchedlueMaker.Grades.Where(a => a.Name == currentClass).Single();

			var subjectsFromTeacher = Program.ListBoxToStrings(checkedListBoxOfSubjects).ToArray();
			var dictionary = grade.Subjects;

			foreach (var subjectFromGrade in grade.Subjects.Keys)
				foreach (var subjectFromList in subjectsFromTeacher)
					if (subjectFromGrade.Name == subjectFromList)
						dictionary[subjectFromGrade] = new Teacher(teacherName);
		}
	}
}
