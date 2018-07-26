namespace Raspisanie
{
	partial class FormAddGrades
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
            this.classesCheckedList = new System.Windows.Forms.CheckedListBox();
            this.nextButton = new System.Windows.Forms.Button();
            this.addDefaultClassesButton = new System.Windows.Forms.Button();
            this.addClassTextBox = new System.Windows.Forms.TextBox();
            this.addClassButton = new System.Windows.Forms.Button();
            this.deleteCheckedClassesButton = new System.Windows.Forms.Button();
            this.deleteDefaultClassesButton = new System.Windows.Forms.Button();
            this.sortByNumberButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // classesCheckedList
            // 
            this.classesCheckedList.CheckOnClick = true;
            this.classesCheckedList.Cursor = System.Windows.Forms.Cursors.Default;
            this.classesCheckedList.FormattingEnabled = true;
            this.classesCheckedList.Location = new System.Drawing.Point(0, 47);
            this.classesCheckedList.MultiColumn = true;
            this.classesCheckedList.Name = "classesCheckedList";
            this.classesCheckedList.Size = new System.Drawing.Size(522, 379);
            this.classesCheckedList.TabIndex = 0;
            // 
            // nextButton
            // 
            this.nextButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextButton.Location = new System.Drawing.Point(682, 432);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(100, 31);
            this.nextButton.TabIndex = 3;
            this.nextButton.Text = "Далее";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.NextClick);
            // 
            // addDefaultClassesButton
            // 
            this.addDefaultClassesButton.Location = new System.Drawing.Point(582, 432);
            this.addDefaultClassesButton.Name = "addDefaultClassesButton";
            this.addDefaultClassesButton.Size = new System.Drawing.Size(95, 51);
            this.addDefaultClassesButton.TabIndex = 4;
            this.addDefaultClassesButton.Text = "Добавить классы по умолчанию";
            this.addDefaultClassesButton.UseVisualStyleBackColor = true;
            this.addDefaultClassesButton.Click += new System.EventHandler(this.AddDefaultGradesClick);
            // 
            // addClassTextBox
            // 
            this.addClassTextBox.Location = new System.Drawing.Point(0, 432);
            this.addClassTextBox.Multiline = true;
            this.addClassTextBox.Name = "addClassTextBox";
            this.addClassTextBox.Size = new System.Drawing.Size(158, 24);
            this.addClassTextBox.TabIndex = 5;
            this.addClassTextBox.TextChanged += new System.EventHandler(this.TextAddClass);
            // 
            // addClassButton
            // 
            this.addClassButton.Location = new System.Drawing.Point(164, 432);
            this.addClassButton.Name = "addClassButton";
            this.addClassButton.Size = new System.Drawing.Size(109, 24);
            this.addClassButton.TabIndex = 6;
            this.addClassButton.Text = "Добавить класс";
            this.addClassButton.UseVisualStyleBackColor = true;
            this.addClassButton.Click += new System.EventHandler(this.AddNewClassClick);
            // 
            // deleteCheckedClassesButton
            // 
            this.deleteCheckedClassesButton.Location = new System.Drawing.Point(279, 432);
            this.deleteCheckedClassesButton.Name = "deleteCheckedClassesButton";
            this.deleteCheckedClassesButton.Size = new System.Drawing.Size(95, 51);
            this.deleteCheckedClassesButton.TabIndex = 7;
            this.deleteCheckedClassesButton.Text = "Удалить выбранные классы";
            this.deleteCheckedClassesButton.UseVisualStyleBackColor = true;
            this.deleteCheckedClassesButton.Click += new System.EventHandler(this.DeleteCheckedClassesClick);
            // 
            // deleteDefaultClassesButton
            // 
            this.deleteDefaultClassesButton.Location = new System.Drawing.Point(481, 432);
            this.deleteDefaultClassesButton.Name = "deleteDefaultClassesButton";
            this.deleteDefaultClassesButton.Size = new System.Drawing.Size(95, 51);
            this.deleteDefaultClassesButton.TabIndex = 8;
            this.deleteDefaultClassesButton.Text = "Отменить добавление";
            this.deleteDefaultClassesButton.UseVisualStyleBackColor = true;
            this.deleteDefaultClassesButton.Click += new System.EventHandler(this.DeleteDefaultGradesClick);
            // 
            // sortByNumberButton
            // 
            this.sortByNumberButton.Location = new System.Drawing.Point(380, 432);
            this.sortByNumberButton.Name = "sortByNumberButton";
            this.sortByNumberButton.Size = new System.Drawing.Size(95, 51);
            this.sortByNumberButton.TabIndex = 9;
            this.sortByNumberButton.Text = "Отсортировать по номеру";
            this.sortByNumberButton.UseVisualStyleBackColor = true;
            this.sortByNumberButton.Click += new System.EventHandler(this.SortingByNumberClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 460);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.PreviousFormClick);
            // 
            // label1
            // 
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(525, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 125);
            this.label1.TabIndex = 12;
            this.label1.Text = "Двойной клик по каждому из классов, чтобы установить предметы";
            this.label1.Click += new System.EventHandler(this.TextFieldClick);
            // 
            // FormAddGrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(796, 520);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sortByNumberButton);
            this.Controls.Add(this.deleteDefaultClassesButton);
            this.Controls.Add(this.deleteCheckedClassesButton);
            this.Controls.Add(this.addClassButton);
            this.Controls.Add(this.addClassTextBox);
            this.Controls.Add(this.addDefaultClassesButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.classesCheckedList);
            this.Name = "FormAddGrades";
            this.Text = "Добавить классы";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAddGrades_FormClosing);
            this.Load += new System.EventHandler(this.FormAddGrades_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckedListBox classesCheckedList;
		private System.Windows.Forms.TextBox addClassTextBox;
		private System.Windows.Forms.Button addDefaultClassesButton;
		private System.Windows.Forms.Button addClassButton;
		private System.Windows.Forms.Button nextButton;
		private System.Windows.Forms.Button deleteCheckedClassesButton;
		private System.Windows.Forms.Button deleteDefaultClassesButton;
		private System.Windows.Forms.Button sortByNumberButton;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
	}
}