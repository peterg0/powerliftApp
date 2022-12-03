
namespace Powerliftprototype
{
	partial class Form3MesocycleView
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
			this.userControlMesoView1 = new Powerliftprototype.UserControlMesoView();
			this.SuspendLayout();
			// 
			// userControlMesoView1
			// 
			this.userControlMesoView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.userControlMesoView1.Location = new System.Drawing.Point(0, 0);
			this.userControlMesoView1.Name = "userControlMesoView1";
			this.userControlMesoView1.Size = new System.Drawing.Size(417, 380);
			this.userControlMesoView1.TabIndex = 0;
			// 
			// Form3MesocycleView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(417, 380);
			this.Controls.Add(this.userControlMesoView1);
			this.Name = "Form3MesocycleView";
			this.Text = "Form3MesocycleView";
			this.Load += new System.EventHandler(this.Form3MesocycleView_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private UserControlMesoView userControlMesoView1;
	}
}