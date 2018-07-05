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
			this.checkedListBoxOfSubjects = new System.Windows.Forms.CheckedListBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.addedSubject = new System.Windows.Forms.TextBox();
			this.button7 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// checkedListBoxOfSubjects
			// 
			this.checkedListBoxOfSubjects.FormattingEnabled = true;
			this.checkedListBoxOfSubjects.Location = new System.Drawing.Point(0, 0);
			this.checkedListBoxOfSubjects.Name = "checkedListBoxOfSubjects";
			this.checkedListBoxOfSubjects.Size = new System.Drawing.Size(214, 454);
			this.checkedListBoxOfSubjects.TabIndex = 1;
			this.checkedListBoxOfSubjects.SelectedIndexChanged += new System.EventHandler(this.CheckedListBox1_SelectedIndexChanged);
			// 
			// button2
			// 
			this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button2.Location = new System.Drawing.Point(404, 442);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 2;
			this.button2.Text = "Далее";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.NextClick);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(245, 222);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(93, 51);
			this.button3.TabIndex = 3;
			this.button3.Text = "Отсортировать по алфавиту";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.SortingByAlphabet);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(245, 442);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 4;
			this.button4.Text = "Назад";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.GoToPreviousFormClick);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(404, 70);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 66);
			this.button1.TabIndex = 5;
			this.button1.Text = "Добавить предметы по умолчанию";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.AddDefaultSubjectsClick);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(404, 142);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(75, 40);
			this.button5.TabIndex = 6;
			this.button5.Text = "Отменить добавление";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.DeleteDefaultSubjectsClick);
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(404, 236);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(75, 66);
			this.button6.TabIndex = 7;
			this.button6.Text = "Удалить выбранные предметы";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.DeleteCheckedSubjectsClick);
			// 
			// addedSubject
			// 
			this.addedSubject.Location = new System.Drawing.Point(238, 38);
			this.addedSubject.Name = "addedSubject";
			this.addedSubject.Size = new System.Drawing.Size(100, 20);
			this.addedSubject.TabIndex = 8;
			this.addedSubject.TextChanged += new System.EventHandler(this.textAddSubject);
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(263, 81);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(75, 34);
			this.button7.TabIndex = 9;
			this.button7.Text = "Добавить предмет";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.AddNewSubjectClick);
			// 
			// FormAddSubjects
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(491, 477);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.addedSubject);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.checkedListBoxOfSubjects);
			this.Name = "FormAddSubjects";
			this.Text = "addSubjects";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.CheckedListBox checkedListBoxOfSubjects;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.TextBox addedSubject;
		private System.Windows.Forms.Button button7;
	}
}