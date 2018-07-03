using System;
using System.Collections;
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
	public partial class formAddGrades : Form
	{
		public static string[] checkedGrades;
		public formAddGrades()
		{
			InitializeComponent();
			var classes = Program.returnArrayOfClasses();
			checkedListOfClasses.Items.AddRange(classes);
			checkedListOfClasses.CheckOnClick = true;
			checkedListOfClasses.MultiColumn = true;
		}

		private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void saveClick(object sender, EventArgs e)
		{
			checkedGrades = Program.save(checkedListOfClasses);
		}

		private void showClick(object sender, EventArgs e)
		{
			Program.show(checkedGrades);
		}

		private void NextClick(object sender, EventArgs e)
		{
			formaAddSubjects form = new formaAddSubjects();
			form.Show();
		}
	}
}
