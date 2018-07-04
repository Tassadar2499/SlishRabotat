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
		private static string[] checkedGrades; //grade это тоже класс по английски
		private static string newClass = "";
		public static string[] schoolClasses; //сюда сохраняются все названия классов, работаем мы с этим полем

		public FormAddGrades()
		{
			InitializeComponent();
			checkedListOfClasses.CheckOnClick = true;
			checkedListOfClasses.MultiColumn = true;
		}

		private void CheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void NextClick(object sender, EventArgs e) //совместил кнопку save с кнопкой next
		{
			schoolClasses = Program.CheckedListBoxToStrings(checkedListOfClasses).ToArray();
			Program.ShowOnMessageBox(schoolClasses);
			FormAddSubjects form = new FormAddSubjects();
			form.Show();
		}

		private void AddDefaultGradesClick(object sender, EventArgs e) //добавляет классы из текстового файла
		{
			SchedlueMaker.SchoolClasses = SchedlueMaker.LoadClasses("Classes.txt").ToArray();
			foreach (var schoolClass in SchedlueMaker.SchoolClasses.Select(a => a.Name))
				checkedListOfClasses.Items.Add(schoolClass);
		}

		private void DeleteDefaultGradesClick(object sender, EventArgs e)//удаляет классы из текстового файла
		{
			var schoolClasses = SchedlueMaker.LoadClasses("Classes.txt").ToArray();
			foreach (var schoolClass in SchedlueMaker.SchoolClasses.Select(a => a.Name))
				if (schoolClasses.Select(a => a.Name).Contains(schoolClass))
					checkedListOfClasses.Items.Remove(schoolClass);
		}

		private void TextAddClass(object sender, EventArgs e) //текстовое поле добавления
		{
			newClass = addedClass.Text;
		}

		private void AddNewClass(object sender, EventArgs e) //кнопка добавления
		{
			checkedListOfClasses.Items.Add(newClass);
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
