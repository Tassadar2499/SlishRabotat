namespace Raspisanie
{
	partial class FormCountAndDifficulty
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.numericDifficulty = new System.Windows.Forms.NumericUpDown();
			this.numericCountAtWeek = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.numericDifficulty)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericCountAtWeek)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.Color.Red;
			this.label1.Location = new System.Drawing.Point(37, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(61, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Предмет - ";
			this.label1.Click += new System.EventHandler(this.NameOfSubjLabelClick);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(37, 86);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Сложность";
			this.label2.Click += new System.EventHandler(this.difficultyLabelClick);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(198, 86);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(116, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Количество в неделю";
			this.label3.Click += new System.EventHandler(this.CountAtWeekLabelClick);
			// 
			// numericDifficulty
			// 
			this.numericDifficulty.Location = new System.Drawing.Point(40, 112);
			this.numericDifficulty.Name = "numericDifficulty";
			this.numericDifficulty.Size = new System.Drawing.Size(120, 20);
			this.numericDifficulty.TabIndex = 6;
			this.numericDifficulty.ValueChanged += new System.EventHandler(this.numericDifficulty_ValueChanged);
			// 
			// numericCountAtWeek
			// 
			this.numericCountAtWeek.Location = new System.Drawing.Point(194, 112);
			this.numericCountAtWeek.Name = "numericCountAtWeek";
			this.numericCountAtWeek.Size = new System.Drawing.Size(120, 20);
			this.numericCountAtWeek.TabIndex = 7;
			this.numericCountAtWeek.ValueChanged += new System.EventHandler(this.numericCountAtWeek_ValueChanged);
			// 
			// FormCountAndDifficulty
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Lime;
			this.ClientSize = new System.Drawing.Size(354, 234);
			this.Controls.Add(this.numericCountAtWeek);
			this.Controls.Add(this.numericDifficulty);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FormCountAndDifficulty";
			this.Text = "FormCountAndDifficulty";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCountAndDifficulty_FormClosing);
			this.Load += new System.EventHandler(this.FormCountAndDifficulty_Load);
			((System.ComponentModel.ISupportInitialize)(this.numericDifficulty)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericCountAtWeek)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown numericDifficulty;
		private System.Windows.Forms.NumericUpDown numericCountAtWeek;
	}
}