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
	public partial class FormGradesAndTeachers : Form
	{
		public FormGradesAndTeachers()
		{
			InitializeComponent();
			checkedListBoxOfGrades.DoubleClick += DoubleClicking;
		}

		/// <summary>
		/// Метод для добавления элементов в CheckedListBox
		/// </summary>
		/// <param name="checkedListBox"></param>
		/// <param name="item"></param>
		public void CheckedList_AddItem(CheckedListBox checkedListBox, string item)
		{
			if (item != "" && !checkedListBox.Items.Contains(item))
				checkedListBox.Items.Add(item);
		}

		#region Grade methods

		private void DoubleClicking(object sender, EventArgs e)
		{
			var nameOfClass = (sender as CheckedListBox).SelectedItem;

			if (nameOfClass != null)
			{
				var formTable = new FormTable(nameOfClass.ToString(), checkedListBoxOfTeachers);
				formTable.Show();
			}
		}

		private void AddNewGrade_Click(object sender, EventArgs e)
		{
			CheckedList_AddItem(checkedListBoxOfGrades, addGradeTextBox.Text);
			addGradeTextBox.Clear();
		}

		private void DeleteSelectingGrades_Click(object sender, EventArgs e)
		{
			var checkedItems = checkedListBoxOfGrades.CheckedItems;

			for (var i = checkedListBoxOfGrades.CheckedItems.Count - 1; i >= 0; i--)
				checkedListBoxOfGrades.Items.Remove(checkedListBoxOfGrades.CheckedItems[i]);
		}

		private void SortingByNumber_Click(object sender, EventArgs e)
		{
			var grades = Program.ListBoxToStrings(checkedListBoxOfGrades).ToArray();

			Array.Sort(grades, new SortingStringByNumber());

			checkedListBoxOfGrades.Items.Clear();

			foreach (var schoolClass in grades)
				CheckedList_AddItem(checkedListBoxOfGrades, schoolClass);
		}

		private void AddDefaultGrades_Click(object sender, EventArgs e)
		{
			var grades = SchedlueMaker.LoadClasses("Classes.txt").Select(a => a.Name);

			foreach (var schoolClass in grades)
				CheckedList_AddItem(checkedListBoxOfGrades, schoolClass);
		}

		private void CancelAddingDefaultClasses_Click(object sender, EventArgs e)
		{
			var grades = SchedlueMaker.LoadClasses("Classes.txt").Select(a => a.Name);

			foreach (var schoolClass in grades)
				if (grades.Contains(schoolClass))
					checkedListBoxOfGrades.Items.Remove(schoolClass);
		}

		#region
		private void FormGradesAndTeachers_Load(object sender, EventArgs e)
		{

		}

		private void TabPageGrades(object sender, EventArgs e)
		{

		}

		private void TabPageTeachers(object sender, EventArgs e)
		{

		}

		private void CheckedListBoxOfGrades_SelectingItem(object sender, EventArgs e)
		{

		}

		private void TextAddGrade(object sender, EventArgs e)
		{

		}
		#endregion

		#endregion

		#region Teachers methods

		private void AddTeacher_Click(object sender, EventArgs e)
		{
			CheckedList_AddItem(checkedListBoxOfTeachers, textBoxAddTeacher.Text);
			textBoxAddTeacher.Clear();
		}

		private void DeleteSelectingTeachers_Click(object sender, EventArgs e)
		{
			for (var i = checkedListBoxOfTeachers.CheckedItems.Count - 1; i >= 0; i--)
				checkedListBoxOfTeachers.Items.Remove(checkedListBoxOfTeachers.CheckedItems[i]);
		}

		private void SortingByAlphabet_Click(object sender, EventArgs e)
		{
			var teachers = Program.ListBoxToStrings(checkedListBoxOfTeachers).ToArray();

			Array.Sort(teachers);

			checkedListBoxOfTeachers.Items.Clear();
			checkedListBoxOfTeachers.Items.AddRange(teachers);
		}

		#region
		private void CheckedListBoxOfTeachers_SelectingItem(object sender, EventArgs e)
		{

		}

		private void TextBoxAddTeacher(object sender, EventArgs e)
		{

		}
		#endregion

		#endregion

		private void button9_Click(object sender, EventArgs e)
		{

		}
	}
}
