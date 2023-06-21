namespace PresentationLayer
{
	partial class CupboardForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			label1 = new System.Windows.Forms.Label();
			label2 = new System.Windows.Forms.Label();
			label3 = new System.Windows.Forms.Label();
			label5 = new System.Windows.Forms.Label();
			label6 = new System.Windows.Forms.Label();
			cupboardsGridView = new System.Windows.Forms.DataGridView();
			roomTxtBox = new System.Windows.Forms.TextBox();
			scientistTxtBox = new System.Windows.Forms.TextBox();
			lightTxtBox = new System.Windows.Forms.TextBox();
			createBtn = new System.Windows.Forms.Button();
			updateBtn = new System.Windows.Forms.Button();
			deleteBtn = new System.Windows.Forms.Button();
			clearBtn = new System.Windows.Forms.Button();
			closeBtn = new System.Windows.Forms.Button();
			petriDishListBox = new System.Windows.Forms.ListBox();
			((System.ComponentModel.ISupportInitialize)cupboardsGridView).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(12, 44);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(49, 20);
			label1.TabIndex = 0;
			label1.Text = "Room";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new System.Drawing.Point(12, 84);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(64, 20);
			label2.TabIndex = 1;
			label2.Text = "Scientist";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new System.Drawing.Point(12, 128);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(77, 20);
			label3.TabIndex = 2;
			label3.Text = "Light Type";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new System.Drawing.Point(16, 311);
			label5.Name = "label5";
			label5.Size = new System.Drawing.Size(85, 20);
			label5.TabIndex = 4;
			label5.Text = "Petri Dishes";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new System.Drawing.Point(318, 18);
			label6.Name = "label6";
			label6.Size = new System.Drawing.Size(81, 20);
			label6.TabIndex = 5;
			label6.Text = "Cupboards";
			// 
			// cupboardsGridView
			// 
			cupboardsGridView.BackgroundColor = System.Drawing.Color.FromArgb(212, 135, 183);
			cupboardsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			cupboardsGridView.Location = new System.Drawing.Point(318, 41);
			cupboardsGridView.Name = "cupboardsGridView";
			cupboardsGridView.RowHeadersWidth = 51;
			cupboardsGridView.RowTemplate.Height = 29;
			cupboardsGridView.Size = new System.Drawing.Size(470, 397);
			cupboardsGridView.TabIndex = 6;
			cupboardsGridView.CellClick += cupboardsGridView_CellClick;
			// 
			// roomTxtBox
			// 
			roomTxtBox.BackColor = System.Drawing.Color.FromArgb(191, 213, 227);
			roomTxtBox.Location = new System.Drawing.Point(118, 41);
			roomTxtBox.Name = "roomTxtBox";
			roomTxtBox.Size = new System.Drawing.Size(194, 27);
			roomTxtBox.TabIndex = 7;
			// 
			// scientistTxtBox
			// 
			scientistTxtBox.BackColor = System.Drawing.Color.FromArgb(191, 213, 227);
			scientistTxtBox.Location = new System.Drawing.Point(118, 81);
			scientistTxtBox.Name = "scientistTxtBox";
			scientistTxtBox.Size = new System.Drawing.Size(194, 27);
			scientistTxtBox.TabIndex = 8;
			// 
			// lightTxtBox
			// 
			lightTxtBox.BackColor = System.Drawing.Color.FromArgb(191, 213, 227);
			lightTxtBox.Location = new System.Drawing.Point(118, 125);
			lightTxtBox.Name = "lightTxtBox";
			lightTxtBox.Size = new System.Drawing.Size(194, 27);
			lightTxtBox.TabIndex = 9;
			// 
			// createBtn
			// 
			createBtn.BackColor = System.Drawing.Color.FromArgb(167, 198, 218);
			createBtn.Location = new System.Drawing.Point(16, 225);
			createBtn.Name = "createBtn";
			createBtn.Size = new System.Drawing.Size(94, 29);
			createBtn.TabIndex = 11;
			createBtn.Text = "Create";
			createBtn.UseVisualStyleBackColor = false;
			createBtn.Click += createBtn_Click;
			createBtn.MouseEnter += createBtn_MouseEnter;
			createBtn.MouseLeave += createBtn_MouseLeave;
			// 
			// updateBtn
			// 
			updateBtn.BackColor = System.Drawing.Color.FromArgb(167, 198, 218);
			updateBtn.Location = new System.Drawing.Point(118, 225);
			updateBtn.Name = "updateBtn";
			updateBtn.Size = new System.Drawing.Size(94, 29);
			updateBtn.TabIndex = 12;
			updateBtn.Text = "Update";
			updateBtn.UseVisualStyleBackColor = false;
			updateBtn.Click += updateBtn_Click;
			updateBtn.MouseEnter += updateBtn_MouseEnter;
			updateBtn.MouseLeave += updateBtn_MouseLeave;
			// 
			// deleteBtn
			// 
			deleteBtn.BackColor = System.Drawing.Color.FromArgb(167, 198, 218);
			deleteBtn.Location = new System.Drawing.Point(218, 225);
			deleteBtn.Name = "deleteBtn";
			deleteBtn.Size = new System.Drawing.Size(94, 29);
			deleteBtn.TabIndex = 13;
			deleteBtn.Text = "Delete";
			deleteBtn.UseVisualStyleBackColor = false;
			deleteBtn.Click += deleteBtn_Click;
			deleteBtn.MouseEnter += deleteBtn_MouseEnter;
			deleteBtn.MouseLeave += deleteBtn_MouseLeave;
			// 
			// clearBtn
			// 
			clearBtn.BackColor = System.Drawing.Color.FromArgb(167, 198, 218);
			clearBtn.Location = new System.Drawing.Point(118, 260);
			clearBtn.Name = "clearBtn";
			clearBtn.Size = new System.Drawing.Size(94, 29);
			clearBtn.TabIndex = 14;
			clearBtn.Text = "Clear";
			clearBtn.UseVisualStyleBackColor = false;
			clearBtn.Click += clearBtn_Click;
			clearBtn.MouseEnter += clearBtn_MouseEnter;
			clearBtn.MouseLeave += clearBtn_MouseLeave;
			// 
			// closeBtn
			// 
			closeBtn.BackColor = System.Drawing.Color.FromArgb(167, 198, 218);
			closeBtn.Location = new System.Drawing.Point(218, 260);
			closeBtn.Name = "closeBtn";
			closeBtn.Size = new System.Drawing.Size(94, 29);
			closeBtn.TabIndex = 15;
			closeBtn.Text = "Close";
			closeBtn.UseVisualStyleBackColor = false;
			closeBtn.Click += closeBtn_Click;
			closeBtn.MouseEnter += closeBtn_MouseEnter;
			closeBtn.MouseLeave += closeBtn_MouseLeave;
			// 
			// petriDishListBox
			// 
			petriDishListBox.BackColor = System.Drawing.Color.FromArgb(191, 213, 227);
			petriDishListBox.FormattingEnabled = true;
			petriDishListBox.ItemHeight = 20;
			petriDishListBox.Location = new System.Drawing.Point(12, 334);
			petriDishListBox.Name = "petriDishListBox";
			petriDishListBox.Size = new System.Drawing.Size(295, 104);
			petriDishListBox.TabIndex = 16;
			// 
			// CupboardForm
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackColor = System.Drawing.Color.FromArgb(245, 250, 235);
			ClientSize = new System.Drawing.Size(800, 450);
			Controls.Add(petriDishListBox);
			Controls.Add(closeBtn);
			Controls.Add(clearBtn);
			Controls.Add(deleteBtn);
			Controls.Add(updateBtn);
			Controls.Add(createBtn);
			Controls.Add(lightTxtBox);
			Controls.Add(scientistTxtBox);
			Controls.Add(roomTxtBox);
			Controls.Add(cupboardsGridView);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "CupboardForm";
			Text = "CupboardForm";
			Shown += CupboardForm_Shown;
			((System.ComponentModel.ISupportInitialize)cupboardsGridView).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DataGridView cupboardsGridView;
		private System.Windows.Forms.TextBox roomTxtBox;
		private System.Windows.Forms.TextBox scientistTxtBox;
		private System.Windows.Forms.TextBox lightTxtBox;
		private System.Windows.Forms.Button createBtn;
		private System.Windows.Forms.Button updateBtn;
		private System.Windows.Forms.Button deleteBtn;
		private System.Windows.Forms.Button clearBtn;
		private System.Windows.Forms.Button closeBtn;
		private System.Windows.Forms.ListBox petriDishListBox;
	}
}