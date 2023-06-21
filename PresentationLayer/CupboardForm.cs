using BusinessLayer;
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
	public partial class CupboardForm : Form
	{
		private DbManager<Cupboard, int> dbManager = new(ContextGenerator.GetCupboardContext());
		private SortedDictionary<int, Cupboard>? trackedCupboards;
		private Cupboard? selectedCupboard = null;
		private DbManager<PetriDish, int> petriDishManager = new(ContextGenerator.GetPetriDishContext());

		public CupboardForm()
		{
			InitializeComponent();

			try
			{
				trackedCupboards = new(dbManager.ReadAll(true)
					.ToDictionary(d => d.Id));

				cupboardsGridView.ReadOnly = true;
				petriDishListBox.Enabled = false;
				petriDishListBox.SelectionMode = SelectionMode.None;

				cupboardsGridView.ReadOnly = true;
				cupboardsGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(227, 118, 186);
				cupboardsGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(227, 118, 186);
				cupboardsGridView.EnableHeadersVisualStyles = false;
				cupboardsGridView.GridColor = Color.FromArgb(214, 84, 165);
				cupboardsGridView.DefaultCellStyle.BackColor = Color.FromArgb(232, 169, 208);
			}
			catch (Exception ex)
			{
				while (ex.InnerException != null) ex = ex.InnerException;
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		#region Helper Methods

		private void SetCreation(bool unlock = true)
		{
			createBtn.Enabled = unlock;

			updateBtn.Enabled =
			deleteBtn.Enabled = !unlock;
		}

		private void ClearState()
		{
			SetCreation();

			selectedCupboard = null;

			roomTxtBox.Text = string.Empty;
			roomTxtBox.Focus();
			scientistTxtBox.Text = string.Empty;
			lightTxtBox.Text = string.Empty;

			cupboardsGridView.DataSource = null;
			cupboardsGridView.DataSource = trackedCupboards?.Values.ToList();
		}

		private void FillInputs()
		{
			if (selectedCupboard == null) return;

			try
			{
				roomTxtBox.Text = selectedCupboard.Room;
				scientistTxtBox.Text = selectedCupboard.Scientist;
				lightTxtBox.Text = selectedCupboard.LightType;

				petriDishListBox.Items.Clear();
				foreach (var dish in selectedCupboard.PetriDishes)
					petriDishListBox.Items.Add(dish.ToString());
			}
			catch (Exception ex)
			{
				while (ex.InnerException != null) ex = ex.InnerException;
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		#endregion

		#region Events

		private void CupboardForm_Shown(object sender, EventArgs e)
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
				Cupboard cupboard = new(roomTxtBox.Text, scientistTxtBox.Text, lightTxtBox.Text);

				dbManager.Create(cupboard);

				trackedCupboards?.Add(cupboard.Id, cupboard);

				ClearState();

				MessageBox.Show("Cupboard created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
				if (selectedCupboard == null)
				{
					MessageBox.Show("A cupboard must be selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					roomTxtBox.Focus();
					return;
				}

				selectedCupboard.Room = roomTxtBox.Text;
				selectedCupboard.Scientist = scientistTxtBox.Text;
				selectedCupboard.LightType = lightTxtBox.Text;

				dbManager.Update(selectedCupboard, true);

				MessageBox.Show("Cupboard updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

				ClearState();

				roomTxtBox.Focus();
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
				if (selectedCupboard == null)
				{
					MessageBox.Show("A cupboard must be selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					roomTxtBox.Focus();
					return;
				}

				trackedCupboards?.Remove(selectedCupboard.Id);

				dbManager.Delete(selectedCupboard.Id);

				ClearState();

				MessageBox.Show("Cupboard deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

		private void cupboardsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

				selectedCupboard = cupboardsGridView.Rows[e.RowIndex].DataBoundItem as Cupboard;
				SetCreation(false);
				FillInputs();
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
