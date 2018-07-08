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
		public FormAddGrades()
		{
			InitializeComponent();
			checkedListOfClasses.CheckOnClick = true;
			checkedListOfClasses.MultiColumn = true;
		}

		public void CheckedListOfClasses_AddItem(string item) //Методы одинаковы
		{
			if (item != "" && !checkedListOfClasses.Items.Contains(item))
				checkedListOfClasses.Items.Add(item);
		}

		private void CheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)//Методы одинаковы
		{

		}

		private void NextClick(object sender, EventArgs e)
		{
			var schoolClasses = Program.ListBoxToStrings(checkedListOfClasses).ToArray();
			Program.ShowOnMessageBox(schoolClasses);
			FormAddSubjects formAddSubjects = new FormAddSubjects();
			formAddSubjects.Show();
			this.Hide();
		}

		private void AddDefaultGradesClick(object sender, EventArgs e) //Методы одинаковы
		{
			var schoolClasses = SchedlueMaker.LoadClasses("Classes.txt").Select(a => a.Name);

			foreach (var schoolClass in schoolClasses)
				CheckedListOfClasses_AddItem(schoolClass);
		}
		
		private void DeleteDefaultGradesClick(object sender, EventArgs e)//Методы одинаковы
		{
			var schoolClasses = SchedlueMaker.LoadClasses("Classes.txt").Select(a => a.Name);

			foreach (var schoolClass in schoolClasses)
				if (schoolClasses.Contains(schoolClass))
					checkedListOfClasses.Items.Remove(schoolClass);
		}

		private void TextAddClass(object sender, EventArgs e)
		{

		}

		private void AddNewClassClick(object sender, EventArgs e) //Методы одинаковы
		{
			CheckedListOfClasses_AddItem(addedClass.Text);
			addedClass.Clear();
		}


		private void DeleteCheckedClassesClick(object sender, EventArgs e) //Методы одинаковы
		{
			var checkedItems = checkedListOfClasses.CheckedItems;

			for (var i = checkedListOfClasses.CheckedItems.Count - 1; i >= 0; i--)
				checkedListOfClasses.Items.Remove(checkedListOfClasses.CheckedItems[i]);
		}

		private void SortingByNumberClick(object sender, EventArgs e)
		{
			var schoolClasses = Program.ListBoxToStrings(checkedListOfClasses).ToArray();

			Array.Sort(schoolClasses, new SortingStringByNumber());

			checkedListOfClasses.Items.Clear();

			foreach (var schoolClass in schoolClasses)
				CheckedListOfClasses_AddItem(schoolClass);
		}
	}
}
