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
    public partial class FormTable : Form
    {
        public FormTable(string nameOfGrade)
        {
            InitializeComponent();
            GradeName.Text += nameOfGrade;
        }

        #region
        private void FormTable_Load(object sender, EventArgs e)
        {

        }

        private void DataGridViewSubjects_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TextBoxSubject_Change(object sender, EventArgs e)
        {

        }

        private void NumericDifficulty_Change(object sender, EventArgs e)
        {
            
        }

        private void NumericCountAtWeek_Change(object sender, EventArgs e)
        {
            
        }

        private void TextBoxTeacher_Change(object sender, EventArgs e)
        {

        }
        #endregion
        private void Add_Click(object sender, EventArgs e)
        {
            dataGridSubjects.Rows.Add(textBoxSubject.Text, numericDifficulty.Value, numericCountAtWeek.Value, textBoxTeacher.Text);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            int delet = dataGridSubjects.SelectedCells[0].RowIndex;
            dataGridSubjects.Rows.RemoveAt(delet);
        }
    }
}
