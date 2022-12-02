using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Powerliftprototype
{

	public partial class Form1Login : Form
	{
		//Dictionary<string, string> credentials = new Dictionary<string, string>(); //this dicitonary will store user credentials
		//readonly string[] usernames = File.ReadAllLines("username.txt");
		//readonly string[] passwords = File.ReadAllLines("password.txt");
		Form2ManageCycles form3 = new Form2ManageCycles();
		public UserAccount currentuser { get; set; }
		
		public Form1Login()
		{
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			loginPanel.Visible = false;
			signUpPanel.Visible = true;
			usernameTextBox.Text = ballsstatic.ballsstring;

		}

		private void button4_Click(object sender, EventArgs e)
		{
			loginPanel.Visible = true;
			signUpPanel.Visible = false;
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			
			this.Close();
			form3.Show();

			currentuser = new UserAccount("Guest", "12345");

			DialogResult result = MessageBox.Show("Logged in as " + currentuser.Username + " " + currentuser.Password, "errorbitch", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void confirmSignUpButton_Click(object sender, EventArgs e)
		{
			
		}

		private void Form1Login_Load(object sender, EventArgs e)
		{
		
			
		}
	}
}
