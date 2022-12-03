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
	public partial class MesoBtn : UserControl
	{
		Form3MesocycleView form3 = new Form3MesocycleView();
		public UserAccount currentuserMesoBtn { get; set; }
		public Mesocycle currentUsers_Mesocycle { get; set; }
		public int MesoBtnID { get; set; }


		public MesoBtn()
		{
			InitializeComponent();
			
		}

		private void MesocycleBtn_Click(object sender, EventArgs e)
		{
			//clicking on mesocycle button will bring forward the associated MesocycleOverviewForm
			form3.Show();
			Console.WriteLine("Current User is: " + currentuserMesoBtn.Username); //for debugging
			Console.WriteLine("MesoBtnID: " + MesoBtnID);
			Console.WriteLine("Mesocycle ID: " + currentUsers_Mesocycle.mesoID.ToString());
		}

		private void MesoBtn_Load(object sender, EventArgs e)
		{
			//set text of button
			var dateTime = DateTime.Now;
			MesocycleBtn.Text = dateTime.ToShortDateString();
			//SetCurrentMeso(currentuserMesoBtn);

			currentUsers_Mesocycle = GetCurrentMesocycle(MesoBtnID);

			form3.SetCurrentUser(currentuserMesoBtn);
			form3.SetcurrentUsers_Mesocycle(currentUsers_Mesocycle);
		}

		public Mesocycle GetCurrentMesocycle(int MesoBtnID)
		{
			var m = currentuserMesoBtn.mesocycleList.FirstOrDefault(Mesocycle => Mesocycle.mesoID == MesoBtnID);
			return m;
		}
	}
}
