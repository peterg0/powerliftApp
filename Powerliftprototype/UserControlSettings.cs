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
	public partial class UserControlSettings : UserControl
	{
		public UserAccount currentUser_in_Settings { get; set; }
		public UserControlSettings()
		{
			InitializeComponent();
		}

		public void SetCurrentUser(UserAccount currentUser) { currentUser_in_Settings = currentUser; }

		private void Confirmbtn_Click(object sender, EventArgs e)
		{
			currentUser_in_Settings.userMaxes.OneRepMaxSquat = int.Parse(squat_txtbox.Text);
			currentUser_in_Settings.userMaxes.OneRepMaxBench = int.Parse(bench_txtbox.Text);
			currentUser_in_Settings.userMaxes.OneRepMaxDeadlift = int.Parse(deadlift_txtbox.Text);
			currentUser_in_Settings.userMaxes.OneRepMaxOHP = int.Parse(ohp_txtbox.Text);

			SendToBack();
		}

		private void squat_txtbox_TextChanged(object sender, EventArgs e)
		{
			
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

		private void UserControl2_Load(object sender, EventArgs e)
		{
			
		}

		//calculator weights textbox change handler
		private void calc_weightTextBox_TextChanged(object sender, EventArgs e)
		{
			
		}

		//calculator reps textbox change handler
		private void calc_repsTextBox_TextChanged(object sender, EventArgs e)
		{
			setButtonVisibility();
		}

		//calculate button handler
		private void button3_Click(object sender, EventArgs e)
		{
			if (calc_repsTextBox.Text != "1") { calc_1rmLabel.Text = (CalculateORM(calc_weightTextBox.Text, calc_repsTextBox.Text)).ToString(); }
			else { calc_1rmLabel.Text = calc_weightTextBox.Text; }
		}

	}
}
