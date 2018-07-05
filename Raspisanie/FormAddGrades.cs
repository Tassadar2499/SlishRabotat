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
	{//
		public FormAddGrades()
		{
			InitializeComponent();
			checkedListOfClasses.CheckOnClick = true;
			checkedListOfClasses.MultiColumn = true;
		}

		public void CheckedListOfClasses_AddItem(string item)
		{
			if (!checkedListOfClasses.Items.Contains(item))
				checkedListOfClasses.Items.Add(item);
		}

		private void CheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void NextClick(object sender, EventArgs e) //совместил кнопку save с кнопкой next
		{
			var schoolClasses = Program.CheckedListBoxToStrings(checkedListOfClasses).ToArray();
			Program.ShowOnMessageBox(schoolClasses);
			FormAddSubjects form = new FormAddSubjects();
			form.Show();
		}

		private void AddDefaultGradesClick(object sender, EventArgs e) //добавляет классы из текстового файла
		{
			var schoolClasses = SchedlueMaker.LoadClasses("Classes.txt").Select(a => a.Name);

			foreach (var schoolClass in schoolClasses)
				CheckedListOfClasses_AddItem(schoolClass);
		}
		
		private void DeleteDefaultGradesClick(object sender, EventArgs e)//удаляет классы из текстового файла
		{
			var schoolClasses = SchedlueMaker.LoadClasses("Classes.txt").Select(a => a.Name);

			foreach (var schoolClass in schoolClasses)
				if (schoolClasses.Contains(schoolClass))
					checkedListOfClasses.Items.Remove(schoolClass);
		}

		private void TextAddClass(object sender, EventArgs e) //текстовое поле добавления
		{

		}

		private void AddNewClass(object sender, EventArgs e) //кнопка добавления
		{
			CheckedListOfClasses_AddItem(addedClass.Text);
			addedClass.Clear();
		}


		private void DeleteCheckedClasses(object sender, EventArgs e) 
		{
			var checkedItems = checkedListOfClasses.CheckedItems;

			for (var i = checkedListOfClasses.CheckedItems.Count - 1; i >= 0; i--)
				checkedListOfClasses.Items.Remove(checkedListOfClasses.CheckedItems[i]);
		}
	}
}
