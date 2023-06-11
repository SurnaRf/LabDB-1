namespace PresentationLayer
{
    partial class PetriDishForm
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
            this.solventLabel = new System.Windows.Forms.Label();
            this.solventTxtBox = new System.Windows.Forms.TextBox();
            this.petriDishesLabel = new System.Windows.Forms.Label();
            this.dishesGridView = new System.Windows.Forms.DataGridView();
            this.Diameter = new System.Windows.Forms.Label();
            this.diameterNum = new System.Windows.Forms.NumericUpDown();
            this.lastCheckedDateLabel = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.cupboardLabel = new System.Windows.Forms.Label();
            this.cupboardComboBox = new System.Windows.Forms.ComboBox();
            this.createBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.coloniesLabel = new System.Windows.Forms.Label();
            this.colonyListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dishesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diameterNum)).BeginInit();
            this.SuspendLayout();
            // 
            // solventLabel
            // 
            this.solventLabel.AutoSize = true;
            this.solventLabel.Location = new System.Drawing.Point(12, 39);
            this.solventLabel.Name = "solventLabel";
            this.solventLabel.Size = new System.Drawing.Size(58, 20);
            this.solventLabel.TabIndex = 0;
            this.solventLabel.Text = "Solvent";
            // 
            // solventTxtBox
            // 
            this.solventTxtBox.Location = new System.Drawing.Point(118, 36);
            this.solventTxtBox.Name = "solventTxtBox";
            this.solventTxtBox.Size = new System.Drawing.Size(188, 27);
            this.solventTxtBox.TabIndex = 0;
            // 
            // petriDishesLabel
            // 
            this.petriDishesLabel.AutoSize = true;
            this.petriDishesLabel.Location = new System.Drawing.Point(312, 13);
            this.petriDishesLabel.Name = "petriDishesLabel";
            this.petriDishesLabel.Size = new System.Drawing.Size(85, 20);
            this.petriDishesLabel.TabIndex = 2;
            this.petriDishesLabel.Text = "Petri Dishes";
            // 
            // dishesGridView
            // 
            this.dishesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dishesGridView.Location = new System.Drawing.Point(312, 36);
            this.dishesGridView.Name = "dishesGridView";
            this.dishesGridView.RowHeadersWidth = 51;
            this.dishesGridView.RowTemplate.Height = 29;
            this.dishesGridView.Size = new System.Drawing.Size(476, 396);
            this.dishesGridView.TabIndex = 8;
            // 
            // Diameter
            // 
            this.Diameter.AutoSize = true;
            this.Diameter.Location = new System.Drawing.Point(12, 88);
            this.Diameter.Name = "Diameter";
            this.Diameter.Size = new System.Drawing.Size(71, 20);
            this.Diameter.TabIndex = 4;
            this.Diameter.Text = "Diameter";
            // 
            // diameterNum
            // 
            this.diameterNum.Location = new System.Drawing.Point(118, 86);
            this.diameterNum.Name = "diameterNum";
            this.diameterNum.Size = new System.Drawing.Size(188, 27);
            this.diameterNum.TabIndex = 1;
            // 
            // lastCheckedDateLabel
            // 
            this.lastCheckedDateLabel.AutoSize = true;
            this.lastCheckedDateLabel.Location = new System.Drawing.Point(12, 136);
            this.lastCheckedDateLabel.Name = "lastCheckedDateLabel";
            this.lastCheckedDateLabel.Size = new System.Drawing.Size(95, 20);
            this.lastCheckedDateLabel.TabIndex = 6;
            this.lastCheckedDateLabel.Text = "Last Checked";
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(118, 131);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(188, 27);
            this.datePicker.TabIndex = 2;
            // 
            // cupboardLabel
            // 
            this.cupboardLabel.AutoSize = true;
            this.cupboardLabel.Location = new System.Drawing.Point(12, 187);
            this.cupboardLabel.Name = "cupboardLabel";
            this.cupboardLabel.Size = new System.Drawing.Size(75, 20);
            this.cupboardLabel.TabIndex = 8;
            this.cupboardLabel.Text = "Cupboard";
            // 
            // cupboardComboBox
            // 
            this.cupboardComboBox.FormattingEnabled = true;
            this.cupboardComboBox.Location = new System.Drawing.Point(118, 184);
            this.cupboardComboBox.Name = "cupboardComboBox";
            this.cupboardComboBox.Size = new System.Drawing.Size(188, 28);
            this.cupboardComboBox.TabIndex = 3;
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(12, 230);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(94, 29);
            this.createBtn.TabIndex = 10;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(112, 230);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(94, 29);
            this.updateBtn.TabIndex = 11;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(212, 230);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(94, 29);
            this.deleteBtn.TabIndex = 12;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(112, 265);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(94, 29);
            this.clearBtn.TabIndex = 13;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(212, 265);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(94, 29);
            this.closeBtn.TabIndex = 14;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            // 
            // coloniesLabel
            // 
            this.coloniesLabel.AutoSize = true;
            this.coloniesLabel.Location = new System.Drawing.Point(12, 305);
            this.coloniesLabel.Name = "coloniesLabel";
            this.coloniesLabel.Size = new System.Drawing.Size(66, 20);
            this.coloniesLabel.TabIndex = 15;
            this.coloniesLabel.Text = "Colonies";
            // 
            // colonyListBox
            // 
            this.colonyListBox.FormattingEnabled = true;
            this.colonyListBox.ItemHeight = 20;
            this.colonyListBox.Location = new System.Drawing.Point(12, 328);
            this.colonyListBox.Name = "colonyListBox";
            this.colonyListBox.Size = new System.Drawing.Size(294, 104);
            this.colonyListBox.TabIndex = 16;
            // 
            // PetriDishForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 448);
            this.Controls.Add(this.colonyListBox);
            this.Controls.Add(this.coloniesLabel);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.cupboardComboBox);
            this.Controls.Add(this.cupboardLabel);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.lastCheckedDateLabel);
            this.Controls.Add(this.diameterNum);
            this.Controls.Add(this.Diameter);
            this.Controls.Add(this.dishesGridView);
            this.Controls.Add(this.petriDishesLabel);
            this.Controls.Add(this.solventTxtBox);
            this.Controls.Add(this.solventLabel);
            this.Name = "PetriDishForm";
            this.Text = "PetriDishForm";
            ((System.ComponentModel.ISupportInitialize)(this.dishesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diameterNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label solventLabel;
        private System.Windows.Forms.TextBox solventTxtBox;
        private System.Windows.Forms.Label petriDishesLabel;
        private System.Windows.Forms.DataGridView dishesGridView;
        private System.Windows.Forms.Label Diameter;
        private System.Windows.Forms.NumericUpDown diameterNum;
        private System.Windows.Forms.Label lastCheckedDateLabel;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label cupboardLabel;
        private System.Windows.Forms.ComboBox cupboardComboBox;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label coloniesLabel;
        private System.Windows.Forms.ListBox colonyListBox;
    }
}