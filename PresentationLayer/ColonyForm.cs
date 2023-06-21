using BusinessLayer;
using Microsoft.EntityFrameworkCore.Storage;
using ServiceLayer;
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
	public partial class ColonyForm : Form
	{
		private DbManager<Colony, int> dbManager = new(ContextGenerator.GetColonyContext());

		private DbManager<PetriDish, int> petriDishManager = new(ContextGenerator.GetPetriDishContext());

		private SortedDictionary<int, Colony>? trackedColonies;
		private Colony? selectedColony = null;
		public ColonyForm()
		{
			InitializeComponent();
			try
			{
				trackedColonies = new(dbManager.ReadAll(true)
					.ToDictionary(d => d.Id));

				petriDishesListBox.DisplayMember = "Solvent";
				foreach (PetriDish petriDish in petriDishManager.ReadAll())
					petriDishesListBox.Items.Add(petriDish);

				coloniesDataGridView.ReadOnly = true;
				coloniesDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(227, 118, 186);
				coloniesDataGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(227, 118, 186);
				coloniesDataGridView.EnableHeadersVisualStyles = false;
				coloniesDataGridView.GridColor = Color.FromArgb(214, 84, 165);
				coloniesDataGridView.DefaultCellStyle.BackColor = Color.FromArgb(232, 169, 208);
			}
			catch (Exception ex)
			{
				while (ex.InnerException != null) ex = ex.InnerException;
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		#region Events		

		private void ColonyForm_Shown(object sender, EventArgs e)
		{
			try
			{
				ClearState();
			}
			catch (Exception ex)
			{
				while (ex.InnerException != null) ex = ex.InnerException;
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void createBtn_Click(object sender, EventArgs e)
		{
			try
			{
				if (ValidationManager.IsValidString(bacteriaTxtBox.Text))
				{
					string bacteriaType = bacteriaTxtBox.Text;
					int count = (int)countNumericUpDown.Value;
					int days = (int)daysNumericUpDown.Value;

					PetriDish petriDish = petriDishesListBox.SelectedItem as PetriDish;

					Colony colony = new(bacteriaType, count, days, petriDish);
					dbManager.Create(colony);

					trackedColonies?.Add(colony.Id, colony);

					MessageBox.Show("Colony created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

					ClearState();
				}
				else
				{
					MessageBox.Show("You have to enter values in the text boxes!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					bacteriaTxtBox.Focus();
				}
			}
			catch (Exception ex)
			{
				while (ex.InnerException != null) ex = ex.InnerException;
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void updateBtn_Click(object sender, EventArgs e)
		{
			try
			{
				if (ValidationManager.IsValidString(bacteriaTxtBox.Text)
					&& selectedColony != null)
				{
					selectedColony.BacteriaType = bacteriaTxtBox.Text;
					selectedColony.Count = (int)countNumericUpDown.Value;
					selectedColony.Days = (int)daysNumericUpDown.Value;
					selectedColony.PetriDish = petriDishesListBox.SelectedItem as PetriDish;
					selectedColony.PetriDishId = selectedColony.PetriDish.Id;

					dbManager.Update(selectedColony, true);

					MessageBox.Show("Colony updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

					ClearState();

					bacteriaTxtBox.Focus();
				}
				else
				{
					MessageBox.Show("A colony must be selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (Exception ex)
			{
				while (ex.InnerException != null) ex = ex.InnerException;
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void deleteBtn_Click(object sender, EventArgs e)
		{
			try
			{
				if (selectedColony != null)
				{
					trackedColonies?.Remove(selectedColony.Id);
					dbManager.Delete(selectedColony.Id);
					MessageBox.Show("Colony deleted successfully!", "Successful operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
					ClearState();
				}
				else
				{
					MessageBox.Show("A colony must be selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (Exception ex)
			{
				while (ex.InnerException != null) ex = ex.InnerException;
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void coloniesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

				selectedColony = coloniesDataGridView.Rows[e.RowIndex].DataBoundItem as Colony;
				SetCreation(false);
				FillInputs();
			}
			catch (Exception ex)
			{
				while (ex.InnerException != null) ex = ex.InnerException;
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void clearBtn_Click(object sender, EventArgs e)
		{
			ClearState();
		}

		private void closeBtn_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		#endregion

		#region Methods

		private void SetCreation(bool unlock = true)
		{
			createBtn.Enabled = unlock;

			updateBtn.Enabled =
			deleteBtn.Enabled = !unlock;
		}

		private void ClearState()
		{
			SetCreation();

			selectedColony = null;

			bacteriaTxtBox.Text = string.Empty;
			bacteriaTxtBox.Focus();

			countNumericUpDown.Value = 0;
			daysNumericUpDown.Value = 0;

			coloniesDataGridView.DataSource = null;
			coloniesDataGridView.DataSource = trackedColonies?.Values.ToList();
		}

		private void FillInputs()
		{
			if (selectedColony == null) { return; }

			try
			{
				bacteriaTxtBox.Text = selectedColony.BacteriaType;
				countNumericUpDown.Value = selectedColony.Count;
				daysNumericUpDown.Value = selectedColony.Days;
				petriDishesListBox.SelectedItem = selectedColony.PetriDish;
			}
			catch (Exception ex)
			{
				while (ex.InnerException != null) ex = ex.InnerException;
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		#endregion

		#region Colors
		private void createBtn_MouseEnter(object sender, EventArgs e)
		{
			createBtn.BackColor = Color.FromArgb(59, 155, 217);
		}

		private void createBtn_MouseLeave(object sender, EventArgs e)
		{
			createBtn.BackColor = Color.FromArgb(167, 198, 218);
		}

		private void updateBtn_MouseEnter(object sender, EventArgs e)
		{
			updateBtn.BackColor = Color.FromArgb(59, 155, 217);

		}

		private void updateBtn_MouseLeave(object sender, EventArgs e)
		{
			updateBtn.BackColor = Color.FromArgb(167, 198, 218);
		}

		private void deleteBtn_MouseEnter(object sender, EventArgs e)
		{
			deleteBtn.BackColor = Color.FromArgb(59, 155, 217);
		}

		private void deleteBtn_MouseLeave(object sender, EventArgs e)
		{
			deleteBtn.BackColor = Color.FromArgb(167, 198, 218);
		}

		private void clearBtn_MouseEnter(object sender, EventArgs e)
		{
			clearBtn.BackColor = Color.FromArgb(59, 155, 217);
		}

		private void clearBtn_MouseLeave(object sender, EventArgs e)
		{
			clearBtn.BackColor = Color.FromArgb(167, 198, 218);
		}

		private void closeBtn_MouseEnter(object sender, EventArgs e)
		{
			closeBtn.BackColor = Color.FromArgb(59, 155, 217);
		}

		private void closeBtn_MouseLeave(object sender, EventArgs e)
		{
			closeBtn.BackColor = Color.FromArgb(167, 198, 218);
		}
		#endregion
	}
}
