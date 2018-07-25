using System;
using System.Linq;
using System.Windows.Forms;

namespace Raspisanie
{
	public partial class FormAddTeacher : Form
	{
		public static bool flagOfSaveClicking;
		public static string[] teachers;

		public FormAddTeacher()
		{
			InitializeComponent();
			flagOfSaveClicking = false;
		}

		private void FormAddTeacher_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		private void CheckedListOfTeachersClick(object sender, EventArgs e)
		{
			if (flagOfSaveClicking)
				checkedListOfTeachers.DoubleClick += DoubleClicking;
		}

		private void AddTeacherClick(object sender, EventArgs e)
		{
			CheckedListOfTeachers_AddItem(textBoxTeacher.Text);
			textBoxTeacher.Clear();
		}

		public void CheckedListOfTeachers_AddItem(string item)
		{
			if (item != "" && !checkedListOfTeachers.Items.Contains(item))
				checkedListOfTeachers.Items.Add(item);
		}

		private void DeletingTeachersClick(object sender, EventArgs e)
		{
			for (var i = checkedListOfTeachers.CheckedItems.Count - 1; i >= 0; i--)
				checkedListOfTeachers.Items.Remove(checkedListOfTeachers.CheckedItems[i]);
		}

		private void SortingByAlphabetClick(object sender, EventArgs e)
		{
			var teachers = Program.ListBoxToStrings(checkedListOfTeachers).ToArray();

			Array.Sort(teachers);

			checkedListOfTeachers.Items.Clear();
			checkedListOfTeachers.Items.AddRange(teachers);
		}

		private static void DoubleClicking(object sender, EventArgs e)
		{
			var nameOfTeacher = (sender as CheckedListBox).SelectedItem;
			FormClassesForTeacher formHelpAdding = new FormClassesForTeacher(nameOfTeacher.ToString(), FormAddGrades.schoolClasses);
			formHelpAdding.Show();
		}

		private void SaveClick(object sender, EventArgs e)
		{
			flagOfSaveClicking = true;
			teachers = Program.ListBoxToStrings(checkedListOfTeachers).ToArray();
			Program.teachers = new Teacher[checkedListOfTeachers.Items.Count];

			for (int i = 0; i < Program.teachers.Length; i++)
				Program.teachers[i] = new Teacher(checkedListOfTeachers.Items[i].ToString());
		}

		#region
		private void TextingTeacher(object sender, EventArgs e)
		{

		}

		private void FormAddTeacher_Load(object sender, EventArgs e)
		{

		}
		#endregion

		private void Label1_Click(object sender, EventArgs e)
		{

		}

		private void NextClick(object sender, EventArgs e)
		{
			var formLoading = new FormLoading();
			Hide();
			formLoading.Show();
		}
	}
}
