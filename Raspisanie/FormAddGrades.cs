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
	public partial class FormAddGrades : Form
	{
		public static string[] schoolClasses;

		public FormAddGrades()
		{
			InitializeComponent();
			if (schoolClasses != null)
				classesCheckedList.Items.AddRange(schoolClasses);
			classesCheckedList.DoubleClick += DoubleClicking;
		}

		public void CheckedListOfClasses_AddItem(string item)
		{
			if (item != "" && !classesCheckedList.Items.Contains(item))
				classesCheckedList.Items.Add(item);
		}

		private void NextClick(object sender, EventArgs e)
		{
			schoolClasses = Program.ListBoxToStrings(classesCheckedList).ToArray();
			Program.ShowOnMessageBox(schoolClasses);
			FormAddTeacher formAddTeacher = new FormAddTeacher();
			formAddTeacher.Show();
			Hide();
		}

		private void AddDefaultGradesClick(object sender, EventArgs e)
		{
			var schoolClasses = SchedlueMaker.LoadClasses("Classes.txt").Select(a => a.Name);

			foreach (var schoolClass in schoolClasses)
				CheckedListOfClasses_AddItem(schoolClass);
		}

		private void DeleteDefaultGradesClick(object sender, EventArgs e)
		{
			var schoolGrades = SchedlueMaker.LoadClasses("Classes.txt").Select(a => a.Name);

			foreach (var schoolClass in schoolGrades)
				if (schoolGrades.Contains(schoolClass))
					classesCheckedList.Items.Remove(schoolClass);
		}

		private void AddNewClassClick(object sender, EventArgs e)
		{
			CheckedListOfClasses_AddItem(addClassTextBox.Text);
			addClassTextBox.Clear();
		}


		private void DeleteCheckedClassesClick(object sender, EventArgs e)
		{
			var checkedItems = classesCheckedList.CheckedItems;

			for (var i = classesCheckedList.CheckedItems.Count - 1; i >= 0; i--)
				classesCheckedList.Items.Remove(classesCheckedList.CheckedItems[i]);
		}

		private void PreviousFormClick(object sender, EventArgs e)
		{
			FormAddSubjects formAddSubjects = new FormAddSubjects();
			Hide();
			formAddSubjects.Show();
		}

		private void SortingByNumberClick(object sender, EventArgs e)
		{
			var schoolClasses = Program.ListBoxToStrings(classesCheckedList).ToArray();

			Array.Sort(schoolClasses, new SortingStringByNumber());

			classesCheckedList.Items.Clear();

			foreach (var schoolClass in schoolClasses)
				CheckedListOfClasses_AddItem(schoolClass);
		}

		private void DoubleClicking(object sender, EventArgs e)
		{
			SchedlueMaker.Grades.Clear();
			foreach (var grade in Program.ListBoxToStrings(classesCheckedList))
				SchedlueMaker.Grades.Add(new Grade(grade));

			var nameOfClass = (sender as CheckedListBox).SelectedItem;

			if (nameOfClass == null)
				return;

			FormHelpAdding formHelpAdding = new FormHelpAdding(nameOfClass.ToString(), FormAddSubjects.checkedSubjects);
			formHelpAdding.Show();
		}

		private void FormAddGrades_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		#region
		private void FormAddGrades_Load(object sender, EventArgs e)
		{

		}

		private void TextAddClass(object sender, EventArgs e)
		{

		}

		private void TextFieldClick(object sender, EventArgs e)
		{

		}
		#endregion
	}
}
