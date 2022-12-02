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
		
		private UserAccount currentuserForm1 { get; set; }

		private Form2ManageCycles form2;
		
		public Form1Login()
		{
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			loginPanel.Visible = false;
			signUpPanel.Visible = true;
		}

		private void button4_Click(object sender, EventArgs e)
		{
			loginPanel.Visible = true;
			signUpPanel.Visible = false;
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			currentuserForm1 = new UserAccount("Guest", "12345");
			Console.WriteLine("Logged in as: "+currentuserForm1.Username + " " + currentuserForm1.Password);
		
			form2 = new Form2ManageCycles();
			form2.SetCurrentUser(currentuserForm1);

			this.Hide();
			form2.Show();
		}


		private void confirmSignUpButton_Click(object sender, EventArgs e)
		{
			
		}

		private void Form1Login_Load(object sender, EventArgs e)
		{
		
			
		}
	}
}
