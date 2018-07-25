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
	public partial class FormCountAndDifficulty : Form
	{
		string nameOfSubj;

		public FormCountAndDifficulty(string nameOfSubject)
		{
			InitializeComponent();
			label1.Text += nameOfSubject;
			nameOfSubj = nameOfSubject;
		}

		#region
		private void NameOfSubjLabelClick(object sender, EventArgs e)
		{

		}

		private void DifficultyLabelClick(object sender, EventArgs e)
		{

		}

		private void CountAtWeekLabelClick(object sender, EventArgs e)
		{

		}
		#endregion

		private void FormCountAndDifficulty_FormClosing(object sender, FormClosingEventArgs e)
		{
			var dificulty = (int)numericDifficulty.Value;
			var countAtWeek = (int)numericCountAtWeek.Value;
			var subject = new Subject(nameOfSubj, dificulty, countAtWeek);

			if (!FormHelpAdding.subjOfCurrentClass.Contains(subject))
				FormHelpAdding.subjOfCurrentClass.Add(subject);
		}

		private void FormCountAndDifficulty_Load(object sender, EventArgs e)
		{

		}
	}
}
