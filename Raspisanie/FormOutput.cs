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
            var nameOfClass = (sender as ListBox).SelectedItem;

            if (nameOfClass != null)
            {
                var formSchedlue = new FormSchedlue(nameOfClass.ToString());
                formSchedlue.Show();
            }
        }

        private void DoubleClickingTeacher(object sender, EventArgs e)
        {
            var nameOfTeacher = (sender as ListBox).SelectedItem;

            if (nameOfTeacher != null)
            {
                var formSchedlue = new FormSchedlueTeachers(nameOfTeacher.ToString());
                formSchedlue.Show();
            }
        }

        private void tabPageGrades_Click(object sender, EventArgs e)
        {

        }

        private void listOfGrades_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPageTeachers_Click(object sender, EventArgs e)
        {

        }
    }
}
