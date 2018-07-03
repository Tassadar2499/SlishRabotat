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
		public formaAddSubjects()
		{
			InitializeComponent();
			var subjectsDictionary = Program.returnDictionaryOfSubjects();
			foreach (var subj in subjectsDictionary.Keys)
			{
				checkedListBoxOfSubjects.Items.Add(subj);
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
