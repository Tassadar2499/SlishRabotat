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
    public partial class FormSchedlueGrades : Form
    {
        public FormSchedlueGrades(string nameOfGrade)
        {
            InitializeComponent();
            labelTitle.Text += nameOfGrade;

            var week = new string[6,8];
            for (int i = 0; i < 6; i++)
                for (int j = 0; j < 8; j++)
                    week[i,j] = "-";
            Grade schoolClass = new Grade(nameOfGrade);
            foreach (var grade in SchedlueMaker.Grades)
                if (grade.Name == nameOfGrade)
                {
                    schoolClass = grade;
                    break;
                }
            for (int day = 0; day < schoolClass.schedlue.Count; day++)
                for (int lesson = 0; lesson < schoolClass.schedlue[day].Length; lesson++)
                    if (schoolClass.schedlue[day][lesson] != null)
                        week[day, lesson] = schoolClass.schedlue[day][lesson].Name;
            for (int lesson = 0; lesson < 8; lesson++)
                dataTable.Rows.Add(lesson+1, week[0,lesson], week[1, lesson], week[2, lesson], week[3, lesson], week[4, lesson], week[5, lesson]);
        }

        private void FormSchedlueGrades_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
