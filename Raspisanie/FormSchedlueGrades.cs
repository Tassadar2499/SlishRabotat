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

			var grade = SchedlueMaker.GetGradeByName(nameOfGrade);

			for (int lesson = 0; lesson < grade.maxLesson; lesson++)
			{
				var row = new string[7];
				row[0] = (lesson + 1).ToString();

				for (var day = 0; day < grade.maxDay; day++)
					row[day + 1] = grade.schedlue[day][lesson] != null
						? grade.schedlue[day][lesson].Name
						: "-";

				dataTable.Rows.Add(row);
			}
		}
	}
}
