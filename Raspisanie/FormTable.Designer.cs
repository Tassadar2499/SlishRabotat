namespace Raspisanie
{
    partial class FormTable
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
			this.dataGridSubjects = new System.Windows.Forms.DataGridView();
			this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Difficult = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CountAtWeek = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Teacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.textBoxSubjects = new System.Windows.Forms.TextBox();
			this.numericDifficulty = new System.Windows.Forms.NumericUpDown();
			this.numericCountAtWeek = new System.Windows.Forms.NumericUpDown();
			this.textBoxTeacher = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.gradeNameLabel = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.gradesToCopyComboBox = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridSubjects)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericDifficulty)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericCountAtWeek)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridSubjects
			// 
			this.dataGridSubjects.AllowUserToAddRows = false;
			this.dataGridSubjects.AllowUserToDeleteRows = false;
			this.dataGridSubjects.AllowUserToOrderColumns = true;
			this.dataGridSubjects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridSubjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridSubjects.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridSubjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Subject,
            this.Difficult,
            this.CountAtWeek,
            this.Teacher});
			this.dataGridSubjects.Location = new System.Drawing.Point(12, 35);
			this.dataGridSubjects.MultiSelect = false;
			this.dataGridSubjects.Name = "dataGridSubjects";
			this.dataGridSubjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridSubjects.Size = new System.Drawing.Size(714, 397);
			this.dataGridSubjects.TabIndex = 0;
			// 
			// Subject
			// 
			this.Subject.HeaderText = "Предмет";
			this.Subject.Name = "Subject";
			this.Subject.ReadOnly = true;
			// 
			// Difficult
			// 
			this.Difficult.HeaderText = "Сложность";
			this.Difficult.Name = "Difficult";
			this.Difficult.ReadOnly = true;
			// 
			// CountAtWeek
			// 
			this.CountAtWeek.HeaderText = "Количество часов в неделю";
			this.CountAtWeek.Name = "CountAtWeek";
			this.CountAtWeek.ReadOnly = true;
			// 
			// Teacher
			// 
			this.Teacher.HeaderText = "Учитель";
			this.Teacher.Name = "Teacher";
			this.Teacher.ReadOnly = true;
			// 
			// textBoxSubjects
			// 
			this.textBoxSubjects.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxSubjects.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.textBoxSubjects.Location = new System.Drawing.Point(732, 61);
			this.textBoxSubjects.Name = "textBoxSubjects";
			this.textBoxSubjects.Size = new System.Drawing.Size(189, 20);
			this.textBoxSubjects.TabIndex = 1;
			// 
			// numericDifficulty
			// 
			this.numericDifficulty.AllowDrop = true;
			this.numericDifficulty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.numericDifficulty.Location = new System.Drawing.Point(732, 119);
			this.numericDifficulty.Name = "numericDifficulty";
			this.numericDifficulty.Size = new System.Drawing.Size(189, 20);
			this.numericDifficulty.TabIndex = 2;
			// 
			// numericCountAtWeek
			// 
			this.numericCountAtWeek.AllowDrop = true;
			this.numericCountAtWeek.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.numericCountAtWeek.Location = new System.Drawing.Point(732, 177);
			this.numericCountAtWeek.Name = "numericCountAtWeek";
			this.numericCountAtWeek.Size = new System.Drawing.Size(189, 20);
			this.numericCountAtWeek.TabIndex = 3;
			// 
			// textBoxTeacher
			// 
			this.textBoxTeacher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxTeacher.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.textBoxTeacher.Location = new System.Drawing.Point(732, 235);
			this.textBoxTeacher.Name = "textBoxTeacher";
			this.textBoxTeacher.Size = new System.Drawing.Size(189, 20);
			this.textBoxTeacher.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(732, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(116, 23);
			this.label1.TabIndex = 5;
			this.label1.Text = "Предмет";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(732, 93);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(94, 23);
			this.label2.TabIndex = 6;
			this.label2.Text = "Сложность";
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(732, 151);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(123, 23);
			this.label3.TabIndex = 7;
			this.label3.Text = "Часов в неделю";
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.Location = new System.Drawing.Point(732, 261);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(105, 61);
			this.button1.TabIndex = 9;
			this.button1.Text = "Добавить";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Add_Click);
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button2.Location = new System.Drawing.Point(843, 261);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(78, 61);
			this.button2.TabIndex = 10;
			this.button2.Text = "Удалить выделенную строку";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Delete_Click);
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(732, 209);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(116, 23);
			this.label4.TabIndex = 8;
			this.label4.Text = "Учитель";
			// 
			// gradeNameLabel
			// 
			this.gradeNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.gradeNameLabel.Location = new System.Drawing.Point(12, 9);
			this.gradeNameLabel.Name = "gradeNameLabel";
			this.gradeNameLabel.Size = new System.Drawing.Size(116, 23);
			this.gradeNameLabel.TabIndex = 11;
			this.gradeNameLabel.Text = "Класс - ";
			// 
			// button3
			// 
			this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button3.Location = new System.Drawing.Point(732, 365);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(189, 40);
			this.button3.TabIndex = 12;
			this.button3.Text = "Копировать значения из другого класса";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.CopyTheTable_Click);
			// 
			// gradesToCopyComboBox
			// 
			this.gradesToCopyComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.gradesToCopyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.gradesToCopyComboBox.FormattingEnabled = true;
			this.gradesToCopyComboBox.Location = new System.Drawing.Point(732, 411);
			this.gradesToCopyComboBox.Name = "gradesToCopyComboBox";
			this.gradesToCopyComboBox.Size = new System.Drawing.Size(189, 21);
			this.gradesToCopyComboBox.TabIndex = 13;
			// 
			// FormTable
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(931, 438);
			this.Controls.Add(this.gradesToCopyComboBox);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.gradeNameLabel);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxTeacher);
			this.Controls.Add(this.numericCountAtWeek);
			this.Controls.Add(this.numericDifficulty);
			this.Controls.Add(this.textBoxSubjects);
			this.Controls.Add(this.dataGridSubjects);
			this.MinimumSize = new System.Drawing.Size(500, 477);
			this.Name = "FormTable";
			this.Text = "FormTable";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTable_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.dataGridSubjects)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericDifficulty)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericCountAtWeek)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridSubjects;
        private System.Windows.Forms.TextBox textBoxSubjects;
        private System.Windows.Forms.NumericUpDown numericDifficulty;
        private System.Windows.Forms.NumericUpDown numericCountAtWeek;
        private System.Windows.Forms.TextBox textBoxTeacher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label gradeNameLabel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Difficult;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountAtWeek;
        private System.Windows.Forms.DataGridViewTextBoxColumn Teacher;
		private System.Windows.Forms.ComboBox gradesToCopyComboBox;
	}
}