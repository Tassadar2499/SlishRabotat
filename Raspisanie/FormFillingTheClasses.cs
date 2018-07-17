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
	public partial class FormFillingTheClasses : Form
	{
		public FormFillingTheClasses()
		{
			InitializeComponent();
			var schoolClasses = FormAddGrades.schoolClasses;
			foreach (var grade in schoolClasses)
			{
				TabPage newClass = new TabPage();
				newClass.Text = grade;
				tabControlClasses.TabPages.Add(newClass);
				tabControlClasses.Multiline = true;
			}
		}

		private void tabControlClasses_SelectedIndexChanged(object sender, EventArgs e)
		{
			var tabs = tabControlClasses.Controls;
			for (int i = 0; i < tabControlClasses.TabCount; i++)
			{
				var tab = tabControlClasses.GetControl(i);
			}
		}
	}
}
