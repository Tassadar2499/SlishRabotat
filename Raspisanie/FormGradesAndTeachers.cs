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
    public partial class FormGradesAndTeachers : Form
    {
        public static string[] schoolClasses;
        public FormGradesAndTeachers()
        {
            InitializeComponent();
            if (schoolClasses != null)
                checkedListBoxOfGrades.Items.AddRange(schoolClasses);
        }

        private void FormGradesAndTeachers_Load(object sender, EventArgs e)
        {

        }

        private void TabPageGrades(object sender, EventArgs e)
        {

        }

        private void TabPageTeachers(object sender, EventArgs e)
        {

        }

        private void CheckedListBoxOfGradesSelectingItem(object sender, EventArgs e)
        {

        }
    }
}
