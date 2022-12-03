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
	public partial class Form2ManageCycles : Form
	{
		public UserAccount currentuserForm2 { get; set; }

		public void SetCurrentUser(UserAccount currentUser) {currentuserForm2 = currentUser;}

		public Form2ManageCycles()
		{
			InitializeComponent();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			settingsPanel.Show();
			manageCyclesPanel.SendToBack();

			
			currentuserForm2.createMesocycle();
			createNewMesoButton();

		}

		private void createNewMesoButton()
		{

			int n=0;
			CycleTablePanel.RowStyles.Add(new RowStyle(SizeType.Percent));
			CycleTablePanel.RowCount++;
			foreach (Control c in CycleTablePanel.Controls)
			{
				n++;
				CycleTablePanel.SetRow(c, CycleTablePanel.GetRow(c) + 1);
			}

			CycleTablePanel.Controls.Add(new MesoBtn() { Anchor = AnchorStyles.Top, MesoBtnID = n , currentuserMesoBtn=currentuserForm2}, 0, 0);

		}


		private void Form3_Load(object sender, EventArgs e)
		{
			CycleTablePanel.HorizontalScroll.Maximum = 0;
			CycleTablePanel.AutoScroll = false;
			CycleTablePanel.VerticalScroll.Visible = false;
			CycleTablePanel.AutoScroll = true;

			settingsPanel.Hide();

			Console.WriteLine("Current User recieved from form 1: " + currentuserForm2.Username);


		}

		private void Confirmbtn_Click_1(object sender, EventArgs e)
		{
			setOneRepMaxes();
			settingsPanel.Hide();
		}
		private void setOneRepMaxes()
		{
			currentuserForm2.userMaxes.OneRepMaxSquat = int.Parse(squat_txtbox.Text);
			currentuserForm2.userMaxes.OneRepMaxBench = int.Parse(bench_txtbox.Text);
			currentuserForm2.userMaxes.OneRepMaxDeadlift = int.Parse(deadlift_txtbox.Text);
			currentuserForm2.userMaxes.OneRepMaxOHP = int.Parse(ohp_txtbox.Text);

			currentuserForm2.userMaxes.TMaxSquat = currentuserForm2.userMaxes.SetTMax(currentuserForm2.userMaxes.OneRepMaxSquat);
			currentuserForm2.userMaxes.TMaxBench = currentuserForm2.userMaxes.SetTMax(currentuserForm2.userMaxes.OneRepMaxBench);
			currentuserForm2.userMaxes.TMaxDeadlift = currentuserForm2.userMaxes.SetTMax(currentuserForm2.userMaxes.OneRepMaxDeadlift);
			currentuserForm2.userMaxes.TMaxOHP = currentuserForm2.userMaxes.SetTMax(currentuserForm2.userMaxes.OneRepMaxOHP);

			Console.WriteLine("Squat  Tmax set to: " + currentuserForm2.userMaxes.TMaxSquat);
			Console.WriteLine("Bench Tmax set to: " + currentuserForm2.userMaxes.TMaxBench);
			Console.WriteLine("Deadlift Tmax set to: " + currentuserForm2.userMaxes.TMaxDeadlift);
			Console.WriteLine("OHP Tmax set to: " + currentuserForm2.userMaxes.TMaxOHP);
		}


		private decimal CalculateORM(string weight, string reps)
		{
			decimal orm = (1 + (Decimal.Parse(reps) / 30)) * Decimal.Parse(weight);
			return Math.Round(orm / 5) * 5;
		}

		private void setButtonVisibility()
		{
			calc_button.Enabled = (!string.IsNullOrWhiteSpace(calc_repsTextBox.Text) &&
							 !string.IsNullOrWhiteSpace(calc_weightTextBox.Text));

		}
		private void setConfirmButtonVisibility()
		{

			Confirmbtn.Enabled = (!string.IsNullOrWhiteSpace(squat_txtbox.Text) &&
								  !string.IsNullOrWhiteSpace(bench_txtbox.Text) &&
								  !string.IsNullOrWhiteSpace(deadlift_txtbox.Text) &&
								  !string.IsNullOrWhiteSpace(ohp_txtbox.Text));
		}
		private void calc_button_Click(object sender, EventArgs e)
		{
			if (calc_repsTextBox.Text != "1") { calc_1rmLabel.Text = (CalculateORM(calc_weightTextBox.Text, calc_repsTextBox.Text)).ToString(); }
			else { calc_1rmLabel.Text = calc_weightTextBox.Text; }
		}

		private void calc_weightTextBox_TextChanged_1(object sender, EventArgs e)
		{
			setButtonVisibility();
		}

		private void calc_repsTextBox_TextChanged_1(object sender, EventArgs e)
		{
			setButtonVisibility();
		}

		private void squat_txtbox_TextChanged(object sender, EventArgs e)
		{
			setConfirmButtonVisibility();
		}

		private void bench_txtbox_TextChanged(object sender, EventArgs e)
		{
			setConfirmButtonVisibility();
		}

		private void deadlift_txtbox_TextChanged(object sender, EventArgs e)
		{
			setConfirmButtonVisibility();
		}

		private void ohp_txtbox_TextChanged(object sender, EventArgs e)
		{
			setConfirmButtonVisibility();
		}
	}
}

