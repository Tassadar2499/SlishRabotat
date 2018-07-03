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
	public partial class formaAddSubjects : Form
	{
		public static string[] checkedSubjects;
		public formaAddSubjects()
		{
			InitializeComponent();
			var subjectsDictionary = Program.returnDictionaryOfSubjects();
			foreach (var subj in subjectsDictionary.Keys)
			{
				checkedListBoxOfSubjects.Items.Add(subj);
			}
			checkedListBoxOfSubjects.CheckOnClick = true;
		}

		private void saveClick(object sender, EventArgs e)
		{
			checkedSubjects = Program.save(checkedListBoxOfSubjects);
		}

		private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void showClick(object sender, EventArgs e)
		{
			Program.show(checkedSubjects);
		}
	}
}
