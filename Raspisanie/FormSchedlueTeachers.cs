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
    public partial class FormSchedlueTeachers : Form
    {
        public FormSchedlueTeachers(string nameOfTeacher)
        {
            InitializeComponent();
            labelTitle.Text += nameOfTeacher;
            var week = new string[6, 8];
            for (int i = 0; i < 6; i++)
                for (int j = 0; j < 8; j++)
                    week[i, j] = "-";
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
