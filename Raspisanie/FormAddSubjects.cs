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
			subjectsCheckedListBox.CheckOnClick = true;
		}

		public void CheckedListOfSubjects_AddItem(string item)
		{
			if (item != "" && !subjectsCheckedListBox.Items.Contains(item))
				subjectsCheckedListBox.Items.Add(item);
		}

		private void CheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void NextClick(object sender, EventArgs e)
		{
			checkedSubjects = Program.ListBoxToStrings(subjectsCheckedListBox).ToArray();
			Program.ShowOnMessageBox(checkedSubjects);
			FormFillingTheClasses formFillingTheClasses = new FormFillingTheClasses();
			formFillingTheClasses.Show();
			Hide();
		}

		private void AddDefaultSubjectsClick(object sender, EventArgs e)
		{
			foreach (var subj in SchedlueMaker.LoadSubjects("Subjects.txt").Select(a => a.Name))
				subjectsCheckedListBox.Items.Add(subj);

			subjectsCheckedListBox.CheckOnClick = true;
		}

		private void DeleteDefaultSubjectsClick(object sender, EventArgs e)
		{
			var schoolSubjects = SchedlueMaker.LoadSubjects("Subjects.txt").Select(a => a.Name);

			foreach (var schoolSubject in schoolSubjects)
				if (schoolSubjects.Contains(schoolSubject))
					subjectsCheckedListBox.Items.Remove(schoolSubject);
		}

		private void TextAddSubject(object sender, EventArgs e)
		{
			var text = File.ReadAllText("Subjects.txt").Split(new char[] { '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
			for (var i = 0; i < text.Length; i++)
			{
				var str = text[i];
				var index = str.LastIndexOf('-');
				var subject = str.Substring(0, index);
				text.SetValue(subject, i);
			}
			AutoCompleteStringCollection source = new AutoCompleteStringCollection();
			source.AddRange(text);
			subjectTextBox.AutoCompleteCustomSource = source;
			subjectTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			subjectTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
		}

		private void AddNewSubjectClick(object sender, EventArgs e)
		{
			CheckedListOfSubjects_AddItem(subjectTextBox.Text);
			subjectTextBox.Clear();
		}

		private void DeleteCheckedSubjectsClick(object sender, EventArgs e)
		{
			var checkedItems = subjectsCheckedListBox.CheckedItems;

			for (var i = subjectsCheckedListBox.CheckedItems.Count - 1; i >= 0; i--)
				subjectsCheckedListBox.Items.Remove(subjectsCheckedListBox.CheckedItems[i]);
		}

		private void SortingByAlphabet(object sender, EventArgs e)
		{
			var schoolSubjects = Program.ListBoxToStrings(subjectsCheckedListBox).ToArray();

			Array.Sort(schoolSubjects);

			subjectsCheckedListBox.Items.Clear();
			subjectsCheckedListBox.Items.AddRange(schoolSubjects);
		}

		private void GoToPreviousFormClick(object sender, EventArgs e)
		{
			FormAddGrades formAddGrades = new FormAddGrades();
			Close();
			formAddGrades.Show();
		}

		private void FormAddSubjects_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}
	}
}
