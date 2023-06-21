using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BusinessLayer;
using ServiceLayer;

namespace PresentationLayer
{
	public partial class PetriDishForm : Form
	{
		private DbManager<PetriDish, int> dbManager
			= new(ContextGenerator.GetPetriDishContext());

		private SortedDictionary<int, PetriDish>? trackedDishes;
		private PetriDish? selectedDish = null;

		private DbManager<Cupboard, int> cupboardManager
			= new(ContextGenerator.GetCupboardContext());

		public PetriDishForm()
		{
			InitializeComponent();

			try
			{
				trackedDishes = new(dbManager.ReadAll(true)
					.ToDictionary(d => d.Id));

				// Cupboard combo box
				cupboardComboBox.DisplayMember = "Room";
				foreach (var cupboard in cupboardManager.ReadAll())
					cupboardComboBox.Items.Add(cupboard);

				dishesGridView.ReadOnly = true;
				colonyListBox.Enabled = false;
				colonyListBox.SelectionMode = SelectionMode.None;

				dishesGridView.ReadOnly = true;
				dishesGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(227, 118, 186);
				dishesGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(227, 118, 186);
				dishesGridView.EnableHeadersVisualStyles = false;
				dishesGridView.GridColor = Color.FromArgb(214, 84, 165);
				dishesGridView.DefaultCellStyle.BackColor = Color.FromArgb(232, 169, 208);
			}
			catch (Exception ex)
			{
				while (ex.InnerException != null) ex = ex.InnerException;
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		#region HelperMethods

		private void SetCreation(bool unlock = true)
		{
			createBtn.Enabled = unlock;

			updateBtn.Enabled =
			deleteBtn.Enabled = !unlock;
		}

		private void ClearState()
		{
			SetCreation();

			selectedDish = null;

			solventTxtBox.Text = string.Empty;
			solventTxtBox.Focus();

			diameterNum.Value = 0;
			datePicker.Value = DateTime.UtcNow;
			cupboardComboBox.SelectedIndex = 0;

			dishesGridView.DataSource = null;
			dishesGridView.DataSource = trackedDishes?.Values.ToList();
		}

		private void FillInputs()
		{
			if (selectedDish == null) return;

			try
			{
				solventTxtBox.Text = selectedDish.Solvent;
				diameterNum.Value = (decimal)selectedDish.Diameter;
				datePicker.Value = selectedDish.LastCheckDate;

				cupboardComboBox.SelectedIndex =
					cupboardComboBox.Items
					.IndexOf(selectedDish.Cupboard);

				colonyListBox.Items.Clear();
				foreach (var colony in selectedDish.Colonies)
					colonyListBox.Items.Add(colony.ToString());
			}
			catch (Exception ex)
			{
				while (ex.InnerException != null) ex = ex.InnerException;
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		#endregion

		#region Events

		private void PetriDishForm_Shown(object sender, EventArgs e)
		{
			try
			{
				if (cupboardComboBox.Items.Count == 0)
				{
					MessageBox.Show("Warning", "No cupboards recorded.",
						MessageBoxButtons.OK, MessageBoxIcon.Warning);
					this.Close();
					return;
				}

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
				PetriDish dish = new(
					solventTxtBox.Text,
					(float)diameterNum.Value,
					datePicker.Value,
					cupboardComboBox.SelectedItem as Cupboard);

				dbManager.Create(dish);

				trackedDishes?.Add(dish.Id, dish);

				ClearState();

				MessageBox.Show(
					"Dish created successfully.",
					"Success", MessageBoxButtons.OK,
					MessageBoxIcon.Information);
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
				if (selectedDish == null)
				{
					MessageBox.Show("A petri dish must be selected.",
						"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					solventTxtBox.Focus();
					return;
				}

				selectedDish.Solvent = solventTxtBox.Text;
				selectedDish.Diameter = (float)diameterNum.Value;
				selectedDish.LastCheckDate = datePicker.Value;
				selectedDish.Cupboard = cupboardComboBox.SelectedItem as Cupboard;
				selectedDish.CupboardId = selectedDish.Cupboard.Id;

				dbManager.Update(selectedDish, true);

				MessageBox.Show(
					"Petri dish updated successfully!", "Success",
					MessageBoxButtons.OK, MessageBoxIcon.Information);

				ClearState();

				solventTxtBox.Focus();
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
				if (selectedDish == null)
				{
					MessageBox.Show("A petri dish must be selected.",
						"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					solventTxtBox.Focus();
					return;
				}

				trackedDishes?.Remove(selectedDish.Id);

				dbManager.Delete(selectedDish.Id);

				ClearState();

				MessageBox.Show(
					"Petri dish deleted successfully.", "Success",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				while (ex.InnerException != null) ex = ex.InnerException;
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void dishesGridView_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

				selectedDish = dishesGridView.Rows[e.RowIndex].DataBoundItem as PetriDish;
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
