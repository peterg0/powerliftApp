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
		public static Form2ManageCycles instance;
		public UserAccount currentuser { get; set; }

		public Form2ManageCycles()
		{
			InitializeComponent();
			instance = this;
		
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void button6_Click(object sender, EventArgs e)
		{
			settingsPanel.Show();
			manageCyclesPanel.SendToBack();
			CycleTablePanel.RowStyles.Add(new RowStyle(SizeType.Percent));
			CycleTablePanel.RowCount++;
			foreach (Control c in CycleTablePanel.Controls)
			{
				CycleTablePanel.SetRow(c, CycleTablePanel.GetRow(c) + 1);
			}
			
			CycleTablePanel.Controls.Add(new MesoBtn() {Anchor = AnchorStyles.Top }, 0, 0);

		}



		private void mesocyclePanel_Paint(object sender, PaintEventArgs e)
		{

		}

		private void Form3_Load(object sender, EventArgs e)
		{
			CycleTablePanel.HorizontalScroll.Maximum = 0;
			CycleTablePanel.AutoScroll = false;
			CycleTablePanel.VerticalScroll.Visible = false;
			CycleTablePanel.AutoScroll = true;

			settingsPanel.Hide();

			
			


		}
	}
}
