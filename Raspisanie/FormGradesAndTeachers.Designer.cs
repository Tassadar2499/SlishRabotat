namespace Raspisanie
{
    partial class FormGradesAndTeachers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.Классы = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.MakeSchedlueButton = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.addGradeTextBox = new System.Windows.Forms.TextBox();
			this.checkedListBoxOfGrades = new System.Windows.Forms.CheckedListBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.button8 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.textBoxAddTeacher = new System.Windows.Forms.TextBox();
			this.checkedListBoxOfTeachers = new System.Windows.Forms.CheckedListBox();
			this.SaveInFile = new System.Windows.Forms.Button();
			this.LoadFromFile = new System.Windows.Forms.Button();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.Классы.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// Классы
			// 
			this.Классы.Controls.Add(this.tabPage1);
			this.Классы.Controls.Add(this.tabPage2);
			this.Классы.ItemSize = new System.Drawing.Size(150, 50);
			this.Классы.Location = new System.Drawing.Point(2, 35);
			this.Классы.Name = "Классы";
			this.Классы.SelectedIndex = 0;
			this.Классы.Size = new System.Drawing.Size(663, 540);
			this.Классы.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.Color.DarkGray;
			this.tabPage1.Controls.Add(this.MakeSchedlueButton);
			this.tabPage1.Controls.Add(this.button3);
			this.tabPage1.Controls.Add(this.button2);
			this.tabPage1.Controls.Add(this.button1);
			this.tabPage1.Controls.Add(this.addGradeTextBox);
			this.tabPage1.Controls.Add(this.checkedListBoxOfGrades);
			this.tabPage1.Location = new System.Drawing.Point(4, 54);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(655, 482);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Классы";
			this.tabPage1.Click += new System.EventHandler(this.TabPageGrades);
			// 
			// MakeSchedlueButton
			// 
			this.MakeSchedlueButton.Location = new System.Drawing.Point(549, 6);
			this.MakeSchedlueButton.Name = "MakeSchedlueButton";
			this.MakeSchedlueButton.Size = new System.Drawing.Size(100, 60);
			this.MakeSchedlueButton.TabIndex = 5;
			this.MakeSchedlueButton.Text = "Сформировать расписание";
			this.MakeSchedlueButton.UseVisualStyleBackColor = true;
			this.MakeSchedlueButton.Click += new System.EventHandler(this.MakeSchedlueButton_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(269, 373);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(94, 67);
			this.button3.TabIndex = 3;
			this.button3.Text = "Отсортировать по номеру";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.SortingByNumber_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(164, 373);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 54);
			this.button2.TabIndex = 2;
			this.button2.Text = "Удалить выбранные классы";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.DeleteSelectingGrades_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(47, 422);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 44);
			this.button1.TabIndex = 1;
			this.button1.Text = "Добавить класс";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.AddNewGrade_Click);
			// 
			// addGradeTextBox
			// 
			this.addGradeTextBox.Location = new System.Drawing.Point(8, 373);
			this.addGradeTextBox.Multiline = true;
			this.addGradeTextBox.Name = "addGradeTextBox";
			this.addGradeTextBox.Size = new System.Drawing.Size(114, 43);
			this.addGradeTextBox.TabIndex = 1;
			this.addGradeTextBox.TextChanged += new System.EventHandler(this.TextAddGrade);
			// 
			// checkedListBoxOfGrades
			// 
			this.checkedListBoxOfGrades.CheckOnClick = true;
			this.checkedListBoxOfGrades.FormattingEnabled = true;
			this.checkedListBoxOfGrades.Location = new System.Drawing.Point(8, 8);
			this.checkedListBoxOfGrades.Name = "checkedListBoxOfGrades";
			this.checkedListBoxOfGrades.Size = new System.Drawing.Size(485, 349);
			this.checkedListBoxOfGrades.TabIndex = 0;
			this.checkedListBoxOfGrades.SelectedIndexChanged += new System.EventHandler(this.CheckedListBoxOfGrades_SelectingItem);
			// 
			// tabPage2
			// 
			this.tabPage2.BackColor = System.Drawing.Color.DarkGray;
			this.tabPage2.Controls.Add(this.button8);
			this.tabPage2.Controls.Add(this.button7);
			this.tabPage2.Controls.Add(this.button6);
			this.tabPage2.Controls.Add(this.textBoxAddTeacher);
			this.tabPage2.Controls.Add(this.checkedListBoxOfTeachers);
			this.tabPage2.Location = new System.Drawing.Point(4, 54);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(655, 482);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Учителя";
			this.tabPage2.Click += new System.EventHandler(this.TabPageTeachers);
			// 
			// button8
			// 
			this.button8.Location = new System.Drawing.Point(388, 304);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(100, 70);
			this.button8.TabIndex = 4;
			this.button8.Text = "Отсортировать в алфавитном порядке";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.SortingByAlphabet_Click);
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(523, 231);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(75, 54);
			this.button7.TabIndex = 3;
			this.button7.Text = "Удалить выбранных учителей";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.DeleteSelectingTeachers_Click);
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(388, 181);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(75, 48);
			this.button6.TabIndex = 2;
			this.button6.Text = "Добавить учителя";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.AddTeacher_Click);
			// 
			// textBoxAddTeacher
			// 
			this.textBoxAddTeacher.Location = new System.Drawing.Point(388, 121);
			this.textBoxAddTeacher.Multiline = true;
			this.textBoxAddTeacher.Name = "textBoxAddTeacher";
			this.textBoxAddTeacher.Size = new System.Drawing.Size(100, 54);
			this.textBoxAddTeacher.TabIndex = 1;
			this.textBoxAddTeacher.TextChanged += new System.EventHandler(this.TextBoxAddTeacher);
			// 
			// checkedListBoxOfTeachers
			// 
			this.checkedListBoxOfTeachers.CheckOnClick = true;
			this.checkedListBoxOfTeachers.FormattingEnabled = true;
			this.checkedListBoxOfTeachers.Location = new System.Drawing.Point(8, 8);
			this.checkedListBoxOfTeachers.Name = "checkedListBoxOfTeachers";
			this.checkedListBoxOfTeachers.Size = new System.Drawing.Size(344, 319);
			this.checkedListBoxOfTeachers.TabIndex = 0;
			this.checkedListBoxOfTeachers.SelectedIndexChanged += new System.EventHandler(this.CheckedListBoxOfTeachers_SelectingItem);
			// 
			// SaveInFile
			// 
			this.SaveInFile.BackColor = System.Drawing.Color.Teal;
			this.SaveInFile.Location = new System.Drawing.Point(188, 6);
			this.SaveInFile.Name = "SaveInFile";
			this.SaveInFile.Size = new System.Drawing.Size(70, 49);
			this.SaveInFile.TabIndex = 1;
			this.SaveInFile.Text = "Сохранить в файл";
			this.SaveInFile.UseVisualStyleBackColor = false;
			this.SaveInFile.Click += new System.EventHandler(this.SaveInFile_Click);
			// 
			// LoadFromFile
			// 
			this.LoadFromFile.BackColor = System.Drawing.Color.Lime;
			this.LoadFromFile.Location = new System.Drawing.Point(255, 6);
			this.LoadFromFile.Name = "LoadFromFile";
			this.LoadFromFile.Size = new System.Drawing.Size(75, 49);
			this.LoadFromFile.TabIndex = 2;
			this.LoadFromFile.Text = "Загрузить из файла";
			this.LoadFromFile.UseVisualStyleBackColor = false;
			this.LoadFromFile.Click += new System.EventHandler(this.LoadFromFile_Click);
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.DefaultExt = "txt";
			this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.SaveFileDialog1_FileOk);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.DefaultExt = "txt";
			this.openFileDialog1.FileName = "openFileDialog1";
			this.openFileDialog1.Filter = "Текстовые файлы (*.txt)|*.txt";
			this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog1_FileOk);
			// 
			// FormGradesAndTeachers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(668, 587);
			this.Controls.Add(this.LoadFromFile);
			this.Controls.Add(this.SaveInFile);
			this.Controls.Add(this.Классы);
			this.Name = "FormGradesAndTeachers";
			this.Text = "FormGradesAndTeachers";
			this.Load += new System.EventHandler(this.FormGradesAndTeachers_Load);
			this.Классы.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Классы;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckedListBox checkedListBoxOfGrades;
        private System.Windows.Forms.TextBox addGradeTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.CheckedListBox checkedListBoxOfTeachers;
        private System.Windows.Forms.TextBox textBoxAddTeacher;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button MakeSchedlueButton;
        private System.Windows.Forms.Button SaveInFile;
        private System.Windows.Forms.Button LoadFromFile;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
	}
}