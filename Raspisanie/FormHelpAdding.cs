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
	public partial class FormHelpAdding : Form
	{
		public FormHelpAdding(string className, string[] subjects)
		{
			InitializeComponent();
			listOfSubjects.Items.AddRange(subjects);
			listOfSubjects.CheckOnClick = true;
			labelClassName.Text += className;
		}


		private void checkedListBoxOfSubjectsSelect(object sender, EventArgs e)
		{

		}

		private void SaveClick(object sender, EventArgs e)
		{
			for (var i = listOfSubjects.Items.Count - 1; i >= 0; i--)
				if (!listOfSubjects.GetItemChecked(i))
					listOfSubjects.Items.RemoveAt(i);
		}

		private void LabelClassNameClick(object sender, EventArgs e)
		{

		}
	}
}
