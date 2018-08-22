namespace Raspisanie
{
    partial class FormOutput
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
            this.TabSchedlue = new System.Windows.Forms.TabControl();
            this.tabPageGrades = new System.Windows.Forms.TabPage();
            this.gradesListBox = new System.Windows.Forms.ListBox();
            this.tabPageTeachers = new System.Windows.Forms.TabPage();
            this.teachersListBox = new System.Windows.Forms.ListBox();
            this.TabSchedlue.SuspendLayout();
            this.tabPageGrades.SuspendLayout();
            this.tabPageTeachers.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabSchedlue
            // 
            this.TabSchedlue.Controls.Add(this.tabPageGrades);
            this.TabSchedlue.Controls.Add(this.tabPageTeachers);
            this.TabSchedlue.Location = new System.Drawing.Point(0, 0);
            this.TabSchedlue.Name = "TabSchedlue";
            this.TabSchedlue.SelectedIndex = 0;
            this.TabSchedlue.Size = new System.Drawing.Size(796, 446);
            this.TabSchedlue.TabIndex = 0;
            // 
            // tabPageGrades
            // 
            this.tabPageGrades.Controls.Add(this.gradesListBox);
            this.tabPageGrades.Location = new System.Drawing.Point(4, 22);
            this.tabPageGrades.Name = "tabPageGrades";
            this.tabPageGrades.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGrades.Size = new System.Drawing.Size(788, 420);
            this.tabPageGrades.TabIndex = 0;
            this.tabPageGrades.Text = "Классы";
            this.tabPageGrades.UseVisualStyleBackColor = true;
            // 
            // listOfGrades
            // 
            this.gradesListBox.FormattingEnabled = true;
            this.gradesListBox.Location = new System.Drawing.Point(6, 6);
            this.gradesListBox.MultiColumn = true;
            this.gradesListBox.Name = "listOfGrades";
            this.gradesListBox.Size = new System.Drawing.Size(280, 407);
            this.gradesListBox.TabIndex = 0;
            // 
            // tabPageTeachers
            // 
            this.tabPageTeachers.Controls.Add(this.teachersListBox);
            this.tabPageTeachers.Location = new System.Drawing.Point(4, 22);
            this.tabPageTeachers.Name = "tabPageTeachers";
            this.tabPageTeachers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTeachers.Size = new System.Drawing.Size(788, 420);
            this.tabPageTeachers.TabIndex = 1;
            this.tabPageTeachers.Text = "Учителя";
            this.tabPageTeachers.UseVisualStyleBackColor = true;
            // 
            // listBoxOfTeachers
            // 
            this.teachersListBox.FormattingEnabled = true;
            this.teachersListBox.Location = new System.Drawing.Point(8, 8);
            this.teachersListBox.Name = "listBoxOfTeachers";
            this.teachersListBox.Size = new System.Drawing.Size(257, 394);
            this.teachersListBox.TabIndex = 0;
            // 
            // FormOutput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TabSchedlue);
            this.Name = "FormOutput";
            this.Text = "FormOutput";
            this.TabSchedlue.ResumeLayout(false);
            this.tabPageGrades.ResumeLayout(false);
            this.tabPageTeachers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabSchedlue;
        private System.Windows.Forms.TabPage tabPageGrades;
        private System.Windows.Forms.TabPage tabPageTeachers;
        private System.Windows.Forms.ListBox gradesListBox;
        private System.Windows.Forms.ListBox teachersListBox;
    }
}