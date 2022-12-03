
namespace Powerliftprototype
{
	partial class UserControlMesoView
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
			this.MesocyclePanel = new System.Windows.Forms.Panel();
			this.week1btn = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.MesoTitle = new System.Windows.Forms.Label();
			this.week3btn = new System.Windows.Forms.Button();
			this.week2btn = new System.Windows.Forms.Button();
			this.week4btn = new System.Windows.Forms.Button();
			this.MesocyclePanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// MesocyclePanel
			// 
			this.MesocyclePanel.Controls.Add(this.week1btn);
			this.MesocyclePanel.Controls.Add(this.button2);
			this.MesocyclePanel.Controls.Add(this.MesoTitle);
			this.MesocyclePanel.Controls.Add(this.week3btn);
			this.MesocyclePanel.Controls.Add(this.week2btn);
			this.MesocyclePanel.Controls.Add(this.week4btn);
			this.MesocyclePanel.Location = new System.Drawing.Point(0, 0);
			this.MesocyclePanel.Name = "MesocyclePanel";
			this.MesocyclePanel.Size = new System.Drawing.Size(433, 419);
			this.MesocyclePanel.TabIndex = 16;
			this.MesocyclePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MesocyclePanel_Paint);
			// 
			// week1btn
			// 
			this.week1btn.Location = new System.Drawing.Point(71, 96);
			this.week1btn.Name = "week1btn";
			this.week1btn.Size = new System.Drawing.Size(302, 36);
			this.week1btn.TabIndex = 8;
			this.week1btn.Text = "week 1";
			this.week1btn.UseVisualStyleBackColor = true;
			
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(34, 324);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(74, 36);
			this.button2.TabIndex = 13;
			this.button2.Text = "Back";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// MesoTitle
			// 
			this.MesoTitle.AutoSize = true;
			this.MesoTitle.Location = new System.Drawing.Point(191, 70);
			this.MesoTitle.Name = "MesoTitle";
			this.MesoTitle.Size = new System.Drawing.Size(67, 13);
			this.MesoTitle.TabIndex = 7;
			this.MesoTitle.Text = "Mesocycle 1";
			this.MesoTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// week3btn
			// 
			this.week3btn.Location = new System.Drawing.Point(71, 180);
			this.week3btn.Name = "week3btn";
			this.week3btn.Size = new System.Drawing.Size(302, 36);
			this.week3btn.TabIndex = 12;
			this.week3btn.Text = "week 3";
			this.week3btn.UseVisualStyleBackColor = true;
			
			// 
			// week2btn
			// 
			this.week2btn.Location = new System.Drawing.Point(71, 138);
			this.week2btn.Name = "week2btn";
			this.week2btn.Size = new System.Drawing.Size(302, 36);
			this.week2btn.TabIndex = 9;
			this.week2btn.Text = "week 2";
			this.week2btn.UseVisualStyleBackColor = true;
			
			// 
			// week4btn
			// 
			this.week4btn.Location = new System.Drawing.Point(71, 222);
			this.week4btn.Name = "week4btn";
			this.week4btn.Size = new System.Drawing.Size(302, 36);
			this.week4btn.TabIndex = 11;
			this.week4btn.Text = "week 4";
			this.week4btn.UseVisualStyleBackColor = true;
		
			// 
			// UserControlMesoView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.MesocyclePanel);
			this.Name = "UserControlMesoView";
			this.Size = new System.Drawing.Size(433, 419);
			this.MesocyclePanel.ResumeLayout(false);
			this.MesocyclePanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel MesocyclePanel;
		private System.Windows.Forms.Button week1btn;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label MesoTitle;
		private System.Windows.Forms.Button week3btn;
		private System.Windows.Forms.Button week2btn;
		private System.Windows.Forms.Button week4btn;
	}
}
