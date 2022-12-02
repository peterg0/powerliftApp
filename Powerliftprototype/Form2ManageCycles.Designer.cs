namespace Powerliftprototype
{
	partial class Form2ManageCycles
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
			this.button6 = new System.Windows.Forms.Button();
			this.CycleTablePanel = new System.Windows.Forms.TableLayoutPanel();
			this.label2 = new System.Windows.Forms.Label();
			this.manageCyclesPanel = new System.Windows.Forms.Panel();
			this.settingsPanel = new System.Windows.Forms.Panel();
			this.Confirmbtn = new System.Windows.Forms.Button();
			this.calc_repsTextBox = new TextBoxNumbers.TextBoxNumbers();
			this.calc_weightTextBox = new TextBoxNumbers.TextBoxNumbers();
			this.ohp_txtbox = new TextBoxNumbers.TextBoxNumbers();
			this.deadlift_txtbox = new TextBoxNumbers.TextBoxNumbers();
			this.bench_txtbox = new TextBoxNumbers.TextBoxNumbers();
			this.squat_txtbox = new TextBoxNumbers.TextBoxNumbers();
			this.label10 = new System.Windows.Forms.Label();
			this.calc_1rmLabel = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.calc_button = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.manageCyclesPanel.SuspendLayout();
			this.settingsPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(46, 273);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(307, 36);
			this.button6.TabIndex = 6;
			this.button6.Text = "Create New Mesocycle+";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// CycleTablePanel
			// 
			this.CycleTablePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.CycleTablePanel.ColumnCount = 1;
			this.CycleTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.CycleTablePanel.Location = new System.Drawing.Point(-1, 41);
			this.CycleTablePanel.Name = "CycleTablePanel";
			this.CycleTablePanel.RowCount = 1;
			this.CycleTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.CycleTablePanel.Size = new System.Drawing.Size(403, 226);
			this.CycleTablePanel.TabIndex = 7;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(154, 25);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Manage Cycles";
			// 
			// manageCyclesPanel
			// 
			this.manageCyclesPanel.Controls.Add(this.label2);
			this.manageCyclesPanel.Controls.Add(this.button6);
			this.manageCyclesPanel.Controls.Add(this.CycleTablePanel);
			this.manageCyclesPanel.Location = new System.Drawing.Point(0, 24);
			this.manageCyclesPanel.Name = "manageCyclesPanel";
			this.manageCyclesPanel.Size = new System.Drawing.Size(401, 317);
			this.manageCyclesPanel.TabIndex = 8;
			// 
			// settingsPanel
			// 
			this.settingsPanel.Controls.Add(this.Confirmbtn);
			this.settingsPanel.Controls.Add(this.calc_repsTextBox);
			this.settingsPanel.Controls.Add(this.calc_weightTextBox);
			this.settingsPanel.Controls.Add(this.ohp_txtbox);
			this.settingsPanel.Controls.Add(this.deadlift_txtbox);
			this.settingsPanel.Controls.Add(this.bench_txtbox);
			this.settingsPanel.Controls.Add(this.squat_txtbox);
			this.settingsPanel.Controls.Add(this.label10);
			this.settingsPanel.Controls.Add(this.calc_1rmLabel);
			this.settingsPanel.Controls.Add(this.label8);
			this.settingsPanel.Controls.Add(this.calc_button);
			this.settingsPanel.Controls.Add(this.label7);
			this.settingsPanel.Controls.Add(this.label6);
			this.settingsPanel.Controls.Add(this.label5);
			this.settingsPanel.Controls.Add(this.label3);
			this.settingsPanel.Controls.Add(this.label4);
			this.settingsPanel.Controls.Add(this.label1);
			this.settingsPanel.Controls.Add(this.label9);
			this.settingsPanel.Location = new System.Drawing.Point(0, 0);
			this.settingsPanel.Name = "settingsPanel";
			this.settingsPanel.Size = new System.Drawing.Size(402, 341);
			this.settingsPanel.TabIndex = 9;
			// 
			// Confirmbtn
			// 
			this.Confirmbtn.Enabled = false;
			this.Confirmbtn.Location = new System.Drawing.Point(187, 166);
			this.Confirmbtn.Name = "Confirmbtn";
			this.Confirmbtn.Size = new System.Drawing.Size(75, 23);
			this.Confirmbtn.TabIndex = 70;
			this.Confirmbtn.Text = "Confirm";
			this.Confirmbtn.UseVisualStyleBackColor = true;
			this.Confirmbtn.Click += new System.EventHandler(this.Confirmbtn_Click_1);
			// 
			// calc_repsTextBox
			// 
			this.calc_repsTextBox.Location = new System.Drawing.Point(89, 253);
			this.calc_repsTextBox.Name = "calc_repsTextBox";
			this.calc_repsTextBox.Size = new System.Drawing.Size(100, 20);
			this.calc_repsTextBox.TabIndex = 69;
			this.calc_repsTextBox.TextChanged += new System.EventHandler(this.calc_repsTextBox_TextChanged_1);
			// 
			// calc_weightTextBox
			// 
			this.calc_weightTextBox.Location = new System.Drawing.Point(89, 226);
			this.calc_weightTextBox.Name = "calc_weightTextBox";
			this.calc_weightTextBox.Size = new System.Drawing.Size(100, 20);
			this.calc_weightTextBox.TabIndex = 68;
			this.calc_weightTextBox.TextChanged += new System.EventHandler(this.calc_weightTextBox_TextChanged_1);
			// 
			// ohp_txtbox
			// 
			this.ohp_txtbox.Location = new System.Drawing.Point(178, 127);
			this.ohp_txtbox.Name = "ohp_txtbox";
			this.ohp_txtbox.Size = new System.Drawing.Size(100, 20);
			this.ohp_txtbox.TabIndex = 67;
			this.ohp_txtbox.TextChanged += new System.EventHandler(this.ohp_txtbox_TextChanged);
			// 
			// deadlift_txtbox
			// 
			this.deadlift_txtbox.Location = new System.Drawing.Point(178, 102);
			this.deadlift_txtbox.Name = "deadlift_txtbox";
			this.deadlift_txtbox.Size = new System.Drawing.Size(100, 20);
			this.deadlift_txtbox.TabIndex = 66;
			this.deadlift_txtbox.TextChanged += new System.EventHandler(this.deadlift_txtbox_TextChanged);
			// 
			// bench_txtbox
			// 
			this.bench_txtbox.Location = new System.Drawing.Point(178, 76);
			this.bench_txtbox.Name = "bench_txtbox";
			this.bench_txtbox.Size = new System.Drawing.Size(100, 20);
			this.bench_txtbox.TabIndex = 65;
			this.bench_txtbox.TextChanged += new System.EventHandler(this.bench_txtbox_TextChanged);
			// 
			// squat_txtbox
			// 
			this.squat_txtbox.Location = new System.Drawing.Point(178, 50);
			this.squat_txtbox.Name = "squat_txtbox";
			this.squat_txtbox.Size = new System.Drawing.Size(100, 20);
			this.squat_txtbox.TabIndex = 64;
			this.squat_txtbox.TextChanged += new System.EventHandler(this.squat_txtbox_TextChanged);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(172, 18);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(100, 13);
			this.label10.TabIndex = 63;
			this.label10.Text = "Input One Rep Max";
			// 
			// calc_1rmLabel
			// 
			this.calc_1rmLabel.AutoSize = true;
			this.calc_1rmLabel.Location = new System.Drawing.Point(292, 242);
			this.calc_1rmLabel.Name = "calc_1rmLabel";
			this.calc_1rmLabel.Size = new System.Drawing.Size(13, 13);
			this.calc_1rmLabel.TabIndex = 62;
			this.calc_1rmLabel.Text = "0";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(204, 242);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(82, 13);
			this.label8.TabIndex = 61;
			this.label8.Text = "Estimated 1RM:";
			// 
			// calc_button
			// 
			this.calc_button.Enabled = false;
			this.calc_button.Location = new System.Drawing.Point(102, 279);
			this.calc_button.Name = "calc_button";
			this.calc_button.Size = new System.Drawing.Size(75, 23);
			this.calc_button.TabIndex = 60;
			this.calc_button.Text = "Calculate";
			this.calc_button.UseVisualStyleBackColor = true;
			this.calc_button.Click += new System.EventHandler(this.calc_button_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(51, 256);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(32, 13);
			this.label7.TabIndex = 59;
			this.label7.Text = "Reps";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(48, 229);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(41, 13);
			this.label6.TabIndex = 58;
			this.label6.Text = "Weight";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(25, 199);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(123, 13);
			this.label5.TabIndex = 57;
			this.label5.Text = "One Rep Max Calculator";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(102, 79);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 13);
			this.label3.TabIndex = 56;
			this.label3.Text = "Bench Press";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(134, 53);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(35, 13);
			this.label4.TabIndex = 55;
			this.label4.Text = "Squat";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(86, 130);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 13);
			this.label1.TabIndex = 54;
			this.label1.Text = "Overhead Press";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(129, 104);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(43, 13);
			this.label9.TabIndex = 53;
			this.label9.Text = "Deadlift";
			// 
			// Form2ManageCycles
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(401, 341);
			this.Controls.Add(this.manageCyclesPanel);
			this.Controls.Add(this.settingsPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Form2ManageCycles";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "PowerLiftPro";
			this.Load += new System.EventHandler(this.Form3_Load);
			this.manageCyclesPanel.ResumeLayout(false);
			this.manageCyclesPanel.PerformLayout();
			this.settingsPanel.ResumeLayout(false);
			this.settingsPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.TableLayoutPanel CycleTablePanel;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel manageCyclesPanel;
		private System.Windows.Forms.Panel settingsPanel;
		private System.Windows.Forms.Button Confirmbtn;
		private TextBoxNumbers.TextBoxNumbers calc_repsTextBox;
		private TextBoxNumbers.TextBoxNumbers calc_weightTextBox;
		private TextBoxNumbers.TextBoxNumbers ohp_txtbox;
		private TextBoxNumbers.TextBoxNumbers deadlift_txtbox;
		private TextBoxNumbers.TextBoxNumbers bench_txtbox;
		private TextBoxNumbers.TextBoxNumbers squat_txtbox;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label calc_1rmLabel;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button calc_button;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label9;
	}
}