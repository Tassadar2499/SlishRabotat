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

            AutoCompleteStringCollection source = new AutoCompleteStringCollection();
            source.AddRange(text);
            textBoxSubjects.AutoCompleteCustomSource = source;
            textBoxSubjects.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void AutoComplitingForTeachers()
        {
            var teachers = FormGradesAndTeachers.teachers;;
            var text = Program.ListBoxToStrings(teachers).ToArray();
            AutoCompleteStringCollection source = new AutoCompleteStringCollection();
            source.AddRange(text);
            textBoxTeacher.AutoCompleteCustomSource = source;
            textBoxTeacher.AutoCompleteSource = AutoCompleteSource.CustomSource;
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
        private void Add_Click(object sender, EventArgs e)
        {
            dataGridSubjects.Rows.Add(textBoxTeacher.Text, numericDifficulty.Value, numericCountAtWeek.Value, textBoxSubjects.Text);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            int delet = dataGridSubjects.SelectedCells[0].RowIndex;
            dataGridSubjects.Rows.RemoveAt(delet);
        }

        private void FormTable_FormClosing(object sender, FormClosingEventArgs e)
        {
            string[] columnArray = new string[dataGridSubjects.Rows.Count];
            var grade = new Grade(GradeName.Text);
            int costil = 0;
            foreach (DataGridViewRow row in dataGridSubjects.Rows)
            {
                var subject = row.Cells[0].Value != null ? row.Cells[0].Value.ToString() : string.Empty;
                var difficulty = row.Cells[1].Value != null ? row.Cells[1].Value.ToString() : string.Empty;
                var countAtWeek = row.Cells[2].Value != null ? row.Cells[2].Value.ToString() : string.Empty;
                var teacher = row.Cells[3].Value != null ? row.Cells[3].Value.ToString() : string.Empty;
                if (costil + 1 < dataGridSubjects.Rows.Count)
                grade.AddSubject(
                    new Subject(subject,Int32.Parse(difficulty), Int32.Parse(countAtWeek)),
                    new Teacher(teacher)
                    );
                costil++;
            }
            Program.grades.Add(grade);
        }
    }
}
