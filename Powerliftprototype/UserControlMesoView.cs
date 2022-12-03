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

		public void SetCurrentUser(UserAccount u) { currentUser = u; }
		public void SetCurrentCycle(Mesocycle m) { currentUser_Mesocycle = m; }
		public UserControlMesoView()
		{
			InitializeComponent();

		
		}



		private void button2_Click(object sender, EventArgs e)
		{
		ParentForm.Hide();
		MesoTitle.Text = currentUser_Mesocycle.mesoID.ToString();
		}
	}
}
