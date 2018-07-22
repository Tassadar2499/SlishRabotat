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
	public partial class FormAddTeacher : Form
	{
		public FormAddTeacher()
		{
			InitializeComponent();
		}

		private void FormAddTeacher_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
			//var gg = checkedListOfTeachers.Items;
		}

		private void CheckedListOfTeachersClick(object sender, EventArgs e)
		{

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

		#region
		private void TextingTeacher(object sender, EventArgs e)
		{
			
		}
		#endregion

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
	}
}
