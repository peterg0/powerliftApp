
namespace Powerliftprototype
{
	partial class UserControlSettings
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label10 = new System.Windows.Forms.Label();
			this.calc_1rmLabel = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.calc_button = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.squat_txtbox = new TextBoxNumbers.TextBoxNumbers();
			this.bench_txtbox = new TextBoxNumbers.TextBoxNumbers();
			this.deadlift_txtbox = new TextBoxNumbers.TextBoxNumbers();
			this.ohp_txtbox = new TextBoxNumbers.TextBoxNumbers();
			this.calc_weightTextBox = new TextBoxNumbers.TextBoxNumbers();
			this.calc_repsTextBox = new TextBoxNumbers.TextBoxNumbers();
			this.Confirmbtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(171, 18);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(100, 13);
			this.label10.TabIndex = 45;
			this.label10.Text = "Input One Rep Max";
			// 
			// calc_1rmLabel
			// 
			this.calc_1rmLabel.AutoSize = true;
			this.calc_1rmLabel.Location = new System.Drawing.Point(220, 277);
			this.calc_1rmLabel.Name = "calc_1rmLabel";
			this.calc_1rmLabel.Size = new System.Drawing.Size(13, 13);
			this.calc_1rmLabel.TabIndex = 44;
			this.calc_1rmLabel.Text = "0";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(135, 277);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(82, 13);
			this.label8.TabIndex = 43;
			this.label8.Text = "Estimated 1RM:";
			// 
			// calc_button
			// 
			this.calc_button.Enabled = false;
			this.calc_button.Location = new System.Drawing.Point(186, 300);
			this.calc_button.Name = "calc_button";
			this.calc_button.Size = new System.Drawing.Size(75, 23);
			this.calc_button.TabIndex = 42;
			this.calc_button.Text = "Calculate";
			this.calc_button.UseVisualStyleBackColor = true;
			this.calc_button.Click += new System.EventHandler(this.button3_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(245, 244);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(32, 13);
			this.label7.TabIndex = 40;
			this.label7.Text = "Reps";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(47, 244);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(41, 13);
			this.label6.TabIndex = 38;
			this.label6.Text = "Weight";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(16, 212);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(123, 13);
			this.label5.TabIndex = 37;
			this.label5.Text = "One Rep Max Calculator";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(101, 79);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 13);
			this.label3.TabIndex = 35;
			this.label3.Text = "Bench Press";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(133, 53);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(35, 13);
			this.label4.TabIndex = 32;
			this.label4.Text = "Squat";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(85, 130);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(83, 13);
			this.label2.TabIndex = 31;
			this.label2.Text = "Overhead Press";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(128, 104);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 13);
			this.label1.TabIndex = 27;
			this.label1.Text = "Deadlift";
			// 
			// squat_txtbox
			// 
			this.squat_txtbox.Location = new System.Drawing.Point(177, 50);
			this.squat_txtbox.Name = "squat_txtbox";
			this.squat_txtbox.Size = new System.Drawing.Size(100, 20);
			this.squat_txtbox.TabIndex = 46;
			this.squat_txtbox.TextChanged += new System.EventHandler(this.squat_txtbox_TextChanged);
			// 
			// bench_txtbox
			// 
			this.bench_txtbox.Location = new System.Drawing.Point(177, 76);
			this.bench_txtbox.Name = "bench_txtbox";
			this.bench_txtbox.Size = new System.Drawing.Size(100, 20);
			this.bench_txtbox.TabIndex = 47;
			// 
			// deadlift_txtbox
			// 
			this.deadlift_txtbox.Location = new System.Drawing.Point(177, 102);
			this.deadlift_txtbox.Name = "deadlift_txtbox";
			this.deadlift_txtbox.Size = new System.Drawing.Size(100, 20);
			this.deadlift_txtbox.TabIndex = 48;
			// 
			// ohp_txtbox
			// 
			this.ohp_txtbox.Location = new System.Drawing.Point(177, 127);
			this.ohp_txtbox.Name = "ohp_txtbox";
			this.ohp_txtbox.Size = new System.Drawing.Size(100, 20);
			this.ohp_txtbox.TabIndex = 49;
			// 
			// calc_weightTextBox
			// 
			this.calc_weightTextBox.Location = new System.Drawing.Point(88, 241);
			this.calc_weightTextBox.Name = "calc_weightTextBox";
			this.calc_weightTextBox.Size = new System.Drawing.Size(100, 20);
			this.calc_weightTextBox.TabIndex = 50;
			this.calc_weightTextBox.TextChanged += new System.EventHandler(this.calc_weightTextBox_TextChanged);
			// 
			// calc_repsTextBox
			// 
			this.calc_repsTextBox.Location = new System.Drawing.Point(283, 241);
			this.calc_repsTextBox.Name = "calc_repsTextBox";
			this.calc_repsTextBox.Size = new System.Drawing.Size(100, 20);
			this.calc_repsTextBox.TabIndex = 51;
			this.calc_repsTextBox.TextChanged += new System.EventHandler(this.calc_repsTextBox_TextChanged);
			// 
			// Confirmbtn
			// 
			this.Confirmbtn.Location = new System.Drawing.Point(186, 166);
			this.Confirmbtn.Name = "Confirmbtn";
			this.Confirmbtn.Size = new System.Drawing.Size(75, 23);
			this.Confirmbtn.TabIndex = 52;
			this.Confirmbtn.Text = "Confirm";
			this.Confirmbtn.UseVisualStyleBackColor = true;
			this.Confirmbtn.Click += new System.EventHandler(this.Confirmbtn_Click);
			// 
			// UserControlSettings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.Confirmbtn);
			this.Controls.Add(this.calc_repsTextBox);
			this.Controls.Add(this.calc_weightTextBox);
			this.Controls.Add(this.ohp_txtbox);
			this.Controls.Add(this.deadlift_txtbox);
			this.Controls.Add(this.bench_txtbox);
			this.Controls.Add(this.squat_txtbox);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.calc_1rmLabel);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.calc_button);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "UserControlSettings";
			this.Size = new System.Drawing.Size(396, 334);
			this.Load += new System.EventHandler(this.UserControl2_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label calc_1rmLabel;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button calc_button;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private TextBoxNumbers.TextBoxNumbers squat_txtbox;
		private TextBoxNumbers.TextBoxNumbers bench_txtbox;
		private TextBoxNumbers.TextBoxNumbers deadlift_txtbox;
		private TextBoxNumbers.TextBoxNumbers ohp_txtbox;
		private TextBoxNumbers.TextBoxNumbers calc_weightTextBox;
		private TextBoxNumbers.TextBoxNumbers calc_repsTextBox;
		private System.Windows.Forms.Button Confirmbtn;
	}
}
