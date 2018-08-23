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
	public partial class FormSchedlue : Form
	{
		public FormSchedlue(string labelText, Schedlue schedlue)
		{
			InitializeComponent();
			labelTitle.Text = labelText;

			for (int lesson = 0; lesson < schedlue.maxLesson; lesson++)
			{
				var row = new string[7];
				row[0] = (lesson + 1).ToString();

				for (var day = 0; day < schedlue.maxDay; day++)
					row[day + 1] = schedlue.schedlue[day][lesson] != null
						? schedlue.schedlue[day][lesson].Name
						: "-";

				dataTable.Rows.Add(row);
			}

			for (var lesson = 0; lesson < schedlue.maxLesson; lesson++)
				dataTable.Rows[lesson].HeaderCell.Value = (lesson + 1).ToString();
		}
	}
}
