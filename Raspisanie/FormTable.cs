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
		public FormTable(string nameOfGrade)
		{
			InitializeComponent();
			GradeName.Text += nameOfGrade;
			AutoComplitingForSubjects();
			AutoComplitingForTeachers();
		}

		private void AutoComplitingForSubjects()
		{
			var text = File.ReadAllText("Subjects.txt").Split(new char[] { '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

			var source = new AutoCompleteStringCollection();
			source.AddRange(text);
			textBoxSubjects.AutoCompleteCustomSource = source;
			textBoxSubjects.AutoCompleteSource = AutoCompleteSource.CustomSource;
		}

		private void AutoComplitingForTeachers()
		{
			var text = Program.ListBoxToStrings(FormGradesAndTeachers.teachers).ToArray();

			var source = new AutoCompleteStringCollection();
			source.AddRange(text);
			textBoxTeacher.AutoCompleteCustomSource = source;
			textBoxTeacher.AutoCompleteSource = AutoCompleteSource.CustomSource;
		}

		private void Add_Click(object sender, EventArgs e)
		{
			if (textBoxSubjects.Text != null && numericCountAtWeek.Value != 0 && textBoxTeacher.Text != null)
				dataGridSubjects.Rows.Add(
					textBoxSubjects.Text, 
					numericDifficulty.Value, 
					numericCountAtWeek.Value, 
					textBoxTeacher.Text
				);
		}

		private void Delete_Click(object sender, EventArgs e)
		{
			dataGridSubjects.Rows.RemoveAt(dataGridSubjects.SelectedCells[0].RowIndex);
		}

		private void FormTable_FormClosing(object sender, FormClosingEventArgs e)
		{
			var columnArray = new string[dataGridSubjects.Rows.Count];
			var grade = new Grade(GradeName.Text);

			foreach (DataGridViewRow row in dataGridSubjects.Rows)
			{
				var subject = GetValueFromRow(row, 0);
				var difficulty = GetValueFromRow(row, 1);
				var countAtWeek = GetValueFromRow(row, 2);
				var teacher = GetValueFromRow(row, 3);

				if (subject != "" && difficulty != "" && countAtWeek != "" && teacher != "")
					grade.AddSubject(
						new Subject(subject, int.Parse(difficulty), int.Parse(countAtWeek)),
						new Teacher(teacher)
					);
			}

			var currentGrade = SchedlueMaker.Grades.Where(a => a.Name == GradeName.Text).FirstOrDefault();

			if (currentGrade == null)
				SchedlueMaker.Grades.Add(grade);
			else currentGrade = grade;
		}

		private static string GetValueFromRow(DataGridViewRow row, int index)
		{
			return row.Cells[index].Value != null ? row.Cells[index].Value.ToString() : string.Empty;
		}

		#region
		private void FormTable_Load(object sender, EventArgs e)
		{

		}

		private void DataGridViewSubjects_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void TextBoxSubject_Change(object sender, EventArgs e)
		{

		}

		private void NumericDifficulty_Change(object sender, EventArgs e)
		{

		}

		private void NumericCountAtWeek_Change(object sender, EventArgs e)
		{

		}

		private void TextBoxTeacher_Change(object sender, EventArgs e)
		{

		}
		#endregion
	}
}
