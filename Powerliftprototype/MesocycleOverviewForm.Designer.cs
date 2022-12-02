
namespace Powerliftprototype
{
	partial class MesocycleOverviewForm
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
			this.userControllCycleOverview1 = new Powerliftprototype.UserControllCycleOverview();
			this.userControlWeekOverview1 = new Powerliftprototype.UserControlWeekOverview();
			this.SuspendLayout();
			// 
			// userControllCycleOverview1
			// 
			this.userControllCycleOverview1.Location = new System.Drawing.Point(0, 0);
			this.userControllCycleOverview1.Name = "userControllCycleOverview1";
			this.userControllCycleOverview1.Size = new System.Drawing.Size(370, 338);
			this.userControllCycleOverview1.TabIndex = 0;
			this.userControllCycleOverview1.Load += new System.EventHandler(this.userControllCycleOverview1_Load);
			// 
			// userControlWeekOverview1
			// 
			this.userControlWeekOverview1.Location = new System.Drawing.Point(-18, 0);
			this.userControlWeekOverview1.Name = "userControlWeekOverview1";
			this.userControlWeekOverview1.Size = new System.Drawing.Size(433, 349);
			this.userControlWeekOverview1.TabIndex = 1;
			this.userControlWeekOverview1.Visible = false;
			this.userControlWeekOverview1.Load += new System.EventHandler(this.userControlWeekOverview1_Load);
			// 
			// MesocycleOverviewForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(401, 341);
			this.Controls.Add(this.userControllCycleOverview1);
			this.Controls.Add(this.userControlWeekOverview1);
			this.Name = "MesocycleOverviewForm";
			this.Text = "MesocycleOverviewForm";
			this.ResumeLayout(false);

		}

		#endregion

		private UserControllCycleOverview userControllCycleOverview1;
		private UserControlWeekOverview userControlWeekOverview1;
	}
}