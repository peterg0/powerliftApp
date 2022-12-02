
namespace Powerliftprototype
{
	partial class MesoBtn
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
			this.MesocycleBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// MesocycleBtn
			// 
			this.MesocycleBtn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MesocycleBtn.Location = new System.Drawing.Point(0, 0);
			this.MesocycleBtn.Name = "MesocycleBtn";
			this.MesocycleBtn.Size = new System.Drawing.Size(307, 36);
			this.MesocycleBtn.TabIndex = 1;
			this.MesocycleBtn.UseVisualStyleBackColor = true;
			this.MesocycleBtn.Click += new System.EventHandler(this.MesocycleBtn_Click);
			// 
			// MesoBtn
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.MesocycleBtn);
			this.Name = "MesoBtn";
			this.Size = new System.Drawing.Size(307, 36);
			this.Load += new System.EventHandler(this.MesoBtn_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button MesocycleBtn;
	}
}
