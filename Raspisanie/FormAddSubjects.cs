﻿using System;
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
	public partial class FormAddSubjects : Form
	{
		public static string[] checkedSubjects;

		public FormAddSubjects()
		{
			InitializeComponent();
			var subjectsDictionary = SchedlueMaker.GetSubjects();

			foreach (var subj in subjectsDictionary.Select(a => a.Name))
				checkedListBoxOfSubjects.Items.Add(subj);

			checkedListBoxOfSubjects.CheckOnClick = true;
		}

		private void SaveClick(object sender, EventArgs e)
		{
			checkedSubjects = Program.CheckedListToStrings(checkedListBoxOfSubjects).ToArray();
		}

		private void CheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void ShowClick(object sender, EventArgs e)
		{
			Program.ShowOnMessageBox(checkedSubjects);
		}
	}
}