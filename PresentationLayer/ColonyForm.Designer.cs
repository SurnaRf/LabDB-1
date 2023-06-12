namespace PresentationLayer
{
    partial class ColonyForm
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
            System.Windows.Forms.Label label1;
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            bacteriaTxtBox = new System.Windows.Forms.TextBox();
            countNumericUpDown = new System.Windows.Forms.NumericUpDown();
            daysNumericUpDown = new System.Windows.Forms.NumericUpDown();
            petriDishesListBox = new System.Windows.Forms.ListBox();
            label5 = new System.Windows.Forms.Label();
            coloniesDataGridView = new System.Windows.Forms.DataGridView();
            createBtn = new System.Windows.Forms.Button();
            updateBtn = new System.Windows.Forms.Button();
            deleteBtn = new System.Windows.Forms.Button();
            clearBtn = new System.Windows.Forms.Button();
            closeBtn = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)countNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)daysNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coloniesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(22, 38);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(96, 20);
            label1.TabIndex = 0;
            label1.Text = "Bacteria type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(22, 106);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(48, 20);
            label2.TabIndex = 1;
            label2.Text = "Count";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(22, 174);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(41, 20);
            label3.TabIndex = 2;
            label3.Text = "Days";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(22, 248);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(69, 20);
            label4.TabIndex = 3;
            label4.Text = "Petri dish";
            // 
            // bacteriaTxtBox
            // 
            bacteriaTxtBox.Location = new System.Drawing.Point(22, 61);
            bacteriaTxtBox.Name = "bacteriaTxtBox";
            bacteriaTxtBox.Size = new System.Drawing.Size(154, 27);
            bacteriaTxtBox.TabIndex = 4;
            // 
            // countNumericUpDown
            // 
            countNumericUpDown.Location = new System.Drawing.Point(26, 139);
            countNumericUpDown.Name = "countNumericUpDown";
            countNumericUpDown.Size = new System.Drawing.Size(150, 27);
            countNumericUpDown.TabIndex = 5;
            // 
            // daysNumericUpDown
            // 
            daysNumericUpDown.Location = new System.Drawing.Point(26, 206);
            daysNumericUpDown.Name = "daysNumericUpDown";
            daysNumericUpDown.Size = new System.Drawing.Size(150, 27);
            daysNumericUpDown.TabIndex = 6;
            // 
            // petriDishesListBox
            // 
            petriDishesListBox.FormattingEnabled = true;
            petriDishesListBox.ItemHeight = 20;
            petriDishesListBox.Location = new System.Drawing.Point(26, 284);
            petriDishesListBox.Name = "petriDishesListBox";
            petriDishesListBox.Size = new System.Drawing.Size(150, 24);
            petriDishesListBox.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(391, 25);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(66, 20);
            label5.TabIndex = 8;
            label5.Text = "Colonies";
            // 
            // coloniesDataGridView
            // 
            coloniesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            coloniesDataGridView.Location = new System.Drawing.Point(391, 61);
            coloniesDataGridView.Name = "coloniesDataGridView";
            coloniesDataGridView.RowHeadersWidth = 51;
            coloniesDataGridView.RowTemplate.Height = 29;
            coloniesDataGridView.Size = new System.Drawing.Size(379, 188);
            coloniesDataGridView.TabIndex = 9;
            coloniesDataGridView.CellClick += coloniesDataGridView_CellClick;
            // 
            // createBtn
            // 
            createBtn.Location = new System.Drawing.Point(30, 361);
            createBtn.Name = "createBtn";
            createBtn.Size = new System.Drawing.Size(94, 29);
            createBtn.TabIndex = 10;
            createBtn.Text = "Create";
            createBtn.UseVisualStyleBackColor = true;
            createBtn.Click += createBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.Location = new System.Drawing.Point(152, 361);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new System.Drawing.Size(94, 29);
            updateBtn.TabIndex = 11;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new System.Drawing.Point(391, 361);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new System.Drawing.Size(94, 29);
            deleteBtn.TabIndex = 12;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // clearBtn
            // 
            clearBtn.Location = new System.Drawing.Point(565, 361);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new System.Drawing.Size(94, 29);
            clearBtn.TabIndex = 13;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // closeBtn
            // 
            closeBtn.Location = new System.Drawing.Point(676, 361);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new System.Drawing.Size(94, 29);
            closeBtn.TabIndex = 14;
            closeBtn.Text = "Close";
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += closeBtn_Click;
            // 
            // ColonyForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.WhiteSmoke;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(closeBtn);
            Controls.Add(clearBtn);
            Controls.Add(deleteBtn);
            Controls.Add(updateBtn);
            Controls.Add(createBtn);
            Controls.Add(coloniesDataGridView);
            Controls.Add(label5);
            Controls.Add(petriDishesListBox);
            Controls.Add(daysNumericUpDown);
            Controls.Add(countNumericUpDown);
            Controls.Add(bacteriaTxtBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ColonyForm";
            Text = "ColonyForm";
            Shown += ColonyForm_Shown;
            ((System.ComponentModel.ISupportInitialize)countNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)daysNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)coloniesDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox bacteriaTxtBox;
        private System.Windows.Forms.NumericUpDown countNumericUpDown;
        private System.Windows.Forms.NumericUpDown daysNumericUpDown;
        private System.Windows.Forms.ListBox petriDishesListBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView coloniesDataGridView;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button closeBtn;
    }
}