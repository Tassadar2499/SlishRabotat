namespace Raspisanie
{
    partial class FormSchedlue
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.labelTitle = new System.Windows.Forms.Label();
			this.dataTable = new System.Windows.Forms.DataGridView();
			this.NumberOfLesson = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Monday = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tuesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Wednesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Thursday = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Friday = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Saturday = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
			this.SuspendLayout();
			// 
			// labelTitle
			// 
			this.labelTitle.AutoSize = true;
			this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelTitle.ForeColor = System.Drawing.Color.Red;
			this.labelTitle.Location = new System.Drawing.Point(2, 8);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(64, 16);
			this.labelTitle.TabIndex = 0;
			this.labelTitle.Text = "Класс - ";
			// 
			// dataTable
			// 
			this.dataTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumberOfLesson,
            this.Monday,
            this.Tuesday,
            this.Wednesday,
            this.Thursday,
            this.Friday,
            this.Saturday});
			this.dataTable.Location = new System.Drawing.Point(5, 27);
			this.dataTable.Name = "dataTable";
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataTable.RowHeadersVisible = false;
			this.dataTable.RowHeadersWidth = 40;
			this.dataTable.Size = new System.Drawing.Size(667, 425);
			this.dataTable.TabIndex = 1;
			// 
			// NumberOfLesson
			// 
			this.NumberOfLesson.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.NumberOfLesson.FillWeight = 35.53299F;
			this.NumberOfLesson.HeaderText = "№";
			this.NumberOfLesson.Name = "NumberOfLesson";
			this.NumberOfLesson.Width = 43;
			// 
			// Monday
			// 
			this.Monday.FillWeight = 110.7445F;
			this.Monday.HeaderText = "Понедельник";
			this.Monday.Name = "Monday";
			this.Monday.ReadOnly = true;
			// 
			// Tuesday
			// 
			this.Tuesday.FillWeight = 110.7445F;
			this.Tuesday.HeaderText = "Вторник";
			this.Tuesday.Name = "Tuesday";
			this.Tuesday.ReadOnly = true;
			// 
			// Wednesday
			// 
			this.Wednesday.FillWeight = 110.7445F;
			this.Wednesday.HeaderText = "Среда";
			this.Wednesday.Name = "Wednesday";
			this.Wednesday.ReadOnly = true;
			// 
			// Thursday
			// 
			this.Thursday.FillWeight = 110.7445F;
			this.Thursday.HeaderText = "Четверг";
			this.Thursday.Name = "Thursday";
			this.Thursday.ReadOnly = true;
			// 
			// Friday
			// 
			this.Friday.FillWeight = 110.7445F;
			this.Friday.HeaderText = "Пятница";
			this.Friday.Name = "Friday";
			this.Friday.ReadOnly = true;
			// 
			// Saturday
			// 
			this.Saturday.FillWeight = 110.7445F;
			this.Saturday.HeaderText = "Суббота";
			this.Saturday.Name = "Saturday";
			this.Saturday.ReadOnly = true;
			// 
			// FormSchedlue
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(674, 452);
			this.Controls.Add(this.dataTable);
			this.Controls.Add(this.labelTitle);
			this.Name = "FormSchedlue";
			this.Text = "FormSchedlueGrades";
			((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.DataGridView dataTable;
		private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfLesson;
		private System.Windows.Forms.DataGridViewTextBoxColumn Monday;
		private System.Windows.Forms.DataGridViewTextBoxColumn Tuesday;
		private System.Windows.Forms.DataGridViewTextBoxColumn Wednesday;
		private System.Windows.Forms.DataGridViewTextBoxColumn Thursday;
		private System.Windows.Forms.DataGridViewTextBoxColumn Friday;
		private System.Windows.Forms.DataGridViewTextBoxColumn Saturday;
	}
}