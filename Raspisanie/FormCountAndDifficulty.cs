﻿using System;
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
		int dificulty;
		int countAtWeek;
		string nameOfSubj;
		Subject subject;
		public FormCountAndDifficulty(string nameOfSubject)
		{
			InitializeComponent();
			label1.Text += nameOfSubject;
			nameOfSubj = nameOfSubject;
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void SaveClick(object sender, EventArgs e)
		{
			subject = new Subject(nameOfSubj, dificulty, countAtWeek);
			
			if (!FormHelpAdding.subjOfCurrentClass.Contains(subject))
			FormHelpAdding.subjOfCurrentClass.Add(subject);
		}

		private void numericDifficulty_ValueChanged(object sender, EventArgs e)
		{
			dificulty = (int) numericDifficulty.Value;
		}

		private void numericCountAtWeek_ValueChanged(object sender, EventArgs e)
		{
			countAtWeek = (int) numericCountAtWeek.Value;
		}
	}
}
