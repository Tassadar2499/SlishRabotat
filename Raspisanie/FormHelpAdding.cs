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

		private void checkedListBoxOfSubjectsSelect(object sender, EventArgs e)
		{
			listOfSubjects.DoubleClick -= SubjectSelecting;
			listOfSubjects.DoubleClick += SubjectSelecting;
		}

		private static void SubjectSelecting(object sender, EventArgs e)
		{
			CheckedListBox kek = (CheckedListBox) sender;
			var nameOfSubject = kek.SelectedItem;
			FormCountAndDifficulty formCountAndDifficulty = new FormCountAndDifficulty(nameOfSubject.ToString());
			formCountAndDifficulty.Show();
		}

		private void DeleteClick(object sender, EventArgs e)
		{

			for (var i = listOfSubjects.CheckedItems.Count - 1; i >= 0; i--)
				listOfSubjects.Items.Remove(listOfSubjects.CheckedItems[i]);
		}

		private void FormHelpAdding_FormClosing(object sender, FormClosingEventArgs e)
		{
			var index = 0;
			for (int i = 0; i < Program.grades.Length; i++)
			{
				if (Program.grades[i].Name == nameOfClass)
				{
					index = i;
					break;
				}
			}
			foreach (var subj in subjOfCurrentClass)
			{
				Program.grades[index].AddSubject(subj, new Teacher("Козя"));
			}
		}

		#region
		private void LabelClassNameClick(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void TextClick(object sender, EventArgs e)
		{

		}
		#endregion
	}
}
