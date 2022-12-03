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
	public partial class Form3MesocycleView : Form
	{
		public UserAccount currentUser { get; set; }
		public Mesocycle currentUser_Mesocycle { get; set; }
		public Form3MesocycleView()
		{
			InitializeComponent();
		}

		public void SetCurrentUser(UserAccount user) { user = currentUser; }
		public void SetcurrentUsers_Mesocycle(Mesocycle cycle) { cycle = currentUser_Mesocycle; }

		private void Form3MesocycleView_Load(object sender, EventArgs e)
		{

		}
	}
}
