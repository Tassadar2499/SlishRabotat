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
	public partial class FormOutput : Form
	{
		public FormOutput()
		{
			InitializeComponent();

			gradesListBox.Items.AddRange(
				SchedlueMaker.Grades.Select(a => a.Name).OrderBy(a => a, new SortingStringByNumber()).ToArray());

			teachersListBox.Items.AddRange(
				SchedlueMaker.Teachers.Select(a => a.Name).OrderBy(a => a).ToArray());

			gradesListBox.DoubleClick += DoubleClickingGrade;
			teachersListBox.DoubleClick += DoubleClickingTeacher;
		}

		private void DoubleClickingGrade(object sender, EventArgs e)
		{
			var objectName = (sender as ListBox).SelectedItem;

			if (objectName != null)
			{
				var gradeeName = objectName.ToString();
				var formSchedlue =
					new FormSchedlue("Класс - " + gradeeName, SchedlueMaker.GetGradeByName(gradeeName));

				formSchedlue.Show();
			}
		}

		private void DoubleClickingTeacher(object sender, EventArgs e)
		{
			var objectName = (sender as ListBox).SelectedItem;

			if (objectName != null)
			{
				var teacherName = objectName.ToString();
				var formSchedlue =
					new FormSchedlue("Учитель - " + teacherName, SchedlueMaker.GetTeacherByName(teacherName));

				formSchedlue.Show();
			}
		}

        private void gradesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SaveClassesToHTML_Click(object sender, EventArgs e)
        {
            foreach (var grade in gradesListBox.Items)
                HtmlSaver.SaveToHtml(grade.ToString(), SchedlueMaker.GetGradeByName(grade.ToString()));          
        }

        private void SaveTeachersToHTML_Click(object sender, EventArgs e)
        {
            foreach (var teacher in teachersListBox.Items)
                HtmlSaver.SaveToHtml(teacher.ToString(), SchedlueMaker.GetTeacherByName(teacher.ToString()));
        }
    }
}
