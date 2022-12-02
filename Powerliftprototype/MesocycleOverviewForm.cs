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
	public partial class MesocycleOverviewForm : Form
	{
		private UserAccount currentuserOverviewForm { get; set; }
		public void SetCurrentUser(UserAccount currentUser) { currentuserOverviewForm = currentUser; }

		public MesocycleOverviewForm()
		{
			InitializeComponent();
		}

		private void userControlWeekOverview1_Load(object sender, EventArgs e)
		{
			
		}

		private void userControllCycleOverview1_Load(object sender, EventArgs e)
		{

		}
	}
}
