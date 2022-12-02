﻿using System;
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
		MesocycleOverviewForm form = new MesocycleOverviewForm();
		public UserAccount currentuserMesoBtn { get; set; }
		public Mesocycle currentuserMeso { get; set; }
		public void SetCurrentUser(UserAccount currentUser) { currentuserMesoBtn = currentUser; }

		public MesoBtn()
		{
			InitializeComponent();
		}

		private void MesocycleBtn_Click(object sender, EventArgs e)
		{
			form.Show();
		}

		private void MesoBtn_Load(object sender, EventArgs e)
		{
			form.SetCurrentUser(currentuserMesoBtn);
			MesocycleBtn.Text = "Mesocycle ";
		}
	}
}
