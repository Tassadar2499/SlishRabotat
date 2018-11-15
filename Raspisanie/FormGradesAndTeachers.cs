using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Raspisanie
{
	public partial class FormGradesAndTeachers : Form
	{
		public FormGradesAndTeachers()
		{
			InitializeComponent();
			listBoxOfGrades.DoubleClick += DoubleClicking;
		}

		/// <summary>
		/// Метод для добавления элементов в ListBox
		/// </summary>
		/// <param name="listBox"></param>
		/// <param name="item"></param>
		public void CheckedList_AddItem(ListBox listBox, string item)
		{
			if (item != "" && !listBox.Items.Contains(item))
				listBox.Items.Add(item);

			var grades = Program.ListBoxToStrings(listBoxOfGrades).ToArray();

			Array.Sort(grades, new SortingStringByNumber());

			listBoxOfGrades.Items.Clear();

			foreach (var schoolClass in grades)
				listBox.Items.Add(schoolClass);
		}

		private void MakeSchedlueButton_Click(object sender, EventArgs e)
		{
			SchedlueMaker.CalculateSchedlue();

			var formOutput = new FormOutput();
			formOutput.Show();
		}
        
		#region Grade methods

		private void DoubleClicking(object sender, EventArgs e)
		{
			var nameOfClass = (sender as ListBox).SelectedItem;

			if (nameOfClass != null)
			{
				var formTable = new FormTable(nameOfClass.ToString(), Program.ListBoxToStrings(listBoxOfTeachers).ToArray());
				formTable.Show();
			}
		}

		private void AddNewGrade_Click(object sender, EventArgs e)
		{
			CheckedList_AddItem(listBoxOfGrades, addGradeTextBox.Text);
			addGradeTextBox.Clear();
		}

		private void DeleteSelectingGrades_Click(object sender, EventArgs e)
		{
			for (var i = listBoxOfGrades.SelectedItems.Count - 1; i >= 0; i--)
			{
				SchedlueMaker.Grades.Remove(SchedlueMaker.GetGradeByName(listBoxOfGrades.SelectedItems[i].ToString()));
				listBoxOfGrades.Items.Remove(listBoxOfGrades.SelectedItems[i]);
			}
		}

		#endregion

		#region Teachers methods

		private void AddTeacher_Click(object sender, EventArgs e)
		{
			CheckedList_AddItem(listBoxOfTeachers, textBoxAddTeacher.Text);
			textBoxAddTeacher.Clear();
		}

		private void DeleteSelectingTeachers_Click(object sender, EventArgs e)
		{
			for (var i = listBoxOfTeachers.SelectedItems.Count - 1; i >= 0; i--)
				listBoxOfTeachers.Items.Remove(listBoxOfTeachers.SelectedItems[i]);
		}

		#endregion

		#region Serialise Methods
		private void SaveInFile_Click(object sender, EventArgs e)
		{
			saveFileDialog.ShowDialog();
		}

		private void LoadFromFile_Click(object sender, EventArgs e)
		{
			openFileDialog.ShowDialog();
		}

		private void SaveFileDialog_FileOk(object sender, CancelEventArgs e)
		{
			File.Delete((sender as SaveFileDialog).FileName);

			var strOutput = "";

            foreach (var grade in SchedlueMaker.Grades)
            {
                strOutput += grade.Name + "\r\n?";

                foreach (var subject in grade.Subjects)
                    strOutput += subject.Key.Name + "&" + subject.Key.Difficult.ToString() + "&" + subject.Key.CountAtWeek.ToString() + "&" + subject.Value.Name + "\r\n%";

                strOutput = strOutput.Remove(strOutput.Length - 1) + "#";
            }

            strOutput = strOutput.Remove(strOutput.Length - 1);

            File.AppendAllText((sender as SaveFileDialog).FileName, strOutput);
		}

		private void OpenFileDialog_FileOk(object sender, CancelEventArgs e)
		{
			var grades = new List<Grade>();
            var arrOfGrades = File.ReadAllText((sender as OpenFileDialog).FileName).Split('#');

            foreach (var gradeStr in arrOfGrades)
            {
                var grade = new Grade(gradeStr.Substring(0, gradeStr.IndexOf('?') - 2));
                var strArr = gradeStr.Substring(gradeStr.IndexOf('?') + 1).Split('%');

                foreach (var str in strArr)
                {
                    var helpArr = str.Split('&');
                    grade.Subjects.Add(
                        new Subject(helpArr[0], int.Parse(helpArr[1]), int.Parse(helpArr[2])),
                        SchedlueMaker.GetOrCreateTeacherByName(helpArr[3].Substring(0, helpArr[3].Length - 2)));
                }

                grades.Add(grade);
            }

            SchedlueMaker.Grades = grades;
			listBoxOfGrades.Items.Clear();

			foreach (var schoolClass in grades)
				CheckedList_AddItem(listBoxOfGrades, schoolClass.Name);
		}
		#endregion
	}
}
