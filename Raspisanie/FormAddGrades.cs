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
			classesCheckedList.CheckOnClick = true;
			classesCheckedList.MultiColumn = true;
			if (schoolClasses != null)
			classesCheckedList.Items.AddRange(schoolClasses);
		}

		public void CheckedListOfClasses_AddItem(string item)
		{
			if (item != "" && !classesCheckedList.Items.Contains(item))
				classesCheckedList.Items.Add(item);
		}

		private void CheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void NextClick(object sender, EventArgs e)
		{
			schoolClasses = Program.ListBoxToStrings(classesCheckedList).ToArray();
			Program.ShowOnMessageBox(schoolClasses);
			FormAddSubjects formAddSubjects = new FormAddSubjects();
			formAddSubjects.Show();
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
			var schoolClasses = SchedlueMaker.LoadClasses("Classes.txt").Select(a => a.Name);

			foreach (var schoolClass in schoolClasses)
				if (schoolClasses.Contains(schoolClass))
					classesCheckedList.Items.Remove(schoolClass);
		}

		private void TextAddClass(object sender, EventArgs e)
		{

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

		private void SortingByNumberClick(object sender, EventArgs e)
		{
			var schoolClasses = Program.ListBoxToStrings(classesCheckedList).ToArray();

			Array.Sort(schoolClasses, new SortingStringByNumber());

			classesCheckedList.Items.Clear();

			foreach (var schoolClass in schoolClasses)
				CheckedListOfClasses_AddItem(schoolClass);
		}

		private void FormAddGrades_Load(object sender, EventArgs e)
		{

		}

	}
}
