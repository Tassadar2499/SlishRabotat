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
            this.textBoxTeacher = new System.Windows.Forms.TextBox();
            this.numericDifficulty = new System.Windows.Forms.NumericUpDown();
            this.numericCountAtWeek = new System.Windows.Forms.NumericUpDown();
            this.textBoxSubject = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.GradeName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSubjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDifficulty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCountAtWeek)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridSubjects
            // 
            this.dataGridSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSubjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Subject,
            this.Difficult,
            this.CountAtWeek,
            this.Teacher});
            this.dataGridSubjects.Location = new System.Drawing.Point(48, 71);
            this.dataGridSubjects.Name = "dataGridSubjects";
            this.dataGridSubjects.Size = new System.Drawing.Size(583, 289);
            this.dataGridSubjects.TabIndex = 0;
            this.dataGridSubjects.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewSubjects_CellContentClick);
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
            // textBoxTeacher
            // 
            this.textBoxTeacher.Location = new System.Drawing.Point(45, 365);
            this.textBoxTeacher.Multiline = true;
            this.textBoxTeacher.Name = "textBoxTeacher";
            this.textBoxTeacher.Size = new System.Drawing.Size(116, 21);
            this.textBoxTeacher.TabIndex = 1;
            this.textBoxTeacher.TextChanged += new System.EventHandler(this.TextBoxSubject_Change);
            // 
            // numericDifficulty
            // 
            this.numericDifficulty.Location = new System.Drawing.Point(182, 366);
            this.numericDifficulty.Name = "numericDifficulty";
            this.numericDifficulty.Size = new System.Drawing.Size(109, 20);
            this.numericDifficulty.TabIndex = 2;
            this.numericDifficulty.ValueChanged += new System.EventHandler(this.NumericDifficulty_Change);
            // 
            // numericCountAtWeek
            // 
            this.numericCountAtWeek.Location = new System.Drawing.Point(313, 365);
            this.numericCountAtWeek.Name = "numericCountAtWeek";
            this.numericCountAtWeek.Size = new System.Drawing.Size(120, 20);
            this.numericCountAtWeek.TabIndex = 3;
            this.numericCountAtWeek.ValueChanged += new System.EventHandler(this.NumericCountAtWeek_Change);
            // 
            // textBoxSubject
            // 
            this.textBoxSubject.Location = new System.Drawing.Point(473, 364);
            this.textBoxSubject.Name = "textBoxSubject";
            this.textBoxSubject.Size = new System.Drawing.Size(105, 20);
            this.textBoxSubject.TabIndex = 4;
            this.textBoxSubject.TextChanged += new System.EventHandler(this.TextBoxTeacher_Change);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(45, 389);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Предмет";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(179, 389);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Сложность";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(317, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 52);
            this.label3.TabIndex = 7;
            this.label3.Text = "Количество часов в неделе";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(592, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 51);
            this.button1.TabIndex = 9;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Add_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(652, 243);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 54);
            this.button2.TabIndex = 10;
            this.button2.Text = "Удалить выделенную строку";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Delete_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(470, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Учитель";
            // 
            // GradeName
            // 
            this.GradeName.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.GradeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GradeName.Location = new System.Drawing.Point(12, 18);
            this.GradeName.Name = "GradeName";
            this.GradeName.Size = new System.Drawing.Size(116, 23);
            this.GradeName.TabIndex = 11;
            this.GradeName.Text = "Класс - ";
            // 
            // FormTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GradeName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSubject);
            this.Controls.Add(this.numericCountAtWeek);
            this.Controls.Add(this.numericDifficulty);
            this.Controls.Add(this.textBoxTeacher);
            this.Controls.Add(this.dataGridSubjects);
            this.Name = "FormTable";
            this.Text = "FormTable";
            this.Load += new System.EventHandler(this.FormTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSubjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDifficulty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCountAtWeek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridSubjects;
        private System.Windows.Forms.TextBox textBoxTeacher;
        private System.Windows.Forms.NumericUpDown numericDifficulty;
        private System.Windows.Forms.NumericUpDown numericCountAtWeek;
        private System.Windows.Forms.TextBox textBoxSubject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Difficult;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountAtWeek;
        private System.Windows.Forms.DataGridViewTextBoxColumn Teacher;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label GradeName;
    }
}