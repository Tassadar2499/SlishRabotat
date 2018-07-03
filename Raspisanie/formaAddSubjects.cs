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
			var subjectsDictionary = Program.GetDictionaryOfSubjects();
			foreach (var subj in subjectsDictionary.Keys)
			{
				checkedListBoxOfSubjects.Items.Add(subj);
			}
			checkedListBoxOfSubjects.CheckOnClick = true;
		}

		private void SaveClick(object sender, EventArgs e)
		{
			checkedSubjects = Program.CheckedListToStrings(checkedListBoxOfSubjects).ToArray();
		}

		private void CheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void ShowClick(object sender, EventArgs e)
		{
			Program.ShowOnMessageBox(checkedSubjects);
		}
	}
}
