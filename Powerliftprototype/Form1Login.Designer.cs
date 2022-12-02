namespace Powerliftprototype
{
	partial class Form1Login
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
			this.loginPanel = new System.Windows.Forms.Panel();
			this.SignupButton = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.usernameTextBox = new System.Windows.Forms.TextBox();
			this.LoginButton = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.signUpPanel = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.confirmSignUpButton = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.backButton = new System.Windows.Forms.Button();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.loginPanel.SuspendLayout();
			this.signUpPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// loginPanel
			// 
			this.loginPanel.Controls.Add(this.SignupButton);
			this.loginPanel.Controls.Add(this.label2);
			this.loginPanel.Controls.Add(this.usernameTextBox);
			this.loginPanel.Controls.Add(this.LoginButton);
			this.loginPanel.Controls.Add(this.textBox1);
			this.loginPanel.Controls.Add(this.label1);
			this.loginPanel.Location = new System.Drawing.Point(0, 110);
			this.loginPanel.Name = "loginPanel";
			this.loginPanel.Size = new System.Drawing.Size(415, 145);
			this.loginPanel.TabIndex = 0;
			// 
			// SignupButton
			// 
			this.SignupButton.Location = new System.Drawing.Point(234, 102);
			this.SignupButton.Name = "SignupButton";
			this.SignupButton.Size = new System.Drawing.Size(75, 23);
			this.SignupButton.TabIndex = 11;
			this.SignupButton.Text = "Sign Up";
			this.SignupButton.UseVisualStyleBackColor = true;
			this.SignupButton.Click += new System.EventHandler(this.button2_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(111, 65);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 13);
			this.label2.TabIndex = 10;
			this.label2.Text = "password";
			// 
			// usernameTextBox
			// 
			this.usernameTextBox.Location = new System.Drawing.Point(176, 21);
			this.usernameTextBox.Name = "usernameTextBox";
			this.usernameTextBox.Size = new System.Drawing.Size(100, 20);
			this.usernameTextBox.TabIndex = 9;
			// 
			// LoginButton
			// 
			this.LoginButton.Location = new System.Drawing.Point(133, 102);
			this.LoginButton.Name = "LoginButton";
			this.LoginButton.Size = new System.Drawing.Size(75, 23);
			this.LoginButton.TabIndex = 8;
			this.LoginButton.Text = "Login";
			this.LoginButton.UseVisualStyleBackColor = true;
			this.LoginButton.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(176, 62);
			this.textBox1.Name = "textBox1";
			this.textBox1.PasswordChar = '●';
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 7;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(111, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "username";
			// 
			// signUpPanel
			// 
			this.signUpPanel.Controls.Add(this.label3);
			this.signUpPanel.Controls.Add(this.textBox3);
			this.signUpPanel.Controls.Add(this.confirmSignUpButton);
			this.signUpPanel.Controls.Add(this.label4);
			this.signUpPanel.Controls.Add(this.textBox4);
			this.signUpPanel.Controls.Add(this.backButton);
			this.signUpPanel.Controls.Add(this.textBox5);
			this.signUpPanel.Controls.Add(this.label5);
			this.signUpPanel.Location = new System.Drawing.Point(77, 79);
			this.signUpPanel.Name = "signUpPanel";
			this.signUpPanel.Size = new System.Drawing.Size(251, 196);
			this.signUpPanel.TabIndex = 12;
			this.signUpPanel.Visible = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(15, 99);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(89, 13);
			this.label3.TabIndex = 21;
			this.label3.Text = "confirm password";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(110, 96);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(100, 20);
			this.textBox3.TabIndex = 20;
			// 
			// confirmSignUpButton
			// 
			this.confirmSignUpButton.Location = new System.Drawing.Point(147, 154);
			this.confirmSignUpButton.Name = "confirmSignUpButton";
			this.confirmSignUpButton.Size = new System.Drawing.Size(98, 23);
			this.confirmSignUpButton.TabIndex = 19;
			this.confirmSignUpButton.Text = "Confirm Sign Up";
			this.confirmSignUpButton.UseVisualStyleBackColor = true;
			this.confirmSignUpButton.Click += new System.EventHandler(this.confirmSignUpButton_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(52, 61);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(52, 13);
			this.label4.TabIndex = 18;
			this.label4.Text = "password";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(110, 13);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(100, 20);
			this.textBox4.TabIndex = 17;
			// 
			// backButton
			// 
			this.backButton.Location = new System.Drawing.Point(46, 154);
			this.backButton.Name = "backButton";
			this.backButton.Size = new System.Drawing.Size(75, 23);
			this.backButton.TabIndex = 16;
			this.backButton.Text = "Back";
			this.backButton.UseVisualStyleBackColor = true;
			this.backButton.Click += new System.EventHandler(this.button4_Click);
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(110, 54);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(100, 20);
			this.textBox5.TabIndex = 15;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(51, 16);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(53, 13);
			this.label5.TabIndex = 14;
			this.label5.Text = "username";
			// 
			// Form1Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(417, 380);
			this.Controls.Add(this.loginPanel);
			this.Controls.Add(this.signUpPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Form1Login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.Load += new System.EventHandler(this.Form1Login_Load);
			this.loginPanel.ResumeLayout(false);
			this.loginPanel.PerformLayout();
			this.signUpPanel.ResumeLayout(false);
			this.signUpPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel loginPanel;
		private System.Windows.Forms.Button SignupButton;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox usernameTextBox;
		private System.Windows.Forms.Button LoginButton;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel signUpPanel;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Button confirmSignUpButton;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Button backButton;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Label label5;
	}
}

