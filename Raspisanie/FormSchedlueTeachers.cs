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

			var teacher = SchedlueMaker.GetTeacherByName(nameOfTeacher);

			for (int lesson = 0; lesson < teacher.maxLesson; lesson++)
			{
				var row = new string[7];
				row[0] = (lesson + 1).ToString();

				for (var day = 0; day < teacher.maxDay; day++)
					row[day + 1] = teacher.schedlue[day][lesson] != null
						? teacher.schedlue[day][lesson].Name
						: "-";

				dataTable.Rows.Add(row);
			}
        }

        private void DataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
