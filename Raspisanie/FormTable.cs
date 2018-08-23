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
	public partial class FormTable : Form
	{
		private string gradeName;

		public FormTable(string gradeName, string[] teachersName)
		{
			InitializeComponent();

			gradeNameLabel.Text = "Класс - " + gradeName;
			this.gradeName = gradeName;

			gradesToCopyComboBox.Items.AddRange(
				SchedlueMaker.Grades.Select(a => a.Name).Where(a => a != gradeName).ToArray());
			gradesToCopyComboBox.SelectedIndex = 0;

			MakeAutoCompliting(textBoxSubjects,
				File.ReadAllText("Subjects.txt").Split(new char[] { '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries));

			MakeAutoCompliting(textBoxTeacher, teachersName);

			GetGradesToDataGrid(gradeName);
		}

		private void MakeAutoCompliting(TextBox target, string[] text)
		{
			var source = new AutoCompleteStringCollection();
			source.AddRange(text);
			target.AutoCompleteCustomSource = source;
			target.AutoCompleteSource = AutoCompleteSource.CustomSource;
		}

		private void GetGradesToDataGrid(string gradeName)
		{
			var grade = SchedlueMaker.GetGradeByName(gradeName);

			if (grade != null)
			{
				dataGridSubjects.Rows.Clear();

				foreach (var item in grade.Subjects)
					dataGridSubjects.Rows.Add(
							item.Key.Name,
							item.Key.Difficult,
							item.Key.CountAtWeek,
							item.Value.Name
						);
			}
		}

		private void Add_Click(object sender, EventArgs e)
		{
			if (textBoxSubjects.Text != null && numericCountAtWeek.Value != 0 && textBoxTeacher.Text != null)
				dataGridSubjects.Rows.Add(
					textBoxSubjects.Text,
					(int)numericDifficulty.Value,
					(int)numericCountAtWeek.Value,
					textBoxTeacher.Text
				);
		}

		private void Delete_Click(object sender, EventArgs e)
		{
			dataGridSubjects.Rows.RemoveAt(dataGridSubjects.SelectedCells[0].RowIndex);
		}

		private static string GetValueFromRow(DataGridViewRow row, int index)
		{
			return row.Cells[index].Value != null ? row.Cells[index].Value.ToString() : string.Empty;
		}

		private void FormTable_FormClosing(object sender, FormClosingEventArgs e)
		{
			var columnArray = new string[dataGridSubjects.Rows.Count];
			var grade = new Grade(gradeName);
			foreach (DataGridViewRow row in dataGridSubjects.Rows)
			{
				var subject = GetValueFromRow(row, 0);
				var difficulty = GetValueFromRow(row, 1);
				var countAtWeek = GetValueFromRow(row, 2);
				var teacher = GetValueFromRow(row, 3);

				if (subject != "" && difficulty != "" && countAtWeek != "" && teacher != "")
					grade.AddSubject(
						new Subject(subject, int.Parse(difficulty), int.Parse(countAtWeek)),
						SchedlueMaker.GetOrCreateTeacherByName(teacher)
					);
			}

			var currentGrade = SchedlueMaker.GetGradeByName(gradeName);

			if (currentGrade == null)
				SchedlueMaker.Grades.Add(grade);
			else
			{
				SchedlueMaker.Grades.Remove(currentGrade);
				SchedlueMaker.Grades.Add(grade);
			}
		}

		private void CopyTheTable_Click(object sender, EventArgs e)
		{
			if (gradesToCopyComboBox.SelectedText != null)
				GetGradesToDataGrid(gradesToCopyComboBox.SelectedItem.ToString());
		}
	}
}
