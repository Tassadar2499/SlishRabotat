namespace Raspisanie
{
	partial class FormSubjectsForTeacher
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
			this.labelClass = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// checkedListBoxOfSubjects
			// 
			this.checkedListBoxOfSubjects.CheckOnClick = true;
			this.checkedListBoxOfSubjects.FormattingEnabled = true;
			this.checkedListBoxOfSubjects.Location = new System.Drawing.Point(22, 74);
			this.checkedListBoxOfSubjects.Name = "checkedListBoxOfSubjects";
			this.checkedListBoxOfSubjects.Size = new System.Drawing.Size(265, 259);
			this.checkedListBoxOfSubjects.TabIndex = 0;
			this.checkedListBoxOfSubjects.SelectedIndexChanged += new System.EventHandler(this.CheckedListBoxOfSubjectsSelect);
			// 
			// labelClass
			// 
			this.labelClass.AutoSize = true;
			this.labelClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.labelClass.Location = new System.Drawing.Point(19, 32);
			this.labelClass.Name = "labelClass";
			this.labelClass.Size = new System.Drawing.Size(64, 16);
			this.labelClass.TabIndex = 1;
			this.labelClass.Text = "Класс - ";
			this.labelClass.Click += new System.EventHandler(this.LabelClassClick);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(201, 355);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(86, 60);
			this.button1.TabIndex = 2;
			this.button1.Text = "Сохранить выбранные предметы";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.SaveClick);
			// 
			// FormSubjectsForTeacher
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(350, 450);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.labelClass);
			this.Controls.Add(this.checkedListBoxOfSubjects);
			this.Name = "FormSubjectsForTeacher";
			this.Text = "SubjectsForTeacher";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSubjectsForTeacher_FormClosing);
			this.Load += new System.EventHandler(this.FormSubjectsForTeacher_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckedListBox checkedListBoxOfSubjects;
		private System.Windows.Forms.Label labelClass;
		private System.Windows.Forms.Button button1;
	}
}