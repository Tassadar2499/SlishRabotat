using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Raspisanie
{
	public partial class FormAddSubjects : Form
	{
		public static string[] checkedSubjects;

		public FormAddSubjects()
		{
			InitializeComponent();
			checkedListBoxOfSubjects.CheckOnClick = true;
		}

		public void CheckedListOfSubjects_AddItem(string item) //Методы одинаковы
		{
			if (!checkedListBoxOfSubjects.Items.Contains(item))
				checkedListBoxOfSubjects.Items.Add(item);
		}

		private void CheckedListBox1_SelectedIndexChanged(object sender, EventArgs e) //Методы одинаковы
		{

		}

		private void NextClick(object sender, EventArgs e)
		{
			checkedSubjects = Program.ListBoxToStrings(checkedListBoxOfSubjects).ToArray();
			Program.ShowOnMessageBox(checkedSubjects);
			Application.Exit();
		}

		private void AddDefaultSubjectsClick(object sender, EventArgs e) //Методы одинаковы
		{
			foreach (var subj in SchedlueMaker.LoadSubjects("Subjects.txt").Select(a => a.Name))
				checkedListBoxOfSubjects.Items.Add(subj);

			checkedListBoxOfSubjects.CheckOnClick = true;

		}

		private void DeleteDefaultSubjectsClick(object sender, EventArgs e) //Методы одинаковы
		{
			var schoolSubjects = SchedlueMaker.LoadSubjects("Subjects.txt").Select(a => a.Name);

			foreach (var schoolSubject in schoolSubjects)
				if (schoolSubjects.Contains(schoolSubject))
					checkedListBoxOfSubjects.Items.Remove(schoolSubject);
		}

		private void textAddSubject(object sender, EventArgs e)
		{
			var text = File.ReadAllText("Subjects.txt").Split(new char[] { '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
			for (var i = 0; i < text.Length; i++)
			{
				var str = text[i];
				var index = str.LastIndexOf('-');
				var subject = str.Substring(0, index);
				text.SetValue(subject,i);
			}
			AutoCompleteStringCollection source = new AutoCompleteStringCollection();
			source.AddRange(text);			
			addedSubject.AutoCompleteCustomSource = source;
			addedSubject.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			addedSubject.AutoCompleteSource = AutoCompleteSource.CustomSource;
		}

		private void AddNewSubjectClick(object sender, EventArgs e) //Методы одинаковы
		{
			CheckedListOfSubjects_AddItem(addedSubject.Text);
			addedSubject.Clear();
		}

		private void DeleteCheckedSubjectsClick(object sender, EventArgs e) //Методы одинаковы
		{
			var checkedItems = checkedListBoxOfSubjects.CheckedItems;

			for (var i = checkedListBoxOfSubjects.CheckedItems.Count - 1; i >= 0; i--)
				checkedListBoxOfSubjects.Items.Remove(checkedListBoxOfSubjects.CheckedItems[i]);
		}

		private void SortingByAlphabet(object sender, EventArgs e)
		{
			var schoolSubjects = Program.ListBoxToStrings(checkedListBoxOfSubjects).ToArray();
			Sorting.SortingByAlphabet(schoolSubjects);
			checkedListBoxOfSubjects.Items.Clear();
			checkedListBoxOfSubjects.Items.AddRange(schoolSubjects);
		}

		private void GoToPreviousFormClick(object sender, EventArgs e)
		{
			FormAddGrades formAddGrades = new FormAddGrades();
			this.Close();
			formAddGrades.Show();
		}
	}
}
