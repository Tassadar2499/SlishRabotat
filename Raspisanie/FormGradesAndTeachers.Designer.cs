namespace Raspisanie
{
    partial class FormGradesAndTeachers
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
            this.Классы = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkedListBoxOfGrades = new System.Windows.Forms.CheckedListBox();
            this.Классы.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Классы
            // 
            this.Классы.Controls.Add(this.tabPage1);
            this.Классы.Controls.Add(this.tabPage2);
            this.Классы.ItemSize = new System.Drawing.Size(150, 50);
            this.Классы.Location = new System.Drawing.Point(0, 0);
            this.Классы.Name = "Классы";
            this.Классы.SelectedIndex = 0;
            this.Классы.Size = new System.Drawing.Size(916, 544);
            this.Классы.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage1.Controls.Add(this.checkedListBoxOfGrades);
            this.tabPage1.Location = new System.Drawing.Point(4, 54);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(908, 486);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Классы";
            this.tabPage1.Click += new System.EventHandler(this.TabPageGrades);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage2.Location = new System.Drawing.Point(4, 54);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(908, 486);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Учителя";
            this.tabPage2.Click += new System.EventHandler(this.TabPageTeachers);
            // 
            // checkedListBox1
            // 
            this.checkedListBoxOfGrades.FormattingEnabled = true;
            this.checkedListBoxOfGrades.Location = new System.Drawing.Point(8, 8);
            this.checkedListBoxOfGrades.Name = "checkedListBox1";
            this.checkedListBoxOfGrades.Size = new System.Drawing.Size(378, 349);
            this.checkedListBoxOfGrades.TabIndex = 0;
            this.checkedListBoxOfGrades.SelectedIndexChanged += new System.EventHandler(this.CheckedListBoxOfGradesSelectingItem);
            // 
            // FormGradesAndTeachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 543);
            this.Controls.Add(this.Классы);
            this.Name = "FormGradesAndTeachers";
            this.Text = "FormGradesAndTeachers";
            this.Load += new System.EventHandler(this.FormGradesAndTeachers_Load);
            this.Классы.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Классы;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckedListBox checkedListBoxOfGrades;
    }
}