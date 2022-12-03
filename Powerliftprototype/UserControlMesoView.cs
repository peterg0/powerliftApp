using System;
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
	public partial class UserControlMesoView : UserControl
	{
		public UserAccount currentUser { get; set; }
		public Mesocycle currentUser_Mesocycle { get; set; }

		UserControlWeekOverview week1 = new UserControlWeekOverview();
		UserControlWeekOverview week2 = new UserControlWeekOverview();
		UserControlWeekOverview week3 = new UserControlWeekOverview();
		UserControlWeekOverview week4 = new UserControlWeekOverview();

		public void SetCurrentUser(UserAccount u) { currentUser = u; }
		public void SetCurrentCycle(Mesocycle m) { currentUser_Mesocycle = m; }
		public UserControlMesoView()
		{
			InitializeComponent();

			
		}



		private void button2_Click(object sender, EventArgs e)
		{
		ParentForm.Hide();
		
		}

		private void MesocyclePanel_Paint(object sender, PaintEventArgs e)
		{
			MesoTitle.Text = "Mesocycle "+ (currentUser_Mesocycle.mesoID+1).ToString();
		}

		private void week1btn_Click(object sender, EventArgs e)
		{
			
			week1.BringToFront();
		}

		private void week2btn_Click(object sender, EventArgs e)
		{
			
			week2.BringToFront();
		}

		private void week3btn_Click(object sender, EventArgs e)
		{
			
			week3.BringToFront();
		}

		private void week4btn_Click(object sender, EventArgs e)
		{
			
			week4.BringToFront();
		}
	}
}
