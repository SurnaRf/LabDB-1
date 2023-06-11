namespace PresentationLayer
{
	partial class LabApp
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
			colonyBtn = new System.Windows.Forms.Button();
			petriDishBtn = new System.Windows.Forms.Button();
			cupboardBtn = new System.Windows.Forms.Button();
			SuspendLayout();
			// 
			// colonyBtn
			// 
			colonyBtn.Location = new System.Drawing.Point(103, 223);
			colonyBtn.Name = "colonyBtn";
			colonyBtn.Size = new System.Drawing.Size(94, 29);
			colonyBtn.TabIndex = 0;
			colonyBtn.Text = "Colonies";
			colonyBtn.UseVisualStyleBackColor = true;
			colonyBtn.Click += colonyBtn_Click;
			// 
			// petriDishBtn
			// 
			petriDishBtn.Location = new System.Drawing.Point(330, 223);
			petriDishBtn.Name = "petriDishBtn";
			petriDishBtn.Size = new System.Drawing.Size(94, 29);
			petriDishBtn.TabIndex = 1;
			petriDishBtn.Text = "Petri Dishes";
			petriDishBtn.UseVisualStyleBackColor = true;
			petriDishBtn.Click += petriDishBtn_Click;
			// 
			// cupboardBtn
			// 
			cupboardBtn.Location = new System.Drawing.Point(562, 223);
			cupboardBtn.Name = "cupboardBtn";
			cupboardBtn.Size = new System.Drawing.Size(94, 29);
			cupboardBtn.TabIndex = 2;
			cupboardBtn.Text = "Cupboards";
			cupboardBtn.UseVisualStyleBackColor = true;
			cupboardBtn.Click += cupboardBtn_Click;
			// 
			// LabApp
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(800, 450);
			Controls.Add(cupboardBtn);
			Controls.Add(petriDishBtn);
			Controls.Add(colonyBtn);
			Name = "LabApp";
			Text = "LabApp";
			ResumeLayout(false);
		}

		#endregion

		private System.Windows.Forms.Button colonyBtn;
		private System.Windows.Forms.Button petriDishBtn;
		private System.Windows.Forms.Button cupboardBtn;
	}
}