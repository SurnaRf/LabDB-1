using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
	public partial class LabApp : Form
	{
		public LabApp()
		{
			InitializeComponent();
		}

		private void petriDishBtn_Click(object sender, EventArgs e)
		{
			PetriDishForm petriDishForm = new();
			petriDishForm.ShowDialog();
		}

		private void cupboardBtn_Click(object sender, EventArgs e)
		{
			CupboardForm cupboardForm = new();
			cupboardForm.ShowDialog();
		}

		private void colonyBtn_Click(object sender, EventArgs e)
		{
			ColonyForm colonyForm = new ColonyForm();
			colonyForm.ShowDialog();
		}

		private void colonyBtn_MouseEnter(object sender, EventArgs e)
		{
			colonyBtn.BackColor = Color.FromArgb(59, 155, 217);
		}

		private void colonyBtn_MouseLeave(object sender, EventArgs e)
		{
			colonyBtn.BackColor = Color.FromArgb(167, 198, 218);
		}

		private void petriDishBtn_MouseEnter(object sender, EventArgs e)
		{
			petriDishBtn.BackColor = Color.FromArgb(59, 155, 217);
		}

		private void petriDishBtn_MouseLeave(object sender, EventArgs e)
		{
			petriDishBtn.BackColor = Color.FromArgb(167, 198, 218);
		}

		private void cupboardBtn_MouseEnter(object sender, EventArgs e)
		{
			cupboardBtn.BackColor = Color.FromArgb(59, 155, 217);
		}

		private void cupboardBtn_MouseLeave(object sender, EventArgs e)
		{
			cupboardBtn.BackColor = Color.FromArgb(167, 198, 218);
		}
	}
}
