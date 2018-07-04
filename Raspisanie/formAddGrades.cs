﻿using System;
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
		public static string[] checkedGrades;

		public FormAddGrades()
		{
			InitializeComponent();

			SchedlueMaker.SchoolClasses = SchedlueMaker.LoadClasses("Classes.txt").ToArray();
			//SchedlueMaker.Teachers = SchedlueMaker.LoadTeachers("Teachers.txt").ToArray();

			foreach (var schoolClass in SchedlueMaker.SchoolClasses.Select(a => a.Name))
				checkedListOfClasses.Items.Add(schoolClass);

			checkedListOfClasses.CheckOnClick = true;
			checkedListOfClasses.MultiColumn = true;
		}

		private void CheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void SaveClick(object sender, EventArgs e)
		{
			checkedGrades = Program.CheckedListToStrings(checkedListOfClasses).ToArray();
		}

		private void ShowClick(object sender, EventArgs e)
		{
			Program.ShowOnMessageBox(checkedGrades);
		}

		private void NextClick(object sender, EventArgs e)
		{
			FormAddSubjects form = new FormAddSubjects();
			form.Show();
		}
	}
}
