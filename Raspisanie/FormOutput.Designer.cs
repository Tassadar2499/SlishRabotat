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
            this.SaveClassesToHTML = new System.Windows.Forms.Button();
            this.gradesListBox = new System.Windows.Forms.ListBox();
            this.tabPageTeachers = new System.Windows.Forms.TabPage();
            this.teachersListBox = new System.Windows.Forms.ListBox();
            this.SaveTeachersToHTML = new System.Windows.Forms.Button();
            this.TabSchedlue.SuspendLayout();
            this.tabPageGrades.SuspendLayout();
            this.tabPageTeachers.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabSchedlue
            // 
            this.TabSchedlue.Controls.Add(this.tabPageGrades);
            this.TabSchedlue.Controls.Add(this.tabPageTeachers);
            this.TabSchedlue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabSchedlue.Location = new System.Drawing.Point(0, 0);
            this.TabSchedlue.Name = "TabSchedlue";
            this.TabSchedlue.SelectedIndex = 0;
            this.TabSchedlue.Size = new System.Drawing.Size(582, 428);
            this.TabSchedlue.TabIndex = 0;
            // 
            // tabPageGrades
            // 
            this.tabPageGrades.BackColor = System.Drawing.Color.Gray;
            this.tabPageGrades.Controls.Add(this.SaveClassesToHTML);
            this.tabPageGrades.Controls.Add(this.gradesListBox);
            this.tabPageGrades.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tabPageGrades.Location = new System.Drawing.Point(4, 22);
            this.tabPageGrades.Name = "tabPageGrades";
            this.tabPageGrades.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGrades.Size = new System.Drawing.Size(574, 402);
            this.tabPageGrades.TabIndex = 0;
            this.tabPageGrades.Text = "Классы";
            // 
            // SaveClassesToHTML
            // 
            this.SaveClassesToHTML.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SaveClassesToHTML.Location = new System.Drawing.Point(464, 326);
            this.SaveClassesToHTML.Name = "SaveClassesToHTML";
            this.SaveClassesToHTML.Size = new System.Drawing.Size(89, 59);
            this.SaveClassesToHTML.TabIndex = 1;
            this.SaveClassesToHTML.Text = "Сохранить в html документ";
            this.SaveClassesToHTML.UseVisualStyleBackColor = true;
            this.SaveClassesToHTML.Click += new System.EventHandler(this.SaveClassesToHTML_Click);
            // 
            // gradesListBox
            // 
            this.gradesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gradesListBox.FormattingEnabled = true;
            this.gradesListBox.Location = new System.Drawing.Point(3, 3);
            this.gradesListBox.MultiColumn = true;
            this.gradesListBox.Name = "gradesListBox";
            this.gradesListBox.Size = new System.Drawing.Size(443, 394);
            this.gradesListBox.TabIndex = 0;
            this.gradesListBox.SelectedIndexChanged += new System.EventHandler(this.gradesListBox_SelectedIndexChanged);
            // 
            // tabPageTeachers
            // 
            this.tabPageTeachers.BackColor = System.Drawing.Color.Gray;
            this.tabPageTeachers.Controls.Add(this.SaveTeachersToHTML);
            this.tabPageTeachers.Controls.Add(this.teachersListBox);
            this.tabPageTeachers.Location = new System.Drawing.Point(4, 22);
            this.tabPageTeachers.Name = "tabPageTeachers";
            this.tabPageTeachers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTeachers.Size = new System.Drawing.Size(574, 402);
            this.tabPageTeachers.TabIndex = 1;
            this.tabPageTeachers.Text = "Учителя";
            // 
            // teachersListBox
            // 
            this.teachersListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.teachersListBox.FormattingEnabled = true;
            this.teachersListBox.Location = new System.Drawing.Point(3, 3);
            this.teachersListBox.Name = "teachersListBox";
            this.teachersListBox.Size = new System.Drawing.Size(417, 394);
            this.teachersListBox.TabIndex = 0;
            // 
            // SaveTeachersToHTML
            // 
            this.SaveTeachersToHTML.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SaveTeachersToHTML.Location = new System.Drawing.Point(445, 318);
            this.SaveTeachersToHTML.Name = "SaveTeachersToHTML";
            this.SaveTeachersToHTML.Size = new System.Drawing.Size(89, 59);
            this.SaveTeachersToHTML.TabIndex = 2;
            this.SaveTeachersToHTML.Text = "Сохранить в html документ";
            this.SaveTeachersToHTML.UseVisualStyleBackColor = true;
            this.SaveTeachersToHTML.Click += new System.EventHandler(this.SaveTeachersToHTML_Click);
            // 
            // FormOutput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 428);
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
        private System.Windows.Forms.Button SaveClassesToHTML;
        private System.Windows.Forms.Button SaveTeachersToHTML;
    }
}