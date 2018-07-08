namespace Raspisanie
{
	partial class FormAddSubjects
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
			this.subjectsCheckedListBox = new System.Windows.Forms.CheckedListBox();
			this.nextButton = new System.Windows.Forms.Button();
			this.sortByAlpButton = new System.Windows.Forms.Button();
			this.prewButton = new System.Windows.Forms.Button();
			this.addDefaultSubjectButton = new System.Windows.Forms.Button();
			this.deleteDefaultSubject = new System.Windows.Forms.Button();
			this.deleteCheckedButton = new System.Windows.Forms.Button();
			this.subjectTextBox = new System.Windows.Forms.TextBox();
			this.addSubjectButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// checkedListBoxOfSubjects
			// 
			this.subjectsCheckedListBox.FormattingEnabled = true;
			this.subjectsCheckedListBox.Location = new System.Drawing.Point(0, 0);
			this.subjectsCheckedListBox.Name = "checkedListBoxOfSubjects";
			this.subjectsCheckedListBox.Size = new System.Drawing.Size(214, 454);
			this.subjectsCheckedListBox.TabIndex = 1;
			this.subjectsCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.CheckedListBox1_SelectedIndexChanged);
			// 
			// NextButton
			// 
			this.nextButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.nextButton.Location = new System.Drawing.Point(404, 442);
			this.nextButton.Name = "NextButton";
			this.nextButton.Size = new System.Drawing.Size(75, 23);
			this.nextButton.TabIndex = 2;
			this.nextButton.Text = "Далее";
			this.nextButton.UseVisualStyleBackColor = true;
			this.nextButton.Click += new System.EventHandler(this.NextClick);
			// 
			// SortByAlpButton
			// 
			this.sortByAlpButton.Location = new System.Drawing.Point(245, 222);
			this.sortByAlpButton.Name = "SortByAlpButton";
			this.sortByAlpButton.Size = new System.Drawing.Size(93, 51);
			this.sortByAlpButton.TabIndex = 3;
			this.sortByAlpButton.Text = "Отсортировать по алфавиту";
			this.sortByAlpButton.UseVisualStyleBackColor = true;
			this.sortByAlpButton.Click += new System.EventHandler(this.SortingByAlphabet);
			// 
			// PrewButton
			// 
			this.prewButton.Location = new System.Drawing.Point(245, 442);
			this.prewButton.Name = "PrewButton";
			this.prewButton.Size = new System.Drawing.Size(75, 23);
			this.prewButton.TabIndex = 4;
			this.prewButton.Text = "Назад";
			this.prewButton.UseVisualStyleBackColor = true;
			this.prewButton.Click += new System.EventHandler(this.GoToPreviousFormClick);
			// 
			// AddDefaultSubjectButton
			// 
			this.addDefaultSubjectButton.Location = new System.Drawing.Point(404, 70);
			this.addDefaultSubjectButton.Name = "AddDefaultSubjectButton";
			this.addDefaultSubjectButton.Size = new System.Drawing.Size(75, 66);
			this.addDefaultSubjectButton.TabIndex = 5;
			this.addDefaultSubjectButton.Text = "Добавить предметы по умолчанию";
			this.addDefaultSubjectButton.UseVisualStyleBackColor = true;
			this.addDefaultSubjectButton.Click += new System.EventHandler(this.AddDefaultSubjectsClick);
			// 
			// DeleteDefaultSubject
			// 
			this.deleteDefaultSubject.Location = new System.Drawing.Point(404, 142);
			this.deleteDefaultSubject.Name = "DeleteDefaultSubject";
			this.deleteDefaultSubject.Size = new System.Drawing.Size(75, 40);
			this.deleteDefaultSubject.TabIndex = 6;
			this.deleteDefaultSubject.Text = "Отменить добавление";
			this.deleteDefaultSubject.UseVisualStyleBackColor = true;
			this.deleteDefaultSubject.Click += new System.EventHandler(this.DeleteDefaultSubjectsClick);
			// 
			// DeleteCheckedButton
			// 
			this.deleteCheckedButton.Location = new System.Drawing.Point(404, 236);
			this.deleteCheckedButton.Name = "DeleteCheckedButton";
			this.deleteCheckedButton.Size = new System.Drawing.Size(75, 66);
			this.deleteCheckedButton.TabIndex = 7;
			this.deleteCheckedButton.Text = "Удалить выбранные предметы";
			this.deleteCheckedButton.UseVisualStyleBackColor = true;
			this.deleteCheckedButton.Click += new System.EventHandler(this.DeleteCheckedSubjectsClick);
			// 
			// addedSubject
			// 
			this.subjectTextBox.Location = new System.Drawing.Point(238, 38);
			this.subjectTextBox.Name = "addedSubject";
			this.subjectTextBox.Size = new System.Drawing.Size(100, 20);
			this.subjectTextBox.TabIndex = 8;
			this.subjectTextBox.TextChanged += new System.EventHandler(this.TextAddSubject);
			// 
			// AddSubjectButton
			// 
			this.addSubjectButton.Location = new System.Drawing.Point(263, 81);
			this.addSubjectButton.Name = "AddSubjectButton";
			this.addSubjectButton.Size = new System.Drawing.Size(75, 34);
			this.addSubjectButton.TabIndex = 9;
			this.addSubjectButton.Text = "Добавить предмет";
			this.addSubjectButton.UseVisualStyleBackColor = true;
			this.addSubjectButton.Click += new System.EventHandler(this.AddNewSubjectClick);
			// 
			// FormAddSubjects
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(491, 477);
			this.Controls.Add(this.addSubjectButton);
			this.Controls.Add(this.subjectTextBox);
			this.Controls.Add(this.deleteCheckedButton);
			this.Controls.Add(this.deleteDefaultSubject);
			this.Controls.Add(this.addDefaultSubjectButton);
			this.Controls.Add(this.prewButton);
			this.Controls.Add(this.sortByAlpButton);
			this.Controls.Add(this.nextButton);
			this.Controls.Add(this.subjectsCheckedListBox);
			this.Name = "FormAddSubjects";
			this.Text = "addSubjects";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.CheckedListBox subjectsCheckedListBox;
		private System.Windows.Forms.TextBox subjectTextBox;
		private System.Windows.Forms.Button addDefaultSubjectButton;
		private System.Windows.Forms.Button nextButton;
		private System.Windows.Forms.Button sortByAlpButton;
		private System.Windows.Forms.Button prewButton;
		private System.Windows.Forms.Button deleteDefaultSubject;
		private System.Windows.Forms.Button deleteCheckedButton;
		private System.Windows.Forms.Button addSubjectButton;
	}
}