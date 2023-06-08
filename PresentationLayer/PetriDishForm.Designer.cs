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
            solventLabel = new System.Windows.Forms.Label();
            solventTxtBox = new System.Windows.Forms.TextBox();
            petriDishesLabel = new System.Windows.Forms.Label();
            dishesGridView = new System.Windows.Forms.DataGridView();
            Diameter = new System.Windows.Forms.Label();
            diameterNum = new System.Windows.Forms.NumericUpDown();
            lastCheckedDateLabel = new System.Windows.Forms.Label();
            datePicker = new System.Windows.Forms.DateTimePicker();
            cupboardLabel = new System.Windows.Forms.Label();
            cupboardComboBox = new System.Windows.Forms.ComboBox();
            createBtn = new System.Windows.Forms.Button();
            updateBtn = new System.Windows.Forms.Button();
            deleteBtn = new System.Windows.Forms.Button();
            clearBtn = new System.Windows.Forms.Button();
            closeBtn = new System.Windows.Forms.Button();
            coloniesLabel = new System.Windows.Forms.Label();
            colonyListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)dishesGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)diameterNum).BeginInit();
            SuspendLayout();
            // 
            // solventLabel
            // 
            solventLabel.AutoSize = true;
            solventLabel.Location = new System.Drawing.Point(12, 39);
            solventLabel.Name = "solventLabel";
            solventLabel.Size = new System.Drawing.Size(58, 20);
            solventLabel.TabIndex = 0;
            solventLabel.Text = "Solvent";
            // 
            // solventTxtBox
            // 
            solventTxtBox.Location = new System.Drawing.Point(118, 36);
            solventTxtBox.Name = "solventTxtBox";
            solventTxtBox.Size = new System.Drawing.Size(188, 27);
            solventTxtBox.TabIndex = 0;
            // 
            // petriDishesLabel
            // 
            petriDishesLabel.AutoSize = true;
            petriDishesLabel.Location = new System.Drawing.Point(312, 13);
            petriDishesLabel.Name = "petriDishesLabel";
            petriDishesLabel.Size = new System.Drawing.Size(85, 20);
            petriDishesLabel.TabIndex = 2;
            petriDishesLabel.Text = "Petri Dishes";
            // 
            // dishesGridView
            // 
            dishesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dishesGridView.Location = new System.Drawing.Point(312, 36);
            dishesGridView.Name = "dishesGridView";
            dishesGridView.RowHeadersWidth = 51;
            dishesGridView.RowTemplate.Height = 29;
            dishesGridView.Size = new System.Drawing.Size(476, 396);
            dishesGridView.TabIndex = 8;
            dishesGridView.CellClick += dishesGridView_CellClick;
            // 
            // Diameter
            // 
            Diameter.AutoSize = true;
            Diameter.Location = new System.Drawing.Point(12, 88);
            Diameter.Name = "Diameter";
            Diameter.Size = new System.Drawing.Size(71, 20);
            Diameter.TabIndex = 4;
            Diameter.Text = "Diameter";
            // 
            // diameterNum
            // 
            diameterNum.Location = new System.Drawing.Point(118, 86);
            diameterNum.Name = "diameterNum";
            diameterNum.Size = new System.Drawing.Size(188, 27);
            diameterNum.TabIndex = 1;
            // 
            // lastCheckedDateLabel
            // 
            lastCheckedDateLabel.AutoSize = true;
            lastCheckedDateLabel.Location = new System.Drawing.Point(12, 136);
            lastCheckedDateLabel.Name = "lastCheckedDateLabel";
            lastCheckedDateLabel.Size = new System.Drawing.Size(95, 20);
            lastCheckedDateLabel.TabIndex = 6;
            lastCheckedDateLabel.Text = "Last Checked";
            // 
            // datePicker
            // 
            datePicker.Location = new System.Drawing.Point(118, 131);
            datePicker.Name = "datePicker";
            datePicker.Size = new System.Drawing.Size(188, 27);
            datePicker.TabIndex = 2;
            // 
            // cupboardLabel
            // 
            cupboardLabel.AutoSize = true;
            cupboardLabel.Location = new System.Drawing.Point(12, 187);
            cupboardLabel.Name = "cupboardLabel";
            cupboardLabel.Size = new System.Drawing.Size(75, 20);
            cupboardLabel.TabIndex = 8;
            cupboardLabel.Text = "Cupboard";
            // 
            // cupboardComboBox
            // 
            cupboardComboBox.FormattingEnabled = true;
            cupboardComboBox.Location = new System.Drawing.Point(118, 184);
            cupboardComboBox.Name = "cupboardComboBox";
            cupboardComboBox.Size = new System.Drawing.Size(188, 28);
            cupboardComboBox.TabIndex = 3;
            // 
            // createBtn
            // 
            createBtn.Location = new System.Drawing.Point(12, 230);
            createBtn.Name = "createBtn";
            createBtn.Size = new System.Drawing.Size(94, 29);
            createBtn.TabIndex = 10;
            createBtn.Text = "Create";
            createBtn.UseVisualStyleBackColor = true;
            createBtn.Click += createBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.Location = new System.Drawing.Point(112, 230);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new System.Drawing.Size(94, 29);
            updateBtn.TabIndex = 11;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new System.Drawing.Point(212, 230);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new System.Drawing.Size(94, 29);
            deleteBtn.TabIndex = 12;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // clearBtn
            // 
            clearBtn.Location = new System.Drawing.Point(112, 265);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new System.Drawing.Size(94, 29);
            clearBtn.TabIndex = 13;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // closeBtn
            // 
            closeBtn.Location = new System.Drawing.Point(212, 265);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new System.Drawing.Size(94, 29);
            closeBtn.TabIndex = 14;
            closeBtn.Text = "Close";
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += closeBtn_Click;
            // 
            // coloniesLabel
            // 
            coloniesLabel.AutoSize = true;
            coloniesLabel.Location = new System.Drawing.Point(12, 305);
            coloniesLabel.Name = "coloniesLabel";
            coloniesLabel.Size = new System.Drawing.Size(66, 20);
            coloniesLabel.TabIndex = 15;
            coloniesLabel.Text = "Colonies";
            // 
            // colonyListBox
            // 
            colonyListBox.FormattingEnabled = true;
            colonyListBox.ItemHeight = 20;
            colonyListBox.Location = new System.Drawing.Point(12, 328);
            colonyListBox.Name = "colonyListBox";
            colonyListBox.Size = new System.Drawing.Size(294, 104);
            colonyListBox.TabIndex = 16;
            // 
            // PetriDishForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(797, 448);
            Controls.Add(colonyListBox);
            Controls.Add(coloniesLabel);
            Controls.Add(closeBtn);
            Controls.Add(clearBtn);
            Controls.Add(deleteBtn);
            Controls.Add(updateBtn);
            Controls.Add(createBtn);
            Controls.Add(cupboardComboBox);
            Controls.Add(cupboardLabel);
            Controls.Add(datePicker);
            Controls.Add(lastCheckedDateLabel);
            Controls.Add(diameterNum);
            Controls.Add(Diameter);
            Controls.Add(dishesGridView);
            Controls.Add(petriDishesLabel);
            Controls.Add(solventTxtBox);
            Controls.Add(solventLabel);
            Name = "PetriDishForm";
            Text = "PetriDishForm";
            Shown += PetriDishForm_Shown;
            ((System.ComponentModel.ISupportInitialize)dishesGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)diameterNum).EndInit();
            ResumeLayout(false);
            PerformLayout();
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