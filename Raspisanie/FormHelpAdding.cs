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
	public partial class FormHelpAdding : Form
	{
		public static List<Subject> subjOfCurrentClass;
		string nameOfClass;

		public FormHelpAdding(string className, string[] subjects)
		{
			InitializeComponent();
			listOfSubjects.Items.AddRange(subjects);
			labelClassName.Text += className;
			subjOfCurrentClass = new List<Subject>();
			nameOfClass = className;
		}

		private void CheckedListBoxOfSubjectsSelect(object sender, EventArgs e)
		{
			listOfSubjects.DoubleClick += SubjectSelecting;
		}

		private static void SubjectSelecting(object sender, EventArgs e)
		{
			var nameOfSubject = (sender as CheckedListBox).SelectedItem;

			FormCountAndDifficulty formCountAndDifficulty
				= new FormCountAndDifficulty(nameOfSubject.ToString());
			formCountAndDifficulty.Show();
		}

		private void DeleteClick(object sender, EventArgs e)
		{

			for (var i = listOfSubjects.CheckedItems.Count - 1; i >= 0; i--)
				listOfSubjects.Items.Remove(listOfSubjects.CheckedItems[i]);
		}

		private void FormHelpAdding_FormClosing(object sender, FormClosingEventArgs e)
		{
			var grade = SchedlueMaker.Grades.Where(a => a.Name == nameOfClass).Single();

			foreach (var subj in subjOfCurrentClass)
				grade.AddSubject(subj, new Teacher("")); //что это блять за параша?
		}

		#region
		private void LabelClassNameClick(object sender, EventArgs e)
		{

		}

		private void Label1_Click(object sender, EventArgs e)
		{

		}

		private void TextClick(object sender, EventArgs e)
		{

		}
		#endregion
	}
}
