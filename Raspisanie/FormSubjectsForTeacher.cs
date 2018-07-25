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
			{
				if (!checkedListBoxOfSubjects.GetItemChecked(i))
				{
					checkedListBoxOfSubjects.Items.RemoveAt(i);
				}
			}
		}

		private void FormSubjectsForTeacher_FormClosing(object sender, FormClosingEventArgs e)
		{
						
		}

		private void FormSubjectsForTeacher_Load(object sender, EventArgs e)
		{
			SchoolClass grade = new SchoolClass("");
			var iterator = 0;
			for (int i = 0; i < Program.grades.Length; i++)
			{
				if (Program.grades[i].Name == currentClass)
				{
					grade = Program.grades[i];
					iterator = i;
					break;
				}
			}
			var subjArr = Program.ListBoxToStrings(checkedListBoxOfSubjects).ToArray();
			var dictionary = grade.Subjects;
			foreach (var key in dictionary.Keys.ToList())
			{
				foreach (var subj in subjArr)
				{
					if (key.Name == subj)
						dictionary[key] = new Teacher(teacherName);
				}
			}
			Program.grades[iterator].Subjects = dictionary;
		}
	}
}
