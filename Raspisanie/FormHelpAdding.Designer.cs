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
			this.labelClassName = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// listOfSubjects
			// 
			this.listOfSubjects.CheckOnClick = true;
			this.listOfSubjects.FormattingEnabled = true;
			this.listOfSubjects.Location = new System.Drawing.Point(12, 91);
			this.listOfSubjects.Name = "listOfSubjects";
			this.listOfSubjects.Size = new System.Drawing.Size(236, 334);
			this.listOfSubjects.TabIndex = 1;
			this.listOfSubjects.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxOfSubjectsSelect);
			// 
			// labelClassName
			// 
			this.labelClassName.AutoSize = true;
			this.labelClassName.BackColor = System.Drawing.Color.White;
			this.labelClassName.ForeColor = System.Drawing.Color.Red;
			this.labelClassName.Location = new System.Drawing.Point(12, 38);
			this.labelClassName.Name = "labelClassName";
			this.labelClassName.Size = new System.Drawing.Size(47, 13);
			this.labelClassName.TabIndex = 4;
			this.labelClassName.Text = "Класс - ";
			this.labelClassName.Click += new System.EventHandler(this.LabelClassNameClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 75);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Предмет";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(282, 437);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 49);
			this.button2.TabIndex = 6;
			this.button2.Text = "Удалить выбранные предметы";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.DeleteClick);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(270, 112);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 164);
			this.label2.TabIndex = 7;
			this.label2.Text = "Двойной клик по каждому из предметов, чтобы установить сложность и количество час" +
    "ов в неделю";
			this.label2.Click += new System.EventHandler(this.TextClick);
			// 
			// FormHelpAdding
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Aqua;
			this.ClientSize = new System.Drawing.Size(447, 529);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.labelClassName);
			this.Controls.Add(this.listOfSubjects);
			this.Name = "FormHelpAdding";
			this.Text = "FormHelpAdding";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormHelpAdding_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckedListBox listOfSubjects;
		private System.Windows.Forms.Label labelClassName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label2;
	}
}