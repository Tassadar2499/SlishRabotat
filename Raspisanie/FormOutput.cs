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

			gradesListBox.Items.AddRange(SchedlueMaker.Grades.Select(a => a.Name).ToArray());
			teachersListBox.Items.AddRange(SchedlueMaker.Teachers.Select(a => a.Name).ToArray());

			gradesListBox.DoubleClick += DoubleClickingGrade;
			teachersListBox.DoubleClick += DoubleClickingTeacher;
		}

		private void DoubleClickingGrade(object sender, EventArgs e)
		{
			var gradeName = (sender as ListBox).SelectedItem.ToString();

			if (gradeName != null)
			{
				var formSchedlue =
					new FormSchedlue("Класс - " + gradeName, SchedlueMaker.GetGradeByName(gradeName));

				formSchedlue.Show();
			}
		}

		private void DoubleClickingTeacher(object sender, EventArgs e)
		{
			var teacherName = (sender as ListBox).SelectedItem.ToString();

			if (teacherName != null)
			{
				var formSchedlue =
					new FormSchedlue("Учитель - " + teacherName, SchedlueMaker.GetTeacherByName(teacherName));

				formSchedlue.Show();
			}
		}
	}
}
