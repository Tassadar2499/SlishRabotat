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
    public partial class FormSchedlueTeachers : Form
    {
        public FormSchedlueTeachers(string nameOfTeacher)
        {
            InitializeComponent();
            labelTitle.Text += nameOfTeacher;

			foreach (var teacher in SchedlueMaker.Teachers)
				for (int lesson = 0; lesson < teacher; lesson++)
					dataTable.Rows.Add(lesson + 1, week[0, lesson], week[1, lesson], week[2, lesson], week[3, lesson], week[4, lesson], week[5, lesson]);

			foreach (var schoolClass in SchedlueMaker.Grades)
            {
                for (int day = 0; day < schoolClass.schedlue.Count; day++)
                    for (int lesson = 0; lesson < schoolClass.schedlue[day].Length; lesson++)
                        if (schoolClass.schedlue[day][lesson] != null)
                        {
                            var teacher = new Teacher("");
                            schoolClass.Subjects.TryGetValue(schoolClass.schedlue[day][lesson], out teacher);
                            if (teacher.Name == nameOfTeacher)
                                week[day, lesson] = schoolClass.schedlue[day][lesson].Name + "(" + schoolClass.Name + ")"; ;
                        }
            }


            //Надо чтобы в 
        }

        private void LabelTitle_Click(object sender, EventArgs e)
        {

        }

        private void DataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
