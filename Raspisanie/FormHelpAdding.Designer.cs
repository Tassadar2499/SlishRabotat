namespace Raspisanie
{
	partial class FormHelpAdding
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
			this.listOfSubjects = new System.Windows.Forms.CheckedListBox();
			this.button1 = new System.Windows.Forms.Button();
			this.labelClassName = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// listOfSubjects
			// 
			this.listOfSubjects.FormattingEnabled = true;
			this.listOfSubjects.Location = new System.Drawing.Point(12, 91);
			this.listOfSubjects.Name = "listOfSubjects";
			this.listOfSubjects.Size = new System.Drawing.Size(236, 334);
			this.listOfSubjects.TabIndex = 1;
			this.listOfSubjects.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxOfSubjectsSelect);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(292, 462);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "Сохранить";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.SaveClick);
			// 
			// label2
			// 
			this.labelClassName.AutoSize = true;
			this.labelClassName.BackColor = System.Drawing.Color.White;
			this.labelClassName.ForeColor = System.Drawing.Color.Red;
			this.labelClassName.Location = new System.Drawing.Point(12, 38);
			this.labelClassName.Name = "label2";
			this.labelClassName.Size = new System.Drawing.Size(47, 13);
			this.labelClassName.TabIndex = 4;
			this.labelClassName.Text = "Класс - ";
			this.labelClassName.Click += new System.EventHandler(this.LabelClassNameClick);
			// 
			// FormHelpAdding
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(591, 529);
			this.Controls.Add(this.labelClassName);

			this.Controls.Add(this.button1);
			this.Controls.Add(this.listOfSubjects);
			this.Name = "FormHelpAdding";
			this.Text = "FormHelpAdding";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckedListBox listOfSubjects;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label labelClassName;
	}
}