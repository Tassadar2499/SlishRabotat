namespace Raspisanie
{
	partial class FormFillingTheClasses
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
			this.tabControlClasses = new System.Windows.Forms.TabControl();
			this.SuspendLayout();
			// 
			// tabControlClasses
			// 
			this.tabControlClasses.Location = new System.Drawing.Point(0, 32);
			this.tabControlClasses.Name = "tabControlClasses";
			this.tabControlClasses.SelectedIndex = 0;
			this.tabControlClasses.Size = new System.Drawing.Size(788, 220);
			this.tabControlClasses.TabIndex = 0;
			this.tabControlClasses.SelectedIndexChanged += new System.EventHandler(this.tabControlClasses_SelectedIndexChanged);
			// 
			// FormFillingTheClasses
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tabControlClasses);
			this.Name = "FormFillingTheClasses";
			this.Text = "FormFillingTheClasses";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormFillingTheClasses_FormClosing);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControlClasses;
	}
}