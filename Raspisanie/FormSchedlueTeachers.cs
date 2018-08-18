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
            var week = new string[6, 8];
            for (int i = 0; i < 6; i++)
                for (int j = 0; j < 8; j++)
                    week[i, j] = "-";
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
            for (int lesson = 0; lesson < 8; lesson++)
                dataTable.Rows.Add(lesson + 1, week[0, lesson], week[1, lesson], week[2, lesson], week[3, lesson], week[4, lesson], week[5, lesson]);
            //Надо чтобы в 
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void dataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
