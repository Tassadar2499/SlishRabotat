﻿namespace Raspisanie
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
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.addGradeTextBox = new System.Windows.Forms.TextBox();
			this.listBoxOfGrades = new System.Windows.Forms.ListBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.button7 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.textBoxAddTeacher = new System.Windows.Forms.TextBox();
			this.listBoxOfTeachers = new System.Windows.Forms.ListBox();
			this.SaveInFile = new System.Windows.Forms.Button();
			this.LoadFromFile = new System.Windows.Forms.Button();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.Классы.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// Классы
			// 
			this.Классы.Controls.Add(this.tabPage1);
			this.Классы.Controls.Add(this.tabPage2);
			this.Классы.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Классы.ItemSize = new System.Drawing.Size(150, 50);
			this.Классы.Location = new System.Drawing.Point(0, 0);
			this.Классы.Name = "Классы";
			this.Классы.SelectedIndex = 0;
			this.Классы.Size = new System.Drawing.Size(660, 413);
			this.Классы.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.Color.DarkGray;
			this.tabPage1.Controls.Add(this.MakeSchedlueButton);
			this.tabPage1.Controls.Add(this.button2);
			this.tabPage1.Controls.Add(this.button1);
			this.tabPage1.Controls.Add(this.addGradeTextBox);
			this.tabPage1.Controls.Add(this.listBoxOfGrades);
			this.tabPage1.Location = new System.Drawing.Point(4, 54);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(652, 355);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Классы";
			// 
			// MakeSchedlueButton
			// 
			this.MakeSchedlueButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.MakeSchedlueButton.Location = new System.Drawing.Point(494, 292);
			this.MakeSchedlueButton.Name = "MakeSchedlueButton";
			this.MakeSchedlueButton.Size = new System.Drawing.Size(152, 60);
			this.MakeSchedlueButton.TabIndex = 5;
			this.MakeSchedlueButton.Text = "Сформировать расписание";
			this.MakeSchedlueButton.UseVisualStyleBackColor = true;
			this.MakeSchedlueButton.Click += new System.EventHandler(this.MakeSchedlueButton_Click);
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button2.Location = new System.Drawing.Point(575, 35);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(71, 36);
			this.button2.TabIndex = 2;
			this.button2.Text = "Удалить";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.DeleteSelectingGrades_Click);
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.Location = new System.Drawing.Point(494, 35);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 36);
			this.button1.TabIndex = 1;
			this.button1.Text = "Добавить";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.AddNewGrade_Click);
			// 
			// addGradeTextBox
			// 
			this.addGradeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.addGradeTextBox.Location = new System.Drawing.Point(494, 4);
			this.addGradeTextBox.Multiline = true;
			this.addGradeTextBox.Name = "addGradeTextBox";
			this.addGradeTextBox.Size = new System.Drawing.Size(152, 25);
			this.addGradeTextBox.TabIndex = 1;
			// 
			// listBoxOfGrades
			// 
			this.listBoxOfGrades.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listBoxOfGrades.FormattingEnabled = true;
			this.listBoxOfGrades.IntegralHeight = false;
			this.listBoxOfGrades.Location = new System.Drawing.Point(3, 3);
			this.listBoxOfGrades.Name = "listBoxOfGrades";
			this.listBoxOfGrades.Size = new System.Drawing.Size(485, 349);
			this.listBoxOfGrades.TabIndex = 0;
			// 
			// tabPage2
			// 
			this.tabPage2.BackColor = System.Drawing.Color.DarkGray;
			this.tabPage2.Controls.Add(this.button7);
			this.tabPage2.Controls.Add(this.button6);
			this.tabPage2.Controls.Add(this.textBoxAddTeacher);
			this.tabPage2.Controls.Add(this.listBoxOfTeachers);
			this.tabPage2.Location = new System.Drawing.Point(4, 54);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(652, 355);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Учителя";
			// 
			// button7
			// 
			this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button7.Location = new System.Drawing.Point(575, 35);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(71, 36);
			this.button7.TabIndex = 3;
			this.button7.Text = "Удалить";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.DeleteSelectingTeachers_Click);
			// 
			// button6
			// 
			this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button6.Location = new System.Drawing.Point(494, 35);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(75, 36);
			this.button6.TabIndex = 2;
			this.button6.Text = "Добавить";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.AddTeacher_Click);
			// 
			// textBoxAddTeacher
			// 
			this.textBoxAddTeacher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxAddTeacher.Location = new System.Drawing.Point(494, 4);
			this.textBoxAddTeacher.Multiline = true;
			this.textBoxAddTeacher.Name = "textBoxAddTeacher";
			this.textBoxAddTeacher.Size = new System.Drawing.Size(152, 25);
			this.textBoxAddTeacher.TabIndex = 1;
			// 
			// listBoxOfTeachers
			// 
			this.listBoxOfTeachers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listBoxOfTeachers.FormattingEnabled = true;
			this.listBoxOfTeachers.IntegralHeight = false;
			this.listBoxOfTeachers.Location = new System.Drawing.Point(3, 3);
			this.listBoxOfTeachers.Name = "listBoxOfTeachers";
			this.listBoxOfTeachers.Size = new System.Drawing.Size(485, 349);
			this.listBoxOfTeachers.Sorted = true;
			this.listBoxOfTeachers.TabIndex = 0;
			// 
			// SaveInFile
			// 
			this.SaveInFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.SaveInFile.BackColor = System.Drawing.Color.Teal;
			this.SaveInFile.Location = new System.Drawing.Point(498, 2);
			this.SaveInFile.Name = "SaveInFile";
			this.SaveInFile.Size = new System.Drawing.Size(75, 50);
			this.SaveInFile.TabIndex = 1;
			this.SaveInFile.Text = "Сохранить в файл";
			this.SaveInFile.UseVisualStyleBackColor = true;
			this.SaveInFile.Click += new System.EventHandler(this.SaveInFile_Click);
			// 
			// LoadFromFile
			// 
			this.LoadFromFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.LoadFromFile.BackColor = System.Drawing.Color.DarkGray;
			this.LoadFromFile.Location = new System.Drawing.Point(580, 2);
			this.LoadFromFile.Name = "LoadFromFile";
			this.LoadFromFile.Size = new System.Drawing.Size(75, 50);
			this.LoadFromFile.TabIndex = 2;
			this.LoadFromFile.Text = "Загрузить из файла";
			this.LoadFromFile.UseVisualStyleBackColor = true;
			this.LoadFromFile.Click += new System.EventHandler(this.LoadFromFile_Click);
			// 
			// saveFileDialog
			// 
			this.saveFileDialog.DefaultExt = "txt";
			this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.SaveFileDialog_FileOk);
			// 
			// openFileDialog
			// 
			this.openFileDialog.DefaultExt = "txt";
			this.openFileDialog.FileName = "openFileDialog1";
			this.openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt";
			this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog_FileOk);
			// 
			// FormGradesAndTeachers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(660, 413);
			this.Controls.Add(this.LoadFromFile);
			this.Controls.Add(this.SaveInFile);
			this.Controls.Add(this.Классы);
			this.Name = "FormGradesAndTeachers";
			this.Text = "FormGradesAndTeachers";
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
        public System.Windows.Forms.ListBox listBoxOfTeachers;
        private System.Windows.Forms.ListBox listBoxOfGrades;
        private System.Windows.Forms.TextBox addGradeTextBox;
        private System.Windows.Forms.TextBox textBoxAddTeacher;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button MakeSchedlueButton;
        private System.Windows.Forms.Button SaveInFile;
        private System.Windows.Forms.Button LoadFromFile;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
	}
}