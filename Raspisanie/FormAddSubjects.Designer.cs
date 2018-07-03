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
			this.button1 = new System.Windows.Forms.Button();
			this.checkedListBoxOfSubjects = new System.Windows.Forms.CheckedListBox();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.Location = new System.Drawing.Point(261, 431);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Сохранить";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.SaveClick);
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
			this.button2.Location = new System.Drawing.Point(370, 431);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 2;
			this.button2.Text = "Что вышло";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.ShowClick);
			// 
			// formaAddSubjects
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(491, 477);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.checkedListBoxOfSubjects);
			this.Controls.Add(this.button1);
			this.Name = "formaAddSubjects";
			this.Text = "addSubjects";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.CheckedListBox checkedListBoxOfSubjects;
		private System.Windows.Forms.Button button2;
	}
}