namespace Raspisanie
{
	partial class FormAddTeacher
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
			this.checkedListOfTeachers = new System.Windows.Forms.CheckedListBox();
			this.button1 = new System.Windows.Forms.Button();
			this.textBoxTeacher = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// checkedListOfTeachers
			// 
			this.checkedListOfTeachers.CheckOnClick = true;
			this.checkedListOfTeachers.FormattingEnabled = true;
			this.checkedListOfTeachers.Location = new System.Drawing.Point(12, 28);
			this.checkedListOfTeachers.Name = "checkedListOfTeachers";
			this.checkedListOfTeachers.Size = new System.Drawing.Size(289, 334);
			this.checkedListOfTeachers.TabIndex = 0;
			this.checkedListOfTeachers.SelectedIndexChanged += new System.EventHandler(this.CheckedListOfTeachersClick);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(333, 305);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 66);
			this.button1.TabIndex = 1;
			this.button1.Text = "Добавить Учителя";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.AddTeacherClick);
			// 
			// textBoxTeacher
			// 
			this.textBoxTeacher.Location = new System.Drawing.Point(333, 256);
			this.textBoxTeacher.Multiline = true;
			this.textBoxTeacher.Name = "textBoxTeacher";
			this.textBoxTeacher.Size = new System.Drawing.Size(129, 43);
			this.textBoxTeacher.TabIndex = 2;
			this.textBoxTeacher.TextChanged += new System.EventHandler(this.TextingTeacher);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(429, 310);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 57);
			this.button2.TabIndex = 3;
			this.button2.Text = "Удалить выбранных учителей";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.DeletingTeachersClick);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(341, 377);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(107, 61);
			this.button3.TabIndex = 4;
			this.button3.Text = "Отсортировать в алфавитном порядке";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.SortingByAlphabetClick);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(454, 415);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 5;
			this.button4.Text = "Сохранить";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.SaveClick);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(338, 93);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(104, 126);
			this.label1.TabIndex = 6;
			this.label1.Text = "Жми на сохранить, а потом двойной клик по учителю";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// FormAddTeacher
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(539, 450);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.textBoxTeacher);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.checkedListOfTeachers);
			this.Name = "FormAddTeacher";
			this.Text = "FormAddTeacher";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAddTeacher_FormClosing);
			this.Load += new System.EventHandler(this.FormAddTeacher_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckedListBox checkedListOfTeachers;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBoxTeacher;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label label1;
	}
}