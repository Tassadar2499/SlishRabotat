namespace Raspisanie
{
	partial class FormClassesForTeacher
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
			this.listOfClasses = new System.Windows.Forms.CheckedListBox();
			this.labelTeacher = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// listOfClasses
			// 
			this.listOfClasses.CheckOnClick = true;
			this.listOfClasses.FormattingEnabled = true;
			this.listOfClasses.Location = new System.Drawing.Point(12, 67);
			this.listOfClasses.Name = "listOfClasses";
			this.listOfClasses.Size = new System.Drawing.Size(190, 229);
			this.listOfClasses.TabIndex = 0;
			this.listOfClasses.SelectedIndexChanged += new System.EventHandler(this.CheckedListOfSubjectsSelect);
			// 
			// labelTeacher
			// 
			this.labelTeacher.AutoSize = true;
			this.labelTeacher.Location = new System.Drawing.Point(12, 34);
			this.labelTeacher.Name = "labelTeacher";
			this.labelTeacher.Size = new System.Drawing.Size(58, 13);
			this.labelTeacher.TabIndex = 1;
			this.labelTeacher.Text = "Учитель - ";
			this.labelTeacher.Click += new System.EventHandler(this.LabelTeacherClick);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(264, 283);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 66);
			this.button1.TabIndex = 2;
			this.button1.Text = "Оставить только выбранные классы";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.DeleteClick);
			// 
			// FormClassesForTeacher
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(510, 468);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.labelTeacher);
			this.Controls.Add(this.listOfClasses);
			this.Name = "FormClassesForTeacher";
			this.Text = "FormClassesForTeacher";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckedListBox listOfClasses;
		private System.Windows.Forms.Label labelTeacher;
		private System.Windows.Forms.Button button1;
	}
}