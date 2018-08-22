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
            foreach (var grade in SchedlueMaker.Grades) //добавляем классы для которых расписание сформированно в список
                listOfGrades.Items.Add(grade.Name);
            var list = new List<Teacher>();
            foreach (var grade in SchedlueMaker.Grades) //короче тут костыль ебучий для добавления списка учителей
                foreach (var teacher in grade.Subjects.Values)
                {
                    var flag = true;

                    foreach (var elem in list)
                        if (elem.Name == teacher.Name) flag = false;

                    if (flag) list.Add(teacher);
                }
            foreach (var teacher in list)
                listBoxOfTeachers.Items.Add(teacher.Name);
            listOfGrades.DoubleClick += DoubleClickingGrade;
            listBoxOfTeachers.DoubleClick += DoubleClickingTeacher;
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
