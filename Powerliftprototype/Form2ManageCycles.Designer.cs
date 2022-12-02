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
			this.settingsPanel = new Powerliftprototype.UserControlSettings();
			this.manageCyclesPanel.SuspendLayout();
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
			this.CycleTablePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mesocyclePanel_Paint);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(154, 25);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Manage Cycles";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// manageCyclesPanel
			// 
			this.manageCyclesPanel.Controls.Add(this.label2);
			this.manageCyclesPanel.Controls.Add(this.CycleTablePanel);
			this.manageCyclesPanel.Controls.Add(this.button6);
			this.manageCyclesPanel.Location = new System.Drawing.Point(0, 0);
			this.manageCyclesPanel.Name = "manageCyclesPanel";
			this.manageCyclesPanel.Size = new System.Drawing.Size(401, 341);
			this.manageCyclesPanel.TabIndex = 8;
			// 
			// settingsPanel
			// 
			this.settingsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.settingsPanel.Location = new System.Drawing.Point(0, 0);
			this.settingsPanel.Name = "settingsPanel";
			this.settingsPanel.Size = new System.Drawing.Size(401, 341);
			this.settingsPanel.TabIndex = 8;
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
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.TableLayoutPanel CycleTablePanel;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel manageCyclesPanel;
		private UserControlSettings settingsPanel;
	}
}